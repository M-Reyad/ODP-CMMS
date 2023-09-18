namespace ODP2.Views.Equipment_Management
{
    partial class AssetsInformation
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
            this.equipmentComboBox = new System.Windows.Forms.ComboBox();
            this.eQUIPMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newEquipment = new System.Windows.Forms.Button();
            this.equipmentDirective = new System.Windows.Forms.TextBox();
            this.selectedEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastPMDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inOperationDateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.runningHoursTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.componentGridView = new System.Windows.Forms.DataGridView();
            this.cOMPONENTSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTEQUIPMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTMODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPONENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hibernateEquipmebtButton = new System.Windows.Forms.Button();
            this.equipmentModel = new System.Windows.Forms.TextBox();
            this.warrantyEndDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentComboBox
            // 
            this.equipmentComboBox.CausesValidation = false;
            this.equipmentComboBox.DataSource = this.eQUIPMENTBindingSource;
            this.equipmentComboBox.DisplayMember = "EQUIPMENTID";
            this.equipmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentComboBox.FormattingEnabled = true;
            this.equipmentComboBox.Location = new System.Drawing.Point(10, 8);
            this.equipmentComboBox.Name = "equipmentComboBox";
            this.equipmentComboBox.Size = new System.Drawing.Size(87, 21);
            this.equipmentComboBox.TabIndex = 0;
            this.equipmentComboBox.SelectedIndexChanged += new System.EventHandler(this.equipmentComboBox_SelectedIndexChanged);
            // 
            // eQUIPMENTBindingSource
            // 
            this.eQUIPMENTBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // newEquipment
            // 
            this.newEquipment.Location = new System.Drawing.Point(643, 6);
            this.newEquipment.Name = "newEquipment";
            this.newEquipment.Size = new System.Drawing.Size(112, 23);
            this.newEquipment.TabIndex = 2;
            this.newEquipment.Text = "Add New Equipment";
            this.newEquipment.UseVisualStyleBackColor = true;
            this.newEquipment.Click += new System.EventHandler(this.newEquipment_Click);
            // 
            // equipmentDirective
            // 
            this.equipmentDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentBindingSource, "EQUIPMENTDIRECTIVE", true));
            this.equipmentDirective.Location = new System.Drawing.Point(112, 9);
            this.equipmentDirective.Name = "equipmentDirective";
            this.equipmentDirective.ReadOnly = true;
            this.equipmentDirective.Size = new System.Drawing.Size(230, 20);
            this.equipmentDirective.TabIndex = 1;
            // 
            // selectedEquipmentBindingSource
            // 
            this.selectedEquipmentBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentBindingSource, "EQUIPMENTSTATUSID", true));
            this.statusTextBox.Location = new System.Drawing.Point(102, 86);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(117, 20);
            this.statusTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Equipment Status";
            // 
            // lastPMDate
            // 
            this.lastPMDate.Location = new System.Drawing.Point(482, 86);
            this.lastPMDate.Name = "lastPMDate";
            this.lastPMDate.ReadOnly = true;
            this.lastPMDate.Size = new System.Drawing.Size(182, 20);
            this.lastPMDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Last PM Date";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentBindingSource, "EQUIPMENTMANUFACTURER", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(103, 60);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.ReadOnly = true;
            this.manufacturerTextBox.Size = new System.Drawing.Size(116, 20);
            this.manufacturerTextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Manufacturer";
            // 
            // inOperationDateTextBox
            // 
            this.inOperationDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentBindingSource, "INSERVICEDATE", true));
            this.inOperationDateTextBox.Location = new System.Drawing.Point(482, 34);
            this.inOperationDateTextBox.Name = "inOperationDateTextBox";
            this.inOperationDateTextBox.ReadOnly = true;
            this.inOperationDateTextBox.Size = new System.Drawing.Size(182, 20);
            this.inOperationDateTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "In-Operation Date";
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentBindingSource, "EQUIPMENTSN", true));
            this.serialNumberTextBox.Location = new System.Drawing.Point(103, 34);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.ReadOnly = true;
            this.serialNumberTextBox.Size = new System.Drawing.Size(229, 20);
            this.serialNumberTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Equipment S/N";
            // 
            // runningHoursTextBox
            // 
            this.runningHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentBindingSource, "EQUIPMENTHR", true));
            this.runningHoursTextBox.Location = new System.Drawing.Point(482, 8);
            this.runningHoursTextBox.Name = "runningHoursTextBox";
            this.runningHoursTextBox.ReadOnly = true;
            this.runningHoursTextBox.Size = new System.Drawing.Size(92, 20);
            this.runningHoursTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Running Hours";
            // 
            // componentGridView
            // 
            this.componentGridView.AllowUserToAddRows = false;
            this.componentGridView.AllowUserToDeleteRows = false;
            this.componentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.componentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.componentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOMPONENTSNDataGridViewTextBoxColumn,
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn,
            this.cOMPONENTEQUIPMENTDataGridViewTextBoxColumn,
            this.cOMPONENTMODELDataGridViewTextBoxColumn,
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn});
            this.componentGridView.DataSource = this.cOMPONENTBindingSource;
            this.componentGridView.Location = new System.Drawing.Point(8, 179);
            this.componentGridView.Name = "componentGridView";
            this.componentGridView.ReadOnly = true;
            this.componentGridView.RowHeadersVisible = false;
            this.componentGridView.Size = new System.Drawing.Size(749, 367);
            this.componentGridView.TabIndex = 6;
            // 
            // cOMPONENTSNDataGridViewTextBoxColumn
            // 
            this.cOMPONENTSNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cOMPONENTSNDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTSN";
            this.cOMPONENTSNDataGridViewTextBoxColumn.HeaderText = "SN";
            this.cOMPONENTSNDataGridViewTextBoxColumn.Name = "cOMPONENTSNDataGridViewTextBoxColumn";
            this.cOMPONENTSNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPONENTPARTCODEDataGridViewTextBoxColumn
            // 
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTPARTCODE";
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.HeaderText = "Part Code";
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.Name = "cOMPONENTPARTCODEDataGridViewTextBoxColumn";
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPONENTPARTCODEDataGridViewTextBoxColumn.Width = 96;
            // 
            // cOMPONENTEQUIPMENTDataGridViewTextBoxColumn
            // 
            this.cOMPONENTEQUIPMENTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOMPONENTEQUIPMENTDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTEQUIPMENT";
            this.cOMPONENTEQUIPMENTDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.cOMPONENTEQUIPMENTDataGridViewTextBoxColumn.Name = "cOMPONENTEQUIPMENTDataGridViewTextBoxColumn";
            this.cOMPONENTEQUIPMENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPONENTEQUIPMENTDataGridViewTextBoxColumn.Width = 103;
            // 
            // cOMPONENTMODELDataGridViewTextBoxColumn
            // 
            this.cOMPONENTMODELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOMPONENTMODELDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTMODEL";
            this.cOMPONENTMODELDataGridViewTextBoxColumn.HeaderText = "Model";
            this.cOMPONENTMODELDataGridViewTextBoxColumn.Name = "cOMPONENTMODELDataGridViewTextBoxColumn";
            this.cOMPONENTMODELDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPONENTMODELDataGridViewTextBoxColumn.Width = 73;
            // 
            // cOMPONENTMANFACTURERDataGridViewTextBoxColumn
            // 
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.DataPropertyName = "COMPONENTMANFACTURER";
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.Name = "cOMPONENTMANFACTURERDataGridViewTextBoxColumn";
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPONENTMANFACTURERDataGridViewTextBoxColumn.Width = 119;
            // 
            // cOMPONENTBindingSource
            // 
            this.cOMPONENTBindingSource.DataSource = typeof(ODP2.Models.COMPONENT);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Components List";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.runningHoursTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.hibernateEquipmebtButton);
            this.panel1.Controls.Add(this.equipmentModel);
            this.panel1.Controls.Add(this.serialNumberTextBox);
            this.panel1.Controls.Add(this.manufacturerTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.warrantyEndDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inOperationDateTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.statusTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lastPMDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(10, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(745, 119);
            this.panel1.TabIndex = 7;
            // 
            // hibernateEquipmebtButton
            // 
            this.hibernateEquipmebtButton.Enabled = false;
            this.hibernateEquipmebtButton.Location = new System.Drawing.Point(225, 84);
            this.hibernateEquipmebtButton.Name = "hibernateEquipmebtButton";
            this.hibernateEquipmebtButton.Size = new System.Drawing.Size(107, 23);
            this.hibernateEquipmebtButton.TabIndex = 2;
            this.hibernateEquipmebtButton.Text = "Hibernated";
            this.hibernateEquipmebtButton.UseVisualStyleBackColor = true;
            this.hibernateEquipmebtButton.Click += new System.EventHandler(this.hibernatedEquipmentButton_Click);
            // 
            // equipmentModel
            // 
            this.equipmentModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentBindingSource, "EQUIPMENTMODEL", true));
            this.equipmentModel.Location = new System.Drawing.Point(102, 8);
            this.equipmentModel.Name = "equipmentModel";
            this.equipmentModel.ReadOnly = true;
            this.equipmentModel.Size = new System.Drawing.Size(229, 20);
            this.equipmentModel.TabIndex = 1;
            // 
            // warrantyEndDate
            // 
            this.warrantyEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedEquipmentBindingSource, "WARRANTYENDDATE", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "---"));
            this.warrantyEndDate.Location = new System.Drawing.Point(482, 60);
            this.warrantyEndDate.Name = "warrantyEndDate";
            this.warrantyEndDate.ReadOnly = true;
            this.warrantyEndDate.Size = new System.Drawing.Size(182, 20);
            this.warrantyEndDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Warranty End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // AssetsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.equipmentDirective);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.componentGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newEquipment);
            this.Controls.Add(this.equipmentComboBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AssetsInformation";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(765, 554);
            this.Load += new System.EventHandler(this.AssetsInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox equipmentComboBox;
        private System.Windows.Forms.Button newEquipment;
        private System.Windows.Forms.TextBox equipmentDirective;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastPMDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inOperationDateTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox runningHoursTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView componentGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTPARTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTEQUIPMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTMODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPONENTMANFACTURERDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cOMPONENTBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource eQUIPMENTBindingSource;
        private System.Windows.Forms.BindingSource selectedEquipmentBindingSource;
        private System.Windows.Forms.Button hibernateEquipmebtButton;
        private System.Windows.Forms.TextBox warrantyEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox equipmentModel;
        private System.Windows.Forms.Label label3;
    }
}
