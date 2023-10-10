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
            this.issueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sparePartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sparePartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sparePartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueID,
            this.sparePart,
            this.WorkOrderID,
            this.workOrderDirective,
            this.partDirective,
            this.equipmentID,
            this.QtyTextBox,
            this.RequestDate,
            this.State});
            this.sparePartGridView.DataSource = this.issueBindingSource;
            this.sparePartGridView.Location = new System.Drawing.Point(8, 133);
            this.sparePartGridView.Name = "sparePartGridView";
            this.sparePartGridView.ReadOnly = true;
            this.sparePartGridView.RowHeadersVisible = false;
            this.sparePartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sparePartGridView.Size = new System.Drawing.Size(817, 354);
            this.sparePartGridView.TabIndex = 6;
            // 
            // issueID
            // 
            this.issueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueID.DataPropertyName = "ISSUEID";
            this.issueID.HeaderText = "Issue #";
            this.issueID.Name = "issueID";
            this.issueID.ReadOnly = true;
            this.issueID.Width = 72;
            // 
            // sparePart
            // 
            this.sparePart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sparePart.DataPropertyName = "SPAREPARTCODE";
            this.sparePart.HeaderText = "Part Code";
            this.sparePart.Name = "sparePart";
            this.sparePart.ReadOnly = true;
            this.sparePart.Width = 88;
            // 
            // WorkOrderID
            // 
            this.WorkOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WorkOrderID.DataPropertyName = "WORKORDERID";
            this.WorkOrderID.HeaderText = "WO#";
            this.WorkOrderID.Name = "WorkOrderID";
            this.WorkOrderID.ReadOnly = true;
            this.WorkOrderID.Width = 61;
            // 
            // workOrderDirective
            // 
            this.workOrderDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workOrderDirective.DataPropertyName = "WORKORDERDIRECTIVE";
            this.workOrderDirective.HeaderText = "Work Order Directive";
            this.workOrderDirective.Name = "workOrderDirective";
            this.workOrderDirective.ReadOnly = true;
            // 
            // partDirective
            // 
            this.partDirective.DataPropertyName = "PARTDIRECTIVE";
            this.partDirective.HeaderText = "Part Description";
            this.partDirective.Name = "partDirective";
            this.partDirective.ReadOnly = true;
            // 
            // equipmentID
            // 
            this.equipmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentID.DataPropertyName = "WORKORDEREQUIPMENTID";
            this.equipmentID.HeaderText = "Equipment";
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.ReadOnly = true;
            this.equipmentID.Width = 103;
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QtyTextBox.DataPropertyName = "QTY";
            this.QtyTextBox.HeaderText = "QTY";
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.ReadOnly = true;
            this.QtyTextBox.Width = 59;
            // 
            // RequestDate
            // 
            this.RequestDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RequestDate.DataPropertyName = "ISSUEDATE";
            this.RequestDate.HeaderText = "Issue Date";
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.ReadOnly = true;
            this.RequestDate.Width = 94;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.State.DataPropertyName = "ISSUESTATE";
            this.State.HeaderText = "Issue State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 98;
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
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
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
            this.toDateCheckBox.Location = new System.Drawing.Point(239, 63);
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
            this.toDatePicker.CustomFormat = "dd-MMM-yy hh:mm tt";
            this.toDatePicker.Enabled = false;
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePicker.Location = new System.Drawing.Point(310, 60);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(141, 20);
            this.toDatePicker.TabIndex = 18;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "dd-MMM-yy hh:mm tt";
            this.fromDatePicker.Enabled = false;
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(89, 60);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(144, 20);
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
            this.sparePartBindingSource.DataSource = typeof(ODP2.Models.SPAREPART);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueState;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePart;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderDirective;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDirective;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}
