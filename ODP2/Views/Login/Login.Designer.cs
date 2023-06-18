using System.Windows.Forms;

namespace ODP2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.connectionColorLabel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionColorLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(104, 126);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(104, 151);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(111, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.connectionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.connectionLabel.Location = new System.Drawing.Point(60, 267);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(132, 13);
            this.connectionLabel.TabIndex = 5;
            this.connectionLabel.Text = "Connecting to Database";
            this.connectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(146, 177);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(69, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButtonPressed);
            // 
            // rememberMe
            // 
            this.rememberMe.AutoSize = true;
            this.rememberMe.Location = new System.Drawing.Point(45, 183);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(95, 17);
            this.rememberMe.TabIndex = 2;
            this.rememberMe.Text = "Remember Me";
            this.rememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ODP2.Properties.Resources.f27e0b_b59fb7a9e18b4d179c0d59ef036f5036_mv2;
            this.pictureBox1.Location = new System.Drawing.Point(45, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(73, 209);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(110, 24);
            this.changePasswordButton.TabIndex = 4;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButtonPressed);
            // 
            // connectionColorLabel
            // 
            this.connectionColorLabel.BackColor = System.Drawing.Color.Red;
            this.connectionColorLabel.Location = new System.Drawing.Point(56, 272);
            this.connectionColorLabel.Name = "connectionColorLabel";
            this.connectionColorLabel.Size = new System.Drawing.Size(4, 4);
            this.connectionColorLabel.TabIndex = 5;
            this.connectionColorLabel.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(73, 239);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(110, 24);
            this.newAccountButton.TabIndex = 4;
            this.newAccountButton.Text = "New Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.changePasswordButtonPressed);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 295);
            this.Controls.Add(this.connectionColorLabel);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODP2 Engineering Login";
            this.Load += new System.EventHandler(this.loginFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionColorLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label connectionLabel;
        private Button loginButton;
        private CheckBox rememberMe;
        private PictureBox pictureBox1;
        private Button changePasswordButton;
        private PictureBox connectionColorLabel;
        private Label label2;
        private Button newAccountButton;
    }
}