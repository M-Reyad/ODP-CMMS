namespace ODP2.Views.Equipment_Management
{
    partial class InsertNewPMTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertNewPMTemp));
            this.equipmentFamilyDirective = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentFamiliesBox = new System.Windows.Forms.ComboBox();
            this.equipmentFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pmDirective = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.attachmentLink = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentFamilyDirective
            // 
            this.equipmentFamilyDirective.Location = new System.Drawing.Point(212, 12);
            this.equipmentFamilyDirective.Name = "equipmentFamilyDirective";
            this.equipmentFamilyDirective.ReadOnly = true;
            this.equipmentFamilyDirective.Size = new System.Drawing.Size(235, 20);
            this.equipmentFamilyDirective.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Equipment Family";
            // 
            // equipmentFamiliesBox
            // 
            this.equipmentFamiliesBox.DataSource = this.equipmentFamilyBindingSource;
            this.equipmentFamiliesBox.DisplayMember = "equipmentFamilyCode";
            this.equipmentFamiliesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentFamiliesBox.FormattingEnabled = true;
            this.equipmentFamiliesBox.Location = new System.Drawing.Point(107, 12);
            this.equipmentFamiliesBox.Name = "equipmentFamiliesBox";
            this.equipmentFamiliesBox.Size = new System.Drawing.Size(98, 21);
            this.equipmentFamiliesBox.TabIndex = 4;
            this.equipmentFamiliesBox.SelectionChangeCommitted += new System.EventHandler(this.equipmentFamiliesBox_SelectedIndexChanged);
            // 
            // equipmentFamilyBindingSource
            // 
            this.equipmentFamilyBindingSource.DataSource = typeof(ODP2.Models.EQUIPMENTFAMILY);
            // 
            // pmDirective
            // 
            this.pmDirective.Location = new System.Drawing.Point(107, 39);
            this.pmDirective.Name = "pmDirective";
            this.pmDirective.Size = new System.Drawing.Size(340, 20);
            this.pmDirective.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PM Directive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attachment";
            // 
            // browseButton
            // 
            this.browseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.browseButton.Location = new System.Drawing.Point(107, 64);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // attachmentLink
            // 
            this.attachmentLink.AutoSize = true;
            this.attachmentLink.Location = new System.Drawing.Point(188, 69);
            this.attachmentLink.Name = "attachmentLink";
            this.attachmentLink.Size = new System.Drawing.Size(84, 13);
            this.attachmentLink.TabIndex = 5;
            this.attachmentLink.Text = "Attachment Link";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(130, 93);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(251, 93);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // InsertNewPMTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(470, 132);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pmDirective);
            this.Controls.Add(this.equipmentFamilyDirective);
            this.Controls.Add(this.attachmentLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipmentFamiliesBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertNewPMTemp";
            this.Text = "Insert New PM Template";
            this.Load += new System.EventHandler(this.InsertNewPMTemp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentFamilyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equipmentFamilyDirective;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipmentFamiliesBox;
        private System.Windows.Forms.TextBox pmDirective;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label attachmentLink;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource equipmentFamilyBindingSource;
        private System.Windows.Forms.Button cancelButton;
    }
}