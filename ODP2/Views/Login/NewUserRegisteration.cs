using ODP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                } else
                {
                    userIDTextBox.Enabled = true;
                    userCodeTextBox.Enabled = true;
                    userNameTextBox.Enabled = true;
                    passwordTextBox.Enabled = true;
                    rePasswordTextBox.Enabled = true;
                    sectionComboBox.Enabled = true;
                    userSectionBindingSource.DataSource = dbContext.USERSECTIONS.ToList();
                    levelComboBox.Enabled = true;
                    userLevelBindingSource.DataSource = dbContext.USERLEVELS.ToList();
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
                    if (userCodeTextBox.Text != "" &&  !int.TryParse(userCodeTextBox.Text,out _))
                    {
                        if (passwordTextBox.Text != "")
                        {
                            if (rePasswordTextBox.Text != "" && passwordTextBox.Text == rePasswordTextBox.Text)
                            {
                                var newUser = new ODP_USER();
                                newUser.USERID = userIDTextBox.Text;
                                newUser.USEREMAIL = userEmailAddress.Text;
                                newUser.USERIDNUMBER = int.Parse(userCodeTextBox.Text);
                                newUser.USERLEVEL1 = (USERLEVEL) levelComboBox.SelectedItem;
                                newUser.USERSECTION1 = (USERSECTION) sectionComboBox.SelectedItem;
                                try
                                {
                                    dbContext.ODP_USERS.Add(newUser);
                                    dbContext.SaveChanges();
                                } 
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error Adding new User" + ex);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords Doen't Match, try typing Password Again");
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
