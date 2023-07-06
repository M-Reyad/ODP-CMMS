using System.Windows.Forms;

namespace ODP2.Views
{
    partial class CreateNewWorkOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewWorkOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.workOrderTextBox = new System.Windows.Forms.TextBox();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newWorkOrderButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.equipmentDirective = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.workOrderDirective = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.creatorIDTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workTypeTextBox = new System.Windows.Forms.ComboBox();
            this.workOrderTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.workTypeDirective = new System.Windows.Forms.TextBox();
            this.creatorNameTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.equipmentWHR = new System.Windows.Forms.TextBox();
            this.regsiterationDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderTypeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Order";
            // 
            // workOrderTextBox
            // 
            this.workOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderID", true));
            this.workOrderTextBox.Location = new System.Drawing.Point(69, 10);
            this.workOrderTextBox.Name = "workOrderTextBox";
            this.workOrderTextBox.ReadOnly = true;
            this.workOrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.workOrderTextBox.TabIndex = 6;
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.DataSource = typeof(ODP2.Models.WORKORDER);
            // 
            // newWorkOrderButton
            // 
            this.newWorkOrderButton.Location = new System.Drawing.Point(343, 11);
            this.newWorkOrderButton.Name = "newWorkOrderButton";
            this.newWorkOrderButton.Size = new System.Drawing.Size(109, 20);
            this.newWorkOrderButton.TabIndex = 1;
            this.newWorkOrderButton.Text = "New Work Order";
            this.newWorkOrderButton.UseVisualStyleBackColor = true;
            this.newWorkOrderButton.Click += new System.EventHandler(this.newWorkOrderButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(500, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 20);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Equipment";
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.equipmentTextBox.Location = new System.Drawing.Point(110, 65);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(94, 20);
            this.equipmentTextBox.TabIndex = 2;
            this.equipmentTextBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // equipmentDirective
            // 
            this.equipmentDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "equipmentDirective", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.equipmentDirective.Location = new System.Drawing.Point(354, 66);
            this.equipmentDirective.Name = "equipmentDirective";
            this.equipmentDirective.ReadOnly = true;
            this.equipmentDirective.Size = new System.Drawing.Size(250, 20);
            this.equipmentDirective.TabIndex = 10;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENT);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Equipment Directive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Directive";
            // 
            // workOrderDirective
            // 
            this.workOrderDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "workOrderDirective", true));
            this.workOrderDirective.Location = new System.Drawing.Point(103, 168);
            this.workOrderDirective.Name = "workOrderDirective";
            this.workOrderDirective.Size = new System.Drawing.Size(436, 20);
            this.workOrderDirective.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Work Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Creator ID";
            // 
            // creatorIDTextBox
            // 
            this.creatorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "userIDNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.creatorIDTextBox.Enabled = false;
            this.creatorIDTextBox.Location = new System.Drawing.Point(110, 116);
            this.creatorIDTextBox.Name = "creatorIDTextBox";
            this.creatorIDTextBox.ReadOnly = true;
            this.creatorIDTextBox.Size = new System.Drawing.Size(94, 20);
            this.creatorIDTextBox.TabIndex = 10;
            this.creatorIDTextBox.Leave += new System.EventHandler(this.textBox_Leave);
            this.creatorIDTextBox.LostFocus += new System.EventHandler(this.textBox_Leave);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ODP2.Models.ODP_USER);
            // 
            // workTypeTextBox
            // 
            this.workTypeTextBox.DataSource = this.workOrderTypeBindingSource;
            this.workTypeTextBox.DisplayMember = "workOrderTypeID";
            this.workTypeTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workTypeTextBox.FormattingEnabled = true;
            this.workTypeTextBox.Location = new System.Drawing.Point(110, 89);
            this.workTypeTextBox.Name = "workTypeTextBox";
            this.workTypeTextBox.Size = new System.Drawing.Size(94, 21);
            this.workTypeTextBox.TabIndex = 3;
            // 
            // workOrderTypeBindingSource
            // 
            this.workOrderTypeBindingSource.DataSource = typeof(ODP2.Models.WORKORDERTYPE);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Work Type";
            // 
            // workTypeDirective
            // 
            this.workTypeDirective.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderTypeBindingSource, "workOrderTypeDirective", true));
            this.workTypeDirective.Location = new System.Drawing.Point(354, 92);
            this.workTypeDirective.Name = "workTypeDirective";
            this.workTypeDirective.ReadOnly = true;
            this.workTypeDirective.Size = new System.Drawing.Size(185, 20);
            this.workTypeDirective.TabIndex = 10;
            // 
            // creatorNameTextBox
            // 
            this.creatorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "userName", true));
            this.creatorNameTextBox.Location = new System.Drawing.Point(354, 116);
            this.creatorNameTextBox.Name = "creatorNameTextBox";
            this.creatorNameTextBox.ReadOnly = true;
            this.creatorNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.creatorNameTextBox.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Registeration Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(276, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Creator Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.workOrderTextBox);
            this.panel1.Controls.Add(this.newWorkOrderButton);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 42);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Equipment HR";
            // 
            // equipmentWHR
            // 
            this.equipmentWHR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workOrderBindingSource, "equipmentRH", true));
            this.equipmentWHR.Location = new System.Drawing.Point(354, 142);
            this.equipmentWHR.Name = "equipmentWHR";
            this.equipmentWHR.Size = new System.Drawing.Size(92, 20);
            this.equipmentWHR.TabIndex = 4;
            // 
            // regsiterationDatePicker
            // 
            this.regsiterationDatePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.regsiterationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.regsiterationDatePicker.Location = new System.Drawing.Point(110, 142);
            this.regsiterationDatePicker.Name = "regsiterationDatePicker";
            this.regsiterationDatePicker.Size = new System.Drawing.Size(127, 20);
            this.regsiterationDatePicker.TabIndex = 11;
            // 
            // CreateNewWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 201);
            this.Controls.Add(this.regsiterationDatePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.workTypeTextBox);
            this.Controls.Add(this.creatorNameTextBox);
            this.Controls.Add(this.workTypeDirective);
            this.Controls.Add(this.equipmentDirective);
            this.Controls.Add(this.workOrderDirective);
            this.Controls.Add(this.equipmentWHR);
            this.Controls.Add(this.creatorIDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.equipmentTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewWorkOrder";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Work Order";
            this.Load += new System.EventHandler(this.CreateNewWorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderTypeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox workOrderTextBox;
        private Button newWorkOrderButton;
        private Button saveButton;
        private Label label2;
        private TextBox equipmentTextBox;
        private TextBox equipmentDirective;
        private Label label3;
        private Label label4;
        private TextBox workOrderDirective;
        private Label label5;
        private Label label9;
        public TextBox creatorIDTextBox;
        private ComboBox workTypeTextBox;
        private Label label13;
        private TextBox workTypeDirective;
        private TextBox creatorNameTextBox;
        private Label label14;
        private Label label15;
        private Panel panel1;
        private Label label6;
        public TextBox equipmentWHR;
        private BindingSource workOrderTypeBindingSource;
        private BindingSource equipmentBindingSource;
        private BindingSource userBindingSource;
        private BindingSource workOrderBindingSource;
        private DateTimePicker regsiterationDatePicker;
    }
}