using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ODP2.Views;
using System.Drawing;
using ODP2.Models;
using System.Linq;
using ODP2.Views.Login;
//using Microsoft.Data.SqlClient;

namespace ODP2
{
    public partial class Login : Form
    {

        public ODPEntities_ORACLE dbContext = new ODPEntities_ORACLE();
        public Login()
        {
            InitializeComponent();
            
            try
            {
                dbContext.ODP_USERS.ToList();
                connectionLabel.Text = "Database Connected Successfully";
                connectionColorLabel.BackColor = Color.Green;
            }
            catch (Exception err)
            {
                connectionLabel.Text = "Cannot Connect to Database!";
                MessageBox.Show(""+err, "DB Connection Error");
                
            }

        }

        private void loginFormLoad(object sender, EventArgs e)
        {
            rememberMe.Checked = Properties.Settings.Default.rememberMe;
            userNameTextBox.Text = Properties.Settings.Default.userName;
            passwordTextBox.Text = Properties.Settings.Default.password;
            
        }

        private void loginButtonPressed(object sender, EventArgs e)
        {
            //Check if the userID exists

            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Valid User ID", "Missing Data");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Your Password", "Missing Data");
            }
            else
            {
                var loginValidationTable = dbContext.ODP_USERS.Where(user => user.USERID.Trim() == userNameTextBox.Text);
                if (loginValidationTable.Count() != 1)
                {
                    MessageBox.Show("Wrong User ID or Password", "Error Login");
                }
                else
                {
                    //Check if Password is Correct
                    var user = loginValidationTable.First();
                    if (user.USERPASSWORD.Trim() == passwordTextBox.Text)
                    {
                        var homeForm = new Home();
                        homeForm.user = user;
                        homeForm.dbContext = dbContext;
                        //Remember Me Feature
                        if (rememberMe.Checked == true)
                        {
                            Properties.Settings.Default.userName = userNameTextBox.Text;
                            Properties.Settings.Default.password = passwordTextBox.Text;
                            Properties.Settings.Default.rememberMe = true;
                        }
                        else
                        {
                            Properties.Settings.Default.userName = "";
                            Properties.Settings.Default.password = "";
                            Properties.Settings.Default.rememberMe = false;
                        }
                        homeForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName or Password! Enter a Valid User ID and Password.", "Failed Login");
                    }
                }
            }
        }


        private void changePasswordButtonPressed(object sender, EventArgs e)
        {
            var changePasswordForm = new ChangePassword();
            changePasswordForm.dbContext = dbContext;
            changePasswordForm.Show();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            var newUser = new NewUserRegisteration();
            newUser.dbContext = dbContext;
            newUser.Show();
        }
    }


}