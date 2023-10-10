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
            this.WORKORDERTYPEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDEREQUIPMENTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDERDIRECTIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDERSTATUSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDERREGISTERATIONDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDERFINISHDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKDONETYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.closedWorkOrdersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.closedWorkOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closedWorkOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WORKORDERTYPEID,
            this.WORKORDEREQUIPMENTID,
            this.WORKORDERDIRECTIVE,
            this.WORKORDERSTATUSID,
            this.WORKORDERREGISTERATIONDATE,
            this.WORKORDERFINISHDATE,
            this.WORKDONETYPE});
            this.closedWorkOrdersGrid.DataSource = this.workOrderBindingSource;
            this.closedWorkOrdersGrid.Location = new System.Drawing.Point(8, 204);
            this.closedWorkOrdersGrid.Name = "closedWorkOrdersGrid";
            this.closedWorkOrdersGrid.ReadOnly = true;
            this.closedWorkOrdersGrid.RowHeadersVisible = false;
            this.closedWorkOrdersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.closedWorkOrdersGrid.RowTemplate.Height = 25;
            this.closedWorkOrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.closedWorkOrdersGrid.Size = new System.Drawing.Size(988, 273);
            this.closedWorkOrdersGrid.TabIndex = 3;
            this.closedWorkOrdersGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.closedWorkOrdersGrid_MouseDoubleClick);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "dd-MMM-yy hh:mm tt";
            this.fromDatePicker.Enabled = false;
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(89, 119);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(139, 20);
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
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 190);
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
            this.workOrderTypeBindingSource.DataSource = typeof(ODP2.Models.WORKORDERTYPE);
            // 
            // workTypeDirective
            // 
            this.workTypeDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderTypeBindingSource, "workOrderTypeDirective", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.workTypeDirective.Location = new System.Drawing.Point(183, 68);
            this.workTypeDirective.Name = "workTypeDirective";
            this.workTypeDirective.ReadOnly = true;
            this.workTypeDirective.Size = new System.Drawing.Size(258, 20);
            this.workTypeDirective.TabIndex = 0;
            // 
            // equipmentDirective
            // 
            this.equipmentDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentDirective", true));
            this.equipmentDirective.Location = new System.Drawing.Point(183, 37);
            this.equipmentDirective.Name = "equipmentDirective";
            this.equipmentDirective.ReadOnly = true;
            this.equipmentDirective.Size = new System.Drawing.Size(258, 20);
            this.equipmentDirective.TabIndex = 0;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // toDatePicker
            // 
            this.toDatePicker.CustomFormat = "dd-MMM-yy hh:mm tt";
            this.toDatePicker.Enabled = false;
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePicker.Location = new System.Drawing.Point(305, 119);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(136, 20);
            this.toDatePicker.TabIndex = 4;
            // 
            // directiveTextBox
            // 
            this.directiveTextBox.Location = new System.Drawing.Point(69, 93);
            this.directiveTextBox.Name = "directiveTextBox";
            this.directiveTextBox.Size = new System.Drawing.Size(372, 20);
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
            // WORKORDERTYPEID
            // 
            this.WORKORDERTYPEID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKORDERTYPEID.DataPropertyName = "WORKORDERID";
            this.WORKORDERTYPEID.HeaderText = "WO#";
            this.WORKORDERTYPEID.Name = "WORKORDERTYPEID";
            this.WORKORDERTYPEID.ReadOnly = true;
            this.WORKORDERTYPEID.Width = 55;
            // 
            // WORKORDEREQUIPMENTID
            // 
            this.WORKORDEREQUIPMENTID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKORDEREQUIPMENTID.DataPropertyName = "WORKORDEREQUIPMENTID";
            this.WORKORDEREQUIPMENTID.HeaderText = "Equipment";
            this.WORKORDEREQUIPMENTID.Name = "WORKORDEREQUIPMENTID";
            this.WORKORDEREQUIPMENTID.ReadOnly = true;
            this.WORKORDEREQUIPMENTID.Width = 94;
            // 
            // WORKORDERDIRECTIVE
            // 
            this.WORKORDERDIRECTIVE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WORKORDERDIRECTIVE.DataPropertyName = "WORKORDERDIRECTIVE";
            this.WORKORDERDIRECTIVE.HeaderText = "Directive";
            this.WORKORDERDIRECTIVE.Name = "WORKORDERDIRECTIVE";
            this.WORKORDERDIRECTIVE.ReadOnly = true;
            // 
            // WORKORDERSTATUSID
            // 
            this.WORKORDERSTATUSID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKORDERSTATUSID.DataPropertyName = "WORKORDERSTATUSID";
            this.WORKORDERSTATUSID.HeaderText = "Status";
            this.WORKORDERSTATUSID.Name = "WORKORDERSTATUSID";
            this.WORKORDERSTATUSID.ReadOnly = true;
            this.WORKORDERSTATUSID.Width = 69;
            // 
            // WORKORDERREGISTERATIONDATE
            // 
            this.WORKORDERREGISTERATIONDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKORDERREGISTERATIONDATE.DataPropertyName = "WORKORDERREGISTERATIONDATE";
            this.WORKORDERREGISTERATIONDATE.HeaderText = "Registeration Date";
            this.WORKORDERREGISTERATIONDATE.Name = "WORKORDERREGISTERATIONDATE";
            this.WORKORDERREGISTERATIONDATE.ReadOnly = true;
            this.WORKORDERREGISTERATIONDATE.Width = 133;
            // 
            // WORKORDERFINISHDATE
            // 
            this.WORKORDERFINISHDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKORDERFINISHDATE.DataPropertyName = "WORKORDERFINISHDATE";
            this.WORKORDERFINISHDATE.HeaderText = "Finish Date";
            this.WORKORDERFINISHDATE.Name = "WORKORDERFINISHDATE";
            this.WORKORDERFINISHDATE.ReadOnly = true;
            this.WORKORDERFINISHDATE.Width = 89;
            // 
            // WORKDONETYPE
            // 
            this.WORKDONETYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKDONETYPE.DataPropertyName = "WORKDONETYPE1.WORKDONETYPEDIRECTIVE";
            this.WORKDONETYPE.HeaderText = "Action";
            this.WORKDONETYPE.Name = "WORKDONETYPE";
            this.WORKDONETYPE.ReadOnly = true;
            this.WORKDONETYPE.Width = 69;
            // 
            // ClosedWorkOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closedWorkOrdersGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private DataGridView closedWorkOrdersGrid;
        private DataGridViewTextBoxColumn WORKORDERTYPEID;
        private DataGridViewTextBoxColumn WORKORDEREQUIPMENTID;
        private DataGridViewTextBoxColumn WORKORDERDIRECTIVE;
        private DataGridViewTextBoxColumn WORKORDERSTATUSID;
        private DataGridViewTextBoxColumn WORKORDERREGISTERATIONDATE;
        private DataGridViewTextBoxColumn WORKORDERFINISHDATE;
        private DataGridViewTextBoxColumn WORKDONETYPE;
    }
}