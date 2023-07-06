namespace ODP2.Views.Equipment_Management
{
    partial class AddNewEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewEquipment));
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newEquipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.selectedEquipmentFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.componentGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.equipmentPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.equipmentFamilyDirective = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.componentsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.selectedEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedEquipmentFamilyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentGridView)).BeginInit();
            this.equipmentPanel.SuspendLayout();
            this.componentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedEquipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment Family";
            // 
            // equipmentFamilyComboBox
            // 
            this.equipmentFamilyComboBox.DataSource = this.equipmentFamilyBindingSource;
            this.equipmentFamilyComboBox.DisplayMember = "equipmentFamilyCode";
            this.equipmentFamilyComboBox.FormattingEnabled = true;
            this.equipmentFamilyComboBox.Location = new System.Drawing.Point(106, 9);
            this.equipmentFamilyComboBox.Name = "equipmentFamilyComboBox";
            this.equipmentFamilyComboBox.Size = new System.Drawing.Size(77, 21);
            this.equipmentFamilyComboBox.TabIndex = 1;
            this.equipmentFamilyComboBox.Validated += new System.EventHandler(this.equipmentFamilyComboBox_Validated);
            // 
            // equipmentFamilyBindingSource
            // 
            this.equipmentFamilyBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENTFAMILY);
            // 
            // newEquipmentIDTextBox
            // 
            this.newEquipmentIDTextBox.Location = new System.Drawing.Point(432, 10);
            this.newEquipmentIDTextBox.Name = "newEquipmentIDTextBox";
            this.newEquipmentIDTextBox.ReadOnly = true;
            this.newEquipmentIDTextBox.Size = new System.Drawing.Size(191, 20);
            this.newEquipmentIDTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Suggested Equipment ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Equipment SN";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "In-Service Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manufacturer";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentFamilyBindingSource, "manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(432, 62);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.ReadOnly = true;
            this.manufacturerTextBox.Size = new System.Drawing.Size(191, 20);
            this.manufacturerTextBox.TabIndex = 2;
            // 
            // selectedEquipmentFamilyBindingSource
            // 
            this.selectedEquipmentFamilyBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENTFAMILY);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // componentGridView
            // 
            this.componentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentGridView.Location = new System.Drawing.Point(10, 300);
            this.componentGridView.Name = "componentGridView";
            this.componentGridView.Size = new System.Drawing.Size(748, 223);
            this.componentGridView.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(652, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Capacity";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentFamilyBindingSource, "capacity", true));
            this.textBox6.Location = new System.Drawing.Point(432, 88);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(88, 20);
            this.textBox6.TabIndex = 2;
            // 
            // equipmentPanel
            // 
            this.equipmentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentPanel.Controls.Add(this.label1);
            this.equipmentPanel.Controls.Add(this.saveButton);
            this.equipmentPanel.Controls.Add(this.label13);
            this.equipmentPanel.Controls.Add(this.label2);
            this.equipmentPanel.Controls.Add(this.equipmentFamilyComboBox);
            this.equipmentPanel.Controls.Add(this.label3);
            this.equipmentPanel.Controls.Add(this.equipmentFamilyDirective);
            this.equipmentPanel.Controls.Add(this.newEquipmentIDTextBox);
            this.equipmentPanel.Controls.Add(this.dateTimePicker1);
            this.equipmentPanel.Controls.Add(this.label4);
            this.equipmentPanel.Controls.Add(this.countTextBox);
            this.equipmentPanel.Controls.Add(this.textBox6);
            this.equipmentPanel.Controls.Add(this.label5);
            this.equipmentPanel.Controls.Add(this.manufacturerTextBox);
            this.equipmentPanel.Controls.Add(this.label14);
            this.equipmentPanel.Controls.Add(this.textBox2);
            this.equipmentPanel.Controls.Add(this.label10);
            this.equipmentPanel.Location = new System.Drawing.Point(10, 10);
            this.equipmentPanel.Margin = new System.Windows.Forms.Padding(5);
            this.equipmentPanel.Name = "equipmentPanel";
            this.equipmentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.equipmentPanel.Size = new System.Drawing.Size(748, 118);
            this.equipmentPanel.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Equipment Family Directive";
            // 
            // equipmentFamilyDirective
            // 
            this.equipmentFamilyDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentFamilyBindingSource, "equipmentTypeDirective", true));
            this.equipmentFamilyDirective.Location = new System.Drawing.Point(432, 36);
            this.equipmentFamilyDirective.Name = "equipmentFamilyDirective";
            this.equipmentFamilyDirective.ReadOnly = true;
            this.equipmentFamilyDirective.Size = new System.Drawing.Size(191, 20);
            this.equipmentFamilyDirective.TabIndex = 2;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentFamilyBindingSource, "count", true));
            this.countTextBox.Location = new System.Drawing.Point(573, 87);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(88, 20);
            this.countTextBox.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(532, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Count";
            // 
            // componentsPanel
            // 
            this.componentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentsPanel.Controls.Add(this.button1);
            this.componentsPanel.Controls.Add(this.comboBox2);
            this.componentsPanel.Controls.Add(this.textBox7);
            this.componentsPanel.Controls.Add(this.textBox8);
            this.componentsPanel.Controls.Add(this.textBox3);
            this.componentsPanel.Controls.Add(this.label6);
            this.componentsPanel.Controls.Add(this.label7);
            this.componentsPanel.Controls.Add(this.label11);
            this.componentsPanel.Controls.Add(this.label12);
            this.componentsPanel.Controls.Add(this.label8);
            this.componentsPanel.Controls.Add(this.textBox5);
            this.componentsPanel.Controls.Add(this.label9);
            this.componentsPanel.Location = new System.Drawing.Point(10, 138);
            this.componentsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.componentsPanel.Name = "componentsPanel";
            this.componentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.componentsPanel.Size = new System.Drawing.Size(748, 154);
            this.componentsPanel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Engine",
            "Transmission",
            "Drive Axle",
            "Steering Axle"});
            this.comboBox2.Location = new System.Drawing.Point(111, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(111, 87);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(111, 35);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(145, 20);
            this.textBox8.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, -25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Components";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Select Component";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Manufacturer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Component SN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Model";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(425, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(197, 20);
            this.textBox5.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Component Part Code";
            // 
            // selectedEquipmentBindingSource
            // 
            this.selectedEquipmentBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // AddNewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 531);
            this.Controls.Add(this.componentsPanel);
            this.Controls.Add(this.equipmentPanel);
            this.Controls.Add(this.componentGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewEquipment";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Add New Equipment";
            this.Load += new System.EventHandler(this.AddNewEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedEquipmentFamilyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentGridView)).EndInit();
            this.equipmentPanel.ResumeLayout(false);
            this.equipmentPanel.PerformLayout();
            this.componentsPanel.ResumeLayout(false);
            this.componentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedEquipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipmentFamilyComboBox;
        private System.Windows.Forms.TextBox newEquipmentIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView componentGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.BindingSource equipmentFamilyBindingSource;
        private System.Windows.Forms.Panel equipmentPanel;
        private System.Windows.Forms.Panel componentsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource selectedEquipmentBindingSource;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox equipmentFamilyDirective;
        private System.Windows.Forms.BindingSource selectedEquipmentFamilyBindingSource;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label label14;
    }
}