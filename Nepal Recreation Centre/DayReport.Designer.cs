
namespace Nepal_Recreation_Centre
{
    partial class DayReport
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
            this.dailyReportTable = new System.Windows.Forms.DataGridView();
            this.dailyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.selectDateLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyReportTable
            // 
            this.dailyReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportTable.Location = new System.Drawing.Point(140, 125);
            this.dailyReportTable.Name = "dailyReportTable";
            this.dailyReportTable.Size = new System.Drawing.Size(445, 237);
            this.dailyReportTable.TabIndex = 5;
            this.dailyReportTable.Visible = false;
            // 
            // dailyDatePicker
            // 
            this.dailyDatePicker.Location = new System.Drawing.Point(140, 57);
            this.dailyDatePicker.Name = "dailyDatePicker";
            this.dailyDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dailyDatePicker.TabIndex = 3;
            this.dailyDatePicker.ValueChanged += new System.EventHandler(this.dailyDatePicker_ValueChanged);
            // 
            // selectDateLbl
            // 
            this.selectDateLbl.AutoSize = true;
            this.selectDateLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.selectDateLbl.Location = new System.Drawing.Point(48, 57);
            this.selectDateLbl.Name = "selectDateLbl";
            this.selectDateLbl.Size = new System.Drawing.Size(77, 17);
            this.selectDateLbl.TabIndex = 4;
            this.selectDateLbl.Text = "Select Date";
            // 
            // DayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.dailyReportTable);
            this.Controls.Add(this.dailyDatePicker);
            this.Controls.Add(this.selectDateLbl);
            this.Name = "DayReport";
            this.Size = new System.Drawing.Size(780, 412);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dailyReportTable;
        private System.Windows.Forms.DateTimePicker dailyDatePicker;
        private System.Windows.Forms.Label selectDateLbl;
    }
}
