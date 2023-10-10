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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewEquipment));
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.eQUIPMENTFAMILYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newEquipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.inServiceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.componentGridView = new System.Windows.Forms.DataGridView();
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTMODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.equipmentPanel = new System.Windows.Forms.Panel();
            this.refueledCheckBox = new System.Windows.Forms.CheckBox();
            this.equipmentBatchComboBox = new System.Windows.Forms.ComboBox();
            this.enterEquipmentDirectiveCheckBox = new System.Windows.Forms.CheckBox();
            this.warrantyEndCheckBox = new System.Windows.Forms.CheckBox();
            this.enterEquipmentIDCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.equipmentFamilyDirectiveTextBox = new System.Windows.Forms.TextBox();
            this.warrantyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.equipmentDirectiveTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.equipmentHourTextBox = new System.Windows.Forms.TextBox();
            this.equipmentSerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.componentsPanel = new System.Windows.Forms.Panel();
            this.insertButton = new System.Windows.Forms.Button();
            this.componentComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentComboBox = new System.Windows.Forms.ComboBox();
            this.eQUIPMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentSNTextBox = new System.Windows.Forms.TextBox();
            this.componentManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.componentModelTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.equipmentDirective = new System.Windows.Forms.TextBox();
            this.componentPartCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTFAMILYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTBindingSource)).BeginInit();
            this.equipmentPanel.SuspendLayout();
            this.componentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTBindingSource)).BeginInit();
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
            this.equipmentFamilyComboBox.DataSource = this.eQUIPMENTFAMILYBindingSource;
            this.equipmentFamilyComboBox.DisplayMember = "EQUIPMENTFAMILYCODE";
            this.equipmentFamilyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentFamilyComboBox.FormattingEnabled = true;
            this.equipmentFamilyComboBox.Location = new System.Drawing.Point(106, 8);
            this.equipmentFamilyComboBox.Name = "equipmentFamilyComboBox";
            this.equipmentFamilyComboBox.Size = new System.Drawing.Size(77, 21);
            this.equipmentFamilyComboBox.TabIndex = 1;
            this.equipmentFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentFamilyComboBox_SelectionChanged);
            // 
            // eQUIPMENTFAMILYBindingSource
            // 
            this.eQUIPMENTFAMILYBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENTFAMILY);
            // 
            // newEquipmentIDTextBox
            // 
            this.newEquipmentIDTextBox.Location = new System.Drawing.Point(432, 10);
            this.newEquipmentIDTextBox.Name = "newEquipmentIDTextBox";
            this.newEquipmentIDTextBox.ReadOnly = true;
            this.newEquipmentIDTextBox.Size = new System.Drawing.Size(88, 20);
            this.newEquipmentIDTextBox.TabIndex = 2;
            this.newEquipmentIDTextBox.TextChanged += new System.EventHandler(this.newEquipmentIDTextBox_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Batch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
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
            this.manufacturerTextBox.Location = new System.Drawing.Point(432, 62);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.ReadOnly = true;
            this.manufacturerTextBox.Size = new System.Drawing.Size(122, 20);
            this.manufacturerTextBox.TabIndex = 2;
            this.manufacturerTextBox.Validated += new System.EventHandler(this.shallUpdateDirective);
            // 
            // inServiceDatePicker
            // 
            this.inServiceDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.inServiceDatePicker.Enabled = false;
            this.inServiceDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inServiceDatePicker.Location = new System.Drawing.Point(106, 88);
            this.inServiceDatePicker.Name = "inServiceDatePicker";
            this.inServiceDatePicker.Size = new System.Drawing.Size(145, 20);
            this.inServiceDatePicker.TabIndex = 3;
            // 
            // componentGridView
            // 
            this.componentGridView.AllowUserToAddRows = false;
            this.componentGridView.AllowUserToDeleteRows = false;
            this.componentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.componentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.componentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn,
            this.cOMPONENTSNDataGridViewTextBoxColumn,
            this.cOMPONENTSTATUSDataGridViewTextBoxColumn,
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn,
            this.cOMPONENTMODELDataGridViewTextBoxColumn});
            this.componentGridView.DataSource = this.cOMPONENTBindingSource;
            this.componentGridView.Location = new System.Drawing.Point(10, 317);
            this.componentGridView.Name = "componentGridView";
            this.componentGridView.ReadOnly = true;
            this.componentGridView.RowHeadersVisible = false;
            this.componentGridView.Size = new System.Drawing.Size(755, 206);
            this.componentGridView.TabIndex = 5;
            // 
            // cOMPONENTPARTCODEDataGridViewTextBoxColumn
            // 
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTPARTCODE";
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.HeaderText = "Component Part Code";
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.Name = "cOMPONENTPARTCODEDataGridViewTextBoxColumn";
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.Width = 132;
            // 
            // cOMPONENTSNDataGridViewTextBoxColumn
            // 
            this.cOMPONENTSNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cOMPONENTSNDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTSN";
            this.cOMPONENTSNDataGridViewTextBoxColumn.HeaderText = "Component S/N";
            this.cOMPONENTSNDataGridViewTextBoxColumn.Name = "cOMPONENTSNDataGridViewTextBoxColumn";
            this.cOMPONENTSNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPONENTSTATUSDataGridViewTextBoxColumn
            // 
            this.cOMPONENTSTATUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOMPONENTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTSTATUS";
            this.cOMPONENTSTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.cOMPONENTSTATUSDataGridViewTextBoxColumn.Name = "cOMPONENTSTATUSDataGridViewTextBoxColumn";
            this.cOMPONENTSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPONENTSTATUSDataGridViewTextBoxColumn.Width = 76;
            // 
            // cOMPONENTMANFACTURERDataGridViewTextBoxColumn
            // 
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTMANFACTURER";
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.Name = "cOMPONENTMANFACTURERDataGridViewTextBoxColumn";
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.Width = 119;
            // 
            // cOMPONENTMODELDataGridViewTextBoxColumn
            // 
            this.cOMPONENTMODELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOMPONENTMODELDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTMODEL";
            this.cOMPONENTMODELDataGridViewTextBoxColumn.HeaderText = "Model";
            this.cOMPONENTMODELDataGridViewTextBoxColumn.Name = "cOMPONENTMODELDataGridViewTextBoxColumn";
            this.cOMPONENTMODELDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPONENTMODELDataGridViewTextBoxColumn.Width = 73;
            // 
            // cOMPONENTBindingSource
            // 
            this.cOMPONENTBindingSource.DataSource = typeof(ODP2.Models.COMPONENT);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(640, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Capacity";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(432, 114);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.ReadOnly = true;
            this.capacityTextBox.Size = new System.Drawing.Size(122, 20);
            this.capacityTextBox.TabIndex = 2;
            // 
            // equipmentPanel
            // 
            this.equipmentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentPanel.Controls.Add(this.refueledCheckBox);
            this.equipmentPanel.Controls.Add(this.equipmentBatchComboBox);
            this.equipmentPanel.Controls.Add(this.enterEquipmentDirectiveCheckBox);
            this.equipmentPanel.Controls.Add(this.warrantyEndCheckBox);
            this.equipmentPanel.Controls.Add(this.enterEquipmentIDCheckBox);
            this.equipmentPanel.Controls.Add(this.label1);
            this.equipmentPanel.Controls.Add(this.saveButton);
            this.equipmentPanel.Controls.Add(this.label13);
            this.equipmentPanel.Controls.Add(this.equipmentFamilyComboBox);
            this.equipmentPanel.Controls.Add(this.label2);
            this.equipmentPanel.Controls.Add(this.label15);
            this.equipmentPanel.Controls.Add(this.label3);
            this.equipmentPanel.Controls.Add(this.equipmentFamilyDirectiveTextBox);
            this.equipmentPanel.Controls.Add(this.newEquipmentIDTextBox);
            this.equipmentPanel.Controls.Add(this.warrantyDateTimePicker);
            this.equipmentPanel.Controls.Add(this.equipmentDirectiveTextBox);
            this.equipmentPanel.Controls.Add(this.inServiceDatePicker);
            this.equipmentPanel.Controls.Add(this.label4);
            this.equipmentPanel.Controls.Add(this.countTextBox);
            this.equipmentPanel.Controls.Add(this.capacityTextBox);
            this.equipmentPanel.Controls.Add(this.model);
            this.equipmentPanel.Controls.Add(this.label5);
            this.equipmentPanel.Controls.Add(this.modelTextBox);
            this.equipmentPanel.Controls.Add(this.manufacturerTextBox);
            this.equipmentPanel.Controls.Add(this.label14);
            this.equipmentPanel.Controls.Add(this.equipmentHourTextBox);
            this.equipmentPanel.Controls.Add(this.equipmentSerialNumberTextBox);
            this.equipmentPanel.Controls.Add(this.label10);
            this.equipmentPanel.Location = new System.Drawing.Point(10, 10);
            this.equipmentPanel.Margin = new System.Windows.Forms.Padding(5);
            this.equipmentPanel.Name = "equipmentPanel";
            this.equipmentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.equipmentPanel.Size = new System.Drawing.Size(755, 169);
            this.equipmentPanel.TabIndex = 8;
            // 
            // refueledCheckBox
            // 
            this.refueledCheckBox.AutoSize = true;
            this.refueledCheckBox.Enabled = false;
            this.refueledCheckBox.Location = new System.Drawing.Point(526, 13);
            this.refueledCheckBox.Name = "refueledCheckBox";
            this.refueledCheckBox.Size = new System.Drawing.Size(63, 17);
            this.refueledCheckBox.TabIndex = 10;
            this.refueledCheckBox.Text = "Re-Fuel";
            this.refueledCheckBox.UseVisualStyleBackColor = true;
            // 
            // equipmentBatchComboBox
            // 
            this.equipmentBatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentBatchComboBox.Enabled = false;
            this.equipmentBatchComboBox.FormattingEnabled = true;
            this.equipmentBatchComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K"});
            this.equipmentBatchComboBox.Location = new System.Drawing.Point(106, 35);
            this.equipmentBatchComboBox.Name = "equipmentBatchComboBox";
            this.equipmentBatchComboBox.Size = new System.Drawing.Size(77, 21);
            this.equipmentBatchComboBox.TabIndex = 9;
            this.equipmentBatchComboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentBatchComboBox_SelectedIndexChanged);
            // 
            // enterEquipmentDirectiveCheckBox
            // 
            this.enterEquipmentDirectiveCheckBox.AutoSize = true;
            this.enterEquipmentDirectiveCheckBox.Enabled = false;
            this.enterEquipmentDirectiveCheckBox.Location = new System.Drawing.Point(264, 90);
            this.enterEquipmentDirectiveCheckBox.Name = "enterEquipmentDirectiveCheckBox";
            this.enterEquipmentDirectiveCheckBox.Size = new System.Drawing.Size(162, 17);
            this.enterEquipmentDirectiveCheckBox.TabIndex = 8;
            this.enterEquipmentDirectiveCheckBox.Text = "Neglect Suggested Directive";
            this.enterEquipmentDirectiveCheckBox.UseVisualStyleBackColor = true;
            this.enterEquipmentDirectiveCheckBox.CheckedChanged += new System.EventHandler(this.enterEquipmentDirectiveCheckBox_CheckedChanged);
            // 
            // warrantyEndCheckBox
            // 
            this.warrantyEndCheckBox.AutoSize = true;
            this.warrantyEndCheckBox.Location = new System.Drawing.Point(9, 142);
            this.warrantyEndCheckBox.Name = "warrantyEndCheckBox";
            this.warrantyEndCheckBox.Size = new System.Drawing.Size(91, 17);
            this.warrantyEndCheckBox.TabIndex = 8;
            this.warrantyEndCheckBox.Text = "Warranty End";
            this.warrantyEndCheckBox.UseVisualStyleBackColor = true;
            this.warrantyEndCheckBox.CheckedChanged += new System.EventHandler(this.enterWarrantyEndDateCheckBox_CheckedChanged);
            // 
            // enterEquipmentIDCheckBox
            // 
            this.enterEquipmentIDCheckBox.AutoSize = true;
            this.enterEquipmentIDCheckBox.Enabled = false;
            this.enterEquipmentIDCheckBox.Location = new System.Drawing.Point(295, 12);
            this.enterEquipmentIDCheckBox.Name = "enterEquipmentIDCheckBox";
            this.enterEquipmentIDCheckBox.Size = new System.Drawing.Size(131, 17);
            this.enterEquipmentIDCheckBox.TabIndex = 8;
            this.enterEquipmentIDCheckBox.Text = "Neglect Suggested ID";
            this.enterEquipmentIDCheckBox.UseVisualStyleBackColor = true;
            this.enterEquipmentIDCheckBox.CheckedChanged += new System.EventHandler(this.enterEquipmentIDCheckBox_CheckedChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Equipment HR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Equipment SN";
            // 
            // equipmentFamilyDirectiveTextBox
            // 
            this.equipmentFamilyDirectiveTextBox.Location = new System.Drawing.Point(432, 36);
            this.equipmentFamilyDirectiveTextBox.Name = "equipmentFamilyDirectiveTextBox";
            this.equipmentFamilyDirectiveTextBox.ReadOnly = true;
            this.equipmentFamilyDirectiveTextBox.Size = new System.Drawing.Size(306, 20);
            this.equipmentFamilyDirectiveTextBox.TabIndex = 2;
            // 
            // warrantyDateTimePicker
            // 
            this.warrantyDateTimePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.warrantyDateTimePicker.Enabled = false;
            this.warrantyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.warrantyDateTimePicker.Location = new System.Drawing.Point(106, 140);
            this.warrantyDateTimePicker.Name = "warrantyDateTimePicker";
            this.warrantyDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.warrantyDateTimePicker.TabIndex = 3;
            // 
            // equipmentDirectiveTextBox
            // 
            this.equipmentDirectiveTextBox.Location = new System.Drawing.Point(432, 88);
            this.equipmentDirectiveTextBox.Name = "equipmentDirectiveTextBox";
            this.equipmentDirectiveTextBox.ReadOnly = true;
            this.equipmentDirectiveTextBox.Size = new System.Drawing.Size(306, 20);
            this.equipmentDirectiveTextBox.TabIndex = 16;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(602, 113);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(136, 20);
            this.countTextBox.TabIndex = 2;
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(560, 65);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(36, 13);
            this.model.TabIndex = 0;
            this.model.Text = "Model";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(602, 63);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(136, 20);
            this.modelTextBox.TabIndex = 2;
            this.modelTextBox.Validated += new System.EventHandler(this.shallUpdateDirective);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(561, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Count";
            // 
            // equipmentHourTextBox
            // 
            this.equipmentHourTextBox.Location = new System.Drawing.Point(106, 114);
            this.equipmentHourTextBox.Name = "equipmentHourTextBox";
            this.equipmentHourTextBox.ReadOnly = true;
            this.equipmentHourTextBox.Size = new System.Drawing.Size(145, 20);
            this.equipmentHourTextBox.TabIndex = 2;
            // 
            // equipmentSerialNumberTextBox
            // 
            this.equipmentSerialNumberTextBox.Location = new System.Drawing.Point(106, 62);
            this.equipmentSerialNumberTextBox.Name = "equipmentSerialNumberTextBox";
            this.equipmentSerialNumberTextBox.ReadOnly = true;
            this.equipmentSerialNumberTextBox.Size = new System.Drawing.Size(145, 20);
            this.equipmentSerialNumberTextBox.TabIndex = 2;
            // 
            // componentsPanel
            // 
            this.componentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.componentsPanel.Controls.Add(this.insertButton);
            this.componentsPanel.Controls.Add(this.componentComboBox);
            this.componentsPanel.Controls.Add(this.equipmentComboBox);
            this.componentsPanel.Controls.Add(this.componentSNTextBox);
            this.componentsPanel.Controls.Add(this.componentManufacturerTextBox);
            this.componentsPanel.Controls.Add(this.componentModelTextBox);
            this.componentsPanel.Controls.Add(this.label16);
            this.componentsPanel.Controls.Add(this.label6);
            this.componentsPanel.Controls.Add(this.label7);
            this.componentsPanel.Controls.Add(this.label11);
            this.componentsPanel.Controls.Add(this.label12);
            this.componentsPanel.Controls.Add(this.label8);
            this.componentsPanel.Controls.Add(this.equipmentDirective);
            this.componentsPanel.Controls.Add(this.componentPartCode);
            this.componentsPanel.Controls.Add(this.label18);
            this.componentsPanel.Controls.Add(this.label9);
            this.componentsPanel.Location = new System.Drawing.Point(10, 189);
            this.componentsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.componentsPanel.Name = "componentsPanel";
            this.componentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.componentsPanel.Size = new System.Drawing.Size(755, 120);
            this.componentsPanel.TabIndex = 9;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(432, 86);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(112, 23);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.componentInsertButton_Clicked);
            // 
            // componentComboBox
            // 
            this.componentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.componentComboBox.FormattingEnabled = true;
            this.componentComboBox.Items.AddRange(new object[] {
            "Engine",
            "Transmission",
            "Drive Axle"});
            this.componentComboBox.Location = new System.Drawing.Point(111, 35);
            this.componentComboBox.Name = "componentComboBox";
            this.componentComboBox.Size = new System.Drawing.Size(101, 21);
            this.componentComboBox.TabIndex = 17;
            this.componentComboBox.SelectedIndexChanged += new System.EventHandler(this.componentComboBox_SelectedIndexChanged);
            // 
            // equipmentComboBox
            // 
            this.equipmentComboBox.DataSource = this.eQUIPMENTBindingSource;
            this.equipmentComboBox.DisplayMember = "EQUIPMENTID";
            this.equipmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentComboBox.Location = new System.Drawing.Point(111, 8);
            this.equipmentComboBox.Name = "equipmentComboBox";
            this.equipmentComboBox.Size = new System.Drawing.Size(101, 21);
            this.equipmentComboBox.TabIndex = 17;
            this.equipmentComboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentComboBox_SelectedIndexChanged);
            // 
            // eQUIPMENTBindingSource
            // 
            this.eQUIPMENTBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // componentSNTextBox
            // 
            this.componentSNTextBox.Location = new System.Drawing.Point(111, 62);
            this.componentSNTextBox.Name = "componentSNTextBox";
            this.componentSNTextBox.Size = new System.Drawing.Size(145, 20);
            this.componentSNTextBox.TabIndex = 14;
            // 
            // componentManufacturerTextBox
            // 
            this.componentManufacturerTextBox.Location = new System.Drawing.Point(111, 88);
            this.componentManufacturerTextBox.Name = "componentManufacturerTextBox";
            this.componentManufacturerTextBox.Size = new System.Drawing.Size(145, 20);
            this.componentManufacturerTextBox.TabIndex = 15;
            // 
            // componentModelTextBox
            // 
            this.componentModelTextBox.Location = new System.Drawing.Point(432, 60);
            this.componentModelTextBox.Name = "componentModelTextBox";
            this.componentModelTextBox.Size = new System.Drawing.Size(112, 20);
            this.componentModelTextBox.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Select Component";
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
            this.label7.Location = new System.Drawing.Point(48, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Equipment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Manufacturer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Component SN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Model";
            // 
            // equipmentDirective
            // 
            this.equipmentDirective.Location = new System.Drawing.Point(432, 8);
            this.equipmentDirective.Name = "equipmentDirective";
            this.equipmentDirective.ReadOnly = true;
            this.equipmentDirective.Size = new System.Drawing.Size(306, 20);
            this.equipmentDirective.TabIndex = 16;
            // 
            // componentPartCode
            // 
            this.componentPartCode.Location = new System.Drawing.Point(432, 34);
            this.componentPartCode.Name = "componentPartCode";
            this.componentPartCode.Size = new System.Drawing.Size(306, 20);
            this.componentPartCode.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(315, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Equipment Directive";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Component Part Code";
            // 
            // AddNewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 531);
            this.Controls.Add(this.componentsPanel);
            this.Controls.Add(this.equipmentPanel);
            this.Controls.Add(this.componentGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewEquipment";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Add New Equipment";
            this.Load += new System.EventHandler(this.AddNewEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTFAMILYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTBindingSource)).EndInit();
            this.equipmentPanel.ResumeLayout(false);
            this.equipmentPanel.PerformLayout();
            this.componentsPanel.ResumeLayout(false);
            this.componentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipmentFamilyComboBox;
        private System.Windows.Forms.TextBox newEquipmentIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.DateTimePicker inServiceDatePicker;
        private System.Windows.Forms.DataGridView componentGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Panel equipmentPanel;
        private System.Windows.Forms.Panel componentsPanel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ComboBox equipmentComboBox;
        private System.Windows.Forms.TextBox componentSNTextBox;
        private System.Windows.Forms.TextBox componentModelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox componentPartCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox equipmentFamilyDirectiveTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox equipmentSerialNumberTextBox;
        private System.Windows.Forms.CheckBox enterEquipmentIDCheckBox;
        private System.Windows.Forms.ComboBox equipmentBatchComboBox;
        private System.Windows.Forms.BindingSource eQUIPMENTFAMILYBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox equipmentHourTextBox;
        private System.Windows.Forms.ComboBox componentComboBox;
        private System.Windows.Forms.TextBox componentManufacturerTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource eQUIPMENTBindingSource;
        private System.Windows.Forms.TextBox equipmentDirective;
        private System.Windows.Forms.BindingSource cOMPONENTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTPARTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTMANFACTURERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTMODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox refueledCheckBox;
        private System.Windows.Forms.DateTimePicker warrantyDateTimePicker;
        private System.Windows.Forms.CheckBox enterEquipmentDirectiveCheckBox;
        private System.Windows.Forms.TextBox equipmentDirectiveTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.CheckBox warrantyEndCheckBox;
    }
}