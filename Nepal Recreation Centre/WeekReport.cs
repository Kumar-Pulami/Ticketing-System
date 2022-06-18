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
    public partial class WeekReport : UserControl
    {
        public WeekReport()
        {
            InitializeComponent();
            //sortByComboBox.SelectedIndex = 0;
            //orderComboBox.SelectedIndex = 0;
        }

        public dynamic weekReport;


        private void weeklyDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = weeklyDatePicker.Value;
            weekReport = GetWeekReport(selectedDate);
            if (weekReport == null || weekReport.Count == 0)
            {
                weeklyReportTable.DataSource = null;                
                sortByLbl.Visible = false;
                sortByComboBox.Visible = false;
                orderLbl.Visible = false;
                orderComboBox.Visible = false;
                weeklyReportTable.Visible = false;
                weekChart.Visible = false;
                MessageBox.Show("No Data Available.");
            }
            else
            {
                weeklyReportTable.DataSource = weekReport;
                BindChart(weekReport);

                sortByLbl.Visible = true;
                sortByComboBox.Visible = true;
                orderLbl.Visible = true;
                orderComboBox.Visible = true;
                weeklyReportTable.Visible = true;
                weekChart.Visible = true;
            }            
        }

        public static DateTime[] StartEndDateTimeOfWeek(DateTime selectedDateTime)
        {
            DateTime[] startEndDateOfWeek = new DateTime[2];
            int year = selectedDateTime.Date.Year;
            //set the first day of the year
            DateTime firstDay = new DateTime(year, 1, 1);
            //get Day of the week 
            DayOfWeek day = selectedDateTime.DayOfWeek;
            CultureInfo cul = CultureInfo.CurrentCulture;
            //get no of week for the date
            int weekNo = cul.Calendar.GetWeekOfYear(selectedDateTime, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            //get no of day
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
            startEndDateOfWeek[0] = startDateOfWeek;
            startEndDateOfWeek[1] = endDateOfWeek;
            return startEndDateOfWeek;
        }



        public dynamic GetWeekReport(DateTime selectedDateTime)
        {
            List<DateTime> startEndDateOfWeek = new List<DateTime>(StartEndDateTimeOfWeek(selectedDateTime));
            DateTime startDateOfWeek = startEndDateOfWeek[0];
            DateTime endDateOfWeek = startEndDateOfWeek[1];
            List<Visitor> visitorList = new List<Visitor>(Storage.visitorList);
            var weeklyReport = visitorList.
                             Where(
                                 visitor => visitor.EntryTime >= startDateOfWeek && visitor.EntryTime <= endDateOfWeek
                             ).OrderBy(
                                orderBy => orderBy.EntryTime
                                ).
                             GroupBy(
                                groupBy => groupBy.EntryTime.ToString("dddd", CultureInfo.InvariantCulture)
                             ).
                             Select(select => new
                             {
                                 Week = select.First().EntryTime.ToString("dddd", CultureInfo.InvariantCulture),
                                 Visitor = select.Count(),
                                 Earning = select.Sum(Sum => Sum.Price)
                             }).
                             ToList();            
            return weeklyReport;
        }

        public void BindChart(dynamic weekData)
        {
            weekChart.Series[0].LegendText = "Total Visitor";
            weekChart.Series[0].IsValueShownAsLabel = true;
            weekChart.Series[0].XValueMember = "Week";
            weekChart.Series[0].YValueMembers = "Visitor";

            weekChart.Series[1].LegendText = "Total Earning";
            weekChart.Series[1].IsValueShownAsLabel = true;
            weekChart.Series[1].XValueMember = "Week";
            weekChart.Series[1].YValueMembers = "Earning";

            weekChart.DataSource = weekData;
        }

        private void sortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortData();
        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortData();
        }



        public dynamic SortWeekReportByTotalVisitor(dynamic weekReportData)
        {
            for (int j = 0; j <= weekReportData.Count - 2; j++)
            {
                for (int i = 0; i <= weekReportData.Count - 2; i++)
                {
                    if (weekReportData[i].Visitor > weekReportData[i + 1].Visitor)
                    {
                        var temp = weekReportData[i + 1];
                        weekReportData[i + 1] = weekReportData[i];
                        weekReportData[i] = temp;
                    }
                }
            }
            
            return weekReportData;
        }

        public dynamic SortWeekReportByTotalEarning(dynamic weekReportData)
        {
            for (int j = 0; j <= weekReportData.Count - 2; j++)
            {
                for (int i = 0; i <= weekReportData.Count - 2; i++)
                {
                    if (weekReportData[i].Earning > weekReportData[i + 1].Earning)
                    {
                        var temp = weekReportData[i + 1];
                        weekReportData[i + 1] = weekReportData[i];
                        weekReportData[i] = temp;
                    }
                }
            }
            return weekReportData;
        }

        public void SortData()
        {
            if (sortByComboBox.SelectedIndex == 0 && orderComboBox.SelectedIndex == 0)
            {
                var sortedData = SortWeekReportByTotalVisitor(weekReport);
                weeklyReportTable.DataSource = null;               
                weeklyReportTable.DataSource = sortedData;
            }
            else if (sortByComboBox.SelectedIndex == 0 && orderComboBox.SelectedIndex == 1)
            {
                var sortedData = SortWeekReportByTotalVisitor(weekReport);
                weeklyReportTable.DataSource = null;
                sortedData.Reverse();
                weeklyReportTable.DataSource = sortedData;
            }
            else if (sortByComboBox.SelectedIndex == 1 && orderComboBox.SelectedIndex == 0)
            {
                var sortedData = SortWeekReportByTotalEarning(weekReport);
                weeklyReportTable.DataSource = null;
                weeklyReportTable.DataSource = sortedData;
            }
            else if (sortByComboBox.SelectedIndex == 1 && orderComboBox.SelectedIndex == 1)
            {
                var sortedData = SortWeekReportByTotalEarning(weekReport);
                weeklyReportTable.DataSource = null;
                sortedData.Reverse();
                weeklyReportTable.DataSource = sortedData;
            }
        }        
    }
}
