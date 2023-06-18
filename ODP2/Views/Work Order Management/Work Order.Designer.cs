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
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bdnHoursTextbox = new System.Windows.Forms.TextBox();
            this.workOrderTabs = new System.Windows.Forms.TabControl();
            this.materialsTab = new System.Windows.Forms.TabPage();
            this.materialsGridView = new System.Windows.Forms.DataGridView();
            this.issueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label3 = new System.Windows.Forms.Label();
            this.pmCheclistButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workOrderStatusID = new System.Windows.Forms.ComboBox();
            this.workOrderStatuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDirectiveTextBox = new System.Windows.Forms.TextBox();
            this.workOrderDirective = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.workOrderTextBox.Enabled = false;
            this.workOrderTextBox.Location = new System.Drawing.Point(79, 10);
            this.workOrderTextBox.Name = "workOrderTextBox";
            this.workOrderTextBox.ReadOnly = true;
            this.workOrderTextBox.Size = new System.Drawing.Size(94, 20);
            this.workOrderTextBox.TabIndex = 2;
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.DataSource = typeof(ODP2.Models.workOrder);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(506, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 21);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.equipment);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ODP2.Models.user);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Materials Issued";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(431, 5);
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
            this.workOrderTabs.Location = new System.Drawing.Point(10, 192);
            this.workOrderTabs.Name = "workOrderTabs";
            this.workOrderTabs.SelectedIndex = 0;
            this.workOrderTabs.Size = new System.Drawing.Size(711, 446);
            this.workOrderTabs.TabIndex = 6;
            // 
            // materialsTab
            // 
            this.materialsTab.Controls.Add(this.materialsGridView);
            this.materialsTab.Controls.Add(this.label6);
            this.materialsTab.Controls.Add(this.label12);
            this.materialsTab.Location = new System.Drawing.Point(4, 22);
            this.materialsTab.Name = "materialsTab";
            this.materialsTab.Padding = new System.Windows.Forms.Padding(3);
            this.materialsTab.Size = new System.Drawing.Size(703, 387);
            this.materialsTab.TabIndex = 0;
            this.materialsTab.Text = "Materials";
            this.materialsTab.UseVisualStyleBackColor = true;
            // 
            // materialsGridView
            // 
            this.materialsGridView.AllowUserToAddRows = false;
            this.materialsGridView.AllowUserToDeleteRows = false;
            this.materialsGridView.AutoGenerateColumns = false;
            this.materialsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.sparePartCodeDataGridViewTextBoxColumn,
            this.sparePart,
            this.partPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn});
            this.materialsGridView.DataSource = this.issueBindingSource;
            this.materialsGridView.Location = new System.Drawing.Point(8, 32);
            this.materialsGridView.Name = "materialsGridView";
            this.materialsGridView.ReadOnly = true;
            this.materialsGridView.Size = new System.Drawing.Size(689, 382);
            this.materialsGridView.TabIndex = 1;
            // 
            // issueIDDataGridViewTextBoxColumn
            // 
            this.issueIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.issueIDDataGridViewTextBoxColumn.DataPropertyName = "issueID";
            this.issueIDDataGridViewTextBoxColumn.HeaderText = "Issue#";
            this.issueIDDataGridViewTextBoxColumn.Name = "issueIDDataGridViewTextBoxColumn";
            this.issueIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.issueIDDataGridViewTextBoxColumn.Width = 64;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 48;
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
            this.issueBindingSource.DataSource = typeof(ODP2.Models.issue);
            // 
            // bdnTab
            // 
            this.bdnTab.Controls.Add(this.bdnGridView);
            this.bdnTab.Controls.Add(this.bdnHoursTextbox);
            this.bdnTab.Controls.Add(this.label17);
            this.bdnTab.Location = new System.Drawing.Point(4, 22);
            this.bdnTab.Name = "bdnTab";
            this.bdnTab.Padding = new System.Windows.Forms.Padding(3);
            this.bdnTab.Size = new System.Drawing.Size(703, 387);
            this.bdnTab.TabIndex = 1;
            this.bdnTab.Text = "BDN";
            this.bdnTab.UseVisualStyleBackColor = true;
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
            this.bdnGridView.Size = new System.Drawing.Size(697, 344);
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
            this.breakDownBindingSource.DataSource = typeof(ODP2.Models.breakDown);
            // 
            // stepsAndNotesTab
            // 
            this.stepsAndNotesTab.BackColor = System.Drawing.Color.Transparent;
            this.stepsAndNotesTab.Controls.Add(this.workOrderNotes);
            this.stepsAndNotesTab.Controls.Add(this.workDoneType);
            this.stepsAndNotesTab.Controls.Add(this.pmCheclistButton);
            this.stepsAndNotesTab.Controls.Add(this.label3);
            this.stepsAndNotesTab.Location = new System.Drawing.Point(4, 22);
            this.stepsAndNotesTab.Name = "stepsAndNotesTab";
            this.stepsAndNotesTab.Padding = new System.Windows.Forms.Padding(3);
            this.stepsAndNotesTab.Size = new System.Drawing.Size(703, 420);
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
            this.workOrderNotes.Size = new System.Drawing.Size(695, 352);
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
            this.workDoneTypeBindingSource.DataSource = typeof(ODP2.Models.workDoneType);
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
            // pmCheclistButton
            // 
            this.pmCheclistButton.Image = ((System.Drawing.Image)(resources.GetObject("pmCheclistButton.Image")));
            this.pmCheclistButton.Location = new System.Drawing.Point(575, 5);
            this.pmCheclistButton.Name = "pmCheclistButton";
            this.pmCheclistButton.Size = new System.Drawing.Size(122, 27);
            this.pmCheclistButton.TabIndex = 2;
            this.pmCheclistButton.Text = "Attachment";
            this.pmCheclistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pmCheclistButton.UseVisualStyleBackColor = true;
            this.pmCheclistButton.Click += new System.EventHandler(this.pmChecklist_Button);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.workOrderStatusID);
            this.panel1.Controls.Add(this.equipmentDirectiveTextBox);
            this.panel1.Controls.Add(this.workOrderDirective);
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
            this.panel1.Size = new System.Drawing.Size(710, 150);
            this.panel1.TabIndex = 7;
            // 
            // workOrderStatusID
            // 
            this.workOrderStatusID.DataSource = this.workOrderStatuBindingSource;
            this.workOrderStatusID.DisplayMember = "workOrderStatusID";
            this.workOrderStatusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workOrderStatusID.FormattingEnabled = true;
            this.workOrderStatusID.Location = new System.Drawing.Point(68, 89);
            this.workOrderStatusID.Name = "workOrderStatusID";
            this.workOrderStatusID.Size = new System.Drawing.Size(93, 21);
            this.workOrderStatusID.TabIndex = 14;
            this.workOrderStatusID.SelectedIndexChanged += new System.EventHandler(this.statusTextBox_SelectedIndexChanged);
            // 
            // workOrderStatuBindingSource
            // 
            this.workOrderStatuBindingSource.DataSource = typeof(ODP2.Models.workOrderStatu);
            // 
            // equipmentDirectiveTextBox
            // 
            this.equipmentDirectiveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentDirective", true));
            this.equipmentDirectiveTextBox.Enabled = false;
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
            this.workOrderDirective.Size = new System.Drawing.Size(326, 20);
            this.workOrderDirective.TabIndex = 20;
            // 
            // creatorIDTextBox
            // 
            this.creatorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "userIDNumber", true));
            this.creatorIDTextBox.Enabled = false;
            this.creatorIDTextBox.Location = new System.Drawing.Point(68, 63);
            this.creatorIDTextBox.Name = "creatorIDTextBox";
            this.creatorIDTextBox.ReadOnly = true;
            this.creatorIDTextBox.Size = new System.Drawing.Size(93, 20);
            this.creatorIDTextBox.TabIndex = 19;
            // 
            // creatorNameTextBox
            // 
            this.creatorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "userName", true));
            this.creatorNameTextBox.Enabled = false;
            this.creatorNameTextBox.Location = new System.Drawing.Point(167, 63);
            this.creatorNameTextBox.Name = "creatorNameTextBox";
            this.creatorNameTextBox.ReadOnly = true;
            this.creatorNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.creatorNameTextBox.TabIndex = 16;
            // 
            // workTypeDirectiveTextBox
            // 
            this.workTypeDirectiveTextBox.Enabled = false;
            this.workTypeDirectiveTextBox.Location = new System.Drawing.Point(167, 38);
            this.workTypeDirectiveTextBox.Name = "workTypeDirectiveTextBox";
            this.workTypeDirectiveTextBox.ReadOnly = true;
            this.workTypeDirectiveTextBox.Size = new System.Drawing.Size(143, 20);
            this.workTypeDirectiveTextBox.TabIndex = 25;
            // 
            // workTypeTextBox
            // 
            this.workTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderTypeID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.workTypeTextBox.Enabled = false;
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
            this.workOrderFinishDate.Location = new System.Drawing.Point(535, 119);
            this.workOrderFinishDate.Name = "workOrderFinishDate";
            this.workOrderFinishDate.ReadOnly = true;
            this.workOrderFinishDate.Size = new System.Drawing.Size(122, 20);
            this.workOrderFinishDate.TabIndex = 17;
            // 
            // workDoneDate
            // 
            this.workDoneDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workDoneDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "g"));
            this.workDoneDate.Location = new System.Drawing.Point(535, 91);
            this.workDoneDate.Name = "workDoneDate";
            this.workDoneDate.ReadOnly = true;
            this.workDoneDate.Size = new System.Drawing.Size(122, 20);
            this.workDoneDate.TabIndex = 17;
            // 
            // workStartDate
            // 
            this.workStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workStartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "g"));
            this.workStartDate.Location = new System.Drawing.Point(535, 65);
            this.workStartDate.Name = "workStartDate";
            this.workStartDate.ReadOnly = true;
            this.workStartDate.Size = new System.Drawing.Size(122, 20);
            this.workStartDate.TabIndex = 17;
            // 
            // registerationDate
            // 
            this.registerationDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderRegisterationDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "g"));
            this.registerationDate.Location = new System.Drawing.Point(535, 39);
            this.registerationDate.Name = "registerationDate";
            this.registerationDate.Size = new System.Drawing.Size(122, 20);
            this.registerationDate.TabIndex = 17;
            // 
            // equipmentHR
            // 
            this.equipmentHR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "equipmentRH", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "N2"));
            this.equipmentHR.Enabled = false;
            this.equipmentHR.Location = new System.Drawing.Point(536, 13);
            this.equipmentHR.Name = "equipmentHR";
            this.equipmentHR.ReadOnly = true;
            this.equipmentHR.Size = new System.Drawing.Size(122, 20);
            this.equipmentHR.TabIndex = 17;
            // 
            // equipmentIDTextBox
            // 
            this.equipmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderEquipmentID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.equipmentIDTextBox.Enabled = false;
            this.equipmentIDTextBox.Location = new System.Drawing.Point(68, 13);
            this.equipmentIDTextBox.Name = "equipmentIDTextBox";
            this.equipmentIDTextBox.ReadOnly = true;
            this.equipmentIDTextBox.Size = new System.Drawing.Size(93, 20);
            this.equipmentIDTextBox.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(434, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Registeration Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Finish Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Work Done Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 71);
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
            this.label9.Location = new System.Drawing.Point(453, 16);
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
            this.finishDatePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.finishDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finishDatePicker.Location = new System.Drawing.Point(535, 119);
            this.finishDatePicker.Name = "finishDatePicker";
            this.finishDatePicker.Size = new System.Drawing.Size(150, 20);
            this.finishDatePicker.TabIndex = 26;
            this.finishDatePicker.Visible = false;
            this.finishDatePicker.ValueChanged += new System.EventHandler(this.datePickerValidated);
            // 
            // doneDatePicker
            // 
            this.doneDatePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.doneDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.doneDatePicker.Location = new System.Drawing.Point(535, 91);
            this.doneDatePicker.Name = "doneDatePicker";
            this.doneDatePicker.Size = new System.Drawing.Size(150, 20);
            this.doneDatePicker.TabIndex = 26;
            this.doneDatePicker.Visible = false;
            this.doneDatePicker.ValueChanged += new System.EventHandler(this.datePickerValidated);
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(535, 65);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(150, 20);
            this.startDatePicker.TabIndex = 26;
            this.startDatePicker.Visible = false;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.datePickerValidated);
            // 
            // registerationDatePicker
            // 
            this.registerationDatePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.registerationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.registerationDatePicker.Location = new System.Drawing.Point(536, 39);
            this.registerationDatePicker.Name = "registerationDatePicker";
            this.registerationDatePicker.Size = new System.Drawing.Size(149, 20);
            this.registerationDatePicker.TabIndex = 26;
            this.registerationDatePicker.Visible = false;
            this.registerationDatePicker.ValueChanged += new System.EventHandler(this.datePickerValidated);
            // 
            // WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.workOrderTabs);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.workOrderTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Order #";
            this.Load += new System.EventHandler(this.WorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private TextBox workOrderTextBox;
        private Button saveButton;
        private Label label1;
        private Label label6;
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
        private BindingSource equipmentBindingSource;
        private BindingSource userBindingSource;
        private DataGridView materialsGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn bdnReasonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fromTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workOrder1DataGridViewTextBoxColumn;
        private BindingSource breakDownBindingSource;
        private DataGridViewTextBoxColumn sparePartDataGridViewTextBoxColumn;
        private BindingSource issueBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn issueIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sparePartCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sparePart;
        private DataGridViewTextBoxColumn partPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private Panel panel1;
        private ComboBox workOrderStatusID;
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
    }
}