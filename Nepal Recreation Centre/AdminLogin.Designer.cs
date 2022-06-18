
namespace Nepal_Recreation_Centre
{
    partial class AdminLogin
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
            this.adminLoginPanel = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.adminLoginLbl = new System.Windows.Forms.Label();
            this.NRCLbl = new System.Windows.Forms.Label();
            this.adminLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminLoginPanel
            // 
            this.adminLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.adminLoginPanel.Controls.Add(this.passwordTxt);
            this.adminLoginPanel.Controls.Add(this.userNameTxt);
            this.adminLoginPanel.Controls.Add(this.loginBtn);
            this.adminLoginPanel.Controls.Add(this.clearBtn);
            this.adminLoginPanel.Controls.Add(this.passwordLbl);
            this.adminLoginPanel.Controls.Add(this.userNameLbl);
            this.adminLoginPanel.Controls.Add(this.adminLoginLbl);
            this.adminLoginPanel.Controls.Add(this.NRCLbl);
            this.adminLoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.adminLoginPanel.Name = "adminLoginPanel";
            this.adminLoginPanel.Size = new System.Drawing.Size(780, 412);
            this.adminLoginPanel.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(351, 225);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(155, 20);
            this.passwordTxt.TabIndex = 15;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(351, 183);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(155, 20);
            this.userNameTxt.TabIndex = 14;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(398, 291);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(60, 30);
            this.loginBtn.TabIndex = 13;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(295, 291);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(60, 30);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.passwordLbl.Location = new System.Drawing.Point(256, 228);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(64, 17);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Password";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.userNameLbl.Location = new System.Drawing.Point(256, 183);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(67, 17);
            this.userNameLbl.TabIndex = 10;
            this.userNameLbl.Text = "Username";
            this.userNameLbl.Click += new System.EventHandler(this.userNameLbl_Click);
            // 
            // adminLoginLbl
            // 
            this.adminLoginLbl.AutoSize = true;
            this.adminLoginLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginLbl.ForeColor = System.Drawing.Color.Red;
            this.adminLoginLbl.Location = new System.Drawing.Point(333, 128);
            this.adminLoginLbl.Name = "adminLoginLbl";
            this.adminLoginLbl.Size = new System.Drawing.Size(107, 21);
            this.adminLoginLbl.TabIndex = 9;
            this.adminLoginLbl.Text = "Admin Login";
            // 
            // NRCLbl
            // 
            this.NRCLbl.AutoSize = true;
            this.NRCLbl.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NRCLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NRCLbl.Location = new System.Drawing.Point(233, 62);
            this.NRCLbl.Name = "NRCLbl";
            this.NRCLbl.Size = new System.Drawing.Size(313, 43);
            this.NRCLbl.TabIndex = 8;
            this.NRCLbl.Text = "Nepal Recreation Centre";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminLoginPanel);
            this.Name = "AdminLogin";
            this.Size = new System.Drawing.Size(780, 412);
            this.adminLoginPanel.ResumeLayout(false);
            this.adminLoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminLoginPanel;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label adminLoginLbl;
        private System.Windows.Forms.Label NRCLbl;
    }
}
