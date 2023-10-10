namespace ODP2.Views
{
    partial class SparePart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparePart));
            this.partCodeTextBox = new System.Windows.Forms.TextBox();
            this.sparePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.uOM1 = new System.Windows.Forms.Label();
            this.uOM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // partCodeTextBox
            // 
            this.partCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "partCode", true));
            this.partCodeTextBox.Location = new System.Drawing.Point(110, 7);
            this.partCodeTextBox.Name = "partCodeTextBox";
            this.partCodeTextBox.ReadOnly = true;
            this.partCodeTextBox.Size = new System.Drawing.Size(164, 20);
            this.partCodeTextBox.TabIndex = 17;
            // 
            // sparePartBindingSource
            // 
            this.sparePartBindingSource.DataSource = typeof(ODP2.Models.SPAREPART);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Part Code";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(110, 230);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(164, 20);
            this.textBox9.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Last Shipment Date";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "supplierID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.textBox8.Location = new System.Drawing.Point(110, 204);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(164, 20);
            this.textBox8.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Supplier Code";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "partPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----", "C2"));
            this.textBox6.Location = new System.Drawing.Point(110, 126);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(88, 20);
            this.textBox6.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Price";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(314, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(99, 20);
            this.textBox5.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(314, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(99, 20);
            this.textBox4.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "compatableEquipmentFamilyID", true));
            this.textBox3.Location = new System.Drawing.Point(314, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Component";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Equipment";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "partDirective", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.textBox2.Location = new System.Drawing.Point(110, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(303, 20);
            this.textBox2.TabIndex = 35;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "partStockQty", true));
            this.textBox7.Location = new System.Drawing.Point(110, 74);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(88, 20);
            this.textBox7.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "manufacturerPN", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "----"));
            this.textBox1.Location = new System.Drawing.Point(110, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "On-Hand Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Manufacturer P/N";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "MRP";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(110, 152);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(88, 20);
            this.textBox10.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(419, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 216);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Available Stock";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "availableStock", true));
            this.textBox11.Location = new System.Drawing.Point(110, 100);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(88, 20);
            this.textBox11.TabIndex = 36;
            // 
            // uOM1
            // 
            this.uOM1.AutoSize = true;
            this.uOM1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "uom", true));
            this.uOM1.Location = new System.Drawing.Point(204, 77);
            this.uOM1.Name = "uOM1";
            this.uOM1.Size = new System.Drawing.Size(13, 13);
            this.uOM1.TabIndex = 28;
            this.uOM1.Text = "--";
            // 
            // uOM
            // 
            this.uOM.AutoSize = true;
            this.uOM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sparePartBindingSource, "uom", true));
            this.uOM.Location = new System.Drawing.Point(204, 103);
            this.uOM.Name = "uOM";
            this.uOM.Size = new System.Drawing.Size(13, 13);
            this.uOM.TabIndex = 28;
            this.uOM.Text = "--";
            // 
            // SparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 276);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uOM);
            this.Controls.Add(this.uOM1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.partCodeTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SparePart";
            this.Text = "Spare Part";
            this.Load += new System.EventHandler(this.SparePart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sparePartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox partCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.BindingSource sparePartBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label uOM1;
        private System.Windows.Forms.Label uOM;
    }
}