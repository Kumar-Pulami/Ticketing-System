
namespace Nepal_Recreation_Centre
{
    partial class IndividualPriceEntry
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
            this.hourTxt = new System.Windows.Forms.TextBox();
            this.hourLbl = new System.Windows.Forms.Label();
            this.deleteIndividualPriceBtn = new System.Windows.Forms.Button();
            this.updateindividualPriceBtn = new System.Windows.Forms.Button();
            this.individualPriceTable = new System.Windows.Forms.DataGridView();
            this.pricePerVisitorAgeCatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regularPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekendPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageCatComboBox = new System.Windows.Forms.ComboBox();
            this.ageCatLbl = new System.Windows.Forms.Label();
            this.IndividualPriceClearBtn = new System.Windows.Forms.Button();
            this.regularPriceTxt = new System.Windows.Forms.TextBox();
            this.weekendPriceTxt = new System.Windows.Forms.TextBox();
            this.addIndividualPriceBtn = new System.Windows.Forms.Button();
            this.weekendLbl = new System.Windows.Forms.Label();
            this.regularLbl = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.individualPriceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // hourTxt
            // 
            this.hourTxt.Location = new System.Drawing.Point(150, 157);
            this.hourTxt.Name = "hourTxt";
            this.hourTxt.Size = new System.Drawing.Size(103, 20);
            this.hourTxt.TabIndex = 45;
            // 
            // hourLbl
            // 
            this.hourLbl.AutoSize = true;
            this.hourLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.hourLbl.Location = new System.Drawing.Point(45, 160);
            this.hourLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hourLbl.Name = "hourLbl";
            this.hourLbl.Size = new System.Drawing.Size(34, 15);
            this.hourLbl.TabIndex = 44;
            this.hourLbl.Text = "Hour";
            // 
            // deleteIndividualPriceBtn
            // 
            this.deleteIndividualPriceBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteIndividualPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIndividualPriceBtn.ForeColor = System.Drawing.Color.White;
            this.deleteIndividualPriceBtn.Location = new System.Drawing.Point(527, 324);
            this.deleteIndividualPriceBtn.Name = "deleteIndividualPriceBtn";
            this.deleteIndividualPriceBtn.Size = new System.Drawing.Size(60, 30);
            this.deleteIndividualPriceBtn.TabIndex = 40;
            this.deleteIndividualPriceBtn.Text = "Delete";
            this.deleteIndividualPriceBtn.UseVisualStyleBackColor = false;
            this.deleteIndividualPriceBtn.Visible = false;
            this.deleteIndividualPriceBtn.Click += new System.EventHandler(this.deleteIndividualPriceBtn_Click);
            // 
            // updateindividualPriceBtn
            // 
            this.updateindividualPriceBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateindividualPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateindividualPriceBtn.ForeColor = System.Drawing.Color.White;
            this.updateindividualPriceBtn.Location = new System.Drawing.Point(413, 324);
            this.updateindividualPriceBtn.Name = "updateindividualPriceBtn";
            this.updateindividualPriceBtn.Size = new System.Drawing.Size(60, 30);
            this.updateindividualPriceBtn.TabIndex = 39;
            this.updateindividualPriceBtn.Text = "Update";
            this.updateindividualPriceBtn.UseVisualStyleBackColor = false;
            this.updateindividualPriceBtn.Visible = false;
            this.updateindividualPriceBtn.Click += new System.EventHandler(this.updateindividualPriceBtn_Click);
            // 
            // individualPriceTable
            // 
            this.individualPriceTable.AllowUserToAddRows = false;
            this.individualPriceTable.AllowUserToDeleteRows = false;
            this.individualPriceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individualPriceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pricePerVisitorAgeCatCol,
            this.hourCol,
            this.regularPriceCol,
            this.weekendPriceCol});
            this.individualPriceTable.Location = new System.Drawing.Point(302, 113);
            this.individualPriceTable.Name = "individualPriceTable";
            this.individualPriceTable.ReadOnly = true;
            this.individualPriceTable.Size = new System.Drawing.Size(444, 172);
            this.individualPriceTable.TabIndex = 43;
            this.individualPriceTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.individualPriceTable_CellClick);
            // 
            // pricePerVisitorAgeCatCol
            // 
            this.pricePerVisitorAgeCatCol.HeaderText = "Age Category";
            this.pricePerVisitorAgeCatCol.Name = "pricePerVisitorAgeCatCol";
            this.pricePerVisitorAgeCatCol.ReadOnly = true;
            // 
            // hourCol
            // 
            this.hourCol.HeaderText = "Hour";
            this.hourCol.Name = "hourCol";
            this.hourCol.ReadOnly = true;
            this.hourCol.Width = 90;
            // 
            // regularPriceCol
            // 
            this.regularPriceCol.HeaderText = "Regular Price";
            this.regularPriceCol.Name = "regularPriceCol";
            this.regularPriceCol.ReadOnly = true;
            // 
            // weekendPriceCol
            // 
            this.weekendPriceCol.HeaderText = "Weekend Price";
            this.weekendPriceCol.Name = "weekendPriceCol";
            this.weekendPriceCol.ReadOnly = true;
            this.weekendPriceCol.Width = 110;
            // 
            // ageCatComboBox
            // 
            this.ageCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageCatComboBox.FormattingEnabled = true;
            this.ageCatComboBox.Items.AddRange(new object[] {
            "Child",
            "Adult"});
            this.ageCatComboBox.Location = new System.Drawing.Point(150, 113);
            this.ageCatComboBox.Name = "ageCatComboBox";
            this.ageCatComboBox.Size = new System.Drawing.Size(103, 21);
            this.ageCatComboBox.TabIndex = 42;
            // 
            // ageCatLbl
            // 
            this.ageCatLbl.AutoSize = true;
            this.ageCatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageCatLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.ageCatLbl.Location = new System.Drawing.Point(45, 116);
            this.ageCatLbl.Name = "ageCatLbl";
            this.ageCatLbl.Size = new System.Drawing.Size(79, 15);
            this.ageCatLbl.TabIndex = 41;
            this.ageCatLbl.Text = "Age Category";
            // 
            // IndividualPriceClearBtn
            // 
            this.IndividualPriceClearBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.IndividualPriceClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndividualPriceClearBtn.ForeColor = System.Drawing.Color.White;
            this.IndividualPriceClearBtn.Location = new System.Drawing.Point(64, 300);
            this.IndividualPriceClearBtn.Name = "IndividualPriceClearBtn";
            this.IndividualPriceClearBtn.Size = new System.Drawing.Size(60, 30);
            this.IndividualPriceClearBtn.TabIndex = 38;
            this.IndividualPriceClearBtn.Text = "Clear";
            this.IndividualPriceClearBtn.UseVisualStyleBackColor = false;
            this.IndividualPriceClearBtn.Click += new System.EventHandler(this.IndividualPriceClearBtn_Click);
            // 
            // regularPriceTxt
            // 
            this.regularPriceTxt.Location = new System.Drawing.Point(150, 200);
            this.regularPriceTxt.Name = "regularPriceTxt";
            this.regularPriceTxt.Size = new System.Drawing.Size(103, 20);
            this.regularPriceTxt.TabIndex = 33;
            // 
            // weekendPriceTxt
            // 
            this.weekendPriceTxt.Location = new System.Drawing.Point(150, 243);
            this.weekendPriceTxt.Name = "weekendPriceTxt";
            this.weekendPriceTxt.Size = new System.Drawing.Size(103, 20);
            this.weekendPriceTxt.TabIndex = 34;
            // 
            // addIndividualPriceBtn
            // 
            this.addIndividualPriceBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addIndividualPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIndividualPriceBtn.ForeColor = System.Drawing.Color.White;
            this.addIndividualPriceBtn.Location = new System.Drawing.Point(172, 300);
            this.addIndividualPriceBtn.Name = "addIndividualPriceBtn";
            this.addIndividualPriceBtn.Size = new System.Drawing.Size(60, 30);
            this.addIndividualPriceBtn.TabIndex = 37;
            this.addIndividualPriceBtn.Text = "Add";
            this.addIndividualPriceBtn.UseVisualStyleBackColor = false;
            this.addIndividualPriceBtn.Click += new System.EventHandler(this.addIndividualPriceBtn_Click);
            // 
            // weekendLbl
            // 
            this.weekendLbl.AutoSize = true;
            this.weekendLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekendLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.weekendLbl.Location = new System.Drawing.Point(45, 246);
            this.weekendLbl.Name = "weekendLbl";
            this.weekendLbl.Size = new System.Drawing.Size(59, 15);
            this.weekendLbl.TabIndex = 36;
            this.weekendLbl.Text = "Weekend";
            // 
            // regularLbl
            // 
            this.regularLbl.AutoSize = true;
            this.regularLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.regularLbl.Location = new System.Drawing.Point(45, 203);
            this.regularLbl.Name = "regularLbl";
            this.regularLbl.Size = new System.Drawing.Size(51, 15);
            this.regularLbl.TabIndex = 35;
            this.regularLbl.Text = "Regular";
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exportBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.Black;
            this.exportBtn.Image = global::Nepal_Recreation_Centre.Properties.Resources.Download;
            this.exportBtn.Location = new System.Drawing.Point(671, 51);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 30);
            this.exportBtn.TabIndex = 47;
            this.exportBtn.Text = "Export";
            this.exportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.importBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.ForeColor = System.Drawing.Color.Black;
            this.importBtn.Image = global::Nepal_Recreation_Centre.Properties.Resources.Upload;
            this.importBtn.Location = new System.Drawing.Point(571, 51);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 30);
            this.importBtn.TabIndex = 46;
            this.importBtn.Text = "Import";
            this.importBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // IndividualPriceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.hourTxt);
            this.Controls.Add(this.hourLbl);
            this.Controls.Add(this.deleteIndividualPriceBtn);
            this.Controls.Add(this.updateindividualPriceBtn);
            this.Controls.Add(this.individualPriceTable);
            this.Controls.Add(this.ageCatComboBox);
            this.Controls.Add(this.ageCatLbl);
            this.Controls.Add(this.IndividualPriceClearBtn);
            this.Controls.Add(this.regularPriceTxt);
            this.Controls.Add(this.weekendPriceTxt);
            this.Controls.Add(this.addIndividualPriceBtn);
            this.Controls.Add(this.weekendLbl);
            this.Controls.Add(this.regularLbl);
            this.Name = "IndividualPriceEntry";
            this.Size = new System.Drawing.Size(784, 416);
            this.Load += new System.EventHandler(this.IndividualPriceEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.individualPriceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hourTxt;
        private System.Windows.Forms.Label hourLbl;
        private System.Windows.Forms.Button deleteIndividualPriceBtn;
        private System.Windows.Forms.Button updateindividualPriceBtn;
        private System.Windows.Forms.DataGridView individualPriceTable;
        private System.Windows.Forms.ComboBox ageCatComboBox;
        private System.Windows.Forms.Label ageCatLbl;
        private System.Windows.Forms.Button IndividualPriceClearBtn;
        private System.Windows.Forms.TextBox regularPriceTxt;
        private System.Windows.Forms.TextBox weekendPriceTxt;
        private System.Windows.Forms.Button addIndividualPriceBtn;
        private System.Windows.Forms.Label weekendLbl;
        private System.Windows.Forms.Label regularLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerVisitorAgeCatCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn regularPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekendPriceCol;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
    }
}
