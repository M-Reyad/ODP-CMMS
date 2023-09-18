using ODP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP2.Views.Login
{
    public partial class NewUserRegisteration : Form
    {
        public ODPEntities_ORACLE dbContext = new ODPEntities_ORACLE();
        public NewUserRegisteration()
        {
            InitializeComponent();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (userEmailAddress.Text != "")
            {
                if (!userEmailAddress.Text.Contains("@odpeg.com"))
                {
                    MessageBox.Show("Only ODP E-mails can register for new accounts");
                    userEmailAddress.Focus();
                } 
                else if (dbContext.ODP_USER.Where(user => user.USEREMAIL.Trim() == userEmailAddress.Text).Count() != 0)
                {
                    MessageBox.Show("This user is registered before, try using another Email");
                    userEmailAddress.Focus();
                } 
                else
                {
                    proceedButton.Enabled = false;
                    userEmailAddress.ReadOnly = true;
                    userIDTextBox.Enabled = true;
                    userCodeTextBox.Enabled = true;
                    userNameTextBox.Enabled = true;
                    passwordTextBox.Enabled = true;
                    rePasswordTextBox.Enabled = true;
                    sectionComboBox.Enabled = true;
                    titleComboBox.Enabled = true;
                    userSectionBindingSource.DataSource = dbContext.USERSECTIONs.ToList();
                    levelComboBox.Enabled = true;
                    userLevelBindingSource.DataSource = dbContext.USERLEVELs.ToList();
                    confirmButton.Enabled = true;
                }
            } 
            else
            {
                MessageBox.Show("Please Enter a valid E-mail Address");
                userEmailAddress.Focus();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (userIDTextBox.Text != "")
            {
                if (userNameTextBox.Text != "")
                {
                    if (userCodeTextBox.Text != "" &&  int.TryParse(userCodeTextBox.Text,out _))
                    {
                        if (passwordTextBox.Text != "")
                        {
                            if (rePasswordTextBox.Text != "" && passwordTextBox.Text == rePasswordTextBox.Text)
                            {
                                var newUser = new ODP_USER();
                                newUser.USERID = userIDTextBox.Text;
                                newUser.USEREMAIL = userEmailAddress.Text;
                                newUser.USERIDNUMBER = int.Parse(userCodeTextBox.Text);
                                newUser.USERLEVEL = levelComboBox.GetItemText(levelComboBox.SelectedItem).Trim();
                                newUser.USERSECTION = sectionComboBox.GetItemText(sectionComboBox.SelectedItem).Trim();
                                newUser.USERTITLE = titleComboBox.GetItemText(titleComboBox.SelectedItem).Trim();
                                newUser.USERNAME = userNameTextBox.Text;
                                newUser.USERPASSWORD = passwordTextBox.Text;
                                try
                                {
                                    dbContext.ODP_USER.Add(newUser);
                                    dbContext.SaveChanges();
                                    MessageBox.Show("Saved Successfully");
                                    this.Close();
                                }
                                catch (Exception ex)
                                {
                                    
                                    MessageBox.Show("Error Adding new User" + ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords don't match, try typing Password Again");
                                rePasswordTextBox.Focus();
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a valid Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a valid User Code");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a valid User Name");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid User ID");
            }
        }
    }
}
