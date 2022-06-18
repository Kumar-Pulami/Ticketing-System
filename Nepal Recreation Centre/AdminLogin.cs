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
    public partial class AdminLogin : UserControl
    {
        public AdminLogin(Main instance)
        {
            InitializeComponent();
            currentObject = instance;
        }
        public Main currentObject;

        public Boolean adminValid = false;

        private void loginBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                String userName = userNameTxt.Text;
                String password = passwordTxt.Text;
                if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please Enter Username/ Password.");
                }
                else
                {
                    adminValid = validateLoginCredentials("Admin", userName, password);
                    if (adminValid)
                    {
                        userNameTxt.Text = null;
                        passwordTxt.Text = null;
                        this.Dispose();
                        currentObject.ShowOptionLblTxt();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password.");
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public Boolean validateLoginCredentials(String checkFOr, String userName, String password)
        {
            Boolean valid = false;
            //if (checkFOr.Equals("Any"))
            //{
            //    foreach (String loginDetails in loginCredentials)
            //    {
            //        if (userName.Equals(loginDetails[1]) && password.Equals(loginDetails[2]))
            //        {
            //            valid = true;
            //            break;
            //        }
            //        else
            //        {
            //            valid = false;
            //        }
            //    }
            //}
            //else
           
            for ( int i =0; i <= Storage.loginCredentials.GetLength(0) - 1; i++)
            {                
                if (checkFOr.Equals(Storage.loginCredentials[i, 0]) && userName.Equals(Storage.loginCredentials[i,1]) && password.Equals(Storage.loginCredentials[i, 2]))
                {
                    valid = true;
                    break;
                }
                else
                {
                    valid = false;
                }           
            }            
            return valid;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            userNameTxt.Text = null;
            passwordTxt.Text = null;
        }

        private void userNameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
