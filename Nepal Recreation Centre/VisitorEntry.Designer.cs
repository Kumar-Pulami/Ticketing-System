
namespace Nepal_Recreation_Centre
{
    partial class visitorEntryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visitorEntryForm));
            this.visitorNameLbl = new System.Windows.Forms.Label();
            this.contactNumberLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.contactNumberTxt = new System.Windows.Forms.TextBox();
            this.visitorNameTxt = new System.Windows.Forms.TextBox();
            this.entryBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.groupCountComboBox = new System.Windows.Forms.ComboBox();
            this.groupCountLbl = new System.Windows.Forms.Label();
            this.visitorTable = new System.Windows.Forms.DataGridView();
            this.visitorIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageCategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupCountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isGroupLbl = new System.Windows.Forms.Label();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.ageCatComboBox = new System.Windows.Forms.ComboBox();
            this.ageCatLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // visitorNameLbl
            // 
            resources.ApplyResources(this.visitorNameLbl, "visitorNameLbl");
            this.visitorNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.visitorNameLbl.Name = "visitorNameLbl";
            // 
            // contactNumberLbl
            // 
            resources.ApplyResources(this.contactNumberLbl, "contactNumberLbl");
            this.contactNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.contactNumberLbl.Name = "contactNumberLbl";
            // 
            // addressLbl
            // 
            resources.ApplyResources(this.addressLbl, "addressLbl");
            this.addressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.addressLbl.Name = "addressLbl";
            // 
            // addressTxt
            // 
            resources.ApplyResources(this.addressTxt, "addressTxt");
            this.addressTxt.Name = "addressTxt";
            // 
            // contactNumberTxt
            // 
            resources.ApplyResources(this.contactNumberTxt, "contactNumberTxt");
            this.contactNumberTxt.Name = "contactNumberTxt";
            // 
            // visitorNameTxt
            // 
            resources.ApplyResources(this.visitorNameTxt, "visitorNameTxt");
            this.visitorNameTxt.Name = "visitorNameTxt";
            // 
            // entryBtn
            // 
            this.entryBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.entryBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.entryBtn, "entryBtn");
            this.entryBtn.ForeColor = System.Drawing.Color.White;
            this.entryBtn.Name = "entryBtn";
            this.entryBtn.UseVisualStyleBackColor = false;
            this.entryBtn.Click += new System.EventHandler(this.entryBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.clearBtn, "clearBtn");
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Controls.Add(this.importBtn);
            this.panel1.Controls.Add(this.groupCountComboBox);
            this.panel1.Controls.Add(this.groupCountLbl);
            this.panel1.Controls.Add(this.visitorTable);
            this.panel1.Controls.Add(this.entryBtn);
            this.panel1.Controls.Add(this.visitorNameLbl);
            this.panel1.Controls.Add(this.contactNumberLbl);
            this.panel1.Controls.Add(this.addressLbl);
            this.panel1.Controls.Add(this.isGroupLbl);
            this.panel1.Controls.Add(this.groupCheckBox);
            this.panel1.Controls.Add(this.addressTxt);
            this.panel1.Controls.Add(this.ageCatComboBox);
            this.panel1.Controls.Add(this.contactNumberTxt);
            this.panel1.Controls.Add(this.ageCatLbl);
            this.panel1.Controls.Add(this.visitorNameTxt);
            this.panel1.Controls.Add(this.clearBtn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.exportBtn, "exportBtn");
            this.exportBtn.ForeColor = System.Drawing.Color.Black;
            this.exportBtn.Image = global::Nepal_Recreation_Centre.Properties.Resources.Download;
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.importBtn, "importBtn");
            this.importBtn.ForeColor = System.Drawing.Color.Black;
            this.importBtn.Image = global::Nepal_Recreation_Centre.Properties.Resources.Upload;
            this.importBtn.Name = "importBtn";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // groupCountComboBox
            // 
            this.groupCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.groupCountComboBox, "groupCountComboBox");
            this.groupCountComboBox.FormattingEnabled = true;
            this.groupCountComboBox.Name = "groupCountComboBox";
            this.groupCountComboBox.DropDown += new System.EventHandler(this.groupCountComboBox_DropDown);
            // 
            // groupCountLbl
            // 
            resources.ApplyResources(this.groupCountLbl, "groupCountLbl");
            this.groupCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.groupCountLbl.Name = "groupCountLbl";
            // 
            // visitorTable
            // 
            this.visitorTable.AllowUserToAddRows = false;
            this.visitorTable.AllowUserToDeleteRows = false;
            this.visitorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitorIdCol,
            this.visitorNameCol,
            this.contactNumberCol,
            this.addressCol,
            this.entryTimeCol,
            this.ageCategoryCol,
            this.groupCountCol});
            resources.ApplyResources(this.visitorTable, "visitorTable");
            this.visitorTable.Name = "visitorTable";
            this.visitorTable.ReadOnly = true;
            // 
            // visitorIdCol
            // 
            resources.ApplyResources(this.visitorIdCol, "visitorIdCol");
            this.visitorIdCol.Name = "visitorIdCol";
            this.visitorIdCol.ReadOnly = true;
            // 
            // visitorNameCol
            // 
            resources.ApplyResources(this.visitorNameCol, "visitorNameCol");
            this.visitorNameCol.Name = "visitorNameCol";
            this.visitorNameCol.ReadOnly = true;
            // 
            // contactNumberCol
            // 
            resources.ApplyResources(this.contactNumberCol, "contactNumberCol");
            this.contactNumberCol.Name = "contactNumberCol";
            this.contactNumberCol.ReadOnly = true;
            // 
            // addressCol
            // 
            resources.ApplyResources(this.addressCol, "addressCol");
            this.addressCol.Name = "addressCol";
            this.addressCol.ReadOnly = true;
            // 
            // entryTimeCol
            // 
            resources.ApplyResources(this.entryTimeCol, "entryTimeCol");
            this.entryTimeCol.Name = "entryTimeCol";
            this.entryTimeCol.ReadOnly = true;
            // 
            // ageCategoryCol
            // 
            resources.ApplyResources(this.ageCategoryCol, "ageCategoryCol");
            this.ageCategoryCol.Name = "ageCategoryCol";
            this.ageCategoryCol.ReadOnly = true;
            // 
            // groupCountCol
            // 
            resources.ApplyResources(this.groupCountCol, "groupCountCol");
            this.groupCountCol.Name = "groupCountCol";
            this.groupCountCol.ReadOnly = true;
            // 
            // isGroupLbl
            // 
            resources.ApplyResources(this.isGroupLbl, "isGroupLbl");
            this.isGroupLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.isGroupLbl.Name = "isGroupLbl";
            // 
            // groupCheckBox
            // 
            resources.ApplyResources(this.groupCheckBox, "groupCheckBox");
            this.groupCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.UseVisualStyleBackColor = true;
            this.groupCheckBox.CheckedChanged += new System.EventHandler(this.groupCheckBox_CheckedChanged);
            // 
            // ageCatComboBox
            // 
            this.ageCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageCatComboBox.FormattingEnabled = true;
            this.ageCatComboBox.Items.AddRange(new object[] {
            resources.GetString("ageCatComboBox.Items"),
            resources.GetString("ageCatComboBox.Items1")});
            resources.ApplyResources(this.ageCatComboBox, "ageCatComboBox");
            this.ageCatComboBox.Name = "ageCatComboBox";
            // 
            // ageCatLbl
            // 
            resources.ApplyResources(this.ageCatLbl, "ageCatLbl");
            this.ageCatLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.ageCatLbl.Name = "ageCatLbl";
            // 
            // visitorEntryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "visitorEntryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label visitorNameLbl;
        private System.Windows.Forms.Label contactNumberLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox contactNumberTxt;
        private System.Windows.Forms.TextBox visitorNameTxt;
        private System.Windows.Forms.Button entryBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label isGroupLbl;
        private System.Windows.Forms.CheckBox groupCheckBox;
        private System.Windows.Forms.ComboBox ageCatComboBox;
        private System.Windows.Forms.Label ageCatLbl;
        private System.Windows.Forms.DataGridView visitorTable;
        private System.Windows.Forms.ComboBox groupCountComboBox;
        private System.Windows.Forms.Label groupCountLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageCategoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupCountCol;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
    }
}