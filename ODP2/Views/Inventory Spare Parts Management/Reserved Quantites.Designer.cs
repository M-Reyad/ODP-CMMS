namespace ODP2.Views.Inventory_Spare_Parts_Management
{
    partial class ReservedQuantites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservedQuantites));
            this.ReservedIssuesGridView = new System.Windows.Forms.DataGridView();
            this.issueIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderDirectiveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQUESTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKORDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReservedIssuesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservedIssuesGridView
            // 
            this.ReservedIssuesGridView.AllowUserToAddRows = false;
            this.ReservedIssuesGridView.AllowUserToDeleteRows = false;
            this.ReservedIssuesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReservedIssuesGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservedIssuesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReservedIssuesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedIssuesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueIDColumn,
            this.workOrderIDNumber,
            this.equipmentIDColumn,
            this.workOrderDirectiveColumn,
            this.partCode,
            this.qtyColumn,
            this.requestDateColumn});
            this.ReservedIssuesGridView.DataSource = this.issueBindingSource;
            this.ReservedIssuesGridView.Location = new System.Drawing.Point(8, 8);
            this.ReservedIssuesGridView.MultiSelect = false;
            this.ReservedIssuesGridView.Name = "ReservedIssuesGridView";
            this.ReservedIssuesGridView.ReadOnly = true;
            this.ReservedIssuesGridView.RowHeadersVisible = false;
            this.ReservedIssuesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservedIssuesGridView.Size = new System.Drawing.Size(747, 394);
            this.ReservedIssuesGridView.TabIndex = 0;
            this.ReservedIssuesGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // issueIDColumn
            // 
            this.issueIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueIDColumn.DataPropertyName = "ISSUEID";
            this.issueIDColumn.HeaderText = "Issue #";
            this.issueIDColumn.Name = "issueIDColumn";
            this.issueIDColumn.ReadOnly = true;
            this.issueIDColumn.Width = 72;
            // 
            // workOrderIDNumber
            // 
            this.workOrderIDNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderIDNumber.DataPropertyName = "WORKORDERID";
            this.workOrderIDNumber.HeaderText = "WO #";
            this.workOrderIDNumber.Name = "workOrderIDNumber";
            this.workOrderIDNumber.ReadOnly = true;
            this.workOrderIDNumber.Width = 53;
            // 
            // equipmentIDColumn
            // 
            this.equipmentIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentIDColumn.DataPropertyName = "WORKORDEREQUIPMENTID";
            this.equipmentIDColumn.HeaderText = "Equipment";
            this.equipmentIDColumn.Name = "equipmentIDColumn";
            this.equipmentIDColumn.ReadOnly = true;
            this.equipmentIDColumn.Width = 103;
            // 
            // workOrderDirectiveColumn
            // 
            this.workOrderDirectiveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workOrderDirectiveColumn.DataPropertyName = "WORKORDERDIRECTIVE";
            this.workOrderDirectiveColumn.HeaderText = "WorkOrder Directive";
            this.workOrderDirectiveColumn.Name = "workOrderDirectiveColumn";
            this.workOrderDirectiveColumn.ReadOnly = true;
            // 
            // partCode
            // 
            this.partCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partCode.DataPropertyName = "SPAREPARTCODE";
            this.partCode.HeaderText = "Part Code";
            this.partCode.Name = "partCode";
            this.partCode.ReadOnly = true;
            this.partCode.Width = 88;
            // 
            // qtyColumn
            // 
            this.qtyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtyColumn.DataPropertyName = "QTY";
            this.qtyColumn.HeaderText = "QTY";
            this.qtyColumn.Name = "qtyColumn";
            this.qtyColumn.ReadOnly = true;
            this.qtyColumn.Width = 59;
            // 
            // requestDateColumn
            // 
            this.requestDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.requestDateColumn.DataPropertyName = "REQUESTDATE";
            this.requestDateColumn.HeaderText = "Request Date";
            this.requestDateColumn.Name = "requestDateColumn";
            this.requestDateColumn.ReadOnly = true;
            this.requestDateColumn.Width = 113;
            // 
            // issueID
            // 
            this.issueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueID.DataPropertyName = "issueID";
            this.issueID.HeaderText = "Issue ID";
            this.issueID.Name = "issueID";
            // 
            // workOrderID
            // 
            this.workOrderID.DataPropertyName = "WORKORDERID";
            this.workOrderID.HeaderText = "Work Order";
            this.workOrderID.Name = "workOrderID";
            // 
            // equipmentID
            // 
            this.equipmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentID.DataPropertyName = "WORKORDEREQUIPMENTID";
            this.equipmentID.HeaderText = "Equipment";
            this.equipmentID.Name = "equipmentID";
            // 
            // directive
            // 
            this.directive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.directive.DataPropertyName = "WORKORDERDIRECTIVE";
            this.directive.HeaderText = "Work Order Directive";
            this.directive.Name = "directive";
            // 
            // partDescription
            // 
            this.partDescription.DataPropertyName = "PARTDIRECTIVE";
            this.partDescription.HeaderText = "Part Description";
            this.partDescription.Name = "partDescription";
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "Qty";
            this.QTY.Name = "QTY";
            // 
            // REQUESTDATE
            // 
            this.REQUESTDATE.DataPropertyName = "REQUESTDATE";
            this.REQUESTDATE.HeaderText = "Request Date";
            this.REQUESTDATE.Name = "REQUESTDATE";
            // 
            // wORKORDERDataGridViewTextBoxColumn
            // 
            this.wORKORDERDataGridViewTextBoxColumn.DataPropertyName = "WORKORDER";
            this.wORKORDERDataGridViewTextBoxColumn.HeaderText = "WORKORDER";
            this.wORKORDERDataGridViewTextBoxColumn.Name = "wORKORDERDataGridViewTextBoxColumn";
            // 
            // ReservedQuantites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 410);
            this.Controls.Add(this.ReservedIssuesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReservedQuantites";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Reserved Quantites";
            this.Load += new System.EventHandler(this.ReservedQuantites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservedIssuesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReservedIssuesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn directive;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQUESTDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKORDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderDirectiveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateColumn;
    }
}