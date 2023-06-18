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
            this.sparePartGridView = new System.Windows.Forms.DataGridView();
            this.sparePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDirectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partStockQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compatableEquipmentFamilyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.componentComboBox = new System.Windows.Forms.ComboBox();
            this.equipmentFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentFamilyIDDirectiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemIDDirectiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sparePartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentFamilyIDDirectiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemIDDirectiveBindingSource)).BeginInit();
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
            this.sparePartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sparePartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partCodeDataGridViewTextBoxColumn,
            this.partDirectiveDataGridViewTextBoxColumn,
            this.partStockQtyDataGridViewTextBoxColumn,
            this.manufacturerPNDataGridViewTextBoxColumn,
            this.partPriceDataGridViewTextBoxColumn,
            this.compatableEquipmentFamilyIDDataGridViewTextBoxColumn});
            this.sparePartGridView.DataSource = this.sparePartBindingSource;
            this.sparePartGridView.Location = new System.Drawing.Point(8, 214);
            this.sparePartGridView.Name = "sparePartGridView";
            this.sparePartGridView.Size = new System.Drawing.Size(784, 277);
            this.sparePartGridView.TabIndex = 3;
            // 
            // sparePartBindingSource
            // 
            this.sparePartBindingSource.DataSource = typeof(ODP2.Models.sparePart);
            // 
            // partCodeDataGridViewTextBoxColumn
            // 
            this.partCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partCodeDataGridViewTextBoxColumn.DataPropertyName = "partCode";
            this.partCodeDataGridViewTextBoxColumn.HeaderText = "Part Code";
            this.partCodeDataGridViewTextBoxColumn.Name = "partCodeDataGridViewTextBoxColumn";
            this.partCodeDataGridViewTextBoxColumn.Width = 79;
            // 
            // partDirectiveDataGridViewTextBoxColumn
            // 
            this.partDirectiveDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partDirectiveDataGridViewTextBoxColumn.DataPropertyName = "partDirective";
            this.partDirectiveDataGridViewTextBoxColumn.HeaderText = "Part Description";
            this.partDirectiveDataGridViewTextBoxColumn.Name = "partDirectiveDataGridViewTextBoxColumn";
            // 
            // partStockQtyDataGridViewTextBoxColumn
            // 
            this.partStockQtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partStockQtyDataGridViewTextBoxColumn.DataPropertyName = "partStockQty";
            this.partStockQtyDataGridViewTextBoxColumn.HeaderText = "Stock Qty";
            this.partStockQtyDataGridViewTextBoxColumn.Name = "partStockQtyDataGridViewTextBoxColumn";
            this.partStockQtyDataGridViewTextBoxColumn.Width = 79;
            // 
            // manufacturerPNDataGridViewTextBoxColumn
            // 
            this.manufacturerPNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturerPNDataGridViewTextBoxColumn.DataPropertyName = "manufacturerPN";
            this.manufacturerPNDataGridViewTextBoxColumn.HeaderText = "Manufacturer PN";
            this.manufacturerPNDataGridViewTextBoxColumn.Name = "manufacturerPNDataGridViewTextBoxColumn";
            // 
            // partPriceDataGridViewTextBoxColumn
            // 
            this.partPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partPriceDataGridViewTextBoxColumn.DataPropertyName = "partPrice";
            this.partPriceDataGridViewTextBoxColumn.HeaderText = "Part Price";
            this.partPriceDataGridViewTextBoxColumn.Name = "partPriceDataGridViewTextBoxColumn";
            // 
            // compatableEquipmentFamilyIDDataGridViewTextBoxColumn
            // 
            this.compatableEquipmentFamilyIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.compatableEquipmentFamilyIDDataGridViewTextBoxColumn.DataPropertyName = "compatableEquipmentFamilyID";
            this.compatableEquipmentFamilyIDDataGridViewTextBoxColumn.HeaderText = "Equipment Family";
            this.compatableEquipmentFamilyIDDataGridViewTextBoxColumn.Name = "compatableEquipmentFamilyIDDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.componentComboBox);
            this.panel1.Controls.Add(this.equipmentFamilyComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 194);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.systemIDDirectiveBindingSource;
            this.comboBox3.DisplayMember = "systemID";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(70, 135);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(117, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // componentComboBox
            // 
            this.componentComboBox.DataSource = this.componentFamilyIDDirectiveBindingSource;
            this.componentComboBox.DisplayMember = "componentID";
            this.componentComboBox.FormattingEnabled = true;
            this.componentComboBox.Location = new System.Drawing.Point(70, 108);
            this.componentComboBox.Name = "componentComboBox";
            this.componentComboBox.Size = new System.Drawing.Size(117, 21);
            this.componentComboBox.TabIndex = 15;
            // 
            // equipmentFamilyComboBox
            // 
            this.equipmentFamilyComboBox.DataSource = this.equipmentFamilyBindingSource;
            this.equipmentFamilyComboBox.DisplayMember = "equipmentFamilyCode";
            this.equipmentFamilyComboBox.FormattingEnabled = true;
            this.equipmentFamilyComboBox.Location = new System.Drawing.Point(70, 81);
            this.equipmentFamilyComboBox.Name = "equipmentFamilyComboBox";
            this.equipmentFamilyComboBox.Size = new System.Drawing.Size(117, 21);
            this.equipmentFamilyComboBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Component";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Equipment";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Part Desc.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Man. P/N";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Part Code";
            // 
            // equipmentFamilyBindingSource
            // 
            this.equipmentFamilyBindingSource.DataSource = typeof(ODP2.Models.equipmentFamily);
            // 
            // componentFamilyIDDirectiveBindingSource
            // 
            this.componentFamilyIDDirectiveBindingSource.DataSource = typeof(ODP2.Models.componentFamilyIDDirective);
            // 
            // systemIDDirectiveBindingSource
            // 
            this.systemIDDirectiveBindingSource.DataSource = typeof(ODP2.Models.systemIDDirective);
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
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentFamilyIDDirectiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemIDDirectiveBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView sparePartGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDirectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partStockQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compatableEquipmentFamilyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sparePartBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox componentComboBox;
        private System.Windows.Forms.ComboBox equipmentFamilyComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource equipmentFamilyBindingSource;
        private System.Windows.Forms.BindingSource componentFamilyIDDirectiveBindingSource;
        private System.Windows.Forms.BindingSource systemIDDirectiveBindingSource;
    }
}
