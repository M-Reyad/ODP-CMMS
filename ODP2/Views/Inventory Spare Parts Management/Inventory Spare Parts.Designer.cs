namespace ODP2.Views.Inventory_Spare_Parts_Management
{
    partial class InventorySpareParts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sparePartGridView = new System.Windows.Forms.DataGridView();
            this.partCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onHandStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compatableEquipmentFamilyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.partDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manPNTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.partCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sparePartGridView
            // 
            this.sparePartGridView.AllowUserToAddRows = false;
            this.sparePartGridView.AllowUserToDeleteRows = false;
            this.sparePartGridView.AllowUserToOrderColumns = true;
            this.sparePartGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sparePartGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sparePartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sparePartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sparePartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partCode,
            this.partDescription,
            this.onHandStock,
            this.reservedStock,
            this.availableStock,
            this.manufacturerPN,
            this.partPrice,
            this.compatableEquipmentFamilyID});
            this.sparePartGridView.DataSource = this.sparePartBindingSource;
            this.sparePartGridView.Location = new System.Drawing.Point(8, 129);
            this.sparePartGridView.Name = "sparePartGridView";
            this.sparePartGridView.RowHeadersVisible = false;
            this.sparePartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sparePartGridView.Size = new System.Drawing.Size(784, 362);
            this.sparePartGridView.TabIndex = 3;
            // 
            // partCode
            // 
            this.partCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partCode.DataPropertyName = "partCode";
            this.partCode.HeaderText = "Part Code";
            this.partCode.Name = "partCode";
            this.partCode.Width = 79;
            // 
            // partDescription
            // 
            this.partDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partDescription.DataPropertyName = "partDirective";
            this.partDescription.HeaderText = "Part Description";
            this.partDescription.Name = "partDescription";
            // 
            // onHandStock
            // 
            this.onHandStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.onHandStock.DataPropertyName = "partStockQty";
            this.onHandStock.HeaderText = "On-Hand Stock";
            this.onHandStock.Name = "onHandStock";
            this.onHandStock.Width = 107;
            // 
            // reservedStock
            // 
            this.reservedStock.DataPropertyName = "reservedStock";
            this.reservedStock.HeaderText = "Reserved";
            this.reservedStock.Name = "reservedStock";
            // 
            // availableStock
            // 
            this.availableStock.DataPropertyName = "availableStock";
            this.availableStock.HeaderText = "Available Qty";
            this.availableStock.Name = "availableStock";
            // 
            // manufacturerPN
            // 
            this.manufacturerPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturerPN.DataPropertyName = "manufacturerPN";
            this.manufacturerPN.HeaderText = "Manufacturer PN";
            this.manufacturerPN.Name = "manufacturerPN";
            // 
            // partPrice
            // 
            this.partPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partPrice.DataPropertyName = "partPrice";
            this.partPrice.HeaderText = "Part Price";
            this.partPrice.Name = "partPrice";
            // 
            // compatableEquipmentFamilyID
            // 
            this.compatableEquipmentFamilyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.compatableEquipmentFamilyID.DataPropertyName = "compatableEquipmentFamilyID";
            this.compatableEquipmentFamilyID.HeaderText = "Equipment Family";
            this.compatableEquipmentFamilyID.Name = "compatableEquipmentFamilyID";
            // 
            // sparePartBindingSource
            // 
            this.sparePartBindingSource.DataSource = typeof(ODP2.Models.sparePart);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.partDescriptionTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.manPNTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.partCodeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 114);
            this.panel1.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(70, 86);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // partDescriptionTextBox
            // 
            this.partDescriptionTextBox.Location = new System.Drawing.Point(70, 60);
            this.partDescriptionTextBox.Name = "partDescriptionTextBox";
            this.partDescriptionTextBox.Size = new System.Drawing.Size(176, 20);
            this.partDescriptionTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Part Desc.";
            // 
            // manPNTextBox
            // 
            this.manPNTextBox.Location = new System.Drawing.Point(70, 34);
            this.manPNTextBox.Name = "manPNTextBox";
            this.manPNTextBox.Size = new System.Drawing.Size(176, 20);
            this.manPNTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Man. P/N";
            // 
            // partCodeTextBox
            // 
            this.partCodeTextBox.Location = new System.Drawing.Point(70, 8);
            this.partCodeTextBox.Name = "partCodeTextBox";
            this.partCodeTextBox.Size = new System.Drawing.Size(176, 20);
            this.partCodeTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Part Code";
            // 
            // InventorySpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sparePartGridView);
            this.Name = "InventorySpareParts";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(800, 499);
            ((System.ComponentModel.ISupportInitialize)(this.sparePartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView sparePartGridView;
        private System.Windows.Forms.BindingSource sparePartBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox partDescriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox manPNTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn onHandStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn compatableEquipmentFamilyID;
    }
}
