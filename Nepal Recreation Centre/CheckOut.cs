using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Nepal_Recreation_Centre
{
    public partial class CheckOut : UserControl
    {
        public CheckOut()
        {
            InitializeComponent();
            UpdateTable();
        }


        DateTime departureTime;

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String visitorIDStr = visitorIDTxt.Text;
                long visitorID;
                String group = null;
                DateTime entry = default;
                DateTime exit = DateTime.Now;
                departureTime = exit;
                String age = null;
                String hour = null;
                if (String.IsNullOrEmpty(visitorIDStr))
                {
                    MessageBox.Show("Please Enter Visitor ID.");                    
                }
                else{
                    visitorID = long.Parse(visitorIDStr);
                    Boolean valid = false;
                    Boolean found = false;
                    foreach (Visitor visitor in Storage.visitorList)
                    {
                        if (visitor.VisitorID == visitorID)
                        {
                            visitorIDTxt.Text = visitor.VisitorID.ToString();
                            visitorNameTxt.Text = visitor.VisitorName;
                            ageTxt.Text = visitor.AgeCategory;
                            groupTxt.Text = visitor.GroupCount;
                            addressTxt.Text = visitor.Address;
                            contactTxt.Text = visitor.ContactNumber.ToString();
                            exitTimeTxt.Text = visitor.DepartureTime.ToString();
                            entryTimeTxt.Text = visitor.EntryTime.ToString();
                            totalPriceValueLbl.Text = visitor.Price.ToString();
                            if (String.IsNullOrEmpty(visitor.DepartureTime.ToString()))
                            {
                                exitTimeTxt.Text = departureTime.ToString();
                            }

                            if (!visitor.EntryTime.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
                            {
                                calcBtn.Enabled = false;
                                MessageBox.Show("Ticket Doesn't belong to Today Date.");
                            }
                            else if (visitor.Price != 0)
                            {
                                calcBtn.Enabled = false;
                                MessageBox.Show("Visitor is Already Checked Out.");
                            }
                            else
                            {                                
                                group = visitor.GroupCount;
                                age = visitor.AgeCategory;
                                entry = visitor.EntryTime;                                
                                valid = true;
                                found = true;
                            }
                            break;
                        }
                    }

                    if (valid)
                    {
                        var hourInserted = Storage.individualPriceList.
                            OrderBy(
                                orderBy => orderBy.Hour
                            ).
                            Select(
                                select => select.Hour
                            ).
                            ToList();

                        if (hourInserted.Count > 0)
                        {
                            Boolean calculate = false;
                            TimeSpan difference = exit - entry;
                            int length = 0;
                            double duration = difference.TotalHours;


                            if (hourInserted[hourInserted.Count - 1].Equals("Unlimited"))
                            {
                                length = hourInserted.Count - 2;

                            }
                            else
                            {
                                length = hourInserted.Count - 1;
                            }

                            int previousHr = int.Parse(hourInserted[0]);

                            // Getting comparing duration of visitor to hour inserted by admin.
                            for (int i = 0; i <= length; i++)
                            {
                                if (double.Parse(duration.ToString()).Equals(int.Parse(hourInserted[i])))
                                {
                                    hour = hourInserted[i];
                                    calculate = true;
                                    break;
                                }
                                else if (double.Parse(duration.ToString()) > int.Parse(hourInserted[i]))
                                {
                                    if (length == i)
                                    {
                                        hour = hourInserted[hourInserted.Count - 1];
                                        calculate = true;
                                    }
                                    else
                                    {
                                        previousHr = int.Parse(hourInserted[i]);
                                    }
                                }
                                else if ((double.Parse(duration.ToString()) < int.Parse(hourInserted[i])))
                                {
                                    hour = hourInserted[i];
                            calculate = true;
                                    break;
                                }
                            }
                            if (calculate)
                            {
                                // calulating price of the visitor 
                                long totalPrice = CalculatePrice(visitorID, hour, age, group);
                                totalPriceValueLbl.Text = totalPrice.ToString();
                                saveBtn.Visible = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Set the Price Rate.");
                        }                        
                    }

                    if(!found)
                    {
                        MessageBox.Show("Visitor Data Not Found.");
                    }
                }
            }
            catch (FormatException numfor)
            {
                MessageBox.Show("Please Enter Only Number on Visitor ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public long CalculatePrice(long visitorID, String duration, String age, String group)
        {
            int totalPrice = 0;
            int rate = 0;
            String dayType = null;
            int discount = 0; 

            // Getting price based on AgeCategory, and duration
            foreach (IndividualPrice individual in Storage.individualPriceList)
            {
                if (individual.AgeCategory.Equals(age) && individual.Hour.Equals(duration))
                {
                    if (DateTime.Now.DayOfWeek.ToString().Equals("Saturday"))
                    {
                        rate = individual.WeekendPrice;
                    }
                    else if (!DateTime.Now.DayOfWeek.ToString().Equals("Saturday"))
                    {
                        rate = individual.RegularPrice;
                    }
                }
            }


            if (rate == 0)
            {
                MessageBox.Show("Price Not Found");
                calcBtn.Visible = false;
            }
            else
            {
                if (group.Equals("Individual"))
                {
                    discount = 0;
                }
                else
                {
                    Boolean found = false;
                    foreach (GroupPrice groupPrice in Storage.groupPriceList)
                    {
                        if (group.Equals(groupPrice.GroupCount))
                        {
                            discount = groupPrice.DiscountPer;
                            found = true;
                        }                        
                    }
                    if (!found)
                    {
                        MessageBox.Show("Group Not Found");
                    }
                }
            }

            totalPrice = Convert.ToInt32(rate - (rate * discount / 100));        

            return totalPrice;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            visitorNameTxt.Text = null;
            visitorIDTxt.Text = null;
            ageTxt.Text = null;
            groupTxt.Text = null;
            entryTimeTxt.Text = null;
            exitTimeTxt.Text = null;
            contactTxt.Text = null;
            addressTxt.Text = null;
            totalPriceValueLbl.Text = "0";
            saveBtn.Visible = false;
            calcBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            long visitorID = long.Parse(visitorIDTxt.Text);
            int totalPrice = int.Parse(totalPriceValueLbl.Text);
            foreach (Visitor visitorData in Storage.visitorList)
            {
                if (visitorData.VisitorID == visitorID)
                {
                    visitorData.Price = totalPrice;
                    visitorData.DepartureTime = departureTime;
                    MessageBox.Show("Price has been saved.");
                    Clear();
                    break;
                }
            }
            UpdateTable();
        }

        public void UpdateTable()
        {
            if(priceTable.Rows.Count > 0)
            {
                priceTable.Rows.Clear();
            }
            var visitorPriceData = Storage.visitorList.
                Where(where => where.Price != 0).
                OrderBy(orderBy => orderBy.EntryTime).
                Select(select => new {
                    select.VisitorID,
                    select.VisitorName,
                    select.AgeCategory,
                    select.GroupCount,
                    select.EntryTime,
                    select.DepartureTime,
                    select.Price
                }).ToList();
            priceTable.DataSource = visitorPriceData;
        }
    }
}
