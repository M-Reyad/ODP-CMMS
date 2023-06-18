using System.Windows.Forms;

namespace ODP2
{
    partial class ClosedWorkOrders
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
            this.equipmentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.workOrderBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.closedWorkOrdersGrid = new System.Windows.Forms.DataGridView();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toDateCheckBox = new System.Windows.Forms.CheckBox();
            this.fromDateCheckBox = new System.Windows.Forms.CheckBox();
            this.workTypeBox = new System.Windows.Forms.ComboBox();
            this.workOrderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workTypeDirective = new System.Windows.Forms.TextBox();
            this.equipmentDirective = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.directiveTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openWorkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderDirectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderEquipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderCreatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderRegisterationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDoneDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderFinishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDoneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.closedWorkOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentBox
            // 
            this.equipmentBox.Location = new System.Drawing.Point(69, 37);
            this.equipmentBox.Name = "equipmentBox";
            this.equipmentBox.Size = new System.Drawing.Size(86, 20);
            this.equipmentBox.TabIndex = 0;
            this.equipmentBox.LostFocus += new System.EventHandler(this.equipmentBox_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipment";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(69, 153);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(86, 20);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // workOrderBox
            // 
            this.workOrderBox.Location = new System.Drawing.Point(69, 12);
            this.workOrderBox.Name = "workOrderBox";
            this.workOrderBox.Size = new System.Drawing.Size(86, 20);
            this.workOrderBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Work Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Work Type";
            // 
            // closedWorkOrdersGrid
            // 
            this.closedWorkOrdersGrid.AllowDrop = true;
            this.closedWorkOrdersGrid.AllowUserToAddRows = false;
            this.closedWorkOrdersGrid.AllowUserToDeleteRows = false;
            this.closedWorkOrdersGrid.AllowUserToOrderColumns = true;
            this.closedWorkOrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closedWorkOrdersGrid.AutoGenerateColumns = false;
            this.closedWorkOrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.closedWorkOrdersGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.closedWorkOrdersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.closedWorkOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closedWorkOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workOrderIDDataGridViewTextBoxColumn,
            this.workOrderDirectiveDataGridViewTextBoxColumn,
            this.workOrderEquipmentIDDataGridViewTextBoxColumn,
            this.workOrderStatusIDDataGridViewTextBoxColumn,
            this.workOrderTypeIDDataGridViewTextBoxColumn,
            this.workOrderCreatorIDDataGridViewTextBoxColumn,
            this.workOrderRegisterationDateDataGridViewTextBoxColumn,
            this.workStartDateDataGridViewTextBoxColumn,
            this.workDoneDateDataGridViewTextBoxColumn,
            this.workOrderFinishDateDataGridViewTextBoxColumn,
            this.workDoneTypeDataGridViewTextBoxColumn});
            this.closedWorkOrdersGrid.DataSource = this.workOrderBindingSource;
            this.closedWorkOrdersGrid.Location = new System.Drawing.Point(15, 211);
            this.closedWorkOrdersGrid.Name = "closedWorkOrdersGrid";
            this.closedWorkOrdersGrid.ReadOnly = true;
            this.closedWorkOrdersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.closedWorkOrdersGrid.RowTemplate.Height = 25;
            this.closedWorkOrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.closedWorkOrdersGrid.Size = new System.Drawing.Size(974, 258);
            this.closedWorkOrdersGrid.TabIndex = 3;
            this.closedWorkOrdersGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.closedWorkOrdersGrid_MouseDoubleClick);
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.DataSource = typeof(ODP2.Models.workOrder);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.fromDatePicker.Enabled = false;
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(89, 119);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(128, 20);
            this.fromDatePicker.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.toDateCheckBox);
            this.panel1.Controls.Add(this.fromDateCheckBox);
            this.panel1.Controls.Add(this.workTypeBox);
            this.panel1.Controls.Add(this.workTypeDirective);
            this.panel1.Controls.Add(this.equipmentDirective);
            this.panel1.Controls.Add(this.equipmentBox);
            this.panel1.Controls.Add(this.toDatePicker);
            this.panel1.Controls.Add(this.fromDatePicker);
            this.panel1.Controls.Add(this.directiveTextBox);
            this.panel1.Controls.Add(this.workOrderBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 190);
            this.panel1.TabIndex = 5;
            // 
            // toDateCheckBox
            // 
            this.toDateCheckBox.AutoSize = true;
            this.toDateCheckBox.Location = new System.Drawing.Point(234, 121);
            this.toDateCheckBox.Name = "toDateCheckBox";
            this.toDateCheckBox.Size = new System.Drawing.Size(65, 17);
            this.toDateCheckBox.TabIndex = 7;
            this.toDateCheckBox.Text = "To Date";
            this.toDateCheckBox.UseVisualStyleBackColor = true;
            this.toDateCheckBox.CheckedChanged += new System.EventHandler(this.toDateCheckBox_CheckedChanged);
            // 
            // fromDateCheckBox
            // 
            this.fromDateCheckBox.AutoSize = true;
            this.fromDateCheckBox.Location = new System.Drawing.Point(8, 121);
            this.fromDateCheckBox.Name = "fromDateCheckBox";
            this.fromDateCheckBox.Size = new System.Drawing.Size(75, 17);
            this.fromDateCheckBox.TabIndex = 7;
            this.fromDateCheckBox.Text = "From Date";
            this.fromDateCheckBox.UseVisualStyleBackColor = true;
            this.fromDateCheckBox.CheckedChanged += new System.EventHandler(this.fromDateCheckBox_CheckedChanged);
            // 
            // workTypeBox
            // 
            this.workTypeBox.DataSource = this.workOrderTypeBindingSource;
            this.workTypeBox.DisplayMember = "workOrderTypeID";
            this.workTypeBox.FormattingEnabled = true;
            this.workTypeBox.Location = new System.Drawing.Point(69, 68);
            this.workTypeBox.Name = "workTypeBox";
            this.workTypeBox.Size = new System.Drawing.Size(86, 21);
            this.workTypeBox.TabIndex = 6;
            this.workTypeBox.SelectionChangeCommitted += new System.EventHandler(this.workTypeBox_SelectedIndexChanged);
            this.workTypeBox.TextUpdate += new System.EventHandler(this.workTypeBox_TextUpdate);
            this.workTypeBox.TextChanged += new System.EventHandler(this.workTypeBox_TextUpdate);
            // 
            // workOrderTypeBindingSource
            // 
            this.workOrderTypeBindingSource.DataSource = typeof(ODP2.Models.workOrderType);
            // 
            // workTypeDirective
            // 
            this.workTypeDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderTypeBindingSource, "workOrderTypeDirective", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.workTypeDirective.Location = new System.Drawing.Point(183, 68);
            this.workTypeDirective.Name = "workTypeDirective";
            this.workTypeDirective.ReadOnly = true;
            this.workTypeDirective.Size = new System.Drawing.Size(247, 20);
            this.workTypeDirective.TabIndex = 0;
            // 
            // equipmentDirective
            // 
            this.equipmentDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentDirective", true));
            this.equipmentDirective.Location = new System.Drawing.Point(183, 37);
            this.equipmentDirective.Name = "equipmentDirective";
            this.equipmentDirective.ReadOnly = true;
            this.equipmentDirective.Size = new System.Drawing.Size(247, 20);
            this.equipmentDirective.TabIndex = 0;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.equipment);
            // 
            // toDatePicker
            // 
            this.toDatePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.toDatePicker.Enabled = false;
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePicker.Location = new System.Drawing.Point(305, 119);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(125, 20);
            this.toDatePicker.TabIndex = 4;
            // 
            // directiveTextBox
            // 
            this.directiveTextBox.Location = new System.Drawing.Point(69, 93);
            this.directiveTextBox.Name = "directiveTextBox";
            this.directiveTextBox.Size = new System.Drawing.Size(361, 20);
            this.directiveTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Directive";
            // 
            // openWorkOrderToolStripMenuItem
            // 
            this.openWorkOrderToolStripMenuItem.Name = "openWorkOrderToolStripMenuItem";
            this.openWorkOrderToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openWorkOrderToolStripMenuItem.Text = "Open Work Order";
            // 
            // workOrderIDDataGridViewTextBoxColumn
            // 
            this.workOrderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderIDDataGridViewTextBoxColumn.DataPropertyName = "workOrderID";
            this.workOrderIDDataGridViewTextBoxColumn.Frozen = true;
            this.workOrderIDDataGridViewTextBoxColumn.HeaderText = "Work Order";
            this.workOrderIDDataGridViewTextBoxColumn.Name = "workOrderIDDataGridViewTextBoxColumn";
            this.workOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workOrderIDDataGridViewTextBoxColumn.Width = 99;
            // 
            // workOrderDirectiveDataGridViewTextBoxColumn
            // 
            this.workOrderDirectiveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workOrderDirectiveDataGridViewTextBoxColumn.DataPropertyName = "workOrderDirective";
            this.workOrderDirectiveDataGridViewTextBoxColumn.HeaderText = "Directive";
            this.workOrderDirectiveDataGridViewTextBoxColumn.Name = "workOrderDirectiveDataGridViewTextBoxColumn";
            this.workOrderDirectiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workOrderEquipmentIDDataGridViewTextBoxColumn
            // 
            this.workOrderEquipmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderEquipmentIDDataGridViewTextBoxColumn.DataPropertyName = "workOrderEquipmentID";
            this.workOrderEquipmentIDDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.workOrderEquipmentIDDataGridViewTextBoxColumn.Name = "workOrderEquipmentIDDataGridViewTextBoxColumn";
            this.workOrderEquipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workOrderEquipmentIDDataGridViewTextBoxColumn.Width = 92;
            // 
            // workOrderStatusIDDataGridViewTextBoxColumn
            // 
            this.workOrderStatusIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderStatusIDDataGridViewTextBoxColumn.DataPropertyName = "workOrderStatusID";
            this.workOrderStatusIDDataGridViewTextBoxColumn.HeaderText = "Status";
            this.workOrderStatusIDDataGridViewTextBoxColumn.Name = "workOrderStatusIDDataGridViewTextBoxColumn";
            this.workOrderStatusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workOrderStatusIDDataGridViewTextBoxColumn.Width = 67;
            // 
            // workOrderTypeIDDataGridViewTextBoxColumn
            // 
            this.workOrderTypeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.workOrderTypeIDDataGridViewTextBoxColumn.DataPropertyName = "workOrderTypeID";
            this.workOrderTypeIDDataGridViewTextBoxColumn.HeaderText = "Type";
            this.workOrderTypeIDDataGridViewTextBoxColumn.Name = "workOrderTypeIDDataGridViewTextBoxColumn";
            this.workOrderTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workOrderTypeIDDataGridViewTextBoxColumn.Width = 58;
            // 
            // workOrderCreatorIDDataGridViewTextBoxColumn
            // 
            this.workOrderCreatorIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderCreatorIDDataGridViewTextBoxColumn.DataPropertyName = "workOrderCreatorID";
            this.workOrderCreatorIDDataGridViewTextBoxColumn.HeaderText = "Creator";
            this.workOrderCreatorIDDataGridViewTextBoxColumn.Name = "workOrderCreatorIDDataGridViewTextBoxColumn";
            this.workOrderCreatorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workOrderCreatorIDDataGridViewTextBoxColumn.Width = 74;
            // 
            // workOrderRegisterationDateDataGridViewTextBoxColumn
            // 
            this.workOrderRegisterationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderRegisterationDateDataGridViewTextBoxColumn.DataPropertyName = "workOrderRegisterationDate";
            this.workOrderRegisterationDateDataGridViewTextBoxColumn.HeaderText = "Registeration Date";
            this.workOrderRegisterationDateDataGridViewTextBoxColumn.Name = "workOrderRegisterationDateDataGridViewTextBoxColumn";
            this.workOrderRegisterationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.workOrderRegisterationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // workStartDateDataGridViewTextBoxColumn
            // 
            this.workStartDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workStartDateDataGridViewTextBoxColumn.DataPropertyName = "workStartDate";
            this.workStartDateDataGridViewTextBoxColumn.HeaderText = "Work Start Date";
            this.workStartDateDataGridViewTextBoxColumn.Name = "workStartDateDataGridViewTextBoxColumn";
            this.workStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.workStartDateDataGridViewTextBoxColumn.Width = 114;
            // 
            // workDoneDateDataGridViewTextBoxColumn
            // 
            this.workDoneDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workDoneDateDataGridViewTextBoxColumn.DataPropertyName = "workDoneDate";
            this.workDoneDateDataGridViewTextBoxColumn.HeaderText = "Work Done Date";
            this.workDoneDateDataGridViewTextBoxColumn.Name = "workDoneDateDataGridViewTextBoxColumn";
            this.workDoneDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.workDoneDateDataGridViewTextBoxColumn.Width = 115;
            // 
            // workOrderFinishDateDataGridViewTextBoxColumn
            // 
            this.workOrderFinishDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderFinishDateDataGridViewTextBoxColumn.DataPropertyName = "workOrderFinishDate";
            this.workOrderFinishDateDataGridViewTextBoxColumn.HeaderText = "Finish Date";
            this.workOrderFinishDateDataGridViewTextBoxColumn.Name = "workOrderFinishDateDataGridViewTextBoxColumn";
            this.workOrderFinishDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.workOrderFinishDateDataGridViewTextBoxColumn.Width = 86;
            // 
            // workDoneTypeDataGridViewTextBoxColumn
            // 
            this.workDoneTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workDoneTypeDataGridViewTextBoxColumn.DataPropertyName = "workDoneType";
            this.workDoneTypeDataGridViewTextBoxColumn.HeaderText = "Work DoneType";
            this.workDoneTypeDataGridViewTextBoxColumn.Name = "workDoneTypeDataGridViewTextBoxColumn";
            this.workDoneTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.workDoneTypeDataGridViewTextBoxColumn.Width = 112;
            // 
            // ClosedWorkOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closedWorkOrdersGrid);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ClosedWorkOrders";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1004, 485);
            this.Load += new System.EventHandler(this.ClosedWorkOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closedWorkOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox equipmentBox;
        private Label label1;
        private Button searchButton;
        private TextBox workOrderBox;
        private Label label2;
        private Label label4;
        private DataGridView closedWorkOrdersGrid;
        private DateTimePicker fromDatePicker;
        private Panel panel1;
        private ComboBox workTypeBox;
        private TextBox workTypeDirective;
        private TextBox equipmentDirective;
        private TextBox directiveTextBox;
        private Label label5;
        private CheckBox fromDateCheckBox;
        private ToolStripMenuItem openWorkOrderToolStripMenuItem;
        private CheckBox toDateCheckBox;
        private DateTimePicker toDatePicker;
        private BindingSource workOrderBindingSource;
        private BindingSource workOrderTypeBindingSource;
        private BindingSource equipmentBindingSource;
        private DataGridViewTextBoxColumn workOrderIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrderDirectiveDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrderEquipmentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrderStatusIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrderTypeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrderCreatorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrderRegisterationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workStartDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workDoneDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrderFinishDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workDoneTypeDataGridViewTextBoxColumn;
    }
}