namespace ODP2.Views.Inventory_Spare_Parts_Management
{
    partial class IssueSparePart
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
            this.workOrderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.issueGridView = new System.Windows.Forms.DataGridView();
            this.selectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.issueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issueButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unissueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.issueGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workOrderTextBox
            // 
            this.workOrderTextBox.Location = new System.Drawing.Point(73, 34);
            this.workOrderTextBox.Name = "workOrderTextBox";
            this.workOrderTextBox.Size = new System.Drawing.Size(87, 20);
            this.workOrderTextBox.TabIndex = 19;
            this.workOrderTextBox.Validated += new System.EventHandler(this.workOrderTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Work Order";
            // 
            // issueGridView
            // 
            this.issueGridView.AllowUserToAddRows = false;
            this.issueGridView.AllowUserToDeleteRows = false;
            this.issueGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueGridView.AutoGenerateColumns = false;
            this.issueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn,
            this.issueID,
            this.workOrder,
            this.qty,
            this.uom,
            this.sparePartCode,
            this.partDirective,
            this.issueState,
            this.requestDate,
            this.issueDate});
            this.issueGridView.DataSource = this.issueBindingSource;
            this.issueGridView.Location = new System.Drawing.Point(8, 66);
            this.issueGridView.Name = "issueGridView";
            this.issueGridView.ReadOnly = true;
            this.issueGridView.RowHeadersVisible = false;
            this.issueGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.issueGridView.Size = new System.Drawing.Size(652, 295);
            this.issueGridView.TabIndex = 20;
            this.issueGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueGridView_CellContentClick);
            // 
            // selectColumn
            // 
            this.selectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.selectColumn.FalseValue = "";
            this.selectColumn.HeaderText = "Select";
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.ReadOnly = true;
            this.selectColumn.TrueValue = "true";
            this.selectColumn.Width = 43;
            // 
            // issueID
            // 
            this.issueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueID.DataPropertyName = "issueID";
            this.issueID.HeaderText = "Issue ID";
            this.issueID.Name = "issueID";
            this.issueID.ReadOnly = true;
            this.issueID.Width = 66;
            // 
            // workOrder
            // 
            this.workOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrder.DataPropertyName = "workOrder";
            this.workOrder.HeaderText = "Work Order";
            this.workOrder.Name = "workOrder";
            this.workOrder.ReadOnly = true;
            this.workOrder.Width = 80;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 48;
            // 
            // uom
            // 
            this.uom.DataPropertyName = "uom";
            this.uom.HeaderText = "UoM";
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            // 
            // sparePartCode
            // 
            this.sparePartCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sparePartCode.DataPropertyName = "sparePartCode";
            this.sparePartCode.HeaderText = "Spare Part Code";
            this.sparePartCode.Name = "sparePartCode";
            this.sparePartCode.ReadOnly = true;
            // 
            // partDirective
            // 
            this.partDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partDirective.DataPropertyName = "partDirective";
            this.partDirective.HeaderText = "Description";
            this.partDirective.Name = "partDirective";
            this.partDirective.ReadOnly = true;
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
            // issueDate
            // 
            this.issueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueDate.DataPropertyName = "issueDate";
            this.issueDate.HeaderText = "Issue Date";
            this.issueDate.Name = "issueDate";
            this.issueDate.ReadOnly = true;
            this.issueDate.Width = 77;
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataSource = typeof(ODP2.Models.ISSUE);
            // 
            // issueButton
            // 
            this.issueButton.Enabled = false;
            this.issueButton.Location = new System.Drawing.Point(217, 8);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(128, 23);
            this.issueButton.TabIndex = 21;
            this.issueButton.Text = "Issue";
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(73, 8);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker.TabIndex = 22;
            this.dateTimePicker.Validated += new System.EventHandler(this.dateTimePicker_Validated);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(18, 11);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dateCheckBox.TabIndex = 23;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sparePart";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unissueButton
            // 
            this.unissueButton.Enabled = false;
            this.unissueButton.Location = new System.Drawing.Point(217, 37);
            this.unissueButton.Name = "unissueButton";
            this.unissueButton.Size = new System.Drawing.Size(128, 23);
            this.unissueButton.TabIndex = 21;
            this.unissueButton.Text = "Un-Issue";
            this.unissueButton.UseVisualStyleBackColor = true;
            this.unissueButton.Click += new System.EventHandler(this.unissueButton_Click);
            // 
            // IssueSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.unissueButton);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.issueGridView);
            this.Controls.Add(this.workOrderTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IssueSparePart";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(668, 369);
            this.Load += new System.EventHandler(this.IssueSparePart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox workOrderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView issueGridView;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button unissueButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDirective;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueState;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDate;
    }
}