using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nepal_Recreation_Centre
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Instance = this;
            timer.Start();
            ActivateCurrentButton(dashboardBtn, "Dashboard");
            formPanel.Controls.Clear();
            dashboard = new Dashboard();
            formPanel.Controls.Add(dashboard);
        }

        public Main Instance;

        
        public static Button previousButton = null;
        public static Button currentButton;


        visitorEntryForm visitorForm;
        GroupPriceEntry groupPriceEntry;
        IndividualPriceEntry individualPriceEntry;
        AdminLogin adminLogin;
        DayReport dayReport;
        WeekReport weekReport;
        CheckOut checkOut;
        Dashboard dashboard;

        public void ActivateCurrentButton(Button btnSender, String label)
        {
            currentButton = btnSender;
            formLbl.Text = label;
            indicatorPanel.Height = currentButton.Height;
            indicatorPanel.Top = currentButton.Top;
            indicatorPanel.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(46, 51, 73);
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
        }

        public void DeactivateButton()
        {
            if (previousButton == null)
            {
                dashboardBtn.BackColor = Color.FromArgb(24, 30, 54);
                dashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                dashboardBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                optionLbl.Visible = false;
                optionComboBox.Visible = false;
                previousButton = currentButton;
            }
            else if(currentButton != previousButton)
            {
                previousButton.BackColor = Color.FromArgb(24, 30, 54);
                previousButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                previousButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                optionLbl.Visible = false;
                optionComboBox.Visible = false;                

                previousButton = currentButton;
            }            
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ActivateCurrentButton(dashboardBtn, "Dashboard");
            DeactivateButton();
            formPanel.Controls.Clear();
            dashboard = new Dashboard();
            formPanel.Controls.Add(dashboard);
        }


        private void visitorEntryBtn_Click(object sender, EventArgs e)
        {
            ActivateCurrentButton(visitorEntryBtn, "Visitor Entry");
            DeactivateButton();
            formPanel.Controls.Clear();
            visitorForm = new visitorEntryForm();
            formPanel.Controls.Add(visitorForm);
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            ActivateCurrentButton(checkOutBtn, "Check Out");
            DeactivateButton();

            formPanel.Controls.Clear();
            checkOut = new CheckOut();
            formPanel.Controls.Add(checkOut);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ActivateCurrentButton(reportBtn, "Report");
            DeactivateButton();
            
            formPanel.Controls.Clear();

            optionLbl.Visible = true;
            optionLbl.Text = "Report Option";

            optionComboBox.Visible = true;
            optionComboBox.Items.Clear();
            optionComboBox.Items.Add("Day Report");
            optionComboBox.Items.Add("Week Report");

        }

        private void priceEntry_Click(object sender, EventArgs e)
        {
            ActivateCurrentButton(priceEntry, "Price Entry");
            DeactivateButton();
            formPanel.Controls.Clear();

            adminLogin = new AdminLogin(Instance);
            formPanel.Controls.Add(adminLogin);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();
            dateLbl.Text = DateTime.Now.ToLongDateString();
        }


        private void optionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            String seletedReportOption = (String) optionComboBox.SelectedItem;
            if (seletedReportOption.Equals("Day Report"))
            {
                formPanel.Controls.Clear();
                dayReport = new DayReport();
                formPanel.Controls.Add(dayReport);
            }
            else if (seletedReportOption.Equals("Week Report"))
            {
                formPanel.Controls.Clear();
                weekReport = new WeekReport();
                formPanel.Controls.Add(weekReport);
            }
            else if (seletedReportOption.Equals("Group Price"))
            {
                formPanel.Controls.Clear();
                groupPriceEntry = new GroupPriceEntry();
                formPanel.Controls.Add(groupPriceEntry);
            }
            else if (seletedReportOption.Equals("Individual Price"))
            {
                formPanel.Controls.Clear();
                individualPriceEntry = new IndividualPriceEntry();
                formPanel.Controls.Add(individualPriceEntry);
            }
        }
         
        
        public void ShowOptionLblTxt()
        {
            formPanel.Controls.Clear();
            optionLbl.Visible = true;
            optionLbl.Text = "Price Entry Option";

            optionComboBox.Visible = true;
            optionComboBox.Items.Clear();
            optionComboBox.Items.Add("Group Price");
            optionComboBox.Items.Add("Individual Price");
        }
    }   
}
