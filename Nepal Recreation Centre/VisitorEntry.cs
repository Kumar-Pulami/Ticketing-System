using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nepal_Recreation_Centre
{
    public partial class visitorEntryForm : UserControl
    {
        public visitorEntryForm()
        {
            InitializeComponent();
            UpdateVisitorTable();
            this.exportBtn.Visible = true;
        }

        private void groupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (groupCheckBox.Checked)
            {
                groupCountComboBox.Enabled = true;
                groupCountComboBox.SelectedItem = null;
                groupCountComboBox.Text = "Please Select";
            }
            else {
                groupCountComboBox.Enabled = false;
                groupCountComboBox.SelectedItem = null;
                groupCountComboBox.Text = "Please Select";
            }
        }

        private void entryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDateTime = DateTime.Now;
                int hour = int.Parse(currentDateTime.ToString("HH"));
                if (hour > 9 && hour < 19)
                {
                    long visitorID = long.Parse(currentDateTime.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture));
                    String visitorName = visitorNameTxt.Text;
                    String contactNumberStr = contactNumberTxt.Text;
                    long contactNumber = 0;
                    String address = addressTxt.Text;
                    String ageCategory = (String)ageCatComboBox.SelectedItem;
                    Boolean group = groupCheckBox.Checked;
                    String groupCount = null;
                    int price = 0;
                    DateTime? departureTime = null;
                    Boolean validation;

                    if (String.IsNullOrEmpty(visitorName) || String.IsNullOrEmpty(contactNumberStr) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(ageCategory))
                    {
                        MessageBox.Show("Please fill up the empty fields.");
                        validation = false;
                    }
                    else
                    {
                        contactNumber = long.Parse(contactNumberStr);
                        validation = true;
                    }

                    if (group && validation)
                    {
                        String groupCountStr = (String)groupCountComboBox.SelectedItem;
                        if (String.IsNullOrEmpty(groupCountStr))
                        {
                            MessageBox.Show("Please Select Group Count.");
                            validation = false;
                        }
                        else
                        {
                            groupCount = groupCountStr;
                            validation = true;
                        }

                    }
                    else if (!group && validation)
                    {
                        groupCount = "Individual";
                    }

                    if (validation)
                    {
                        foreach (Visitor vistor in Storage.visitorList)
                        {
                            if (vistor.VisitorID == visitorID)
                            {
                                MessageBox.Show("Duplicate visitor id, Check system date and time.");
                                validation = false;
                                break;
                            }
                            else
                            {
                                validation = true;
                            }
                        }
                    }

                    if (validation)
                    {
                        Visitor newVisitor = new Visitor(visitorID, visitorName, contactNumber, address, currentDateTime, ageCategory, groupCount, price, departureTime);
                        Storage.visitorList.Add(newVisitor);
                        UpdateVisitorTable();
                        MessageBox.Show("Visitor Details Sucessfully Added.");
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Visitor Entry Available Between 10 AM to 6 PM.");
                }

            }
            catch (FormatException numfor)
            {
                MessageBox.Show("Please Enter Only Number on Contact Number.");
            }      
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            visitorNameTxt.Text = null;
            contactNumberTxt.Text = null;
            addressTxt.Text = null;
            ageCatComboBox.SelectedItem = null;
            groupCheckBox.Checked = false;
            groupCountComboBox.SelectedItem = null;
            groupCountComboBox.Enabled = false;
        }

        public void UpdateVisitorTable()
        {
            int rowCount = visitorTable.Rows.Count;
            if (rowCount > 0)
            {
                visitorTable.Rows.Clear();
            }
            
            foreach (Visitor visitor in Storage.visitorList)
            {                
                visitorTable.Rows.Add(visitor.VisitorID, visitor.VisitorName, visitor.ContactNumber, visitor.Address, visitor.EntryTime.ToString("yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture), visitor.AgeCategory, visitor.GroupCount);
            }
        }

        private void groupCountComboBox_DropDown(object sender, EventArgs e)
        {
            var sortedGroupCount = from groupPrice in Storage.groupPriceList
                         orderby groupPrice.GroupCount
                         select groupPrice.GroupCount;

            groupCountComboBox.Items.Clear();
            foreach( String groupCount in sortedGroupCount.ToList())
            {
                groupCountComboBox.Items.Add(groupCount.ToString());
            }            
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (Storage.visitorList.Count > 0)
            {
                Services.Export(Storage.visitorList, "Visitor.txt");
                System.Windows.MessageBox.Show("Exported Successfully.");
            }
            else
            {
                System.Windows.MessageBox.Show("No Data to Export.");
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            String visitorData = Services.Import("Visitor.txt");

            if (String.IsNullOrEmpty(visitorData))
            {
                System.Windows.MessageBox.Show("Emtpy File.");
            }
            else
            {
                List<Visitor> temp = new List<Visitor>();
                temp = JsonConvert.DeserializeObject<List<Visitor>>(visitorData);
                foreach(Visitor visitor in temp)
                {
                    Storage.visitorList.Add(visitor);
                    
                }
                UpdateVisitorTable();
                System.Windows.MessageBox.Show("Imported Sucessfully.");
            }
        }
    }
}
