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
            this.attachmentsDataGrid = new System.Windows.Forms.DataGridView();
            this.selectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipmentFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmAttachment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.changeAttachment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pmTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentFamilyBox = new System.Windows.Forms.ComboBox();
            this.equipmentFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentFamilyDirective = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.newPMTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmTemplateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attachmentsDataGrid
            // 
            this.attachmentsDataGrid.AllowUserToAddRows = false;
            this.attachmentsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentsDataGrid.AutoGenerateColumns = false;
            this.attachmentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attachmentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn,
            this.equipmentFamily,
            this.pmDirective,
            this.pmAttachment,
            this.changeAttachment});
            this.attachmentsDataGrid.DataSource = this.pmTemplateBindingSource;
            this.attachmentsDataGrid.Location = new System.Drawing.Point(6, 30);
            this.attachmentsDataGrid.Name = "attachmentsDataGrid";
            this.attachmentsDataGrid.RowHeadersVisible = false;
            this.attachmentsDataGrid.Size = new System.Drawing.Size(731, 399);
            this.attachmentsDataGrid.TabIndex = 0;
            this.attachmentsDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.attachmentsDataGrid_CellEndEdit);
            // 
            // selectColumn
            // 
            this.selectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.selectColumn.FalseValue = "false";
            this.selectColumn.HeaderText = "Select";
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.TrueValue = "true";
            this.selectColumn.Width = 43;
            // 
            // equipmentFamily
            // 
            this.equipmentFamily.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.equipmentFamily.DataPropertyName = "equipmentFamily";
            this.equipmentFamily.HeaderText = "Equipment Family";
            this.equipmentFamily.Name = "equipmentFamily";
            this.equipmentFamily.Width = 105;
            // 
            // pmDirective
            // 
            this.pmDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pmDirective.DataPropertyName = "pmDirective";
            this.pmDirective.HeaderText = "PM Directive";
            this.pmDirective.Name = "pmDirective";
            // 
            // pmAttachment
            // 
            this.pmAttachment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pmAttachment.DataPropertyName = "pmAttachment";
            this.pmAttachment.HeaderText = "Attachment";
            this.pmAttachment.Name = "pmAttachment";
            this.pmAttachment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // changeAttachment
            // 
            this.changeAttachment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.changeAttachment.HeaderText = "Insert New Attach";
            this.changeAttachment.Name = "changeAttachment";
            this.changeAttachment.Text = "...";
            this.changeAttachment.Width = 88;
            // 
            // pmTemplateBindingSource
            // 
            this.pmTemplateBindingSource.DataSource = typeof(ODP2.Models.PMTEMPLATE);
            // 
            // equipmentFamilyBox
            // 
            this.equipmentFamilyBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.equipmentFamilyBindingSource, "equipmentFamilyCode", true));
            this.equipmentFamilyBox.DataSource = this.equipmentFamilyBindingSource;
            this.equipmentFamilyBox.DisplayMember = "equipmentFamilyCode";
            this.equipmentFamilyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentFamilyBox.FormattingEnabled = true;
            this.equipmentFamilyBox.Location = new System.Drawing.Point(98, 3);
            this.equipmentFamilyBox.Name = "equipmentFamilyBox";
            this.equipmentFamilyBox.Size = new System.Drawing.Size(98, 21);
            this.equipmentFamilyBox.TabIndex = 1;
            this.equipmentFamilyBox.SelectionChangeCommitted += new System.EventHandler(this.equipmentFamilyBox_SelectedIndexChanged);
            // 
            // equipmentFamilyBindingSource
            // 
            this.equipmentFamilyBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENTFAMILY);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipment Family";
            // 
            // equipmentFamilyDirective
            // 
            this.equipmentFamilyDirective.Location = new System.Drawing.Point(203, 3);
            this.equipmentFamilyDirective.Name = "equipmentFamilyDirective";
            this.equipmentFamilyDirective.ReadOnly = true;
            this.equipmentFamilyDirective.Size = new System.Drawing.Size(300, 20);
            this.equipmentFamilyDirective.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(662, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newPMTemplate
            // 
            this.newPMTemplate.CausesValidation = false;
            this.newPMTemplate.Location = new System.Drawing.Point(542, 3);
            this.newPMTemplate.Name = "newPMTemplate";
            this.newPMTemplate.Size = new System.Drawing.Size(103, 23);
            this.newPMTemplate.TabIndex = 4;
            this.newPMTemplate.Text = "Insert New PM";
            this.newPMTemplate.UseVisualStyleBackColor = true;
            this.newPMTemplate.Click += new System.EventHandler(this.newPMTemplate_Click);
            // 
            // PMAttachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.newPMTemplate);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.equipmentFamilyDirective);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipmentFamilyBox);
            this.Controls.Add(this.attachmentsDataGrid);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PMAttachments";
            this.Size = new System.Drawing.Size(740, 432);
            this.Load += new System.EventHandler(this.PMAttachments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attachmentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmTemplateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView attachmentsDataGrid;
        private System.Windows.Forms.ComboBox equipmentFamilyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox equipmentFamilyDirective;
        private System.Windows.Forms.BindingSource equipmentFamilyBindingSource;
        private System.Windows.Forms.BindingSource pmTemplateBindingSource;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newPMTemplate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmDirective;
        private System.Windows.Forms.DataGridViewLinkColumn pmAttachment;
        private System.Windows.Forms.DataGridViewButtonColumn changeAttachment;
    }
}
