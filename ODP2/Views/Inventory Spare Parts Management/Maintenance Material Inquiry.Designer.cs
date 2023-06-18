namespace ODP2.Views.Inventory_Spare_Parts_Management
{
    partial class MaintenanceMaterialInquiry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sparePartGridView = new System.Windows.Forms.DataGridView();
            this.workOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedPartDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.equipmentDirective = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toDateCheckBox = new System.Windows.Forms.CheckBox();
            this.fromDateCheckBox = new System.Windows.Forms.CheckBox();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.equipmentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partDescription = new System.Windows.Forms.TextBox();
            this.sparePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sparePartGridView
            // 
            this.sparePartGridView.AllowUserToAddRows = false;
            this.sparePartGridView.AllowUserToDeleteRows = false;
            this.sparePartGridView.AllowUserToOrderColumns = true;
            this.sparePartGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sparePartGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sparePartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sparePartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sparePartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workOrder,
            this.equipmentID,
            this.workOrderDirective,
            this.sparePartCode,
            this.issuedPartDescription,
            this.qty,
            this.issueDateDataGridViewTextBoxColumn,
            this.issueState});
            this.sparePartGridView.DataSource = this.issueBindingSource;
            this.sparePartGridView.Location = new System.Drawing.Point(8, 133);
            this.sparePartGridView.Name = "sparePartGridView";
            this.sparePartGridView.RowHeadersVisible = false;
            this.sparePartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sparePartGridView.Size = new System.Drawing.Size(817, 354);
            this.sparePartGridView.TabIndex = 6;
            // 
            // workOrder
            // 
            this.workOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrder.DataPropertyName = "workOrderID";
            this.workOrder.HeaderText = "Work Order";
            this.workOrder.Name = "workOrder";
            this.workOrder.Width = 91;
            // 
            // equipmentID
            // 
            this.equipmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.equipmentID.DataPropertyName = "workOrderEquipmentID";
            this.equipmentID.HeaderText = "Equipment ID";
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.Width = 99;
            // 
            // workOrderDirective
            // 
            this.workOrderDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workOrderDirective.DataPropertyName = "workOrderDirective";
            this.workOrderDirective.HeaderText = "Work Order Directive";
            this.workOrderDirective.Name = "workOrderDirective";
            // 
            // sparePartCode
            // 
            this.sparePartCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sparePartCode.DataPropertyName = "sparePartCode";
            this.sparePartCode.HeaderText = "Part Code";
            this.sparePartCode.Name = "sparePartCode";
            this.sparePartCode.Width = 79;
            // 
            // issuedPartDescription
            // 
            this.issuedPartDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issuedPartDescription.DataPropertyName = "partDirective";
            this.issuedPartDescription.HeaderText = "Part Description";
            this.issuedPartDescription.Name = "issuedPartDescription";
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.Width = 52;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "issueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.Width = 83;
            // 
            // issueState
            // 
            this.issueState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueState.DataPropertyName = "issueState";
            this.issueState.HeaderText = "Issue State";
            this.issueState.Name = "issueState";
            this.issueState.Width = 86;
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataSource = typeof(ODP2.Models.issue);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(89, 86);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // equipmentDirective
            // 
            this.equipmentDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentDirective", true));
            this.equipmentDirective.Location = new System.Drawing.Point(182, 8);
            this.equipmentDirective.Name = "equipmentDirective";
            this.equipmentDirective.ReadOnly = true;
            this.equipmentDirective.Size = new System.Drawing.Size(325, 20);
            this.equipmentDirective.TabIndex = 13;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.equipment);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Part Code";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.toDateCheckBox);
            this.panel1.Controls.Add(this.fromDateCheckBox);
            this.panel1.Controls.Add(this.toDatePicker);
            this.panel1.Controls.Add(this.fromDatePicker);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.equipmentBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.partDescription);
            this.panel1.Controls.Add(this.partCode);
            this.panel1.Controls.Add(this.equipmentDirective);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(817, 121);
            this.panel1.TabIndex = 7;
            // 
            // toDateCheckBox
            // 
            this.toDateCheckBox.AutoSize = true;
            this.toDateCheckBox.Location = new System.Drawing.Point(223, 63);
            this.toDateCheckBox.Name = "toDateCheckBox";
            this.toDateCheckBox.Size = new System.Drawing.Size(65, 17);
            this.toDateCheckBox.TabIndex = 20;
            this.toDateCheckBox.Text = "To Date";
            this.toDateCheckBox.UseVisualStyleBackColor = true;
            this.toDateCheckBox.CheckedChanged += new System.EventHandler(this.toDateCheckBox_CheckedChanged);
            // 
            // fromDateCheckBox
            // 
            this.fromDateCheckBox.AutoSize = true;
            this.fromDateCheckBox.Location = new System.Drawing.Point(8, 60);
            this.fromDateCheckBox.Name = "fromDateCheckBox";
            this.fromDateCheckBox.Size = new System.Drawing.Size(75, 17);
            this.fromDateCheckBox.TabIndex = 21;
            this.fromDateCheckBox.Text = "From Date";
            this.fromDateCheckBox.UseVisualStyleBackColor = true;
            this.fromDateCheckBox.CheckedChanged += new System.EventHandler(this.fromDateCheckBox_CheckedChanged);
            // 
            // toDatePicker
            // 
            this.toDatePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.toDatePicker.Enabled = false;
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePicker.Location = new System.Drawing.Point(294, 60);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(125, 20);
            this.toDatePicker.TabIndex = 18;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.fromDatePicker.Enabled = false;
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(89, 60);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(128, 20);
            this.fromDatePicker.TabIndex = 19;
            // 
            // equipmentBox
            // 
            this.equipmentBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentID", true));
            this.equipmentBox.Location = new System.Drawing.Point(89, 8);
            this.equipmentBox.Name = "equipmentBox";
            this.equipmentBox.Size = new System.Drawing.Size(87, 20);
            this.equipmentBox.TabIndex = 11;
            this.equipmentBox.LostFocus += new System.EventHandler(this.equipmentBox_LostFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Equipment ID";
            // 
            // partDescription
            // 
            this.partDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "partDirective", true));
            this.partDescription.Location = new System.Drawing.Point(271, 34);
            this.partDescription.Name = "partDescription";
            this.partDescription.ReadOnly = true;
            this.partDescription.Size = new System.Drawing.Size(236, 20);
            this.partDescription.TabIndex = 12;
            // 
            // sparePartBindingSource
            // 
            this.sparePartBindingSource.DataSource = typeof(ODP2.Models.sparePart);
            // 
            // partCode
            // 
            this.partCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "partCode", true));
            this.partCode.Location = new System.Drawing.Point(89, 34);
            this.partCode.Name = "partCode";
            this.partCode.Size = new System.Drawing.Size(176, 20);
            this.partCode.TabIndex = 12;
            this.partCode.LostFocus += new System.EventHandler(this.partCode_LostFocus);
            // 
            // MaintenanceMaterialInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sparePartGridView);
            this.Controls.Add(this.panel1);
            this.Name = "MaintenanceMaterialInquiry";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(834, 495);
            this.Load += new System.EventHandler(this.MaintenanceMaterialInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sparePartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sparePartGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox equipmentDirective;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partCode;
        private System.Windows.Forms.TextBox equipmentBox;
        private System.Windows.Forms.CheckBox toDateCheckBox;
        private System.Windows.Forms.CheckBox fromDateCheckBox;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private System.Windows.Forms.TextBox partDescription;
        private System.Windows.Forms.BindingSource sparePartBindingSource;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderDirective;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedPartDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueState;
    }
}
