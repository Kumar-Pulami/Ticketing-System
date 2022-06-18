using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Nepal_Recreation_Centre
{
    public partial class IndividualPriceEntry : UserControl
    {
        public IndividualPriceEntry()
        {
            InitializeComponent();           
            UpdateIndividualPriceGridView();
        }

        DataGridViewRow individualPriceSelectedRow;

        private void addIndividualPriceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String ageCategory = (String)ageCatComboBox.SelectedItem;
                String weekendPriceStr = weekendPriceTxt.Text;
                String regularPriceStr = regularPriceTxt.Text;
                String hour = hourTxt.Text;
                int weekendPrice = 0;
                int regularPrice = 0;
                Boolean validation = false;

                if (String.IsNullOrEmpty(ageCategory) || String.IsNullOrEmpty(weekendPriceStr) || String.IsNullOrEmpty(regularPriceStr) || String.IsNullOrEmpty(hour))
                {
                    validation = false;
                    System.Windows.MessageBox.Show("Please fill the empty fields.");
                }
                else
                {
                    weekendPrice = int.Parse(weekendPriceStr);
                    regularPrice = int.Parse(regularPriceStr);
                    validation = true;
                }
                if ( !hour.Equals("Unlimited"))
                {
                    int tempHour = int.Parse(hour);
                    if (tempHour > 0 && tempHour < 10)
                    {
                        validation = true;
                    }
                    else
                    {
                        validation = false;
                        System.Windows.MessageBox.Show("Please Enter Hour between 0 and 10.");
                    }
                }
                else
                {
                    validation = false;
                    System.Windows.MessageBox.Show("Please Enter Unlimited or only number in Hour.");
                }

                if (validation)
                {
                    foreach (IndividualPrice individualPrice in Storage.individualPriceList)
                    {
                        if (individualPrice.AgeCategory.Equals(ageCategory) && individualPrice.Hour.Equals(hour))
                        {
                            validation = false;
                            System.Windows.MessageBox.Show("Duplicate Individaul Price Entry.");
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
                    IndividualPrice newIndividualPrice = new IndividualPrice(ageCategory, regularPrice, weekendPrice, hour);
                    Storage.individualPriceList.Add(newIndividualPrice);
                    UpdateIndividualPriceGridView();
                    System.Windows.MessageBox.Show("New Indiviual Price is added sucessfully.");
                    ClearIndividualPriceFields();
                }
            }
            catch (FormatException ex)
            {
                System.Windows.MessageBox.Show("Please Enter Weekend/ Regular Price in number.");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }       

        private void updateindividualPriceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String ageCategory = (String)ageCatComboBox.SelectedItem;
                String weekendPriceStr = weekendPriceTxt.Text;
                String regularPriceStr = regularPriceTxt.Text;
                String hour = hourTxt.Text;
                int weekendPrice = 0;
                int regularPrice = 0;
                Boolean validation = false;

                if (String.IsNullOrEmpty(ageCategory) || String.IsNullOrEmpty(weekendPriceStr) || String.IsNullOrEmpty(regularPriceStr) || String.IsNullOrEmpty(hour))
                {
                    validation = false;
                    System.Windows.MessageBox.Show("Please fill the empty fields.");
                }
                else
                {
                    weekendPrice = int.Parse(weekendPriceStr);
                    regularPrice = int.Parse(regularPriceStr);
                    validation = true;
                }

                if (validation)
                {
                    Boolean found = false;
                    foreach (IndividualPrice individualPrice in Storage.individualPriceList)
                    {
                        if (individualPrice.AgeCategory.Equals(ageCategory) && individualPrice.Hour.Equals(hour))
                        {
                            individualPrice.WeekendPrice = weekendPrice;
                            individualPrice.RegularPrice = regularPrice;
                            found = true;
                            UpdateIndividualPriceGridView();
                            System.Windows.MessageBox.Show("Selected Individual Price Sucessfully updated.");
                            ClearIndividualPriceFields();
                            break;
                        }
                        else
                        {
                            found = false;
                            validation = false;
                        }
                    }
                    if (!found)
                    {
                        System.Windows.MessageBox.Show("Selected individual price not Found.");
                    }
                }

            }
            catch (FormatException)
            {
                System.Windows.MessageBox.Show("Please Enter Weekend/ Regular Price in number.");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void deleteIndividualPriceBtn_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete ?", "Delete Conformation", MessageBoxButton.OKCancel);

            if (confirmResult == MessageBoxResult.OK)
            {
                String selectedAgeCat = individualPriceSelectedRow.Cells[0].Value.ToString();
                String hour = individualPriceSelectedRow.Cells[1].Value.ToString();
                foreach (IndividualPrice individualPrice in Storage.individualPriceList)
                {
                    if (individualPrice.AgeCategory.Equals(selectedAgeCat) && individualPrice.Hour.Equals(hour))
                    {
                        Storage.individualPriceList.Remove(individualPrice);
                        UpdateIndividualPriceGridView();
                        System.Windows.MessageBox.Show("Selected Group Price Sucessfully Removed.");
                        ClearIndividualPriceFields();
                        break;
                    }
                }
            }
        }


        private void IndividualPriceClearBtn_Click(object sender, EventArgs e)
        {
            ClearIndividualPriceFields();
        }


        private void individualPriceTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                addIndividualPriceBtn.Enabled = false;
                updateindividualPriceBtn.Visible = true;
                deleteIndividualPriceBtn.Visible = true;
                ageCatComboBox.Enabled = false;
                ageCatComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                hourTxt.Enabled = false;

                int selectedRow = individualPriceTable.CurrentCell.RowIndex;
                individualPriceSelectedRow = individualPriceTable.Rows[selectedRow];

                ageCatComboBox.Text = individualPriceSelectedRow.Cells[0].Value.ToString();
                hourTxt.Text = individualPriceSelectedRow.Cells[1].Value.ToString();
                regularPriceTxt.Text = individualPriceSelectedRow.Cells[2].Value.ToString();
                weekendPriceTxt.Text = individualPriceSelectedRow.Cells[3].Value.ToString();
            }
            else
            {
                System.Windows.MessageBox.Show("No Information to Update.");
            }
        }


        public void ClearIndividualPriceFields()
        {
            ageCatComboBox.SelectedItem = null;
            ageCatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            weekendPriceTxt.Text = null;
            regularPriceTxt.Text = null;
            hourTxt.Text = null;
            addIndividualPriceBtn.Enabled = true;
            updateindividualPriceBtn.Visible = false;
            deleteIndividualPriceBtn.Visible = false;
            ageCatComboBox.Enabled = true;
            hourTxt.Enabled = true;
        }


        public void UpdateIndividualPriceGridView()
        {
            int rowCount = individualPriceTable.Rows.Count;
            if (rowCount > 0)
            {
                individualPriceTable.Rows.Clear();
            }

            foreach (IndividualPrice individualPrice in Storage.individualPriceList)
            {
                individualPriceTable.Rows.Add(individualPrice.AgeCategory, individualPrice.Hour, individualPrice.RegularPrice, individualPrice.WeekendPrice);
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            String individualPriceData = Services.Import("IndividualPrice.txt");

            if (String.IsNullOrEmpty(individualPriceData))
            {
                System.Windows.MessageBox.Show("Emtpy File.");
            }
            else
            {
                List<IndividualPrice> temp = new List<IndividualPrice>();
                temp = JsonConvert.DeserializeObject<List<IndividualPrice>>(individualPriceData);
                foreach (IndividualPrice individualPrice in temp)
                {
                    Storage.individualPriceList.Add(individualPrice);                    
                }
                UpdateIndividualPriceGridView();
                System.Windows.MessageBox.Show("Imported Sucessfully.");
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (Storage.individualPriceList.Count > 0)
            {
                Services.Export(Storage.individualPriceList, "IndividualPrice.txt");
                System.Windows.MessageBox.Show("Exported Successfully.");
            }
            else
            {
                System.Windows.MessageBox.Show("No Data to Export.");
            }
        }

        private void IndividualPriceEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
