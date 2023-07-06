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
            this.FuelStationTab = new System.Windows.Forms.TabControl();
            this.issueFuelTab = new System.Windows.Forms.TabPage();
            this.issueFuelSaveButton = new System.Windows.Forms.Button();
            this.fuelIssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.equipmentReadingTextbox = new System.Windows.Forms.TextBox();
            this.equipmentDirective = new System.Windows.Forms.TextBox();
            this.fuelQtyTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentIDIssue = new System.Windows.Forms.ComboBox();
            this.receiveFuelTab = new System.Windows.Forms.TabPage();
            this.recieveFuelSaveButton = new System.Windows.Forms.Button();
            this.fuelRecievedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.recievedFuelQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.equipmentIDReports = new System.Windows.Forms.TextBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.equipmentIDReport = new System.Windows.Forms.ComboBox();
            this.fuelStockLevel = new System.Windows.Forms.TrackBar();
            this.fuelStockPercentage = new System.Windows.Forms.Label();
            this.fuelStockQty = new System.Windows.Forms.Label();
            this.refuelingDataGrid = new System.Windows.Forms.DataGridView();
            this.fuelingWorkOrder1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelingWorkOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FuelStationTab.SuspendLayout();
            this.issueFuelTab.SuspendLayout();
            this.receiveFuelTab.SuspendLayout();
            this.reportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStockLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refuelingDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelingWorkOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FuelStationTab
            // 
            this.FuelStationTab.Controls.Add(this.issueFuelTab);
            this.FuelStationTab.Controls.Add(this.receiveFuelTab);
            this.FuelStationTab.Controls.Add(this.reportTab);
            this.FuelStationTab.Location = new System.Drawing.Point(8, 8);
            this.FuelStationTab.Multiline = true;
            this.FuelStationTab.Name = "FuelStationTab";
            this.FuelStationTab.SelectedIndex = 0;
            this.FuelStationTab.Size = new System.Drawing.Size(469, 172);
            this.FuelStationTab.TabIndex = 5;
            // 
            // issueFuelTab
            // 
            this.issueFuelTab.BackColor = System.Drawing.Color.Transparent;
            this.issueFuelTab.Controls.Add(this.issueFuelSaveButton);
            this.issueFuelTab.Controls.Add(this.fuelIssueDatePicker);
            this.issueFuelTab.Controls.Add(this.equipmentReadingTextbox);
            this.issueFuelTab.Controls.Add(this.equipmentDirective);
            this.issueFuelTab.Controls.Add(this.fuelQtyTextbox);
            this.issueFuelTab.Controls.Add(this.label6);
            this.issueFuelTab.Controls.Add(this.label3);
            this.issueFuelTab.Controls.Add(this.label2);
            this.issueFuelTab.Controls.Add(this.label1);
            this.issueFuelTab.Controls.Add(this.equipmentIDIssue);
            this.issueFuelTab.Location = new System.Drawing.Point(4, 22);
            this.issueFuelTab.Name = "issueFuelTab";
            this.issueFuelTab.Padding = new System.Windows.Forms.Padding(3);
            this.issueFuelTab.Size = new System.Drawing.Size(461, 146);
            this.issueFuelTab.TabIndex = 0;
            this.issueFuelTab.Text = "Issue Fuel";
            // 
            // issueFuelSaveButton
            // 
            this.issueFuelSaveButton.Location = new System.Drawing.Point(109, 111);
            this.issueFuelSaveButton.Name = "issueFuelSaveButton";
            this.issueFuelSaveButton.Size = new System.Drawing.Size(130, 20);
            this.issueFuelSaveButton.TabIndex = 4;
            this.issueFuelSaveButton.Text = "Save";
            this.issueFuelSaveButton.UseVisualStyleBackColor = true;
            this.issueFuelSaveButton.Click += new System.EventHandler(this.issueFuelSaveButton_Click);
            // 
            // fuelIssueDatePicker
            // 
            this.fuelIssueDatePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.fuelIssueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fuelIssueDatePicker.Location = new System.Drawing.Point(109, 85);
            this.fuelIssueDatePicker.MaxDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.fuelIssueDatePicker.Name = "fuelIssueDatePicker";
            this.fuelIssueDatePicker.Size = new System.Drawing.Size(130, 20);
            this.fuelIssueDatePicker.TabIndex = 3;
            this.fuelIssueDatePicker.Value = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            // 
            // equipmentReadingTextbox
            // 
            this.equipmentReadingTextbox.Location = new System.Drawing.Point(109, 59);
            this.equipmentReadingTextbox.Name = "equipmentReadingTextbox";
            this.equipmentReadingTextbox.Size = new System.Drawing.Size(80, 20);
            this.equipmentReadingTextbox.TabIndex = 2;
            // 
            // equipmentDirective
            // 
            this.equipmentDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentDirective", true));
            this.equipmentDirective.Enabled = false;
            this.equipmentDirective.Location = new System.Drawing.Point(201, 6);
            this.equipmentDirective.Name = "equipmentDirective";
            this.equipmentDirective.Size = new System.Drawing.Size(251, 20);
            this.equipmentDirective.TabIndex = 2;
            // 
            // fuelQtyTextbox
            // 
            this.fuelQtyTextbox.Location = new System.Drawing.Point(109, 33);
            this.fuelQtyTextbox.Name = "fuelQtyTextbox";
            this.fuelQtyTextbox.Size = new System.Drawing.Size(80, 20);
            this.fuelQtyTextbox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Equipment Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 85);
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
            this.equipmentIDIssue.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.equipmentBindingSource, "equipmentID", true));
            this.equipmentIDIssue.DisplayMember = "equipmentID";
            this.equipmentIDIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentIDIssue.FormattingEnabled = true;
            this.equipmentIDIssue.Location = new System.Drawing.Point(109, 6);
            this.equipmentIDIssue.Name = "equipmentIDIssue";
            this.equipmentIDIssue.Size = new System.Drawing.Size(80, 21);
            this.equipmentIDIssue.TabIndex = 0;
            this.equipmentIDIssue.SelectedIndexChanged += new System.EventHandler(this.equipmentID_SelectionChangeCommitted);
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
            this.receiveFuelTab.Size = new System.Drawing.Size(461, 146);
            this.receiveFuelTab.TabIndex = 1;
            this.receiveFuelTab.Text = "Receive Fuel";
            // 
            // recieveFuelSaveButton
            // 
            this.recieveFuelSaveButton.Location = new System.Drawing.Point(78, 58);
            this.recieveFuelSaveButton.Name = "recieveFuelSaveButton";
            this.recieveFuelSaveButton.Size = new System.Drawing.Size(130, 20);
            this.recieveFuelSaveButton.TabIndex = 9;
            this.recieveFuelSaveButton.Text = "Save";
            this.recieveFuelSaveButton.UseVisualStyleBackColor = true;
            this.recieveFuelSaveButton.Click += new System.EventHandler(this.recieveFuelSaveButton_Click);
            // 
            // fuelRecievedDatePicker
            // 
            this.fuelRecievedDatePicker.CustomFormat = "dd/MM/yyyy hh:mm";
            this.fuelRecievedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fuelRecievedDatePicker.Location = new System.Drawing.Point(78, 32);
            this.fuelRecievedDatePicker.MaxDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.fuelRecievedDatePicker.Name = "fuelRecievedDatePicker";
            this.fuelRecievedDatePicker.Size = new System.Drawing.Size(130, 20);
            this.fuelRecievedDatePicker.TabIndex = 8;
            this.fuelRecievedDatePicker.Value = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
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
            this.reportTab.Controls.Add(this.equipmentIDReports);
            this.reportTab.Controls.Add(this.generateReportButton);
            this.reportTab.Controls.Add(this.checkBox1);
            this.reportTab.Controls.Add(this.dateTimePicker3);
            this.reportTab.Controls.Add(this.label8);
            this.reportTab.Controls.Add(this.equipmentIDReport);
            this.reportTab.Location = new System.Drawing.Point(4, 22);
            this.reportTab.Name = "reportTab";
            this.reportTab.Size = new System.Drawing.Size(461, 146);
            this.reportTab.TabIndex = 2;
            this.reportTab.Text = "Reports";
            // 
            // equipmentIDReports
            // 
            this.equipmentIDReports.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource1, "equipmentDirective", true));
            this.equipmentIDReports.Enabled = false;
            this.equipmentIDReports.Location = new System.Drawing.Point(147, 8);
            this.equipmentIDReports.Name = "equipmentIDReports";
            this.equipmentIDReports.Size = new System.Drawing.Size(242, 20);
            this.equipmentIDReports.TabIndex = 10;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(67, 61);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(132, 20);
            this.generateReportButton.TabIndex = 9;
            this.generateReportButton.Text = "Generate";
            this.generateReportButton.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Date";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(67, 35);
            this.dateTimePicker3.MaxDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker3.TabIndex = 7;
            this.dateTimePicker3.Value = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
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
            this.equipmentIDReport.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.equipmentBindingSource1, "equipmentID", true));
            this.equipmentIDReport.DisplayMember = "equipmentID";
            this.equipmentIDReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentIDReport.FormattingEnabled = true;
            this.equipmentIDReport.Location = new System.Drawing.Point(67, 8);
            this.equipmentIDReport.Name = "equipmentIDReport";
            this.equipmentIDReport.Size = new System.Drawing.Size(74, 21);
            this.equipmentIDReport.TabIndex = 4;
            this.equipmentIDReport.SelectionChangeCommitted += new System.EventHandler(this.equipmentID_SelectionChangeCommitted);
            // 
            // fuelStockLevel
            // 
            this.fuelStockLevel.Enabled = false;
            this.fuelStockLevel.LargeChange = 50;
            this.fuelStockLevel.Location = new System.Drawing.Point(559, 12);
            this.fuelStockLevel.Maximum = 100;
            this.fuelStockLevel.Name = "fuelStockLevel";
            this.fuelStockLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fuelStockLevel.Size = new System.Drawing.Size(45, 168);
            this.fuelStockLevel.SmallChange = 20;
            this.fuelStockLevel.TabIndex = 10;
            this.fuelStockLevel.Value = 2;
            this.fuelStockLevel.ValueChanged += new System.EventHandler(this.fuelLevelChanged);
            // 
            // fuelStockPercentage
            // 
            this.fuelStockPercentage.AutoSize = true;
            this.fuelStockPercentage.Location = new System.Drawing.Point(610, 80);
            this.fuelStockPercentage.Name = "fuelStockPercentage";
            this.fuelStockPercentage.Size = new System.Drawing.Size(30, 13);
            this.fuelStockPercentage.TabIndex = 1;
            this.fuelStockPercentage.Text = "20 %";
            // 
            // fuelStockQty
            // 
            this.fuelStockQty.AutoSize = true;
            this.fuelStockQty.Location = new System.Drawing.Point(610, 96);
            this.fuelStockQty.Name = "fuelStockQty";
            this.fuelStockQty.Size = new System.Drawing.Size(34, 13);
            this.fuelStockQty.TabIndex = 1;
            this.fuelStockQty.Text = "500 L";
            // 
            // refuelingDataGrid
            // 
            this.refuelingDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refuelingDataGrid.AutoGenerateColumns = false;
            this.refuelingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refuelingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fuelingWorkOrder1DataGridViewTextBoxColumn,
            this.equipmentIDDataGridViewTextBoxColumn,
            this.fuelQtyDataGridViewTextBoxColumn,
            this.equipmentReadingDataGridViewTextBoxColumn,
            this.fuelingDateDataGridViewTextBoxColumn});
            this.refuelingDataGrid.DataSource = this.fuelingWorkOrderBindingSource;
            this.refuelingDataGrid.Location = new System.Drawing.Point(8, 186);
            this.refuelingDataGrid.Name = "refuelingDataGrid";
            this.refuelingDataGrid.Size = new System.Drawing.Size(934, 303);
            this.refuelingDataGrid.TabIndex = 13;
            // 
            // fuelingWorkOrder1DataGridViewTextBoxColumn
            // 
            this.fuelingWorkOrder1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fuelingWorkOrder1DataGridViewTextBoxColumn.DataPropertyName = "fuelingWorkOrder1";
            this.fuelingWorkOrder1DataGridViewTextBoxColumn.HeaderText = "Fueling ID";
            this.fuelingWorkOrder1DataGridViewTextBoxColumn.Name = "fuelingWorkOrder1DataGridViewTextBoxColumn";
            this.fuelingWorkOrder1DataGridViewTextBoxColumn.Width = 80;
            // 
            // equipmentIDDataGridViewTextBoxColumn
            // 
            this.equipmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentIDDataGridViewTextBoxColumn.DataPropertyName = "equipmentID";
            this.equipmentIDDataGridViewTextBoxColumn.HeaderText = "Equipment ID";
            this.equipmentIDDataGridViewTextBoxColumn.Name = "equipmentIDDataGridViewTextBoxColumn";
            this.equipmentIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // fuelQtyDataGridViewTextBoxColumn
            // 
            this.fuelQtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fuelQtyDataGridViewTextBoxColumn.DataPropertyName = "fuelQty";
            this.fuelQtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.fuelQtyDataGridViewTextBoxColumn.Name = "fuelQtyDataGridViewTextBoxColumn";
            // 
            // equipmentReadingDataGridViewTextBoxColumn
            // 
            this.equipmentReadingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipmentReadingDataGridViewTextBoxColumn.DataPropertyName = "equipmentReading";
            this.equipmentReadingDataGridViewTextBoxColumn.HeaderText = "Equipment Reading";
            this.equipmentReadingDataGridViewTextBoxColumn.Name = "equipmentReadingDataGridViewTextBoxColumn";
            // 
            // fuelingDateDataGridViewTextBoxColumn
            // 
            this.fuelingDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fuelingDateDataGridViewTextBoxColumn.DataPropertyName = "fuelingDate";
            this.fuelingDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.fuelingDateDataGridViewTextBoxColumn.Name = "fuelingDateDataGridViewTextBoxColumn";
            this.fuelingDateDataGridViewTextBoxColumn.Width = 55;
            // 
            // fuelingWorkOrderBindingSource
            // 
            this.fuelingWorkOrderBindingSource.DataSource = typeof(ODP2.Models.FUELINGWORKORDER);
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // equipmentBindingSource1
            // 
            this.equipmentBindingSource1.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // FuelStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refuelingDataGrid);
            this.Controls.Add(this.fuelStockLevel);
            this.Controls.Add(this.FuelStationTab);
            this.Controls.Add(this.fuelStockQty);
            this.Controls.Add(this.fuelStockPercentage);
            this.Name = "FuelStation";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(950, 497);
            this.Load += new System.EventHandler(this.FuelStation_Load);
            this.FuelStationTab.ResumeLayout(false);
            this.issueFuelTab.ResumeLayout(false);
            this.issueFuelTab.PerformLayout();
            this.receiveFuelTab.ResumeLayout(false);
            this.receiveFuelTab.PerformLayout();
            this.reportTab.ResumeLayout(false);
            this.reportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refuelingDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelingWorkOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl FuelStationTab;
        private System.Windows.Forms.TabPage issueFuelTab;
        private System.Windows.Forms.Button issueFuelSaveButton;
        private System.Windows.Forms.DateTimePicker fuelIssueDatePicker;
        private System.Windows.Forms.TextBox equipmentReadingTextbox;
        private System.Windows.Forms.TextBox equipmentDirective;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox equipmentIDReport;
        private System.Windows.Forms.TextBox equipmentIDReports;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.TrackBar fuelStockLevel;
        private System.Windows.Forms.Label fuelStockPercentage;
        private System.Windows.Forms.Label fuelStockQty;
        private System.Windows.Forms.BindingSource equipmentBindingSource1;
        private System.Windows.Forms.BindingSource fuelingWorkOrderBindingSource;
        private System.Windows.Forms.DataGridView refuelingDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelingWorkOrder1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelingDateDataGridViewTextBoxColumn;
    }
}
