namespace ODP2.Views.Stores_Management
{
    partial class FuelStation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FuelStationTab = new System.Windows.Forms.TabControl();
            this.issueFuelTab = new System.Windows.Forms.TabPage();
            this.uomComboBox = new System.Windows.Forms.ComboBox();
            this.issueFuelSaveButton = new System.Windows.Forms.Button();
            this.fuelIssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.equipmentReadingTextbox = new System.Windows.Forms.TextBox();
            this.issueEquipmentDirective = new System.Windows.Forms.TextBox();
            this.comments = new System.Windows.Forms.TextBox();
            this.fuelQtyTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentIDIssue = new System.Windows.Forms.ComboBox();
            this.eQUIPMENTBindingSource_Issue = new System.Windows.Forms.BindingSource(this.components);
            this.receiveFuelTab = new System.Windows.Forms.TabPage();
            this.recieveFuelSaveButton = new System.Windows.Forms.Button();
            this.fuelRecievedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.recievedFuelQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.refuelingDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasuring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUELINGWORKORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportEquipmentDirective = new System.Windows.Forms.TextBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.toCheckBox = new System.Windows.Forms.CheckBox();
            this.fromCheckBox = new System.Windows.Forms.CheckBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.equipmentIDReport = new System.Windows.Forms.ComboBox();
            this.eQUIPMENTBindingSource_Report = new System.Windows.Forms.BindingSource(this.components);
            this.fuelStockLevel = new System.Windows.Forms.TrackBar();
            this.fuelStockPercentage = new System.Windows.Forms.Label();
            this.fuelStockQty = new System.Windows.Forms.Label();
            this.fuelingWorkOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelStationTab.SuspendLayout();
            this.issueFuelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTBindingSource_Issue)).BeginInit();
            this.receiveFuelTab.SuspendLayout();
            this.reportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refuelingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUELINGWORKORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTBindingSource_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStockLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // FuelStationTab
            // 
            this.FuelStationTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FuelStationTab.Controls.Add(this.issueFuelTab);
            this.FuelStationTab.Controls.Add(this.receiveFuelTab);
            this.FuelStationTab.Controls.Add(this.reportTab);
            this.FuelStationTab.Location = new System.Drawing.Point(12, 12);
            this.FuelStationTab.Multiline = true;
            this.FuelStationTab.Name = "FuelStationTab";
            this.FuelStationTab.SelectedIndex = 0;
            this.FuelStationTab.Size = new System.Drawing.Size(758, 479);
            this.FuelStationTab.TabIndex = 5;
            this.FuelStationTab.SelectedIndexChanged += new System.EventHandler(this.FuelStationTab_SelectedIndexChanged);
            // 
            // issueFuelTab
            // 
            this.issueFuelTab.BackColor = System.Drawing.Color.Transparent;
            this.issueFuelTab.Controls.Add(this.uomComboBox);
            this.issueFuelTab.Controls.Add(this.issueFuelSaveButton);
            this.issueFuelTab.Controls.Add(this.fuelIssueDatePicker);
            this.issueFuelTab.Controls.Add(this.equipmentReadingTextbox);
            this.issueFuelTab.Controls.Add(this.issueEquipmentDirective);
            this.issueFuelTab.Controls.Add(this.comments);
            this.issueFuelTab.Controls.Add(this.fuelQtyTextbox);
            this.issueFuelTab.Controls.Add(this.label6);
            this.issueFuelTab.Controls.Add(this.label3);
            this.issueFuelTab.Controls.Add(this.label2);
            this.issueFuelTab.Controls.Add(this.label9);
            this.issueFuelTab.Controls.Add(this.label7);
            this.issueFuelTab.Controls.Add(this.label1);
            this.issueFuelTab.Controls.Add(this.equipmentIDIssue);
            this.issueFuelTab.Location = new System.Drawing.Point(4, 22);
            this.issueFuelTab.Name = "issueFuelTab";
            this.issueFuelTab.Padding = new System.Windows.Forms.Padding(3);
            this.issueFuelTab.Size = new System.Drawing.Size(750, 453);
            this.issueFuelTab.TabIndex = 0;
            this.issueFuelTab.Text = "Issue Fuel";
            // 
            // uomComboBox
            // 
            this.uomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uomComboBox.FormattingEnabled = true;
            this.uomComboBox.Items.AddRange(new object[] {
            "HR",
            "KM"});
            this.uomComboBox.Location = new System.Drawing.Point(260, 57);
            this.uomComboBox.Name = "uomComboBox";
            this.uomComboBox.Size = new System.Drawing.Size(79, 21);
            this.uomComboBox.TabIndex = 5;
            // 
            // issueFuelSaveButton
            // 
            this.issueFuelSaveButton.Location = new System.Drawing.Point(109, 137);
            this.issueFuelSaveButton.Name = "issueFuelSaveButton";
            this.issueFuelSaveButton.Size = new System.Drawing.Size(80, 20);
            this.issueFuelSaveButton.TabIndex = 4;
            this.issueFuelSaveButton.Text = "Save";
            this.issueFuelSaveButton.UseVisualStyleBackColor = true;
            this.issueFuelSaveButton.Click += new System.EventHandler(this.issueFuelSaveButton_Click);
            // 
            // fuelIssueDatePicker
            // 
            this.fuelIssueDatePicker.CustomFormat = "dd-MMM-yy hh:mm tt";
            this.fuelIssueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fuelIssueDatePicker.Location = new System.Drawing.Point(109, 111);
            this.fuelIssueDatePicker.Name = "fuelIssueDatePicker";
            this.fuelIssueDatePicker.Size = new System.Drawing.Size(143, 20);
            this.fuelIssueDatePicker.TabIndex = 3;
            this.fuelIssueDatePicker.Value = new System.DateTime(2023, 7, 17, 0, 0, 0, 0);
            this.fuelIssueDatePicker.Validated += new System.EventHandler(this.newIssueDetected);
            // 
            // equipmentReadingTextbox
            // 
            this.equipmentReadingTextbox.Location = new System.Drawing.Point(109, 59);
            this.equipmentReadingTextbox.Name = "equipmentReadingTextbox";
            this.equipmentReadingTextbox.Size = new System.Drawing.Size(80, 20);
            this.equipmentReadingTextbox.TabIndex = 2;
            this.equipmentReadingTextbox.Validated += new System.EventHandler(this.newIssueDetected);
            // 
            // issueEquipmentDirective
            // 
            this.issueEquipmentDirective.Enabled = false;
            this.issueEquipmentDirective.Location = new System.Drawing.Point(201, 6);
            this.issueEquipmentDirective.Name = "issueEquipmentDirective";
            this.issueEquipmentDirective.ReadOnly = true;
            this.issueEquipmentDirective.Size = new System.Drawing.Size(310, 20);
            this.issueEquipmentDirective.TabIndex = 2;
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(109, 85);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(251, 20);
            this.comments.TabIndex = 2;
            this.comments.Validated += new System.EventHandler(this.newIssueDetected);
            // 
            // fuelQtyTextbox
            // 
            this.fuelQtyTextbox.Location = new System.Drawing.Point(109, 33);
            this.fuelQtyTextbox.Name = "fuelQtyTextbox";
            this.fuelQtyTextbox.Size = new System.Drawing.Size(80, 20);
            this.fuelQtyTextbox.TabIndex = 2;
            this.fuelQtyTextbox.Validated += new System.EventHandler(this.newIssueDetected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Meter Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fuel Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "UoM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Comments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipment";
            // 
            // equipmentIDIssue
            // 
            this.equipmentIDIssue.DataSource = this.eQUIPMENTBindingSource_Issue;
            this.equipmentIDIssue.DisplayMember = "EQUIPMENTID";
            this.equipmentIDIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentIDIssue.FormattingEnabled = true;
            this.equipmentIDIssue.Location = new System.Drawing.Point(109, 6);
            this.equipmentIDIssue.Name = "equipmentIDIssue";
            this.equipmentIDIssue.Size = new System.Drawing.Size(80, 21);
            this.equipmentIDIssue.TabIndex = 0;
            this.equipmentIDIssue.SelectedIndexChanged += new System.EventHandler(this.equipmentID_SelectionChangeCommitted);
            // 
            // eQUIPMENTBindingSource_Issue
            // 
            this.eQUIPMENTBindingSource_Issue.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // receiveFuelTab
            // 
            this.receiveFuelTab.BackColor = System.Drawing.Color.Transparent;
            this.receiveFuelTab.Controls.Add(this.recieveFuelSaveButton);
            this.receiveFuelTab.Controls.Add(this.fuelRecievedDatePicker);
            this.receiveFuelTab.Controls.Add(this.recievedFuelQty);
            this.receiveFuelTab.Controls.Add(this.label4);
            this.receiveFuelTab.Controls.Add(this.label5);
            this.receiveFuelTab.Location = new System.Drawing.Point(4, 22);
            this.receiveFuelTab.Name = "receiveFuelTab";
            this.receiveFuelTab.Padding = new System.Windows.Forms.Padding(3);
            this.receiveFuelTab.Size = new System.Drawing.Size(750, 453);
            this.receiveFuelTab.TabIndex = 1;
            this.receiveFuelTab.Text = "Receive Fuel";
            // 
            // recieveFuelSaveButton
            // 
            this.recieveFuelSaveButton.Location = new System.Drawing.Point(78, 58);
            this.recieveFuelSaveButton.Name = "recieveFuelSaveButton";
            this.recieveFuelSaveButton.Size = new System.Drawing.Size(90, 20);
            this.recieveFuelSaveButton.TabIndex = 9;
            this.recieveFuelSaveButton.Text = "Save";
            this.recieveFuelSaveButton.UseVisualStyleBackColor = true;
            this.recieveFuelSaveButton.Click += new System.EventHandler(this.recieveFuelSaveButton_Click);
            // 
            // fuelRecievedDatePicker
            // 
            this.fuelRecievedDatePicker.CustomFormat = "dd-MMM-yy hh:mm tt";
            this.fuelRecievedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fuelRecievedDatePicker.Location = new System.Drawing.Point(78, 32);
            this.fuelRecievedDatePicker.Name = "fuelRecievedDatePicker";
            this.fuelRecievedDatePicker.Size = new System.Drawing.Size(141, 20);
            this.fuelRecievedDatePicker.TabIndex = 8;
            this.fuelRecievedDatePicker.Value = new System.DateTime(2023, 7, 17, 0, 0, 0, 0);
            // 
            // recievedFuelQty
            // 
            this.recievedFuelQty.Location = new System.Drawing.Point(78, 6);
            this.recievedFuelQty.Name = "recievedFuelQty";
            this.recievedFuelQty.Size = new System.Drawing.Size(65, 20);
            this.recievedFuelQty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fuel Quantity";
            // 
            // reportTab
            // 
            this.reportTab.BackColor = System.Drawing.Color.Transparent;
            this.reportTab.Controls.Add(this.refuelingDataGrid);
            this.reportTab.Controls.Add(this.reportEquipmentDirective);
            this.reportTab.Controls.Add(this.generateReportButton);
            this.reportTab.Controls.Add(this.toCheckBox);
            this.reportTab.Controls.Add(this.fromCheckBox);
            this.reportTab.Controls.Add(this.toDateTimePicker);
            this.reportTab.Controls.Add(this.fromDateTimePicker);
            this.reportTab.Controls.Add(this.label8);
            this.reportTab.Controls.Add(this.equipmentIDReport);
            this.reportTab.Location = new System.Drawing.Point(4, 22);
            this.reportTab.Name = "reportTab";
            this.reportTab.Size = new System.Drawing.Size(750, 453);
            this.reportTab.TabIndex = 2;
            this.reportTab.Text = "Reports";
            // 
            // refuelingDataGrid
            // 
            this.refuelingDataGrid.AllowUserToAddRows = false;
            this.refuelingDataGrid.AllowUserToDeleteRows = false;
            this.refuelingDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refuelingDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.refuelingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.refuelingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refuelingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.equipmentID,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.unitOfMeasuring,
            this.commentsColumn});
            this.refuelingDataGrid.DataSource = this.fUELINGWORKORDERBindingSource;
            this.refuelingDataGrid.Location = new System.Drawing.Point(3, 87);
            this.refuelingDataGrid.Name = "refuelingDataGrid";
            this.refuelingDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.refuelingDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.refuelingDataGrid.RowHeadersVisible = false;
            this.refuelingDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.refuelingDataGrid.Size = new System.Drawing.Size(744, 363);
            this.refuelingDataGrid.TabIndex = 13;
            this.refuelingDataGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.refuelingDataGrid_Scroll);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FUELINGDATE";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 64;
            // 
            // equipmentID
            // 
            this.equipmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentID.DataPropertyName = "EQUIPMENTID";
            this.equipmentID.HeaderText = "Equipment";
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.ReadOnly = true;
            this.equipmentID.Width = 103;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FUELQTY";
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty (Litres)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 97;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EQUIPMENTREADING";
            this.dataGridViewTextBoxColumn4.HeaderText = "Equipment Reading";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 145;
            // 
            // unitOfMeasuring
            // 
            this.unitOfMeasuring.DataPropertyName = "UOM";
            this.unitOfMeasuring.HeaderText = "UoM";
            this.unitOfMeasuring.Name = "unitOfMeasuring";
            this.unitOfMeasuring.ReadOnly = true;
            // 
            // commentsColumn
            // 
            this.commentsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentsColumn.DataPropertyName = "COMMENTS";
            this.commentsColumn.HeaderText = "Comments";
            this.commentsColumn.Name = "commentsColumn";
            this.commentsColumn.ReadOnly = true;
            // 
            // fUELINGWORKORDERBindingSource
            // 
            this.fUELINGWORKORDERBindingSource.DataSource = typeof(ODP2.Models.FUELINGWORKORDER);
            // 
            // reportEquipmentDirective
            // 
            this.reportEquipmentDirective.Enabled = false;
            this.reportEquipmentDirective.Location = new System.Drawing.Point(147, 8);
            this.reportEquipmentDirective.Name = "reportEquipmentDirective";
            this.reportEquipmentDirective.ReadOnly = true;
            this.reportEquipmentDirective.Size = new System.Drawing.Size(245, 20);
            this.reportEquipmentDirective.TabIndex = 10;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(67, 61);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(132, 20);
            this.generateReportButton.TabIndex = 9;
            this.generateReportButton.Text = "Generate";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // toCheckBox
            // 
            this.toCheckBox.AutoSize = true;
            this.toCheckBox.Location = new System.Drawing.Point(215, 38);
            this.toCheckBox.Name = "toCheckBox";
            this.toCheckBox.Size = new System.Drawing.Size(39, 17);
            this.toCheckBox.TabIndex = 8;
            this.toCheckBox.Text = "To";
            this.toCheckBox.UseVisualStyleBackColor = true;
            this.toCheckBox.CheckedChanged += new System.EventHandler(this.toDateTimeCheckBox_CheckedChanged);
            // 
            // fromCheckBox
            // 
            this.fromCheckBox.AutoSize = true;
            this.fromCheckBox.Location = new System.Drawing.Point(12, 38);
            this.fromCheckBox.Name = "fromCheckBox";
            this.fromCheckBox.Size = new System.Drawing.Size(49, 17);
            this.fromCheckBox.TabIndex = 8;
            this.fromCheckBox.Text = "From";
            this.fromCheckBox.UseVisualStyleBackColor = true;
            this.fromCheckBox.CheckedChanged += new System.EventHandler(this.fromDateTimeCheckBox_CheckedChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            this.toDateTimePicker.Enabled = false;
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(260, 35);
            this.toDateTimePicker.MaxDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.toDateTimePicker.TabIndex = 7;
            this.toDateTimePicker.Value = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            this.fromDateTimePicker.Enabled = false;
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(67, 35);
            this.fromDateTimePicker.MaxDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.fromDateTimePicker.TabIndex = 7;
            this.fromDateTimePicker.Value = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Equipment";
            // 
            // equipmentIDReport
            // 
            this.equipmentIDReport.DataSource = this.eQUIPMENTBindingSource_Report;
            this.equipmentIDReport.DisplayMember = "EQUIPMENTID";
            this.equipmentIDReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentIDReport.FormattingEnabled = true;
            this.equipmentIDReport.Location = new System.Drawing.Point(67, 8);
            this.equipmentIDReport.Name = "equipmentIDReport";
            this.equipmentIDReport.Size = new System.Drawing.Size(74, 21);
            this.equipmentIDReport.TabIndex = 4;
            this.equipmentIDReport.SelectedIndexChanged += new System.EventHandler(this.equipmentID_SelectionChangeCommitted);
            // 
            // eQUIPMENTBindingSource_Report
            // 
            this.eQUIPMENTBindingSource_Report.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // fuelStockLevel
            // 
            this.fuelStockLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelStockLevel.Enabled = false;
            this.fuelStockLevel.LargeChange = 50;
            this.fuelStockLevel.Location = new System.Drawing.Point(776, 12);
            this.fuelStockLevel.Maximum = 100;
            this.fuelStockLevel.Name = "fuelStockLevel";
            this.fuelStockLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fuelStockLevel.Size = new System.Drawing.Size(45, 168);
            this.fuelStockLevel.SmallChange = 20;
            this.fuelStockLevel.TabIndex = 10;
            this.fuelStockLevel.Value = 2;
            // 
            // fuelStockPercentage
            // 
            this.fuelStockPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelStockPercentage.AutoSize = true;
            this.fuelStockPercentage.Location = new System.Drawing.Point(829, 113);
            this.fuelStockPercentage.Name = "fuelStockPercentage";
            this.fuelStockPercentage.Size = new System.Drawing.Size(30, 13);
            this.fuelStockPercentage.TabIndex = 1;
            this.fuelStockPercentage.Text = "20 %";
            // 
            // fuelStockQty
            // 
            this.fuelStockQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelStockQty.AutoSize = true;
            this.fuelStockQty.Location = new System.Drawing.Point(829, 126);
            this.fuelStockQty.Name = "fuelStockQty";
            this.fuelStockQty.Size = new System.Drawing.Size(48, 13);
            this.fuelStockQty.TabIndex = 1;
            this.fuelStockQty.Text = "500 Litre";
            // 
            // fuelingWorkOrderID
            // 
            this.fuelingWorkOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fuelingWorkOrderID.DataPropertyName = "FUELINGWORKORDER1";
            this.fuelingWorkOrderID.HeaderText = "ID";
            this.fuelingWorkOrderID.Name = "fuelingWorkOrderID";
            // 
            // FuelStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fuelStockLevel);
            this.Controls.Add(this.FuelStationTab);
            this.Controls.Add(this.fuelStockQty);
            this.Controls.Add(this.fuelStockPercentage);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FuelStation";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(885, 499);
            this.Load += new System.EventHandler(this.FuelStation_Load);
            this.FuelStationTab.ResumeLayout(false);
            this.issueFuelTab.ResumeLayout(false);
            this.issueFuelTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTBindingSource_Issue)).EndInit();
            this.receiveFuelTab.ResumeLayout(false);
            this.receiveFuelTab.PerformLayout();
            this.reportTab.ResumeLayout(false);
            this.reportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refuelingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUELINGWORKORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTBindingSource_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStockLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl FuelStationTab;
        private System.Windows.Forms.TabPage issueFuelTab;
        private System.Windows.Forms.Button issueFuelSaveButton;
        private System.Windows.Forms.DateTimePicker fuelIssueDatePicker;
        private System.Windows.Forms.TextBox equipmentReadingTextbox;
        private System.Windows.Forms.TextBox issueEquipmentDirective;
        private System.Windows.Forms.TextBox fuelQtyTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipmentIDIssue;
        private System.Windows.Forms.TabPage receiveFuelTab;
        private System.Windows.Forms.Button recieveFuelSaveButton;
        private System.Windows.Forms.DateTimePicker fuelRecievedDatePicker;
        private System.Windows.Forms.TextBox recievedFuelQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.CheckBox fromCheckBox;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox equipmentIDReport;
        private System.Windows.Forms.TextBox reportEquipmentDirective;
        private System.Windows.Forms.TrackBar fuelStockLevel;
        private System.Windows.Forms.Label fuelStockPercentage;
        private System.Windows.Forms.Label fuelStockQty;
        private System.Windows.Forms.DataGridView refuelingDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelingWorkOrder1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fUELINGWORKORDERBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelingWorkOrderID;
        private System.Windows.Forms.BindingSource eQUIPMENTBindingSource_Issue;
        private System.Windows.Forms.BindingSource eQUIPMENTBindingSource_Report;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox uomComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeasuring;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsColumn;
        private System.Windows.Forms.CheckBox toCheckBox;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
    }
}
