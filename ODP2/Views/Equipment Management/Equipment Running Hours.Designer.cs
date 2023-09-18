using System.Windows.Forms;

namespace ODP2.Views
{
    partial class EquipmentRunningHours
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lastRHDate = new System.Windows.Forms.TextBox();
            this.newDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.equipmentFamilyLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lastRHDate
            // 
            this.lastRHDate.Location = new System.Drawing.Point(173, 8);
            this.lastRHDate.Name = "lastRHDate";
            this.lastRHDate.ReadOnly = true;
            this.lastRHDate.Size = new System.Drawing.Size(144, 20);
            this.lastRHDate.TabIndex = 25;
            // 
            // newDatePicker
            // 
            this.newDatePicker.CustomFormat = "dd-MMM-yy hh:mm tt";
            this.newDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newDatePicker.Location = new System.Drawing.Point(173, 33);
            this.newDatePicker.Name = "newDatePicker";
            this.newDatePicker.Size = new System.Drawing.Size(144, 20);
            this.newDatePicker.TabIndex = 1;
            this.newDatePicker.Value = new System.DateTime(2023, 9, 9, 0, 0, 0, 0);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(8, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(159, 15);
            this.label25.TabIndex = 0;
            this.label25.Text = "Last Registered Hours Date";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(8, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(141, 15);
            this.label26.TabIndex = 0;
            this.label26.Text = "New Registeration Date";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(575, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 20);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // equipmentFamilyLayout
            // 
            this.equipmentFamilyLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentFamilyLayout.AutoScroll = true;
            this.equipmentFamilyLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.equipmentFamilyLayout.Location = new System.Drawing.Point(8, 59);
            this.equipmentFamilyLayout.Margin = new System.Windows.Forms.Padding(5);
            this.equipmentFamilyLayout.Name = "equipmentFamilyLayout";
            this.equipmentFamilyLayout.Padding = new System.Windows.Forms.Padding(5);
            this.equipmentFamilyLayout.Size = new System.Drawing.Size(662, 365);
            this.equipmentFamilyLayout.TabIndex = 26;
            // 
            // EquipmentRunningHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.equipmentFamilyLayout);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.newDatePicker);
            this.Controls.Add(this.lastRHDate);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EquipmentRunningHours";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(678, 432);
            this.Load += new System.EventHandler(this.EquipmentRunningHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox lastRHDate;
        private DateTimePicker newDatePicker;
        private Label label25;
        private Label label26;
        private Button saveButton;
        private FlowLayoutPanel equipmentFamilyLayout;
    }
}