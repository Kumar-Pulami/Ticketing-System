using Newtonsoft.Json;
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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();

            if (Storage.visitorList.Count <= 0)
            {
                String visitorData = Services.Import("Visitor.txt");
                list = new List<Visitor>(); ;
                list = JsonConvert.DeserializeObject<List<Visitor>>(visitorData);
            }
            else
            {
                
                earningValueLbl.Text = list.Sum(sum => sum.Price).ToString();
            }

            list = new List<Visitor>(Storage.visitorList);
            totalVisitorValueLbl.Text = list.Count.ToString();
            LoadChart(GetReportData(list));

        }


        List<Visitor> list;


        public dynamic GetReportData(List<Visitor> visitorData)
        {
            var filteredData = list.
                                GroupBy
                                (
                                    groupBy => groupBy.AgeCategory
                                ).
                                    Select
                                    (
                                        Select => new
                                        {
                                            Age = Select.First().AgeCategory,
                                            Earning = Select.Sum(sum => sum.Price),
                                            Count = Select.Count()
                                        }
                                     ).ToList();
            return filteredData;
        }

        public void LoadChart(dynamic filteredList)
        {
            chart1.Series[0].LegendText = "Total Count";
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].XValueMember = "Age";
            chart1.Series[0].YValueMembers = "Count";

            chart1.Series[1].LegendText = "Total Earning";
            chart1.Series[1].IsValueShownAsLabel = true;
            chart1.Series[1].XValueMember = "Age";
            chart1.Series[1].YValueMembers = "Earning";

            chart1.DataSource = filteredList;
        }
                                   

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void totalVisitorLbl_Click(object sender, EventArgs e)
        {

        }

        private void earningPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void earningValueLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
