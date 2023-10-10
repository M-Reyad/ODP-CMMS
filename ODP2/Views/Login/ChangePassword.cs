using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Entity;
using ODP2.Models;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace ODP2.Views
{
    public partial class ChangePassword : Form
    {
        public ODPEntities_ORACLE dbContext = new ODPEntities_ORACLE();
        public string userID = "";
        public ChangePassword()
        {
            InitializeComponent();
            
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            if (userID != "")
            {
                userIDTextbox.Text = userID;
                userIDTextbox.Enabled = false;
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            userIDTextbox.ReadOnly = true;
            if (dbContext.ODP_USER.Where(user => user.USERID.Trim() == userIDTextbox.Text).Count() != 1)
            {
                MessageBox.Show("No Such Recorded User Name, Re-enter your ID");
                userIDTextbox.ReadOnly = false;
                userIDTextbox.Focus();
            }
            else 
            {
                enterEmailLabel.Visible = true;
                emailTextbox.Visible = true;
                emailTextbox.Focus();
                confirmEmailButton.Visible = true;
                
            }

        }

        private void confirmEmailButton_Click(object sender, EventArgs e)
        {

            if (dbContext.ODP_USER.Where(user => user.USERID.Trim() == userIDTextbox.Text).First().USEREMAIL.Trim() == emailTextbox.Text)

            {
                newPasswordLabel.Visible = true;
                newpasswordTextbox.Visible = true;
                newpasswordTextbox.Focus();
                reenterPasswordLabel.Visible = true;
                rePasswordTextbox.Visible = true;
                confirmNewPasswordButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong Email Address, Please Enter your recorded email Address");
            }

        }

        private void confirmNewPasswordButton_Click(object sender, EventArgs e)
        {
            if (newpasswordTextbox.Text == rePasswordTextbox.Text)
            {
                try
                {
                    dbContext.ODP_USER.Where(user => user.USERID.Trim() == userIDTextbox.Text).First().USERPASSWORD = newpasswordTextbox.Text;
                    dbContext.SaveChanges();

                    MessageBox.Show("Password Updated Successfully", "Successful Password Change");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Enter Identical Passwords!","Un-Identical Passwords");
            }
        }
    }
}
