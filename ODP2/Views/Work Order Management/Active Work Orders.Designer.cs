using System.Windows.Forms;

namespace ODP2
{
    partial class ActiveWorkOrders
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
            this.activeWorkOrdersGrid = new System.Windows.Forms.DataGridView();
            this.WORKORDERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDEREQUIPMENTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDERDIRECTIVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDERSTATUSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDERTYPEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKORDERREGISTERATIONDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKSTARTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORKDONEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.workOrderBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.workStatusBox = new System.Windows.Forms.ComboBox();
            this.workOrderStatuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workTypeBox = new System.Windows.Forms.ComboBox();
            this.workOrderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workTypeDirective = new System.Windows.Forms.TextBox();
            this.equipmentDirective = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directiveTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activeWorkOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderStatuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activeWorkOrdersGrid
            // 
            this.activeWorkOrdersGrid.AllowDrop = true;
            this.activeWorkOrdersGrid.AllowUserToAddRows = false;
            this.activeWorkOrdersGrid.AllowUserToDeleteRows = false;
            this.activeWorkOrdersGrid.AllowUserToOrderColumns = true;
            this.activeWorkOrdersGrid.AllowUserToResizeRows = false;
            this.activeWorkOrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeWorkOrdersGrid.AutoGenerateColumns = false;
            this.activeWorkOrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activeWorkOrdersGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.activeWorkOrdersGrid.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeWorkOrdersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.activeWorkOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeWorkOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WORKORDERID,
            this.WORKORDEREQUIPMENTID,
            this.WORKORDERDIRECTIVE,
            this.WORKORDERSTATUSID,
            this.WORKORDERTYPEID,
            this.WORKORDERREGISTERATIONDATE,
            this.WORKSTARTDATE,
            this.WORKDONEDATE});
            this.activeWorkOrdersGrid.DataSource = this.workOrderBindingSource;
            this.activeWorkOrdersGrid.Location = new System.Drawing.Point(8, 210);
            this.activeWorkOrdersGrid.Name = "activeWorkOrdersGrid";
            this.activeWorkOrdersGrid.ReadOnly = true;
            this.activeWorkOrdersGrid.RowHeadersVisible = false;
            this.activeWorkOrdersGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.activeWorkOrdersGrid.RowTemplate.DefaultCellStyle.NullValue = "----";
            this.activeWorkOrdersGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.activeWorkOrdersGrid.RowTemplate.Height = 25;
            this.activeWorkOrdersGrid.RowTemplate.ReadOnly = true;
            this.activeWorkOrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activeWorkOrdersGrid.Size = new System.Drawing.Size(952, 302);
            this.activeWorkOrdersGrid.TabIndex = 3;
            this.activeWorkOrdersGrid.Tag = "";
            this.activeWorkOrdersGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.activeWorkOrdersGrid_MouseDoubleClick);
            // 
            // WORKORDERID
            // 
            this.WORKORDERID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKORDERID.DataPropertyName = "WORKORDERID";
            this.WORKORDERID.HeaderText = "WO#";
            this.WORKORDERID.Name = "WORKORDERID";
            this.WORKORDERID.ReadOnly = true;
            this.WORKORDERID.Width = 55;
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
            // WORKORDERTYPEID
            // 
            this.WORKORDERTYPEID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKORDERTYPEID.DataPropertyName = "WORKORDERTYPEID";
            this.WORKORDERTYPEID.HeaderText = "Type";
            this.WORKORDERTYPEID.Name = "WORKORDERTYPEID";
            this.WORKORDERTYPEID.ReadOnly = true;
            this.WORKORDERTYPEID.Width = 60;
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
            // WORKSTARTDATE
            // 
            this.WORKSTARTDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKSTARTDATE.DataPropertyName = "WORKSTARTDATE";
            this.WORKSTARTDATE.HeaderText = "Work Start Date";
            this.WORKSTARTDATE.Name = "WORKSTARTDATE";
            this.WORKSTARTDATE.ReadOnly = true;
            this.WORKSTARTDATE.Width = 116;
            // 
            // WORKDONEDATE
            // 
            this.WORKDONEDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORKDONEDATE.DataPropertyName = "WORKDONEDATE";
            this.WORKDONEDATE.HeaderText = "Work Done Date";
            this.WORKDONEDATE.Name = "WORKDONEDATE";
            this.WORKDONEDATE.ReadOnly = true;
            this.WORKDONEDATE.Width = 116;
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.AllowNew = true;
            this.workOrderBindingSource.Sort = "workOrderID DESC";
            // 
            // equipmentBox
            // 
            this.equipmentBox.Location = new System.Drawing.Point(76, 37);
            this.equipmentBox.Name = "equipmentBox";
            this.equipmentBox.Size = new System.Drawing.Size(103, 20);
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
            this.searchButton.Location = new System.Drawing.Point(76, 167);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(86, 22);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // workOrderBox
            // 
            this.workOrderBox.Location = new System.Drawing.Point(76, 12);
            this.workOrderBox.Name = "workOrderBox";
            this.workOrderBox.Size = new System.Drawing.Size(103, 20);
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
            this.label4.Location = new System.Drawing.Point(8, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Work Type";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "dd-MMM-yy hh:mm tt";
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(76, 141);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(142, 20);
            this.fromDatePicker.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateCheckBox);
            this.panel1.Controls.Add(this.workStatusBox);
            this.panel1.Controls.Add(this.workTypeBox);
            this.panel1.Controls.Add(this.workTypeDirective);
            this.panel1.Controls.Add(this.equipmentDirective);
            this.panel1.Controls.Add(this.equipmentBox);
            this.panel1.Controls.Add(this.fromDatePicker);
            this.panel1.Controls.Add(this.directiveTextBox);
            this.panel1.Controls.Add(this.workOrderBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 196);
            this.panel1.TabIndex = 5;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(15, 145);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dateCheckBox.TabIndex = 7;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // workStatusBox
            // 
            this.workStatusBox.DataSource = this.workOrderStatuBindingSource;
            this.workStatusBox.DisplayMember = "workOrderStatusID";
            this.workStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workStatusBox.FormattingEnabled = true;
            this.workStatusBox.Location = new System.Drawing.Point(76, 114);
            this.workStatusBox.Name = "workStatusBox";
            this.workStatusBox.Size = new System.Drawing.Size(103, 21);
            this.workStatusBox.TabIndex = 6;
            this.workStatusBox.ValueMember = "workOrderTypeDirective";
            this.workStatusBox.SelectionChangeCommitted += new System.EventHandler(this.workTypeBox_SelectedIndexChanged);
            this.workStatusBox.TextUpdate += new System.EventHandler(this.workTypeBox_TextUpdate);
            // 
            // workOrderStatuBindingSource
            // 
            this.workOrderStatuBindingSource.DataSource = typeof(ODP2.Models.WORKORDERSTATU);
            // 
            // workTypeBox
            // 
            this.workTypeBox.DataSource = this.workOrderTypeBindingSource;
            this.workTypeBox.DisplayMember = "workOrderTypeID";
            this.workTypeBox.FormattingEnabled = true;
            this.workTypeBox.Location = new System.Drawing.Point(76, 63);
            this.workTypeBox.Name = "workTypeBox";
            this.workTypeBox.Size = new System.Drawing.Size(103, 21);
            this.workTypeBox.TabIndex = 6;
            this.workTypeBox.SelectionChangeCommitted += new System.EventHandler(this.workTypeBox_SelectedIndexChanged);
            this.workTypeBox.TextUpdate += new System.EventHandler(this.workTypeBox_TextUpdate);
            // 
            // workTypeDirective
            // 
            this.workTypeDirective.Location = new System.Drawing.Point(185, 63);
            this.workTypeDirective.Name = "workTypeDirective";
            this.workTypeDirective.ReadOnly = true;
            this.workTypeDirective.Size = new System.Drawing.Size(247, 20);
            this.workTypeDirective.TabIndex = 0;
            // 
            // equipmentDirective
            // 
            this.equipmentDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentDirective", true));
            this.equipmentDirective.Location = new System.Drawing.Point(185, 37);
            this.equipmentDirective.Name = "equipmentDirective";
            this.equipmentDirective.ReadOnly = true;
            this.equipmentDirective.Size = new System.Drawing.Size(247, 20);
            this.equipmentDirective.TabIndex = 0;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // directiveTextBox
            // 
            this.directiveTextBox.Location = new System.Drawing.Point(76, 88);
            this.directiveTextBox.Name = "directiveTextBox";
            this.directiveTextBox.Size = new System.Drawing.Size(356, 20);
            this.directiveTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Work Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Directive";
            // 
            // ActiveWorkOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.activeWorkOrdersGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ActiveWorkOrders";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(968, 520);
            this.Load += new System.EventHandler(this.ActiveWorkOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activeWorkOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderStatuBindingSource)).EndInit();
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
        private CheckBox dateCheckBox;
        private BindingSource workOrderTypeBindingSource;
        private BindingSource workOrderBindingSource;
        private BindingSource equipmentBindingSource;
        private ComboBox workStatusBox;
        private Label label3;
        private BindingSource workOrderStatuBindingSource;
        private DataGridView activeWorkOrdersGrid;
        private DataGridViewTextBoxColumn WORKORDERID;
        private DataGridViewTextBoxColumn WORKORDEREQUIPMENTID;
        private DataGridViewTextBoxColumn WORKORDERDIRECTIVE;
        private DataGridViewTextBoxColumn WORKORDERSTATUSID;
        private DataGridViewTextBoxColumn WORKORDERTYPEID;
        private DataGridViewTextBoxColumn WORKORDERREGISTERATIONDATE;
        private DataGridViewTextBoxColumn WORKSTARTDATE;
        private DataGridViewTextBoxColumn WORKDONEDATE;
    }
}