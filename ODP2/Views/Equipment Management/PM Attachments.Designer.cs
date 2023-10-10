namespace ODP2.Views
{
    partial class PMAttachments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pmTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newPMTemplate = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.equipmentFamilyDirective = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentFamilyBox = new System.Windows.Forms.ComboBox();
            this.materialGridView = new System.Windows.Forms.DataGridView();
            this.partCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.equipmentFamilyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmDirectiveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmAttachment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.changeAttachment = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pmTemplateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentFamilyBindingSource
            // 
            this.equipmentFamilyBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENTFAMILY);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.attachmentsDataGrid, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 416);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.newPMTemplate);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.equipmentFamilyDirective);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.equipmentFamilyBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(718, 35);
            this.panel1.TabIndex = 9;
            // 
            // newPMTemplate
            // 
            this.newPMTemplate.CausesValidation = false;
            this.newPMTemplate.Location = new System.Drawing.Point(513, 9);
            this.newPMTemplate.Name = "newPMTemplate";
            this.newPMTemplate.Size = new System.Drawing.Size(103, 23);
            this.newPMTemplate.TabIndex = 8;
            this.newPMTemplate.Text = "Insert New PM";
            this.newPMTemplate.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(622, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // equipmentFamilyDirective
            // 
            this.equipmentFamilyDirective.Location = new System.Drawing.Point(207, 9);
            this.equipmentFamilyDirective.Name = "equipmentFamilyDirective";
            this.equipmentFamilyDirective.ReadOnly = true;
            this.equipmentFamilyDirective.Size = new System.Drawing.Size(300, 20);
            this.equipmentFamilyDirective.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Equipment Family";
            // 
            // equipmentFamilyBox
            // 
            this.equipmentFamilyBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.equipmentFamilyBindingSource, "equipmentFamilyCode", true));
            this.equipmentFamilyBox.DataSource = this.equipmentFamilyBindingSource;
            this.equipmentFamilyBox.DisplayMember = "equipmentFamilyCode";
            this.equipmentFamilyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentFamilyBox.FormattingEnabled = true;
            this.equipmentFamilyBox.Location = new System.Drawing.Point(103, 8);
            this.equipmentFamilyBox.Name = "equipmentFamilyBox";
            this.equipmentFamilyBox.Size = new System.Drawing.Size(98, 21);
            this.equipmentFamilyBox.TabIndex = 5;
            this.equipmentFamilyBox.SelectedIndexChanged += new System.EventHandler(this.equipmentFamilyBox_SelectedIndexChanged);
            // 
            // materialGridView
            // 
            this.materialGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materialGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partCode,
            this.partDirective,
            this.qty,
            this.uom});
            this.materialGridView.Location = new System.Drawing.Point(3, 231);
            this.materialGridView.Name = "materialGridView";
            this.materialGridView.RowHeadersVisible = false;
            this.materialGridView.Size = new System.Drawing.Size(718, 182);
            this.materialGridView.TabIndex = 7;
            // 
            // partCode
            // 
            this.partCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.partCode.DataPropertyName = "PARTCODE";
            this.partCode.HeaderText = "Part Code";
            this.partCode.Name = "partCode";
            this.partCode.Width = 88;
            // 
            // partDirective
            // 
            this.partDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partDirective.DataPropertyName = "PARTDESCRIPTION";
            this.partDirective.HeaderText = "Part Description";
            this.partDirective.Name = "partDirective";
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.DataPropertyName = "QTY";
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.Width = 56;
            // 
            // uom
            // 
            this.uom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uom.DataPropertyName = "UOM";
            this.uom.HeaderText = "UoM";
            this.uom.Name = "uom";
            this.uom.Width = 62;
            // 
            // attachmentsDataGrid
            // 
            this.attachmentsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentsDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attachmentsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.attachmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attachmentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentFamilyColumn,
            this.pmDirectiveColumn,
            this.pmAttachment,
            this.changeAttachment});
            this.attachmentsDataGrid.DataSource = this.pmTemplateBindingSource;
            this.attachmentsDataGrid.Location = new System.Drawing.Point(3, 44);
            this.attachmentsDataGrid.Name = "attachmentsDataGrid";
            this.attachmentsDataGrid.RowHeadersVisible = false;
            this.attachmentsDataGrid.Size = new System.Drawing.Size(718, 181);
            this.attachmentsDataGrid.TabIndex = 8;
            // 
            // equipmentFamilyColumn
            // 
            this.equipmentFamilyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentFamilyColumn.HeaderText = "Equipment Family";
            this.equipmentFamilyColumn.Name = "equipmentFamilyColumn";
            this.equipmentFamilyColumn.Width = 134;
            // 
            // pmDirectiveColumn
            // 
            this.pmDirectiveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pmDirectiveColumn.HeaderText = "PM Directive";
            this.pmDirectiveColumn.Name = "pmDirectiveColumn";
            // 
            // pmAttachment
            // 
            this.pmAttachment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pmAttachment.DataPropertyName = "pmAttachment";
            this.pmAttachment.HeaderText = "Attachment";
            this.pmAttachment.Name = "pmAttachment";
            this.pmAttachment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pmAttachment.Width = 93;
            // 
            // changeAttachment
            // 
            this.changeAttachment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.changeAttachment.HeaderText = "Insert New Attach";
            this.changeAttachment.Name = "changeAttachment";
            this.changeAttachment.Text = "...";
            this.changeAttachment.Width = 120;
            // 
            // PMAttachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PMAttachments";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(740, 432);
            this.Load += new System.EventHandler(this.PMAttachments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pmTemplateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource equipmentFamilyBindingSource;
        private System.Windows.Forms.BindingSource pmTemplateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmDirective;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newPMTemplate;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox equipmentFamilyDirective;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipmentFamilyBox;
        private System.Windows.Forms.DataGridView materialGridView;
        private System.Windows.Forms.DataGridView attachmentsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDirective;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentFamilyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmDirectiveColumn;
        private System.Windows.Forms.DataGridViewLinkColumn pmAttachment;
        private System.Windows.Forms.DataGridViewButtonColumn changeAttachment;
    }
}
