using System.Windows.Forms;

namespace ODP2.Views
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.enterEmailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newpasswordTextbox = new System.Windows.Forms.TextBox();
            this.reenterPasswordLabel = new System.Windows.Forms.Label();
            this.rePasswordTextbox = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordButton = new System.Windows.Forms.Button();
            this.confirmEmailButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIDTextbox = new System.Windows.Forms.TextBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterEmailLabel
            // 
            this.enterEmailLabel.AutoSize = true;
            this.enterEmailLabel.Location = new System.Drawing.Point(44, 57);
            this.enterEmailLabel.Name = "enterEmailLabel";
            this.enterEmailLabel.Size = new System.Drawing.Size(138, 15);
            this.enterEmailLabel.TabIndex = 0;
            this.enterEmailLabel.Text = "Enter your Email Address";
            this.enterEmailLabel.Visible = false;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(44, 75);
            this.emailTextbox.Name = "emailTextbox";
            //this.emailTextbox.PlaceholderText = "Enter Email Address";
            this.emailTextbox.Size = new System.Drawing.Size(138, 23);
            this.emailTextbox.TabIndex = 1;
            this.emailTextbox.Visible = false;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(44, 101);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(141, 15);
            this.newPasswordLabel.TabIndex = 0;
            this.newPasswordLabel.Text = "Enter your New Password";
            this.newPasswordLabel.Visible = false;
            // 
            // newpasswordTextbox
            // 
            this.newpasswordTextbox.Location = new System.Drawing.Point(44, 119);
            this.newpasswordTextbox.Name = "newpasswordTextbox";
            this.newpasswordTextbox.PasswordChar = '*';
            //this.newpasswordTextbox.PlaceholderText = "Enter New Password";
            this.newpasswordTextbox.Size = new System.Drawing.Size(138, 23);
            this.newpasswordTextbox.TabIndex = 1;
            this.newpasswordTextbox.Visible = false;
            // 
            // reenterPasswordLabel
            // 
            this.reenterPasswordLabel.AutoSize = true;
            this.reenterPasswordLabel.Location = new System.Drawing.Point(44, 145);
            this.reenterPasswordLabel.Name = "reenterPasswordLabel";
            this.reenterPasswordLabel.Size = new System.Drawing.Size(159, 15);
            this.reenterPasswordLabel.TabIndex = 0;
            this.reenterPasswordLabel.Text = "Re-enter your New Password";
            this.reenterPasswordLabel.Visible = false;
            // 
            // rePasswordTextbox
            // 
            this.rePasswordTextbox.Location = new System.Drawing.Point(44, 163);
            this.rePasswordTextbox.Name = "rePasswordTextbox";
            this.rePasswordTextbox.PasswordChar = '*';
            //this.rePasswordTextbox.
            //= "Re-enter New Password";
            this.rePasswordTextbox.Size = new System.Drawing.Size(138, 23);
            this.rePasswordTextbox.TabIndex = 1;
            this.rePasswordTextbox.Visible = false;
            // 
            // confirmNewPasswordButton
            // 
            this.confirmNewPasswordButton.Location = new System.Drawing.Point(53, 192);
            this.confirmNewPasswordButton.Name = "confirmNewPasswordButton";
            this.confirmNewPasswordButton.Size = new System.Drawing.Size(115, 23);
            this.confirmNewPasswordButton.TabIndex = 2;
            this.confirmNewPasswordButton.Text = "Confirm";
            this.confirmNewPasswordButton.UseVisualStyleBackColor = true;
            this.confirmNewPasswordButton.Visible = false;
            this.confirmNewPasswordButton.Click += new System.EventHandler(this.confirmNewPasswordButton_Click);
            // 
            // confirmEmailButton
            // 
            this.confirmEmailButton.Location = new System.Drawing.Point(188, 75);
            this.confirmEmailButton.Name = "confirmEmailButton";
            this.confirmEmailButton.Size = new System.Drawing.Size(93, 23);
            this.confirmEmailButton.TabIndex = 2;
            this.confirmEmailButton.Text = "Confirm";
            this.confirmEmailButton.UseVisualStyleBackColor = true;
            this.confirmEmailButton.Visible = false;
            this.confirmEmailButton.Click += new System.EventHandler(this.confirmEmailButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(44, 13);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(101, 15);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Enter Your User ID";
            // 
            // userIDTextbox
            // 
            this.userIDTextbox.Location = new System.Drawing.Point(44, 31);
            this.userIDTextbox.Name = "userIDTextbox";
            //this.userIDTextbox.PlaceholderText = "Enter User ID";
            this.userIDTextbox.Size = new System.Drawing.Size(138, 23);
            this.userIDTextbox.TabIndex = 1;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(188, 31);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(93, 23);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 266);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.confirmEmailButton);
            this.Controls.Add(this.confirmNewPasswordButton);
            this.Controls.Add(this.rePasswordTextbox);
            this.Controls.Add(this.newpasswordTextbox);
            this.Controls.Add(this.userIDTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.reenterPasswordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.enterEmailLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label enterEmailLabel;
        private TextBox emailTextbox;
        private Label newPasswordLabel;
        private TextBox newpasswordTextbox;
        private Label reenterPasswordLabel;
        private TextBox rePasswordTextbox;
        private Button confirmNewPasswordButton;
        private Button confirmEmailButton;
        private Label userNameLabel;
        private TextBox userIDTextbox;
        private Button proceedButton;
    }
}