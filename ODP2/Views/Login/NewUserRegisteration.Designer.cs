using ODP2.Properties;
using System.Windows.Forms;

namespace ODP2.Views.Login
{
    partial class NewUserRegisteration
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.userEmailAddress = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.userSectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.userLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceedButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.userSectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address";
            // 
            // userEmailAddress
            // 
            this.userEmailAddress.Location = new System.Drawing.Point(105, 8);
            this.userEmailAddress.Name = "userEmailAddress";
            this.userEmailAddress.Size = new System.Drawing.Size(209, 20);
            this.userEmailAddress.TabIndex = 1;
            // 
            // confirmButton
            // 
            this.confirmButton.CausesValidation = false;
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(151, 245);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(120, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Register";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Enabled = false;
            this.userNameTextBox.Location = new System.Drawing.Point(105, 60);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Code";
            // 
            // userCodeTextBox
            // 
            this.userCodeTextBox.Enabled = false;
            this.userCodeTextBox.Location = new System.Drawing.Point(105, 86);
            this.userCodeTextBox.Name = "userCodeTextBox";
            this.userCodeTextBox.Size = new System.Drawing.Size(121, 20);
            this.userCodeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(105, 112);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(166, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Repeat Password";
            // 
            // rePasswordTextBox
            // 
            this.rePasswordTextBox.Enabled = false;
            this.rePasswordTextBox.Location = new System.Drawing.Point(105, 138);
            this.rePasswordTextBox.Name = "rePasswordTextBox";
            this.rePasswordTextBox.PasswordChar = '*';
            this.rePasswordTextBox.Size = new System.Drawing.Size(166, 20);
            this.rePasswordTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Section";
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.DataSource = this.userSectionBindingSource;
            this.sectionComboBox.DisplayMember = "USERSECTION1";
            this.sectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionComboBox.Enabled = false;
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(105, 191);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sectionComboBox.TabIndex = 3;
            // 
            // userSectionBindingSource
            // 
            this.userSectionBindingSource.DataSource = typeof(ODP2.Models.USERSECTION);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Privilages Level";
            // 
            // levelComboBox
            // 
            this.levelComboBox.DataSource = this.userLevelBindingSource;
            this.levelComboBox.DisplayMember = "USERLEVEL1";
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.Enabled = false;
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(105, 218);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(121, 21);
            this.levelComboBox.TabIndex = 3;
            // 
            // userLevelBindingSource
            // 
            this.userLevelBindingSource.DataSource = typeof(ODP2.Models.USERLEVEL);
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(336, 6);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "UserID";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Enabled = false;
            this.userIDTextBox.Location = new System.Drawing.Point(105, 34);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.userIDTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Title";
            // 
            // titleComboBox
            // 
            this.titleComboBox.DisplayMember = "USERSECTION1";
            this.titleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleComboBox.Enabled = false;
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Items.AddRange(new object[] {
            "Mechanical Engineer",
            "Electrical Engineer",
            "Store Keeper",
            "Section Head"});
            this.titleComboBox.Location = new System.Drawing.Point(105, 164);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(121, 21);
            this.titleComboBox.TabIndex = 3;
            // 
            // NewUserRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(421, 278);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.titleComboBox);
            this.Controls.Add(this.sectionComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rePasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userEmailAddress);
            this.Controls.Add(this.label1);
            this.Name = "NewUserRegisteration";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "New User Registeration";
            ((System.ComponentModel.ISupportInitialize)(this.userSectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLevelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox userEmailAddress;
        private Button confirmButton;
        private Label label2;
        private TextBox userNameTextBox;
        private Label label3;
        private TextBox userCodeTextBox;
        private Label label4;
        private TextBox passwordTextBox;
        private Label label5;
        private TextBox rePasswordTextBox;
        private Label label6;
        private ComboBox sectionComboBox;
        private Label label7;
        private ComboBox levelComboBox;
        private Button proceedButton;
        private Label label8;
        private TextBox userIDTextBox;
        private BindingSource userSectionBindingSource;
        private BindingSource userLevelBindingSource;
        private Label label9;
        private ComboBox titleComboBox;
    }
}