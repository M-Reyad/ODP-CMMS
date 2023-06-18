namespace ODP2.Views.Equipment_Management
{
    partial class PMGeneration
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.pmRegisterationGridView = new System.Windows.Forms.DataGridView();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dueHRTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentHR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentRH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderRegisterationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderDoneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newPMDirective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pmRegisterationGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 91;
            this.button1.Text = "Release WOs";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 90;
            this.checkBox1.Text = "Select All Available";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.dueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDatePicker.Location = new System.Drawing.Point(77, 8);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(126, 20);
            this.dueDatePicker.TabIndex = 92;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 8);
            this.label25.Margin = new System.Windows.Forms.Padding(3);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(5);
            this.label25.Size = new System.Drawing.Size(63, 23);
            this.label25.TabIndex = 28;
            this.label25.Text = "Due Date";
            // 
            // pmRegisterationGridView
            // 
            this.pmRegisterationGridView.AllowUserToAddRows = false;
            this.pmRegisterationGridView.AllowUserToDeleteRows = false;
            this.pmRegisterationGridView.AllowUserToOrderColumns = true;
            this.pmRegisterationGridView.AllowUserToResizeRows = false;
            this.pmRegisterationGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pmRegisterationGridView.AutoGenerateColumns = false;
            this.pmRegisterationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pmRegisterationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.generate,
            this.equipmentID,
            this.equipmentHR,
            this.equipmentRH,
            this.workOrderDirective,
            this.workOrderRegisterationDate,
            this.workOrderDoneDate,
            this.newPMDirective});
            this.pmRegisterationGridView.DataSource = this.equipmentBindingSource;
            this.pmRegisterationGridView.Location = new System.Drawing.Point(8, 95);
            this.pmRegisterationGridView.Name = "pmRegisterationGridView";
            this.pmRegisterationGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pmRegisterationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pmRegisterationGridView.Size = new System.Drawing.Size(808, 326);
            this.pmRegisterationGridView.TabIndex = 93;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(227, 35);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(111, 23);
            this.calculateButton.TabIndex = 91;
            this.calculateButton.Text = "Calculate Due PM";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Due HR";
            // 
            // dueHRTextbox
            // 
            this.dueHRTextbox.Location = new System.Drawing.Point(77, 37);
            this.dueHRTextbox.Name = "dueHRTextbox";
            this.dueHRTextbox.Size = new System.Drawing.Size(47, 20);
            this.dueHRTextbox.TabIndex = 94;
            this.dueHRTextbox.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "HR";
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.equipment);
            // 
            // generate
            // 
            this.generate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.generate.FalseValue = "0";
            this.generate.HeaderText = "Generate";
            this.generate.Name = "generate";
            this.generate.TrueValue = "1";
            this.generate.Width = 57;
            // 
            // equipmentID
            // 
            this.equipmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.equipmentID.DataPropertyName = "equipmentID";
            this.equipmentID.HeaderText = "Equipment ID";
            this.equipmentID.Name = "equipmentID";
            this.equipmentID.ReadOnly = true;
            this.equipmentID.Width = 96;
            // 
            // equipmentHR
            // 
            this.equipmentHR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.equipmentHR.DataPropertyName = "equipmentHR";
            this.equipmentHR.HeaderText = "Equipment HR";
            this.equipmentHR.Name = "equipmentHR";
            this.equipmentHR.ReadOnly = true;
            this.equipmentHR.Width = 101;
            // 
            // equipmentRH
            // 
            this.equipmentRH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.equipmentRH.DataPropertyName = "equipmentRH";
            this.equipmentRH.HeaderText = "Last PM HR";
            this.equipmentRH.Name = "equipmentRH";
            this.equipmentRH.ReadOnly = true;
            this.equipmentRH.Width = 90;
            // 
            // workOrderDirective
            // 
            this.workOrderDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderDirective.DataPropertyName = "workOrderDirective";
            this.workOrderDirective.HeaderText = "Last PM Directive";
            this.workOrderDirective.Name = "workOrderDirective";
            this.workOrderDirective.ReadOnly = true;
            this.workOrderDirective.Width = 106;
            // 
            // workOrderRegisterationDate
            // 
            this.workOrderRegisterationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderRegisterationDate.DataPropertyName = "workOrderRegisterationDate";
            this.workOrderRegisterationDate.HeaderText = "Last PM Registeration Date";
            this.workOrderRegisterationDate.Name = "workOrderRegisterationDate";
            this.workOrderRegisterationDate.ReadOnly = true;
            this.workOrderRegisterationDate.Width = 127;
            // 
            // workOrderDoneDate
            // 
            this.workOrderDoneDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workOrderDoneDate.DataPropertyName = "workOrderDoneDate";
            this.workOrderDoneDate.HeaderText = "Last PM Done Date";
            this.workOrderDoneDate.Name = "workOrderDoneDate";
            this.workOrderDoneDate.ReadOnly = true;
            this.workOrderDoneDate.Width = 95;
            // 
            // newPMDirective
            // 
            this.newPMDirective.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newPMDirective.HeaderText = "New PM Directive";
            this.newPMDirective.Name = "newPMDirective";
            this.newPMDirective.ReadOnly = true;
            // 
            // PMGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dueHRTextbox);
            this.Controls.Add(this.pmRegisterationGridView);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label25);
            this.Name = "PMGeneration";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(824, 429);
            this.Load += new System.EventHandler(this.PMGeneration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pmRegisterationGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView pmRegisterationGridView;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dueHRTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn generate;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentHR;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentRH;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderDirective;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderRegisterationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderDoneDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn newPMDirective;
    }
}
