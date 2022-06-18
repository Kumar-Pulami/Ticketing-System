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
    public partial class GroupPriceEntry : UserControl
    {
        public GroupPriceEntry()
        {
            InitializeComponent();
            updateGroupPriceGridView();
        }

        DataGridViewRow groupCountSelectedRow;

        private void addGroupPriceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String groupCountStr = groupCountTxt.Text;
                String discountPerStr = discountMemberTxt.Text;
                Boolean validation = false;
                String groupCount = null;
                int discountPer = 0;

                if (String.IsNullOrEmpty(groupCountStr) || String.IsNullOrEmpty(discountPerStr))
                {
                    System.Windows.MessageBox.Show("Please fill the empty fields.");
                    validation = false;
                }
                else
                {
                    groupCount = groupCountStr;
                    int temp = int.Parse(groupCountStr);


                    discountPer = int.Parse(discountPerStr);
                    if (int.Parse(groupCount) > 1 )
                    {
                        validation = true;
                    }
                    else
                    {
                        validation = false;
                        System.Windows.Forms.MessageBox.Show("Group Count Must be greater than 1.");
                    }
                }


                if (validation)
                {
                    if (discountPer > 0 && discountPer < 100)
                    {
                        validation = true;
                    }
                    else
                    {
                        validation = false;
                        System.Windows.Forms.MessageBox.Show("Discount Percentage should between 0 and 100.");
                    }
                }


                if (validation)
                {
                    foreach (GroupPrice groupPrice in Storage.groupPriceList)
                    {
                        if (groupPrice.GroupCount.Equals(groupCount))
                        {
                            validation = false;
                            System.Windows.MessageBox.Show("Entered Group Count already exists.");
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
                    GroupPrice newGroupPrice = new GroupPrice(groupCount, discountPer);
                    Storage.groupPriceList.Add(newGroupPrice);
                    updateGroupPriceGridView();
                    System.Windows.MessageBox.Show("New Group Price Sucessfully Inserted.");
                    ClearAddGroupTextFields();
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

        public void ClearAddGroupTextFields()
        {
            groupCountTxt.Text = null;
            discountMemberTxt.Text = null;
            groupCountTxt.Enabled = true;
            updateGroupPriceBtn.Visible = false;
            deleteGroupPriceBtn.Visible = false;
            addGroupPriceBtn.Enabled = true;
        }

        private void updateGroupPriceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String groupCountStr = groupCountTxt.Text;
                String discountMemberStr = discountMemberTxt.Text;
                String selectedGroupPriceStr = groupCountSelectedRow.Cells[0].Value.ToString();
                long selectedGroupPrice = long.Parse(selectedGroupPriceStr);
                Boolean validation;
                String groupcount = null;
                int discountMember = 0;

                if (String.IsNullOrEmpty(groupCountStr) || String.IsNullOrEmpty(discountMemberStr))
                {
                    System.Windows.MessageBox.Show("Please fill the empty fields.");
                    validation = false;
                }
                else
                {
                    groupcount = groupCountStr;
                    //groupcount = int.Parse(groupCountStr);
                    discountMember = int.Parse(discountMemberStr);
                    validation = true;
                }

                if (validation)
                {
                    if (discountMember > 0 && discountMember < 100)
                    {
                        validation = true;
                    }
                    else
                    {
                        validation = false;
                        System.Windows.Forms.MessageBox.Show("Discount Percentage should between 0 and 100.");
                    }
                }

                if (validation)
                {
                    Boolean found = false;
                    foreach (GroupPrice groupPrice in Storage.groupPriceList)
                    {
                        if (groupPrice.GroupCount.Equals(groupcount))
                        {
                            groupPrice.DiscountPer = discountMember;
                            updateGroupPriceBtn.Visible = false;
                            deleteGroupPriceBtn.Visible = false;
                            updateGroupPriceGridView();
                            System.Windows.MessageBox.Show("Group Price Updated Sucessfully.");
                            ClearAddGroupTextFields();
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        System.Windows.MessageBox.Show("Select Group Price Not Found.");
                    }
                }

            }
            catch (FormatException ex)
            {
                System.Windows.MessageBox.Show("Please Enter discount memeber in number.");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void deleteGroupPriceBtn_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete ??", "Delete Conformation", MessageBoxButton.OKCancel);

            if (confirmResult == MessageBoxResult.OK)
            {
                String selectedGroupCount = groupCountSelectedRow.Cells[0].Value.ToString();
                foreach (GroupPrice groupCount in Storage.groupPriceList)
                {
                    if (groupCount.GroupCount.Equals(selectedGroupCount))
                    {
                        Storage.groupPriceList.Remove(groupCount);
                        updateGroupPriceGridView();
                        System.Windows.MessageBox.Show("Selected Group Price Sucessfully Removed.");
                        ClearAddGroupTextFields();
                        break;
                    }
                }
            }
        }

        public void updateGroupPriceGridView()
        {
            int rowCount = groupPriceTable.Rows.Count;
            if (rowCount > 0)
            {
                groupPriceTable.Rows.Clear();
            }

            foreach (GroupPrice groupPrice in Storage.groupPriceList)
            {
                groupPriceTable.Rows.Add(groupPrice.GroupCount, groupPrice.DiscountPer);
            }
        }

        private void groupPriceTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedIndex = groupPriceTable.CurrentCell.RowIndex;
                groupCountSelectedRow = groupPriceTable.Rows[selectedIndex];
                groupCountTxt.Text = groupCountSelectedRow.Cells[0].Value.ToString();
                discountMemberTxt.Text = groupCountSelectedRow.Cells[1].Value.ToString();
                groupCountTxt.Enabled = false;
                addGroupPriceBtn.Enabled = false;
                updateGroupPriceBtn.Visible = true;
                deleteGroupPriceBtn.Visible = true;
                addGroupPriceBtn.Enabled = false;
            }
            else
            {
                System.Windows.MessageBox.Show("No Information to Select.");
            }
        }

        private void groupPriceClearBtn_Click(object sender, EventArgs e)
        {
            ClearAddGroupTextFields();
        }
        
        private void importBtn_Click(object sender, EventArgs e)
        {
            String groupPriceData = Services.Import("GroupPrice.txt");

            if (String.IsNullOrEmpty(groupPriceData))
            {
                System.Windows.MessageBox.Show("Emtpy File.");
            }
            else
            {
                List<GroupPrice> temp = new List<GroupPrice>();
                temp = JsonConvert.DeserializeObject<List<GroupPrice>>(groupPriceData);
                foreach (GroupPrice groupPrice in temp)
                {
                    Storage.groupPriceList.Add(groupPrice);                    
                }
                updateGroupPriceGridView();
                System.Windows.MessageBox.Show("Imported Sucessfully.");
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (Storage.groupPriceList.Count > 0)
            {
                Services.Export(Storage.groupPriceList, "GroupPrice.txt");
                System.Windows.MessageBox.Show("Exported Successfully.");
            }
            else
            {
                System.Windows.MessageBox.Show("No Data to Export.");
            }
        }
    }
}
