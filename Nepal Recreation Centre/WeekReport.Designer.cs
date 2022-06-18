
namespace Nepal_Recreation_Centre
{
    partial class WeekReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.weeklyReportTable = new System.Windows.Forms.DataGridView();
            this.weeklyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.selectDateLbl = new System.Windows.Forms.Label();
            this.weekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sortByLbl = new System.Windows.Forms.Label();
            this.orderLbl = new System.Windows.Forms.Label();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekChart)).BeginInit();
            this.SuspendLayout();
            // 
            // weeklyReportTable
            // 
            this.weeklyReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklyReportTable.Location = new System.Drawing.Point(10, 194);
            this.weeklyReportTable.Margin = new System.Windows.Forms.Padding(2);
            this.weeklyReportTable.Name = "weeklyReportTable";
            this.weeklyReportTable.RowTemplate.Height = 24;
            this.weeklyReportTable.Size = new System.Drawing.Size(318, 205);
            this.weeklyReportTable.TabIndex = 11;
            this.weeklyReportTable.Visible = false;
            // 
            // weeklyDatePicker
            // 
            this.weeklyDatePicker.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyDatePicker.Location = new System.Drawing.Point(127, 39);
            this.weeklyDatePicker.Name = "weeklyDatePicker";
            this.weeklyDatePicker.Size = new System.Drawing.Size(200, 23);
            this.weeklyDatePicker.TabIndex = 9;
            this.weeklyDatePicker.ValueChanged += new System.EventHandler(this.weeklyDatePicker_ValueChanged);
            // 
            // selectDateLbl
            // 
            this.selectDateLbl.AutoSize = true;
            this.selectDateLbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.selectDateLbl.Location = new System.Drawing.Point(37, 42);
            this.selectDateLbl.Name = "selectDateLbl";
            this.selectDateLbl.Size = new System.Drawing.Size(72, 15);
            this.selectDateLbl.TabIndex = 10;
            this.selectDateLbl.Text = "Select Date";
            // 
            // weekChart
            // 
            chartArea1.Name = "ChartArea1";
            this.weekChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.weekChart.Legends.Add(legend1);
            this.weekChart.Location = new System.Drawing.Point(333, 97);
            this.weekChart.Name = "weekChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.weekChart.Series.Add(series1);
            this.weekChart.Series.Add(series2);
            this.weekChart.Size = new System.Drawing.Size(437, 302);
            this.weekChart.TabIndex = 12;
            this.weekChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Week Report";
            this.weekChart.Titles.Add(title1);
            this.weekChart.Visible = false;
            // 
            // sortByLbl
            // 
            this.sortByLbl.AutoSize = true;
            this.sortByLbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.sortByLbl.Location = new System.Drawing.Point(38, 94);
            this.sortByLbl.Name = "sortByLbl";
            this.sortByLbl.Size = new System.Drawing.Size(44, 15);
            this.sortByLbl.TabIndex = 13;
            this.sortByLbl.Text = "Sort By";
            this.sortByLbl.Visible = false;
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.orderLbl.Location = new System.Drawing.Point(38, 138);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(33, 15);
            this.orderLbl.TabIndex = 14;
            this.orderLbl.Text = "Oder";
            this.orderLbl.Visible = false;
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "Total Visitor",
            "Total Earning"});
            this.sortByComboBox.Location = new System.Drawing.Point(98, 92);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortByComboBox.TabIndex = 15;
            this.sortByComboBox.Visible = false;
            this.sortByComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByComboBox_SelectedIndexChanged);
            // 
            // orderComboBox
            // 
            this.orderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.orderComboBox.Location = new System.Drawing.Point(98, 136);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderComboBox.TabIndex = 16;
            this.orderComboBox.Visible = false;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
            // 
            // WeekReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.orderLbl);
            this.Controls.Add(this.sortByLbl);
            this.Controls.Add(this.weekChart);
            this.Controls.Add(this.weeklyReportTable);
            this.Controls.Add(this.weeklyDatePicker);
            this.Controls.Add(this.selectDateLbl);
            this.Name = "WeekReport";
            this.Size = new System.Drawing.Size(780, 412);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyReportTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView weeklyReportTable;
        private System.Windows.Forms.DateTimePicker weeklyDatePicker;
        private System.Windows.Forms.Label selectDateLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart weekChart;
        private System.Windows.Forms.Label sortByLbl;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.ComboBox orderComboBox;
    }
}
