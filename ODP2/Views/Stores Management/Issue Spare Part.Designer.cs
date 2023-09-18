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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.issueGridView = new System.Windows.Forms.DataGridView();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.unissueButton = new System.Windows.Forms.Button();
            this.issueButton = new System.Windows.Forms.Button();
            this.workOrderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.issueIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requesterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.issueGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // issueGridView
            // 
            this.issueGridView.AllowUserToAddRows = false;
            this.issueGridView.AllowUserToDeleteRows = false;
            this.issueGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.issueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn,
            this.issueIDColumn,
            this.workOrder,
            this.partCode,
            this.partDirective,
            this.qty,
            this.uom,
            this.partPrice,
            this.totalPrice,
            this.issueState,
            this.requestDate,
            this.requesterID,
            this.issueDate,
            this.issuerID});
            this.issueGridView.DataSource = this.issueBindingSource;
            this.issueGridView.Location = new System.Drawing.Point(8, 135);
            this.issueGridView.Name = "issueGridView";
            this.issueGridView.RowHeadersVisible = false;
            this.issueGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.issueGridView.Size = new System.Drawing.Size(1228, 287);
            this.issueGridView.TabIndex = 20;
            this.issueGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueGridView_CellContentClick);
            this.issueGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.issueGridView_CellFormatting);
            this.issueGridView.Leave += new System.EventHandler(this.issueGridView_Leave);
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.AllowNew = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sparePart";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateCheckBox);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.unissueButton);
            this.panel1.Controls.Add(this.issueButton);
            this.panel1.Controls.Add(this.workOrderTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1228, 121);
            this.panel1.TabIndex = 24;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(21, 9);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dateCheckBox.TabIndex = 29;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(76, 8);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker.TabIndex = 28;
            this.dateTimePicker.Validated += new System.EventHandler(this.dateTimePicker_Validated);
            // 
            // unissueButton
            // 
            this.unissueButton.Enabled = false;
            this.unissueButton.Location = new System.Drawing.Point(11, 89);
            this.unissueButton.Name = "unissueButton";
            this.unissueButton.Size = new System.Drawing.Size(128, 23);
            this.unissueButton.TabIndex = 26;
            this.unissueButton.Text = "Un-Issue";
            this.unissueButton.UseVisualStyleBackColor = true;
            this.unissueButton.Click += new System.EventHandler(this.unissueButton_Click);
            // 
            // issueButton
            // 
            this.issueButton.Enabled = false;
            this.issueButton.Location = new System.Drawing.Point(11, 60);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(128, 23);
            this.issueButton.TabIndex = 27;
            this.issueButton.Text = "Issue";
            this.issueButton.UseVisualStyleBackColor = true;
            this.issueButton.Click += new System.EventHandler(this.issueButton_Click);
            // 
            // workOrderTextBox
            // 
            this.workOrderTextBox.Location = new System.Drawing.Point(76, 34);
            this.workOrderTextBox.Name = "workOrderTextBox";
            this.workOrderTextBox.Size = new System.Drawing.Size(138, 20);
            this.workOrderTextBox.TabIndex = 25;
            this.workOrderTextBox.Validated += new System.EventHandler(this.workOrderTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Work Order";
            // 
            // selectColumn
            // 
            this.selectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.selectColumn.FalseValue = "";
            this.selectColumn.HeaderText = "Select";
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.TrueValue = "true";
            this.selectColumn.Width = 55;
            // 
            // issueIDColumn
            // 
            this.issueIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueIDColumn.DataPropertyName = "ISSUEID";
            this.issueIDColumn.HeaderText = "Issue #";
            this.issueIDColumn.Name = "issueIDColumn";
            this.issueIDColumn.Width = 78;
            // 
            // workOrder
            // 
            this.workOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrder.DataPropertyName = "WORKORDER";
            this.workOrder.HeaderText = "Work Order";
            this.workOrder.Name = "workOrder";
            this.workOrder.ReadOnly = true;
            this.workOrder.Width = 97;
            // 
            // partCode
            // 
            this.partCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partCode.DataPropertyName = "SPAREPARTCODE";
            this.partCode.HeaderText = "Part Code";
            this.partCode.Name = "partCode";
            this.partCode.ReadOnly = true;
            // 
            // partDirective
            // 
            this.partDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partDirective.DataPropertyName = "PARTDIRECTIVE";
            this.partDirective.HeaderText = "Description";
            this.partDirective.Name = "partDirective";
            this.partDirective.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "QTY";
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 56;
            // 
            // uom
            // 
            this.uom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uom.DataPropertyName = "UOM";
            this.uom.HeaderText = "UoM";
            this.uom.Name = "uom";
            this.uom.ReadOnly = true;
            this.uom.Width = 62;
            // 
            // partPrice
            // 
            this.partPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partPrice.DataPropertyName = "PARTPRICE";
            this.partPrice.HeaderText = "Part Price";
            this.partPrice.Name = "partPrice";
            this.partPrice.ReadOnly = true;
            this.partPrice.Width = 86;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalPrice.DataPropertyName = "TOTALPRICE";
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 94;
            // 
            // issueState
            // 
            this.issueState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueState.DataPropertyName = "ISSUESTATE";
            this.issueState.HeaderText = "Status";
            this.issueState.Name = "issueState";
            this.issueState.ReadOnly = true;
            this.issueState.Width = 76;
            // 
            // requestDate
            // 
            this.requestDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.requestDate.DataPropertyName = "REQUESTDATE";
            this.requestDate.HeaderText = "Request Date";
            this.requestDate.Name = "requestDate";
            this.requestDate.ReadOnly = true;
            this.requestDate.Width = 113;
            // 
            // requesterID
            // 
            this.requesterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.requesterID.DataPropertyName = "requesterName";
            this.requesterID.HeaderText = "Requester";
            this.requesterID.Name = "requesterID";
            this.requesterID.ReadOnly = true;
            // 
            // issueDate
            // 
            this.issueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueDate.DataPropertyName = "ISSUEDATE";
            this.issueDate.HeaderText = "Issue Date";
            this.issueDate.Name = "issueDate";
            this.issueDate.ReadOnly = true;
            this.issueDate.Width = 94;
            // 
            // issuerID
            // 
            this.issuerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issuerID.DataPropertyName = "issuerName";
            this.issuerID.HeaderText = "Issuer";
            this.issuerID.Name = "issuerID";
            this.issuerID.ReadOnly = true;
            this.issuerID.Width = 71;
            // 
            // IssueSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.issueGridView);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IssueSparePart";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1244, 430);
            this.Load += new System.EventHandler(this.IssueSparePart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView issueGridView;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button unissueButton;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.TextBox workOrderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDirective;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueState;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn requesterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuerID;
    }
}