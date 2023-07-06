//using System.Reflection.Emit;
using System.Windows.Forms;

namespace ODP2.Views
{
    partial class WorkOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.workOrderTextBox = new System.Windows.Forms.TextBox();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bdnHoursTextbox = new System.Windows.Forms.TextBox();
            this.workOrderTabs = new System.Windows.Forms.TabControl();
            this.materialsTab = new System.Windows.Forms.TabPage();
            this.releaseButton = new System.Windows.Forms.Button();
            this.requestButton = new System.Windows.Forms.Button();
            this.partDirectiveTextBox = new System.Windows.Forms.TextBox();
            this.totalCostTextbox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.partCodeTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.materialsGridView = new System.Windows.Forms.DataGridView();
            this.issueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.bdnTab = new System.Windows.Forms.TabPage();
            this.bdnGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdnReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrder1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakDownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stepsAndNotesTab = new System.Windows.Forms.TabPage();
            this.workOrderNotes = new System.Windows.Forms.RichTextBox();
            this.workDoneType = new System.Windows.Forms.ComboBox();
            this.workDoneTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pmCheclistButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workOrderStatuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDirectiveTextBox = new System.Windows.Forms.TextBox();
            this.workOrderDirective = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.statusContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.workRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.workStarted = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.workDone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.finished = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelled = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorIDTextBox = new System.Windows.Forms.TextBox();
            this.creatorNameTextBox = new System.Windows.Forms.TextBox();
            this.workTypeDirectiveTextBox = new System.Windows.Forms.TextBox();
            this.workTypeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.workOrderFinishDate = new System.Windows.Forms.TextBox();
            this.workDoneDate = new System.Windows.Forms.TextBox();
            this.workStartDate = new System.Windows.Forms.TextBox();
            this.registerationDate = new System.Windows.Forms.TextBox();
            this.equipmentHR = new System.Windows.Forms.TextBox();
            this.equipmentIDTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.finishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.doneDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.registerationDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            this.workOrderTabs.SuspendLayout();
            this.materialsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            this.bdnTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakDownBindingSource)).BeginInit();
            this.stepsAndNotesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workDoneTypeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderStatuBindingSource)).BeginInit();
            this.statusContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Order";
            // 
            // workOrderTextBox
            // 
            this.workOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "----", "N0"));
            this.workOrderTextBox.Location = new System.Drawing.Point(79, 10);
            this.workOrderTextBox.Name = "workOrderTextBox";
            this.workOrderTextBox.ReadOnly = true;
            this.workOrderTextBox.Size = new System.Drawing.Size(94, 20);
            this.workOrderTextBox.TabIndex = 2;
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.DataSource = typeof(ODP2.Models.WORKORDER);
            // 
            // saveButton
            // 
            this.saveButton.CausesValidation = false;
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(656, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 21);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(631, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Cost";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Man Hours";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "BDN Hours";
            // 
            // bdnHoursTextbox
            // 
            this.bdnHoursTextbox.Location = new System.Drawing.Point(117, 5);
            this.bdnHoursTextbox.Name = "bdnHoursTextbox";
            this.bdnHoursTextbox.ReadOnly = true;
            this.bdnHoursTextbox.Size = new System.Drawing.Size(100, 20);
            this.bdnHoursTextbox.TabIndex = 1;
            // 
            // workOrderTabs
            // 
            this.workOrderTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workOrderTabs.Controls.Add(this.materialsTab);
            this.workOrderTabs.Controls.Add(this.bdnTab);
            this.workOrderTabs.Controls.Add(this.stepsAndNotesTab);
            this.workOrderTabs.Controls.Add(this.returnTab);
            this.workOrderTabs.Location = new System.Drawing.Point(10, 192);
            this.workOrderTabs.Name = "workOrderTabs";
            this.workOrderTabs.SelectedIndex = 0;
            this.workOrderTabs.Size = new System.Drawing.Size(772, 453);
            this.workOrderTabs.TabIndex = 6;
            // 
            // materialsTab
            // 
            this.materialsTab.BackColor = System.Drawing.Color.Transparent;
            this.materialsTab.Controls.Add(this.releaseButton);
            this.materialsTab.Controls.Add(this.requestButton);
            this.materialsTab.Controls.Add(this.partDirectiveTextBox);
            this.materialsTab.Controls.Add(this.totalCostTextbox);
            this.materialsTab.Controls.Add(this.quantityTextBox);
            this.materialsTab.Controls.Add(this.partCodeTextBox);
            this.materialsTab.Controls.Add(this.label18);
            this.materialsTab.Controls.Add(this.materialsGridView);
            this.materialsTab.Controls.Add(this.label15);
            this.materialsTab.Controls.Add(this.label12);
            this.materialsTab.Location = new System.Drawing.Point(4, 22);
            this.materialsTab.Name = "materialsTab";
            this.materialsTab.Padding = new System.Windows.Forms.Padding(5);
            this.materialsTab.Size = new System.Drawing.Size(764, 427);
            this.materialsTab.TabIndex = 0;
            this.materialsTab.Text = "Materials";
            // 
            // releaseButton
            // 
            this.releaseButton.Enabled = false;
            this.releaseButton.Location = new System.Drawing.Point(451, 34);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(75, 23);
            this.releaseButton.TabIndex = 3;
            this.releaseButton.Text = "Release";
            this.releaseButton.UseVisualStyleBackColor = true;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // requestButton
            // 
            this.requestButton.Enabled = false;
            this.requestButton.Location = new System.Drawing.Point(149, 34);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(75, 23);
            this.requestButton.TabIndex = 3;
            this.requestButton.Text = "Request";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // partDirectiveTextBox
            // 
            this.partDirectiveTextBox.Location = new System.Drawing.Point(237, 8);
            this.partDirectiveTextBox.Name = "partDirectiveTextBox";
            this.partDirectiveTextBox.ReadOnly = true;
            this.partDirectiveTextBox.Size = new System.Drawing.Size(289, 20);
            this.partDirectiveTextBox.TabIndex = 2;
            // 
            // totalCostTextbox
            // 
            this.totalCostTextbox.Location = new System.Drawing.Point(692, 8);
            this.totalCostTextbox.Name = "totalCostTextbox";
            this.totalCostTextbox.ReadOnly = true;
            this.totalCostTextbox.Size = new System.Drawing.Size(64, 20);
            this.totalCostTextbox.TabIndex = 2;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(65, 36);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(78, 20);
            this.quantityTextBox.TabIndex = 2;
            // 
            // partCodeTextBox
            // 
            this.partCodeTextBox.Location = new System.Drawing.Point(65, 8);
            this.partCodeTextBox.Name = "partCodeTextBox";
            this.partCodeTextBox.Size = new System.Drawing.Size(159, 20);
            this.partCodeTextBox.TabIndex = 2;
            this.partCodeTextBox.Validated += new System.EventHandler(this.partCodeTextBox_Validated);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Quantity";
            // 
            // materialsGridView
            // 
            this.materialsGridView.AllowUserToAddRows = false;
            this.materialsGridView.AllowUserToDeleteRows = false;
            this.materialsGridView.AllowUserToOrderColumns = true;
            this.materialsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialsGridView.AutoGenerateColumns = false;
            this.materialsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueID,
            this.qty,
            this.uom,
            this.sparePartCodeDataGridViewTextBoxColumn,
            this.sparePart,
            this.issueState,
            this.requestDate,
            this.partPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn});
            this.materialsGridView.DataSource = this.issueBindingSource;
            this.materialsGridView.Location = new System.Drawing.Point(8, 63);
            this.materialsGridView.MultiSelect = false;
            this.materialsGridView.Name = "materialsGridView";
            this.materialsGridView.ReadOnly = true;
            this.materialsGridView.RowHeadersVisible = false;
            this.materialsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialsGridView.Size = new System.Drawing.Size(748, 351);
            this.materialsGridView.TabIndex = 1;
            this.materialsGridView.SelectionChanged += new System.EventHandler(this.materialsGridView_SelectionChanged);
            // 
            // issueID
            // 
            this.issueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.issueID.DataPropertyName = "issueID";
            this.issueID.HeaderText = "Issue#";
            this.issueID.Name = "issueID";
            this.issueID.ReadOnly = true;
            this.issueID.Width = 64;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 48;
            // 
            // uom
            // 
            this.uom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UoM";
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            this.uom.Width = 55;
            // 
            // sparePartCodeDataGridViewTextBoxColumn
            // 
            this.sparePartCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sparePartCodeDataGridViewTextBoxColumn.DataPropertyName = "sparePartCode";
            this.sparePartCodeDataGridViewTextBoxColumn.HeaderText = "Spare Part Code";
            this.sparePartCodeDataGridViewTextBoxColumn.Name = "sparePartCodeDataGridViewTextBoxColumn";
            this.sparePartCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sparePartCodeDataGridViewTextBoxColumn.Width = 79;
            // 
            // sparePart
            // 
            this.sparePart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sparePart.DataPropertyName = "partDirective";
            this.sparePart.HeaderText = "Part Description";
            this.sparePart.Name = "sparePart";
            this.sparePart.ReadOnly = true;
            // 
            // issueState
            // 
            this.issueState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueState.DataPropertyName = "issueState";
            this.issueState.HeaderText = "Status";
            this.issueState.Name = "issueState";
            this.issueState.ReadOnly = true;
            this.issueState.Width = 62;
            // 
            // requestDate
            // 
            this.requestDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.requestDate.DataPropertyName = "requestDate";
            this.requestDate.HeaderText = "Request Date";
            this.requestDate.Name = "requestDate";
            this.requestDate.ReadOnly = true;
            this.requestDate.Width = 90;
            // 
            // partPriceDataGridViewTextBoxColumn
            // 
            this.partPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partPriceDataGridViewTextBoxColumn.DataPropertyName = "partPrice";
            this.partPriceDataGridViewTextBoxColumn.HeaderText = "Part Price";
            this.partPriceDataGridViewTextBoxColumn.Name = "partPriceDataGridViewTextBoxColumn";
            this.partPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.partPriceDataGridViewTextBoxColumn.Width = 72;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 77;
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "issueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            this.issueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.issueDateDataGridViewTextBoxColumn.Width = 77;
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataSource = typeof(ODP2.Models.ISSUE);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Part Code";
            // 
            // bdnTab
            // 
            this.bdnTab.BackColor = System.Drawing.Color.Transparent;
            this.bdnTab.Controls.Add(this.bdnGridView);
            this.bdnTab.Controls.Add(this.bdnHoursTextbox);
            this.bdnTab.Controls.Add(this.label17);
            this.bdnTab.Location = new System.Drawing.Point(4, 22);
            this.bdnTab.Name = "bdnTab";
            this.bdnTab.Padding = new System.Windows.Forms.Padding(3);
            this.bdnTab.Size = new System.Drawing.Size(764, 427);
            this.bdnTab.TabIndex = 1;
            this.bdnTab.Text = "BDN";
            // 
            // bdnGridView
            // 
            this.bdnGridView.AllowUserToAddRows = false;
            this.bdnGridView.AllowUserToDeleteRows = false;
            this.bdnGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdnGridView.AutoGenerateColumns = false;
            this.bdnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdnGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bdnReasonDataGridViewTextBoxColumn,
            this.fromTimeDataGridViewTextBoxColumn,
            this.toTimeDataGridViewTextBoxColumn,
            this.workOrder1DataGridViewTextBoxColumn});
            this.bdnGridView.DataSource = this.breakDownBindingSource;
            this.bdnGridView.Location = new System.Drawing.Point(3, 30);
            this.bdnGridView.Name = "bdnGridView";
            this.bdnGridView.ReadOnly = true;
            this.bdnGridView.RowTemplate.Height = 25;
            this.bdnGridView.Size = new System.Drawing.Size(753, 391);
            this.bdnGridView.TabIndex = 4;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // bdnReasonDataGridViewTextBoxColumn
            // 
            this.bdnReasonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bdnReasonDataGridViewTextBoxColumn.DataPropertyName = "bdnReason";
            this.bdnReasonDataGridViewTextBoxColumn.HeaderText = "BreakDown Reason";
            this.bdnReasonDataGridViewTextBoxColumn.Name = "bdnReasonDataGridViewTextBoxColumn";
            this.bdnReasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromTimeDataGridViewTextBoxColumn
            // 
            this.fromTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fromTimeDataGridViewTextBoxColumn.DataPropertyName = "fromTime";
            this.fromTimeDataGridViewTextBoxColumn.HeaderText = "From Time";
            this.fromTimeDataGridViewTextBoxColumn.Name = "fromTimeDataGridViewTextBoxColumn";
            this.fromTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fromTimeDataGridViewTextBoxColumn.Width = 81;
            // 
            // toTimeDataGridViewTextBoxColumn
            // 
            this.toTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.toTimeDataGridViewTextBoxColumn.DataPropertyName = "toTime";
            this.toTimeDataGridViewTextBoxColumn.HeaderText = "To Time";
            this.toTimeDataGridViewTextBoxColumn.Name = "toTimeDataGridViewTextBoxColumn";
            this.toTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.toTimeDataGridViewTextBoxColumn.Width = 71;
            // 
            // workOrder1DataGridViewTextBoxColumn
            // 
            this.workOrder1DataGridViewTextBoxColumn.DataPropertyName = "workOrder1";
            this.workOrder1DataGridViewTextBoxColumn.HeaderText = "workOrder1";
            this.workOrder1DataGridViewTextBoxColumn.Name = "workOrder1DataGridViewTextBoxColumn";
            this.workOrder1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // breakDownBindingSource
            // 
            this.breakDownBindingSource.DataSource = typeof(ODP2.Models.BREAKDOWN);
            // 
            // stepsAndNotesTab
            // 
            this.stepsAndNotesTab.BackColor = System.Drawing.Color.Transparent;
            this.stepsAndNotesTab.Controls.Add(this.workOrderNotes);
            this.stepsAndNotesTab.Controls.Add(this.workDoneType);
            this.stepsAndNotesTab.Controls.Add(this.pmCheclistButton);
            this.stepsAndNotesTab.Controls.Add(this.label6);
            this.stepsAndNotesTab.Controls.Add(this.label3);
            this.stepsAndNotesTab.Location = new System.Drawing.Point(4, 22);
            this.stepsAndNotesTab.Name = "stepsAndNotesTab";
            this.stepsAndNotesTab.Padding = new System.Windows.Forms.Padding(3);
            this.stepsAndNotesTab.Size = new System.Drawing.Size(764, 427);
            this.stepsAndNotesTab.TabIndex = 2;
            this.stepsAndNotesTab.Text = "Notes";
            // 
            // workOrderNotes
            // 
            this.workOrderNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workOrderNotes.BulletIndent = 3;
            this.workOrderNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderNotes", true));
            this.workOrderNotes.Location = new System.Drawing.Point(5, 38);
            this.workOrderNotes.Name = "workOrderNotes";
            this.workOrderNotes.Size = new System.Drawing.Size(751, 383);
            this.workOrderNotes.TabIndex = 0;
            this.workOrderNotes.Text = "Write Here all the Notes you need";
            this.workOrderNotes.TextChanged += new System.EventHandler(this.workOrderNotes_TextChanged);
            // 
            // workDoneType
            // 
            this.workDoneType.DataSource = this.workDoneTypeBindingSource;
            this.workDoneType.DisplayMember = "workDoneTypeID";
            this.workDoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workDoneType.FormattingEnabled = true;
            this.workDoneType.Location = new System.Drawing.Point(73, 11);
            this.workDoneType.Name = "workDoneType";
            this.workDoneType.Size = new System.Drawing.Size(100, 21);
            this.workDoneType.TabIndex = 5;
            // 
            // workDoneTypeBindingSource
            // 
            this.workDoneTypeBindingSource.DataSource = typeof(ODP2.Models.WORKDONETYPE);
            // 
            // pmCheclistButton
            // 
            this.pmCheclistButton.Image = ((System.Drawing.Image)(resources.GetObject("pmCheclistButton.Image")));
            this.pmCheclistButton.Location = new System.Drawing.Point(634, 5);
            this.pmCheclistButton.Name = "pmCheclistButton";
            this.pmCheclistButton.Size = new System.Drawing.Size(122, 27);
            this.pmCheclistButton.TabIndex = 2;
            this.pmCheclistButton.Text = "Attachment";
            this.pmCheclistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pmCheclistButton.UseVisualStyleBackColor = true;
            this.pmCheclistButton.Click += new System.EventHandler(this.pmChecklist_Button);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workDoneType1.workDoneTypeDirective", true));
            this.label6.Location = new System.Drawing.Point(179, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "--\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Work Done";
            // 
            // returnTab
            // 
            this.returnTab.Location = new System.Drawing.Point(4, 22);
            this.returnTab.Name = "returnTab";
            this.returnTab.Size = new System.Drawing.Size(764, 427);
            this.returnTab.TabIndex = 3;
            this.returnTab.Text = "Returns";
            this.returnTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.equipmentDirectiveTextBox);
            this.panel1.Controls.Add(this.workOrderDirective);
            this.panel1.Controls.Add(this.statusBox);
            this.panel1.Controls.Add(this.creatorIDTextBox);
            this.panel1.Controls.Add(this.creatorNameTextBox);
            this.panel1.Controls.Add(this.workTypeDirectiveTextBox);
            this.panel1.Controls.Add(this.workTypeTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.workOrderFinishDate);
            this.panel1.Controls.Add(this.workDoneDate);
            this.panel1.Controls.Add(this.workStartDate);
            this.panel1.Controls.Add(this.registerationDate);
            this.panel1.Controls.Add(this.equipmentHR);
            this.panel1.Controls.Add(this.equipmentIDTextBox);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.finishDatePicker);
            this.panel1.Controls.Add(this.doneDatePicker);
            this.panel1.Controls.Add(this.startDatePicker);
            this.panel1.Controls.Add(this.registerationDatePicker);
            this.panel1.Location = new System.Drawing.Point(10, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 150);
            this.panel1.TabIndex = 7;
            // 
            // workOrderStatuBindingSource
            // 
            this.workOrderStatuBindingSource.DataSource = typeof(ODP2.Models.WORKORDERSTATU);
            // 
            // equipmentDirectiveTextBox
            // 
            this.equipmentDirectiveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "equipment.equipmentDirective", true));
            this.equipmentDirectiveTextBox.Location = new System.Drawing.Point(167, 13);
            this.equipmentDirectiveTextBox.Name = "equipmentDirectiveTextBox";
            this.equipmentDirectiveTextBox.ReadOnly = true;
            this.equipmentDirectiveTextBox.Size = new System.Drawing.Size(240, 20);
            this.equipmentDirectiveTextBox.TabIndex = 21;
            // 
            // workOrderDirective
            // 
            this.workOrderDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderDirective", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.workOrderDirective.Location = new System.Drawing.Point(68, 116);
            this.workOrderDirective.Name = "workOrderDirective";
            this.workOrderDirective.Size = new System.Drawing.Size(339, 20);
            this.workOrderDirective.TabIndex = 20;
            this.workOrderDirective.TextChanged += new System.EventHandler(this.workOrderAttributeChanged);
            // 
            // statusBox
            // 
            this.statusBox.ContextMenuStrip = this.statusContextMenuStrip;
            this.statusBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderStatusID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "----"));
            this.statusBox.Location = new System.Drawing.Point(68, 89);
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(93, 20);
            this.statusBox.TabIndex = 19;
            this.statusBox.TextChanged += new System.EventHandler(this.statusChanged);
            // 
            // statusContextMenuStrip
            // 
            this.statusContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workRequest,
            this.toolStripSeparator4,
            this.workStarted,
            this.toolStripSeparator5,
            this.workDone,
            this.toolStripSeparator6,
            this.finished,
            this.toolStripSeparator7,
            this.cancelled});
            this.statusContextMenuStrip.Name = "statusContextMenuStrip";
            this.statusContextMenuStrip.Size = new System.Drawing.Size(148, 138);
            this.statusContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.statusContextMenuStrip_Opening);
            // 
            // workRequest
            // 
            this.workRequest.Name = "workRequest";
            this.workRequest.Size = new System.Drawing.Size(147, 22);
            this.workRequest.Text = "Work Request";
            this.workRequest.Click += new System.EventHandler(this.statusSelected);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(144, 6);
            // 
            // workStarted
            // 
            this.workStarted.Name = "workStarted";
            this.workStarted.Size = new System.Drawing.Size(147, 22);
            this.workStarted.Text = "Work Started";
            this.workStarted.Click += new System.EventHandler(this.statusSelected);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
            // 
            // workDone
            // 
            this.workDone.Name = "workDone";
            this.workDone.Size = new System.Drawing.Size(147, 22);
            this.workDone.Text = "Work Done";
            this.workDone.Click += new System.EventHandler(this.statusSelected);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(144, 6);
            // 
            // finished
            // 
            this.finished.Name = "finished";
            this.finished.Size = new System.Drawing.Size(147, 22);
            this.finished.Text = "Finished";
            this.finished.Click += new System.EventHandler(this.statusSelected);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(144, 6);
            // 
            // cancelled
            // 
            this.cancelled.Name = "cancelled";
            this.cancelled.Size = new System.Drawing.Size(147, 22);
            this.cancelled.Text = "Cancelled";
            this.cancelled.Click += new System.EventHandler(this.statusSelected);
            // 
            // creatorIDTextBox
            // 
            this.creatorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "user.userIDNumber", true));
            this.creatorIDTextBox.Location = new System.Drawing.Point(68, 63);
            this.creatorIDTextBox.Name = "creatorIDTextBox";
            this.creatorIDTextBox.ReadOnly = true;
            this.creatorIDTextBox.Size = new System.Drawing.Size(93, 20);
            this.creatorIDTextBox.TabIndex = 19;
            // 
            // creatorNameTextBox
            // 
            this.creatorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "user.userName", true));
            this.creatorNameTextBox.Location = new System.Drawing.Point(167, 63);
            this.creatorNameTextBox.Name = "creatorNameTextBox";
            this.creatorNameTextBox.ReadOnly = true;
            this.creatorNameTextBox.Size = new System.Drawing.Size(240, 20);
            this.creatorNameTextBox.TabIndex = 16;
            // 
            // workTypeDirectiveTextBox
            // 
            this.workTypeDirectiveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderType.workOrderTypeDirective", true));
            this.workTypeDirectiveTextBox.Location = new System.Drawing.Point(167, 38);
            this.workTypeDirectiveTextBox.Name = "workTypeDirectiveTextBox";
            this.workTypeDirectiveTextBox.ReadOnly = true;
            this.workTypeDirectiveTextBox.Size = new System.Drawing.Size(240, 20);
            this.workTypeDirectiveTextBox.TabIndex = 25;
            // 
            // workTypeTextBox
            // 
            this.workTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderTypeID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.workTypeTextBox.Location = new System.Drawing.Point(68, 39);
            this.workTypeTextBox.Name = "workTypeTextBox";
            this.workTypeTextBox.ReadOnly = true;
            this.workTypeTextBox.Size = new System.Drawing.Size(93, 20);
            this.workTypeTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Status";
            // 
            // workOrderFinishDate
            // 
            this.workOrderFinishDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderFinishDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "g"));
            this.workOrderFinishDate.Location = new System.Drawing.Point(609, 118);
            this.workOrderFinishDate.Name = "workOrderFinishDate";
            this.workOrderFinishDate.ReadOnly = true;
            this.workOrderFinishDate.Size = new System.Drawing.Size(122, 20);
            this.workOrderFinishDate.TabIndex = 17;
            // 
            // workDoneDate
            // 
            this.workDoneDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workDoneDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "g"));
            this.workDoneDate.Location = new System.Drawing.Point(609, 90);
            this.workDoneDate.Name = "workDoneDate";
            this.workDoneDate.ReadOnly = true;
            this.workDoneDate.Size = new System.Drawing.Size(122, 20);
            this.workDoneDate.TabIndex = 17;
            // 
            // workStartDate
            // 
            this.workStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workStartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "g"));
            this.workStartDate.Location = new System.Drawing.Point(609, 64);
            this.workStartDate.Name = "workStartDate";
            this.workStartDate.ReadOnly = true;
            this.workStartDate.Size = new System.Drawing.Size(122, 20);
            this.workStartDate.TabIndex = 17;
            // 
            // registerationDate
            // 
            this.registerationDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderRegisterationDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "g"));
            this.registerationDate.Location = new System.Drawing.Point(609, 38);
            this.registerationDate.Name = "registerationDate";
            this.registerationDate.ReadOnly = true;
            this.registerationDate.Size = new System.Drawing.Size(122, 20);
            this.registerationDate.TabIndex = 17;
            this.registerationDate.TextChanged += new System.EventHandler(this.workOrderAttributeChanged);
            // 
            // equipmentHR
            // 
            this.equipmentHR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "equipmentRH", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "N2"));
            this.equipmentHR.Location = new System.Drawing.Point(610, 12);
            this.equipmentHR.Name = "equipmentHR";
            this.equipmentHR.ReadOnly = true;
            this.equipmentHR.Size = new System.Drawing.Size(122, 20);
            this.equipmentHR.TabIndex = 17;
            // 
            // equipmentIDTextBox
            // 
            this.equipmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "equipment.equipmentID", true));
            this.equipmentIDTextBox.Location = new System.Drawing.Point(68, 13);
            this.equipmentIDTextBox.Name = "equipmentIDTextBox";
            this.equipmentIDTextBox.ReadOnly = true;
            this.equipmentIDTextBox.Size = new System.Drawing.Size(93, 20);
            this.equipmentIDTextBox.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Registeration Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Finish Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(515, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Work Done Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Start Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Creator ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Directive";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Equipment HR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Work Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Equipment";
            // 
            // finishDatePicker
            // 
            this.finishDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.finishDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finishDatePicker.Location = new System.Drawing.Point(609, 118);
            this.finishDatePicker.Name = "finishDatePicker";
            this.finishDatePicker.Size = new System.Drawing.Size(150, 20);
            this.finishDatePicker.TabIndex = 26;
            this.finishDatePicker.Visible = false;
            this.finishDatePicker.ValueChanged += new System.EventHandler(this.workOrderAttributeChanged);
            // 
            // doneDatePicker
            // 
            this.doneDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.doneDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.doneDatePicker.Location = new System.Drawing.Point(609, 90);
            this.doneDatePicker.Name = "doneDatePicker";
            this.doneDatePicker.Size = new System.Drawing.Size(150, 20);
            this.doneDatePicker.TabIndex = 26;
            this.doneDatePicker.Visible = false;
            this.doneDatePicker.ValueChanged += new System.EventHandler(this.workOrderAttributeChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(609, 64);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(150, 20);
            this.startDatePicker.TabIndex = 26;
            this.startDatePicker.Visible = false;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.workOrderAttributeChanged);
            // 
            // registerationDatePicker
            // 
            this.registerationDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.registerationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.registerationDatePicker.Location = new System.Drawing.Point(610, 38);
            this.registerationDatePicker.Name = "registerationDatePicker";
            this.registerationDatePicker.Size = new System.Drawing.Size(149, 20);
            this.registerationDatePicker.TabIndex = 26;
            this.registerationDatePicker.Visible = false;
            this.registerationDatePicker.ValueChanged += new System.EventHandler(this.workOrderAttributeChanged);
            // 
            // WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(793, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.workOrderTabs);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.workOrderTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WorkOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Order #";
            this.Load += new System.EventHandler(this.WorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            this.workOrderTabs.ResumeLayout(false);
            this.materialsTab.ResumeLayout(false);
            this.materialsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            this.bdnTab.ResumeLayout(false);
            this.bdnTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdnGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakDownBindingSource)).EndInit();
            this.stepsAndNotesTab.ResumeLayout(false);
            this.stepsAndNotesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workDoneTypeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderStatuBindingSource)).EndInit();
            this.statusContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private TextBox workOrderTextBox;
        private Button saveButton;
        private Label label1;
        private Label label12;
        private Label label13;
        private Label label17;
        private TextBox bdnHoursTextbox;
        private TabControl workOrderTabs;
        private TabPage materialsTab;
        private TabPage bdnTab;
        private DataGridView bdnGridView;
        private TabPage stepsAndNotesTab;
        private RichTextBox workOrderNotes;
        private ComboBox workDoneType;
        private Label label3;
        private BindingSource workDoneTypeBindingSource;
        private BindingSource workOrderBindingSource;
        private DataGridView materialsGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn bdnReasonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fromTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrder1DataGridViewTextBoxColumn;
        private BindingSource breakDownBindingSource;
       
        private BindingSource issueBindingSource;
        private Panel panel1;
        private TextBox equipmentDirectiveTextBox;
        private TextBox workOrderDirective;
        private TextBox creatorIDTextBox;
        private TextBox creatorNameTextBox;
        private TextBox workTypeDirectiveTextBox;
        private TextBox workTypeTextBox;
        private Label label7;
        private TextBox equipmentHR;
        private TextBox equipmentIDTextBox;
        private Label label16;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label14;
        private Label label4;
        private Label label9;
        private Label label5;
        private Label label2;
        private TextBox registerationDate;
        private TextBox workOrderFinishDate;
        private TextBox workDoneDate;
        private TextBox workStartDate;
        private DateTimePicker registerationDatePicker;
        private DateTimePicker finishDatePicker;
        private DateTimePicker doneDatePicker;
        private DateTimePicker startDatePicker;
        private BindingSource workOrderStatuBindingSource;
        private Button pmCheclistButton;
        private Button requestButton;
        private TextBox partDirectiveTextBox;
        private TextBox quantityTextBox;
        private TextBox partCodeTextBox;
        private Label label18;
        private Label label15;
        private TextBox totalCostTextbox;
        private Label label6;
        private TabPage returnTab;
        private ContextMenuStrip statusContextMenuStrip;
        private ToolStripMenuItem workRequest;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem workStarted;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem workDone;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem finished;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem cancelled;
        private TextBox statusBox;
        private Button releaseButton;
        private DataGridViewTextBoxColumn issueID;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn uom;
        private DataGridViewTextBoxColumn sparePartCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sparePart;
        private DataGridViewTextBoxColumn issueState;
        private DataGridViewTextBoxColumn requestDate;
        private DataGridViewTextBoxColumn partPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
    }
}