
namespace Nepal_Recreation_Centre
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.visitorPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalVisitorValueLbl = new System.Windows.Forms.Label();
            this.totalVisitorLbl = new System.Windows.Forms.Label();
            this.earningPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.earningValueLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.visitorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.earningPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // visitorPanel
            // 
            this.visitorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.visitorPanel.Controls.Add(this.pictureBox1);
            this.visitorPanel.Controls.Add(this.totalVisitorValueLbl);
            this.visitorPanel.Controls.Add(this.totalVisitorLbl);
            this.visitorPanel.Location = new System.Drawing.Point(31, 37);
            this.visitorPanel.Name = "visitorPanel";
            this.visitorPanel.Size = new System.Drawing.Size(258, 145);
            this.visitorPanel.TabIndex = 0;
            this.visitorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nepal_Recreation_Centre.Properties.Resources.male_solid;
            this.pictureBox1.Location = new System.Drawing.Point(162, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // totalVisitorValueLbl
            // 
            this.totalVisitorValueLbl.AutoSize = true;
            this.totalVisitorValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVisitorValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.totalVisitorValueLbl.Location = new System.Drawing.Point(15, 83);
            this.totalVisitorValueLbl.Name = "totalVisitorValueLbl";
            this.totalVisitorValueLbl.Size = new System.Drawing.Size(62, 31);
            this.totalVisitorValueLbl.TabIndex = 1;
            this.totalVisitorValueLbl.Text = "450";
            // 
            // totalVisitorLbl
            // 
            this.totalVisitorLbl.AutoSize = true;
            this.totalVisitorLbl.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVisitorLbl.ForeColor = System.Drawing.Color.White;
            this.totalVisitorLbl.Location = new System.Drawing.Point(16, 38);
            this.totalVisitorLbl.Name = "totalVisitorLbl";
            this.totalVisitorLbl.Size = new System.Drawing.Size(126, 25);
            this.totalVisitorLbl.TabIndex = 0;
            this.totalVisitorLbl.Text = "Total Visitors";
            this.totalVisitorLbl.Click += new System.EventHandler(this.totalVisitorLbl_Click);
            // 
            // earningPanel
            // 
            this.earningPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.earningPanel.Controls.Add(this.pictureBox2);
            this.earningPanel.Controls.Add(this.earningValueLbl);
            this.earningPanel.Controls.Add(this.label4);
            this.earningPanel.Location = new System.Drawing.Point(31, 228);
            this.earningPanel.Name = "earningPanel";
            this.earningPanel.Size = new System.Drawing.Size(258, 145);
            this.earningPanel.TabIndex = 1;
            this.earningPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.earningPanel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nepal_Recreation_Centre.Properties.Resources.money_bag;
            this.pictureBox2.Location = new System.Drawing.Point(160, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // earningValueLbl
            // 
            this.earningValueLbl.AutoSize = true;
            this.earningValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningValueLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(249)))));
            this.earningValueLbl.Location = new System.Drawing.Point(15, 84);
            this.earningValueLbl.Name = "earningValueLbl";
            this.earningValueLbl.Size = new System.Drawing.Size(0, 31);
            this.earningValueLbl.TabIndex = 4;
            this.earningValueLbl.Click += new System.EventHandler(this.earningValueLbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Earnings";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(337, 37);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(393, 333);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "reportChart";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Age Category - Earning Chart";
            this.chart1.Titles.Add(title2);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.earningPanel);
            this.Controls.Add(this.visitorPanel);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(780, 412);
            this.visitorPanel.ResumeLayout(false);
            this.visitorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.earningPanel.ResumeLayout(false);
            this.earningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel visitorPanel;
        private System.Windows.Forms.Panel earningPanel;
        private System.Windows.Forms.Label totalVisitorValueLbl;
        private System.Windows.Forms.Label totalVisitorLbl;
        private System.Windows.Forms.Label earningValueLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
