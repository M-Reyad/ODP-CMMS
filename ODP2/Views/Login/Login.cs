using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ODP2.Views;
using System.Drawing;
using ODP2.Models;
using System.Linq;
using ODP2.Views.Login;
using System.Data.Entity;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Threading.Tasks;
using LoadingIndicator.WinForms;
//using Microsoft.Data.SqlClient;

namespace ODP2
{
    public partial class Login : Form
    {

        public ODPEntities_ORACLE dbContext = new ODPEntities_ORACLE();

        public Login()
        {
            
            InitializeComponent();
    }


       private void loginFormLoad(object sender, EventArgs e)
        {
            
            rememberMe.Checked = Properties.Settings.Default.rememberMe;
            userNameTextBox.Text = Properties.Settings.Default.userName;
            passwordTextBox.Text = Properties.Settings.Default.password;
            
            tryConnect();

        }

        private void loginButtonPressed(object sender, EventArgs e)
        {
            loginButtonPressed(sender, e, dbContext);
        }
        private async void loginButtonPressed(object sender, EventArgs e, ODPEntities_ORACLE dbContext)
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
                var loginValidationTable = new List<ODP_USER>();
                try
                {

                    loginValidationTable = await dbContext.ODP_USER.Where(user => user.USERID.Trim().ToUpper() == userNameTextBox.Text.ToUpper()).ToListAsync();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
        private void refreshButton_Click(object sender, EventArgs e)
        {
            tryConnect();
        }
        private async  void tryConnect()
        {
            
            try
            {
                this.Cursor = Cursors.WaitCursor;
                loginButton.Enabled = false;
                changePasswordButton.Enabled = false;
                newAccountButton.Enabled = false;
                connectionLabel.Text = "Connecting to Database...";
                connectionColorLabel.BackColor = Color.Red;   
                await Task.Run(()=> dbContext.ODP_USER.ToList());
                connectionLabel.Text = "Database Connected Successfully";
                connectionColorLabel.BackColor = Color.Green;
                this.Cursor = Cursors.Default;
                loginButton.Enabled = true;
                changePasswordButton.Enabled = true;
                newAccountButton.Enabled = true;
            }
            catch (Exception err)
            {
                connectionLabel.Text = "Cannot Connect to Database!";
                MessageBox.Show("" + err.Message, "DB Connection Error");
                this.Cursor = Cursors.Default;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Application.Exit();
        }
    }
}