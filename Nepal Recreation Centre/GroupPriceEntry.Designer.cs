
namespace Nepal_Recreation_Centre
{
    partial class GroupPriceEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteGroupPriceBtn = new System.Windows.Forms.Button();
            this.updateGroupPriceBtn = new System.Windows.Forms.Button();
            this.groupPriceTable = new System.Windows.Forms.DataGridView();
            this.groupCountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPriceClearBtn = new System.Windows.Forms.Button();
            this.groupCountLbl = new System.Windows.Forms.Label();
            this.groupCountTxt = new System.Windows.Forms.TextBox();
            this.addGroupPriceBtn = new System.Windows.Forms.Button();
            this.discountMemberTxt = new System.Windows.Forms.TextBox();
            this.discountVisitorLbl = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupPriceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteGroupPriceBtn
            // 
            this.deleteGroupPriceBtn.BackColor = System.Drawing.Color.Firebrick;
            this.deleteGroupPriceBtn.FlatAppearance.BorderSize = 0;
            this.deleteGroupPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGroupPriceBtn.ForeColor = System.Drawing.Color.White;
            this.deleteGroupPriceBtn.Location = new System.Drawing.Point(588, 338);
            this.deleteGroupPriceBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteGroupPriceBtn.Name = "deleteGroupPriceBtn";
            this.deleteGroupPriceBtn.Size = new System.Drawing.Size(60, 30);
            this.deleteGroupPriceBtn.TabIndex = 33;
            this.deleteGroupPriceBtn.Text = "Delete";
            this.deleteGroupPriceBtn.UseVisualStyleBackColor = false;
            this.deleteGroupPriceBtn.Visible = false;
            this.deleteGroupPriceBtn.Click += new System.EventHandler(this.deleteGroupPriceBtn_Click);
            // 
            // updateGroupPriceBtn
            // 
            this.updateGroupPriceBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateGroupPriceBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.updateGroupPriceBtn.FlatAppearance.BorderSize = 0;
            this.updateGroupPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGroupPriceBtn.ForeColor = System.Drawing.Color.White;
            this.updateGroupPriceBtn.Location = new System.Drawing.Point(496, 338);
            this.updateGroupPriceBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updateGroupPriceBtn.Name = "updateGroupPriceBtn";
            this.updateGroupPriceBtn.Size = new System.Drawing.Size(60, 30);
            this.updateGroupPriceBtn.TabIndex = 32;
            this.updateGroupPriceBtn.Text = "Update";
            this.updateGroupPriceBtn.UseVisualStyleBackColor = false;
            this.updateGroupPriceBtn.Visible = false;
            this.updateGroupPriceBtn.Click += new System.EventHandler(this.updateGroupPriceBtn_Click);
            // 
            // groupPriceTable
            // 
            this.groupPriceTable.AllowUserToAddRows = false;
            this.groupPriceTable.AllowUserToDeleteRows = false;
            this.groupPriceTable.AllowUserToResizeColumns = false;
            this.groupPriceTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groupPriceTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.groupPriceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupPriceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupCountCol,
            this.discountPerCol});
            this.groupPriceTable.GridColor = System.Drawing.SystemColors.Control;
            this.groupPriceTable.Location = new System.Drawing.Point(437, 107);
            this.groupPriceTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupPriceTable.Name = "groupPriceTable";
            this.groupPriceTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupPriceTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.groupPriceTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.groupPriceTable.RowTemplate.Height = 25;
            this.groupPriceTable.RowTemplate.ReadOnly = true;
            this.groupPriceTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.groupPriceTable.Size = new System.Drawing.Size(264, 206);
            this.groupPriceTable.TabIndex = 31;
            this.groupPriceTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupPriceTable_CellClick);
            // 
            // groupCountCol
            // 
            this.groupCountCol.HeaderText = "Group Count";
            this.groupCountCol.Name = "groupCountCol";
            this.groupCountCol.ReadOnly = true;
            this.groupCountCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // discountPerCol
            // 
            this.discountPerCol.HeaderText = "Discount Percentage";
            this.discountPerCol.Name = "discountPerCol";
            this.discountPerCol.ReadOnly = true;
            this.discountPerCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.discountPerCol.Width = 120;
            // 
            // groupPriceClearBtn
            // 
            this.groupPriceClearBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.groupPriceClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPriceClearBtn.ForeColor = System.Drawing.Color.White;
            this.groupPriceClearBtn.Location = new System.Drawing.Point(145, 210);
            this.groupPriceClearBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupPriceClearBtn.Name = "groupPriceClearBtn";
            this.groupPriceClearBtn.Size = new System.Drawing.Size(60, 30);
            this.groupPriceClearBtn.TabIndex = 30;
            this.groupPriceClearBtn.Text = "Clear";
            this.groupPriceClearBtn.UseVisualStyleBackColor = false;
            this.groupPriceClearBtn.Click += new System.EventHandler(this.groupPriceClearBtn_Click);
            // 
            // groupCountLbl
            // 
            this.groupCountLbl.AutoSize = true;
            this.groupCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.groupCountLbl.Location = new System.Drawing.Point(71, 107);
            this.groupCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.groupCountLbl.Name = "groupCountLbl";
            this.groupCountLbl.Size = new System.Drawing.Size(76, 15);
            this.groupCountLbl.TabIndex = 29;
            this.groupCountLbl.Text = "Group Count";
            // 
            // groupCountTxt
            // 
            this.groupCountTxt.Location = new System.Drawing.Point(231, 107);
            this.groupCountTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupCountTxt.Name = "groupCountTxt";
            this.groupCountTxt.Size = new System.Drawing.Size(108, 20);
            this.groupCountTxt.TabIndex = 25;
            // 
            // addGroupPriceBtn
            // 
            this.addGroupPriceBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addGroupPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupPriceBtn.ForeColor = System.Drawing.Color.White;
            this.addGroupPriceBtn.Location = new System.Drawing.Point(247, 210);
            this.addGroupPriceBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addGroupPriceBtn.Name = "addGroupPriceBtn";
            this.addGroupPriceBtn.Size = new System.Drawing.Size(60, 30);
            this.addGroupPriceBtn.TabIndex = 26;
            this.addGroupPriceBtn.Text = "Add";
            this.addGroupPriceBtn.UseVisualStyleBackColor = false;
            this.addGroupPriceBtn.Click += new System.EventHandler(this.addGroupPriceBtn_Click);
            // 
            // discountMemberTxt
            // 
            this.discountMemberTxt.Location = new System.Drawing.Point(231, 161);
            this.discountMemberTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.discountMemberTxt.Name = "discountMemberTxt";
            this.discountMemberTxt.Size = new System.Drawing.Size(108, 20);
            this.discountMemberTxt.TabIndex = 27;
            // 
            // discountVisitorLbl
            // 
            this.discountVisitorLbl.AutoSize = true;
            this.discountVisitorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountVisitorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.discountVisitorLbl.Location = new System.Drawing.Point(71, 161);
            this.discountVisitorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountVisitorLbl.Name = "discountVisitorLbl";
            this.discountVisitorLbl.Size = new System.Drawing.Size(124, 15);
            this.discountVisitorLbl.TabIndex = 28;
            this.discountVisitorLbl.Text = "Discount  Percentage";
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exportBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.Black;
            this.exportBtn.Image = global::Nepal_Recreation_Centre.Properties.Resources.Download;
            this.exportBtn.Location = new System.Drawing.Point(628, 44);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 30);
            this.exportBtn.TabIndex = 35;
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
            this.importBtn.Location = new System.Drawing.Point(528, 44);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 30);
            this.importBtn.TabIndex = 34;
            this.importBtn.Text = "Import";
            this.importBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // GroupPriceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.deleteGroupPriceBtn);
            this.Controls.Add(this.updateGroupPriceBtn);
            this.Controls.Add(this.groupPriceTable);
            this.Controls.Add(this.groupPriceClearBtn);
            this.Controls.Add(this.groupCountLbl);
            this.Controls.Add(this.groupCountTxt);
            this.Controls.Add(this.addGroupPriceBtn);
            this.Controls.Add(this.discountMemberTxt);
            this.Controls.Add(this.discountVisitorLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GroupPriceEntry";
            this.Size = new System.Drawing.Size(780, 412);
            ((System.ComponentModel.ISupportInitialize)(this.groupPriceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteGroupPriceBtn;
        private System.Windows.Forms.Button updateGroupPriceBtn;
        private System.Windows.Forms.DataGridView groupPriceTable;
        private System.Windows.Forms.Button groupPriceClearBtn;
        private System.Windows.Forms.Label groupCountLbl;
        private System.Windows.Forms.TextBox groupCountTxt;
        private System.Windows.Forms.Button addGroupPriceBtn;
        private System.Windows.Forms.TextBox discountMemberTxt;
        private System.Windows.Forms.Label discountVisitorLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPerCol;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button exportBtn;
    }
}
