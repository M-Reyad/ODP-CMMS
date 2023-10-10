namespace ODP2.Views.NIBs
{
    partial class EquipmentFamilyRunningHoursView
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
            this.equipmentFamilyPanel = new System.Windows.Forms.Panel();
            this.equipmentFamilyLabel = new System.Windows.Forms.Label();
            this.equipmentFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.equipmentFamilyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentFamilyPanel
            // 
            this.equipmentFamilyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentFamilyPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.equipmentFamilyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentFamilyPanel.Controls.Add(this.equipmentFamilyLabel);
            this.equipmentFamilyPanel.Controls.Add(this.equipmentFlowLayout);
            this.equipmentFamilyPanel.Location = new System.Drawing.Point(10, 10);
            this.equipmentFamilyPanel.Margin = new System.Windows.Forms.Padding(5);
            this.equipmentFamilyPanel.Name = "equipmentFamilyPanel";
            this.equipmentFamilyPanel.Padding = new System.Windows.Forms.Padding(5);
            this.equipmentFamilyPanel.Size = new System.Drawing.Size(322, 71);
            this.equipmentFamilyPanel.TabIndex = 1;
            // 
            // equipmentFamilyLabel
            // 
            this.equipmentFamilyLabel.AutoSize = true;
            this.equipmentFamilyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentFamilyLabel.Location = new System.Drawing.Point(8, 14);
            this.equipmentFamilyLabel.Name = "equipmentFamilyLabel";
            this.equipmentFamilyLabel.Size = new System.Drawing.Size(105, 13);
            this.equipmentFamilyLabel.TabIndex = 0;
            this.equipmentFamilyLabel.Text = "Equipment Family";
            // 
            // equipmentFlowLayout
            // 
            this.equipmentFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentFlowLayout.Location = new System.Drawing.Point(11, 30);
            this.equipmentFlowLayout.Name = "equipmentFlowLayout";
            this.equipmentFlowLayout.Padding = new System.Windows.Forms.Padding(5);
            this.equipmentFlowLayout.Size = new System.Drawing.Size(301, 31);
            this.equipmentFlowLayout.TabIndex = 1;
            // 
            // EquipmentFamilyRunningHoursView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equipmentFamilyPanel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EquipmentFamilyRunningHoursView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(342, 91);
            this.Load += new System.EventHandler(this.EquipmentFamilyRunningHoursView_Load);
            this.equipmentFamilyPanel.ResumeLayout(false);
            this.equipmentFamilyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel equipmentFamilyPanel;
        private System.Windows.Forms.Label equipmentFamilyLabel;
        public System.Windows.Forms.FlowLayoutPanel equipmentFlowLayout;
    }
}
