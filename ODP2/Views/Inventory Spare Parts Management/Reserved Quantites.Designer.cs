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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservedQuantites));
            this.ReservedIssuesGridView = new System.Windows.Forms.DataGridView();
            this.issueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ReservedIssuesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedIssuesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueIDDataGridViewTextBoxColumn,
            this.workOrderID,
            this.equipmentID,
            this.directive,
            this.sparePartCodeDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn});
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
            // issueID
            // 
            this.issueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueID.DataPropertyName = "issueID";
            this.issueID.HeaderText = "Issue ID";
            this.issueID.Name = "issueID";
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataSource = typeof(ODP2.Models.ISSUE);
            // 
            // issueIDDataGridViewTextBoxColumn
            // 
            this.issueIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueIDDataGridViewTextBoxColumn.DataPropertyName = "issueID";
            this.issueIDDataGridViewTextBoxColumn.HeaderText = "Issue ID";
            this.issueIDDataGridViewTextBoxColumn.Name = "issueIDDataGridViewTextBoxColumn";
            this.issueIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.issueIDDataGridViewTextBoxColumn.Width = 71;
            // 
            // workOrderID
            // 
            this.workOrderID.DataPropertyName = "workOrderID";
            this.workOrderID.HeaderText = "Work Order";
            this.workOrderID.Name = "workOrderID";
            this.workOrderID.ReadOnly = true;
            // 
            // equipmentID
            // 
            this.equipmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentID.DataPropertyName = "workOrderEquipmentID";
            this.equipmentID.HeaderText = "Equipment";
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.ReadOnly = true;
            this.equipmentID.Width = 82;
            // 
            // directive
            // 
            this.directive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.directive.DataPropertyName = "workOrderDirective";
            this.directive.HeaderText = "Work Order Directive";
            this.directive.Name = "directive";
            this.directive.ReadOnly = true;
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
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 48;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "requestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "Request Date";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestDateDataGridViewTextBoxColumn.Width = 90;
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
        private System.Windows.Forms.BindingSource issueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn directive;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
    }
}