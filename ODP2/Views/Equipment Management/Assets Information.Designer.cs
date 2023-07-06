namespace ODP2.Views.Equipment_Management
{
    partial class AssetsInformation
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
            this.components = new System.ComponentModel.Container();
            this.equipmentComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDirectiveTextBox = new System.Windows.Forms.TextBox();
            this.newEquipment = new System.Windows.Forms.Button();
            this.equipmentModel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentComboBox
            // 
            this.equipmentComboBox.CausesValidation = false;
            this.equipmentComboBox.DataSource = this.equipmentBindingSource;
            this.equipmentComboBox.DisplayMember = "equipmentID";
            this.equipmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentComboBox.FormattingEnabled = true;
            this.equipmentComboBox.Location = new System.Drawing.Point(8, 8);
            this.equipmentComboBox.Name = "equipmentComboBox";
            this.equipmentComboBox.Size = new System.Drawing.Size(87, 21);
            this.equipmentComboBox.TabIndex = 0;
            this.equipmentComboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentComboBox_SelectedIndexChanged);
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // equipmentDirectiveTextBox
            // 
            this.equipmentDirectiveTextBox.Location = new System.Drawing.Point(101, 9);
            this.equipmentDirectiveTextBox.Name = "equipmentDirectiveTextBox";
            this.equipmentDirectiveTextBox.ReadOnly = true;
            this.equipmentDirectiveTextBox.Size = new System.Drawing.Size(326, 20);
            this.equipmentDirectiveTextBox.TabIndex = 1;
            // 
            // newEquipment
            // 
            this.newEquipment.Location = new System.Drawing.Point(514, 6);
            this.newEquipment.Name = "newEquipment";
            this.newEquipment.Size = new System.Drawing.Size(112, 23);
            this.newEquipment.TabIndex = 2;
            this.newEquipment.Text = "Add New Equipment";
            this.newEquipment.UseVisualStyleBackColor = true;
            this.newEquipment.Click += new System.EventHandler(this.newEquipment_Click);
            // 
            // equipmentModel
            // 
            this.equipmentModel.AutoSize = true;
            this.equipmentModel.Location = new System.Drawing.Point(92, 58);
            this.equipmentModel.Name = "equipmentModel";
            this.equipmentModel.Size = new System.Drawing.Size(36, 13);
            this.equipmentModel.TabIndex = 3;
            this.equipmentModel.Text = "Model";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(134, 133);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(117, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Equipment Status";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(514, 107);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(182, 20);
            this.textBox7.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Last PM Date";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(135, 107);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(116, 20);
            this.textBox10.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Manufacturer";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(514, 81);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(182, 20);
            this.textBox8.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "In-Operation Date";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(135, 81);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(229, 20);
            this.textBox9.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Equipment S/N";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(514, 55);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(92, 20);
            this.textBox11.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Running Hours";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(632, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AssetsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.equipmentModel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newEquipment);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.equipmentDirectiveTextBox);
            this.Controls.Add(this.equipmentComboBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AssetsInformation";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(765, 195);
            this.Load += new System.EventHandler(this.AssetsInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox equipmentComboBox;
        private System.Windows.Forms.TextBox equipmentDirectiveTextBox;
        private System.Windows.Forms.Button newEquipment;
        private System.Windows.Forms.Label equipmentModel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
    }
}
