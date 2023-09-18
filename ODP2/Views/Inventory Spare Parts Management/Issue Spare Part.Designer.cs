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
            this.label2 = new System.Windows.Forms.Label();
            this.partCodeTextBox = new System.Windows.Forms.TextBox();
            this.partDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.issueGridView = new System.Windows.Forms.DataGridView();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.issueGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workOrderTextBox
            // 
            this.workOrderTextBox.Location = new System.Drawing.Point(68, 29);
            this.workOrderTextBox.Name = "workOrderTextBox";
            this.workOrderTextBox.Size = new System.Drawing.Size(87, 20);
            this.workOrderTextBox.TabIndex = 19;
            this.workOrderTextBox.Validated += new System.EventHandler(this.workOrderTextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Work Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Part Code";
            // 
            // partCodeTextBox
            // 
            this.partCodeTextBox.Location = new System.Drawing.Point(68, 55);
            this.partCodeTextBox.Name = "partCodeTextBox";
            this.partCodeTextBox.Size = new System.Drawing.Size(164, 20);
            this.partCodeTextBox.TabIndex = 19;
            this.partCodeTextBox.Validated += new System.EventHandler(this.partCodeTextBox_Validated);
            // 
            // partDescriptionTextBox
            // 
            this.partDescriptionTextBox.Location = new System.Drawing.Point(238, 55);
            this.partDescriptionTextBox.Name = "partDescriptionTextBox";
            this.partDescriptionTextBox.ReadOnly = true;
            this.partDescriptionTextBox.Size = new System.Drawing.Size(283, 20);
            this.partDescriptionTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantity";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(68, 81);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(87, 20);
            this.quantityTextbox.TabIndex = 19;
            // 
            // issueGridView
            // 
            this.issueGridView.AllowUserToOrderColumns = true;
            this.issueGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueGridView.AutoGenerateColumns = false;
            this.issueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueID,
            this.workOrder,
            this.qty,
            this.sparePartCodeDataGridViewTextBoxColumn,
            this.partDirective,
            this.issueDate});
            this.issueGridView.DataSource = this.issueBindingSource;
            this.issueGridView.Location = new System.Drawing.Point(3, 108);
            this.issueGridView.Name = "issueGridView";
            this.issueGridView.ReadOnly = true;
            this.issueGridView.Size = new System.Drawing.Size(655, 241);
            this.issueGridView.TabIndex = 20;
            this.issueGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.issueGridView_UserDeletingRow);
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataSource = typeof(ODP2.Models.issue);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(527, 79);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 23);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(68, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker.TabIndex = 22;
            this.dateTimePicker.Validated += new System.EventHandler(this.dateTimePicker_Validated);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(13, 6);
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
            // issueID
            // 
            this.issueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueID.DataPropertyName = "issueID";
            this.issueID.HeaderText = "Issue ID";
            this.issueID.Name = "issueID";
            this.issueID.ReadOnly = true;
            this.issueID.Width = 71;
            // 
            // workOrder
            // 
            this.workOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.workOrder.DataPropertyName = "workOrder";
            this.workOrder.HeaderText = "Work Order";
            this.workOrder.Name = "workOrder";
            this.workOrder.ReadOnly = true;
            this.workOrder.Width = 87;
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
            // sparePartCodeDataGridViewTextBoxColumn
            // 
            this.sparePartCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sparePartCodeDataGridViewTextBoxColumn.DataPropertyName = "sparePartCode";
            this.sparePartCodeDataGridViewTextBoxColumn.HeaderText = "Spare Part Code";
            this.sparePartCodeDataGridViewTextBoxColumn.Name = "sparePartCodeDataGridViewTextBoxColumn";
            this.sparePartCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partDirective
            // 
            this.partDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partDirective.DataPropertyName = "partDirective";
            this.partDirective.HeaderText = "Description";
            this.partDirective.Name = "partDirective";
            this.partDirective.ReadOnly = true;
            // 
            // issueDate
            // 
            this.issueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issueDate.DataPropertyName = "issueDate";
            this.issueDate.HeaderText = "Issue Date";
            this.issueDate.Name = "issueDate";
            this.issueDate.ReadOnly = true;
            this.issueDate.Width = 83;
            // 
            // IssueSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.issueGridView);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.partCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partDescriptionTextBox);
            this.Controls.Add(this.workOrderTextBox);
            this.Controls.Add(this.label1);
            this.Name = "IssueSparePart";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partCodeTextBox;
        private System.Windows.Forms.TextBox partDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.DataGridView issueGridView;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDirective;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDate;
    }
}