namespace ODP2.Views.NIBs
{
    partial class EquipmentRunningHoursView
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
            this.equipmentPanel = new System.Windows.Forms.Panel();
            this.equipmentLabel = new System.Windows.Forms.Label();
            this.oldRunningHours = new System.Windows.Forms.TextBox();
            this.newRunningHours = new System.Windows.Forms.TextBox();
            this.equipmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentPanel
            // 
            this.equipmentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentPanel.Controls.Add(this.equipmentLabel);
            this.equipmentPanel.Controls.Add(this.oldRunningHours);
            this.equipmentPanel.Controls.Add(this.newRunningHours);
            this.equipmentPanel.Location = new System.Drawing.Point(0, 0);
            this.equipmentPanel.Name = "equipmentPanel";
            this.equipmentPanel.Padding = new System.Windows.Forms.Padding(3);
            this.equipmentPanel.Size = new System.Drawing.Size(269, 33);
            this.equipmentPanel.TabIndex = 10;
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Location = new System.Drawing.Point(7, 9);
            this.equipmentLabel.Name = "equipmentLabel";
            this.equipmentLabel.Size = new System.Drawing.Size(35, 13);
            this.equipmentLabel.TabIndex = 10;
            this.equipmentLabel.Text = "label3";
            // 
            // oldRunningHours
            // 
            this.oldRunningHours.Location = new System.Drawing.Point(48, 6);
            this.oldRunningHours.Name = "oldRunningHours";
            this.oldRunningHours.ReadOnly = true;
            this.oldRunningHours.Size = new System.Drawing.Size(100, 20);
            this.oldRunningHours.TabIndex = 1;
            // 
            // newRunningHours
            // 
            this.newRunningHours.Location = new System.Drawing.Point(154, 6);
            this.newRunningHours.Name = "newRunningHours";
            this.newRunningHours.Size = new System.Drawing.Size(100, 20);
            this.newRunningHours.TabIndex = 2;
            // 
            // EquipmentRunningHoursView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.equipmentPanel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EquipmentRunningHoursView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(269, 33);
            this.Load += new System.EventHandler(this.EquipmentRunningHoursView_Load);
            this.equipmentPanel.ResumeLayout(false);
            this.equipmentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel equipmentPanel;
        private System.Windows.Forms.Label equipmentLabel;
        private System.Windows.Forms.TextBox oldRunningHours;
        private System.Windows.Forms.TextBox newRunningHours;
    }
}
