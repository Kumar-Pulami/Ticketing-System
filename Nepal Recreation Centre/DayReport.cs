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
    public partial class DayReport : UserControl
    {
        public DayReport()
        {
            InitializeComponent();
        }

        private void dailyDatePicker_ValueChanged(object sender, EventArgs e)
        {
            String selectedDate = dailyDatePicker.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            List<Visitor> visitorListForDayReport = new List<Visitor>(Storage.visitorList);
            var dayResult = visitorListForDayReport.
                             Where(visitor => visitor.EntryTime.ToString("yyyyMMdd", CultureInfo.InvariantCulture).Equals(selectedDate)).
                             GroupBy(groupBy => new
                             {
                                 groupBy.GroupCount,
                                 groupBy.AgeCategory,
                             }).
                            Select(select => new
                            {
                                Group = select.Key.GroupCount,
                                AgeCategory = select.Key.AgeCategory,
                                Visitor_Number = select.Count(),
                                Earning = select.Sum(sum => sum.Price)
                            }).
                            ToList();

            if (dayResult == null || dayResult.Count == 0)
            {
                dailyReportTable.DataSource = null;
                dailyReportTable.Visible = false;
                MessageBox.Show("No Data Available.");
            }
            else
            {
                dailyReportTable.DataSource = dayResult;
                dailyReportTable.Visible = true;
            }
        }
    }
}
