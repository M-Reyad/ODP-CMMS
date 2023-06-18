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
            this.lastRegisterationDateTextbox = new System.Windows.Forms.TextBox();
            this.newDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.RS02New = new System.Windows.Forms.TextBox();
            this.RS02Old = new System.Windows.Forms.TextBox();
            this.RS01New = new System.Windows.Forms.TextBox();
            this.FL11Old = new System.Windows.Forms.TextBox();
            this.RS03Old = new System.Windows.Forms.TextBox();
            this.FL11New = new System.Windows.Forms.TextBox();
            this.FL10New = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FL12Old = new System.Windows.Forms.TextBox();
            this.RS03New = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FL31Old = new System.Windows.Forms.TextBox();
            this.FL12New = new System.Windows.Forms.TextBox();
            this.RS04Old = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FL31New = new System.Windows.Forms.TextBox();
            this.RS01Old = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.RS04New = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.EHB02Old = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.FL13Old = new System.Windows.Forms.TextBox();
            this.EHB02New = new System.Windows.Forms.TextBox();
            this.FL32Old = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FL10Old = new System.Windows.Forms.TextBox();
            this.TT02Old = new System.Windows.Forms.TextBox();
            this.EHA01New = new System.Windows.Forms.TextBox();
            this.TT02New = new System.Windows.Forms.TextBox();
            this.FL30Old = new System.Windows.Forms.TextBox();
            this.TT01New = new System.Windows.Forms.TextBox();
            this.TT03Old = new System.Windows.Forms.TextBox();
            this.FL50Old = new System.Windows.Forms.TextBox();
            this.TT05Old = new System.Windows.Forms.TextBox();
            this.EHA01Old = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.FL13New = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TT03New = new System.Windows.Forms.TextBox();
            this.FL32New = new System.Windows.Forms.TextBox();
            this.TT05New = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.FL30New = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TT04Old = new System.Windows.Forms.TextBox();
            this.FL50New = new System.Windows.Forms.TextBox();
            this.TT06Old = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TT01Old = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TT04New = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TT06New = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastRegisterationDateTextbox
            // 
            this.lastRegisterationDateTextbox.Location = new System.Drawing.Point(210, 11);
            this.lastRegisterationDateTextbox.Name = "lastRegisterationDateTextbox";
            this.lastRegisterationDateTextbox.ReadOnly = true;
            this.lastRegisterationDateTextbox.Size = new System.Drawing.Size(144, 20);
            this.lastRegisterationDateTextbox.TabIndex = 25;
            // 
            // newDatePicker
            // 
            this.newDatePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.newDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newDatePicker.Location = new System.Drawing.Point(210, 36);
            this.newDatePicker.Name = "newDatePicker";
            this.newDatePicker.Size = new System.Drawing.Size(144, 20);
            this.newDatePicker.TabIndex = 1;
            this.newDatePicker.Value = new System.DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(45, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(159, 15);
            this.label25.TabIndex = 0;
            this.label25.Text = "Last Registered Hours Date";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(45, 43);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(141, 15);
            this.label26.TabIndex = 0;
            this.label26.Text = "New Registeration Date";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(459, 38);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 20);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RS02New
            // 
            this.RS02New.Location = new System.Drawing.Point(202, 146);
            this.RS02New.Name = "RS02New";
            this.RS02New.Size = new System.Drawing.Size(86, 20);
            this.RS02New.TabIndex = 3;
            // 
            // RS02Old
            // 
            this.RS02Old.Location = new System.Drawing.Point(92, 146);
            this.RS02Old.Name = "RS02Old";
            this.RS02Old.ReadOnly = true;
            this.RS02Old.Size = new System.Drawing.Size(86, 20);
            this.RS02Old.TabIndex = 25;
            // 
            // RS01New
            // 
            this.RS01New.Location = new System.Drawing.Point(202, 121);
            this.RS01New.Name = "RS01New";
            this.RS01New.Size = new System.Drawing.Size(86, 20);
            this.RS01New.TabIndex = 2;
            // 
            // FL11Old
            // 
            this.FL11Old.Location = new System.Drawing.Point(405, 287);
            this.FL11Old.Name = "FL11Old";
            this.FL11Old.ReadOnly = true;
            this.FL11Old.Size = new System.Drawing.Size(86, 20);
            this.FL11Old.TabIndex = 25;
            // 
            // RS03Old
            // 
            this.RS03Old.Location = new System.Drawing.Point(92, 171);
            this.RS03Old.Name = "RS03Old";
            this.RS03Old.ReadOnly = true;
            this.RS03Old.Size = new System.Drawing.Size(86, 20);
            this.RS03Old.TabIndex = 25;
            // 
            // FL11New
            // 
            this.FL11New.Location = new System.Drawing.Point(515, 287);
            this.FL11New.Name = "FL11New";
            this.FL11New.Size = new System.Drawing.Size(86, 20);
            this.FL11New.TabIndex = 15;
            // 
            // FL10New
            // 
            this.FL10New.Location = new System.Drawing.Point(515, 261);
            this.FL10New.Name = "FL10New";
            this.FL10New.Size = new System.Drawing.Size(86, 20);
            this.FL10New.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 193);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "RS04";
            // 
            // FL12Old
            // 
            this.FL12Old.Location = new System.Drawing.Point(405, 314);
            this.FL12Old.Name = "FL12Old";
            this.FL12Old.ReadOnly = true;
            this.FL12Old.Size = new System.Drawing.Size(86, 20);
            this.FL12Old.TabIndex = 25;
            // 
            // RS03New
            // 
            this.RS03New.Location = new System.Drawing.Point(202, 171);
            this.RS03New.Name = "RS03New";
            this.RS03New.Size = new System.Drawing.Size(86, 20);
            this.RS03New.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "FL13";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 168);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "RS03";
            // 
            // FL31Old
            // 
            this.FL31Old.Location = new System.Drawing.Point(405, 390);
            this.FL31Old.Name = "FL31Old";
            this.FL31Old.ReadOnly = true;
            this.FL31Old.Size = new System.Drawing.Size(86, 20);
            this.FL31Old.TabIndex = 25;
            // 
            // FL12New
            // 
            this.FL12New.Location = new System.Drawing.Point(515, 314);
            this.FL12New.Name = "FL12New";
            this.FL12New.Size = new System.Drawing.Size(86, 20);
            this.FL12New.TabIndex = 16;
            // 
            // RS04Old
            // 
            this.RS04Old.Location = new System.Drawing.Point(92, 196);
            this.RS04Old.Name = "RS04Old";
            this.RS04Old.ReadOnly = true;
            this.RS04Old.Size = new System.Drawing.Size(86, 20);
            this.RS04Old.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "FL32";
            // 
            // FL31New
            // 
            this.FL31New.Location = new System.Drawing.Point(515, 390);
            this.FL31New.Name = "FL31New";
            this.FL31New.Size = new System.Drawing.Size(86, 20);
            this.FL31New.TabIndex = 19;
            // 
            // RS01Old
            // 
            this.RS01Old.Location = new System.Drawing.Point(92, 121);
            this.RS01Old.Margin = new System.Windows.Forms.Padding(0);
            this.RS01Old.Name = "RS01Old";
            this.RS01Old.ReadOnly = true;
            this.RS01Old.Size = new System.Drawing.Size(86, 20);
            this.RS01Old.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "FL30";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(361, 443);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "FL50";
            // 
            // RS04New
            // 
            this.RS04New.Location = new System.Drawing.Point(202, 196);
            this.RS04New.Name = "RS04New";
            this.RS04New.Size = new System.Drawing.Size(86, 20);
            this.RS04New.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "FL12";
            // 
            // EHB02Old
            // 
            this.EHB02Old.Location = new System.Drawing.Point(405, 146);
            this.EHB02Old.Name = "EHB02Old";
            this.EHB02Old.ReadOnly = true;
            this.EHB02Old.Size = new System.Drawing.Size(86, 20);
            this.EHB02Old.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(361, 392);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "FL31";
            // 
            // FL13Old
            // 
            this.FL13Old.Location = new System.Drawing.Point(405, 340);
            this.FL13Old.Name = "FL13Old";
            this.FL13Old.ReadOnly = true;
            this.FL13Old.Size = new System.Drawing.Size(86, 20);
            this.FL13Old.TabIndex = 25;
            // 
            // EHB02New
            // 
            this.EHB02New.Location = new System.Drawing.Point(515, 146);
            this.EHB02New.Name = "EHB02New";
            this.EHB02New.Size = new System.Drawing.Size(86, 20);
            this.EHB02New.TabIndex = 7;
            // 
            // FL32Old
            // 
            this.FL32Old.Location = new System.Drawing.Point(405, 415);
            this.FL32Old.Name = "FL32Old";
            this.FL32Old.ReadOnly = true;
            this.FL32Old.Size = new System.Drawing.Size(86, 20);
            this.FL32Old.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 143);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "RS02";
            // 
            // FL10Old
            // 
            this.FL10Old.Location = new System.Drawing.Point(405, 261);
            this.FL10Old.Name = "FL10Old";
            this.FL10Old.ReadOnly = true;
            this.FL10Old.Size = new System.Drawing.Size(86, 20);
            this.FL10Old.TabIndex = 25;
            // 
            // TT02Old
            // 
            this.TT02Old.Location = new System.Drawing.Point(92, 287);
            this.TT02Old.Name = "TT02Old";
            this.TT02Old.ReadOnly = true;
            this.TT02Old.Size = new System.Drawing.Size(86, 20);
            this.TT02Old.TabIndex = 25;
            // 
            // EHA01New
            // 
            this.EHA01New.Location = new System.Drawing.Point(515, 121);
            this.EHA01New.Name = "EHA01New";
            this.EHA01New.Size = new System.Drawing.Size(86, 20);
            this.EHA01New.TabIndex = 6;
            // 
            // TT02New
            // 
            this.TT02New.Location = new System.Drawing.Point(202, 287);
            this.TT02New.Name = "TT02New";
            this.TT02New.Size = new System.Drawing.Size(86, 20);
            this.TT02New.TabIndex = 9;
            // 
            // FL30Old
            // 
            this.FL30Old.Location = new System.Drawing.Point(405, 365);
            this.FL30Old.Name = "FL30Old";
            this.FL30Old.ReadOnly = true;
            this.FL30Old.Size = new System.Drawing.Size(86, 20);
            this.FL30Old.TabIndex = 25;
            // 
            // TT01New
            // 
            this.TT01New.Location = new System.Drawing.Point(202, 261);
            this.TT01New.Name = "TT01New";
            this.TT01New.Size = new System.Drawing.Size(86, 20);
            this.TT01New.TabIndex = 8;
            // 
            // TT03Old
            // 
            this.TT03Old.Location = new System.Drawing.Point(92, 312);
            this.TT03Old.Name = "TT03Old";
            this.TT03Old.ReadOnly = true;
            this.TT03Old.Size = new System.Drawing.Size(86, 20);
            this.TT03Old.TabIndex = 25;
            // 
            // FL50Old
            // 
            this.FL50Old.Location = new System.Drawing.Point(405, 440);
            this.FL50Old.Name = "FL50Old";
            this.FL50Old.ReadOnly = true;
            this.FL50Old.Size = new System.Drawing.Size(86, 20);
            this.FL50Old.TabIndex = 25;
            // 
            // TT05Old
            // 
            this.TT05Old.Location = new System.Drawing.Point(92, 362);
            this.TT05Old.Name = "TT05Old";
            this.TT05Old.ReadOnly = true;
            this.TT05Old.Size = new System.Drawing.Size(86, 20);
            this.TT05Old.TabIndex = 25;
            // 
            // EHA01Old
            // 
            this.EHA01Old.Location = new System.Drawing.Point(405, 121);
            this.EHA01Old.Name = "EHA01Old";
            this.EHA01Old.ReadOnly = true;
            this.EHA01Old.Size = new System.Drawing.Size(86, 20);
            this.EHA01Old.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 339);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "TT04";
            // 
            // FL13New
            // 
            this.FL13New.Location = new System.Drawing.Point(515, 340);
            this.FL13New.Name = "FL13New";
            this.FL13New.Size = new System.Drawing.Size(86, 20);
            this.FL13New.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(55, 390);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "TT06";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "RS01";
            // 
            // TT03New
            // 
            this.TT03New.Location = new System.Drawing.Point(202, 312);
            this.TT03New.Name = "TT03New";
            this.TT03New.Size = new System.Drawing.Size(86, 20);
            this.TT03New.TabIndex = 10;
            // 
            // FL32New
            // 
            this.FL32New.Location = new System.Drawing.Point(515, 415);
            this.FL32New.Name = "FL32New";
            this.FL32New.Size = new System.Drawing.Size(86, 20);
            this.FL32New.TabIndex = 20;
            // 
            // TT05New
            // 
            this.TT05New.Location = new System.Drawing.Point(202, 362);
            this.TT05New.Name = "TT05New";
            this.TT05New.Size = new System.Drawing.Size(86, 20);
            this.TT05New.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "EHB02";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 314);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "TT03";
            // 
            // FL30New
            // 
            this.FL30New.Location = new System.Drawing.Point(515, 365);
            this.FL30New.Name = "FL30New";
            this.FL30New.Size = new System.Drawing.Size(86, 20);
            this.FL30New.TabIndex = 18;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(55, 365);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "TT05";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(45, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Reach Stackers";
            // 
            // TT04Old
            // 
            this.TT04Old.Location = new System.Drawing.Point(92, 337);
            this.TT04Old.Name = "TT04Old";
            this.TT04Old.ReadOnly = true;
            this.TT04Old.Size = new System.Drawing.Size(86, 20);
            this.TT04Old.TabIndex = 25;
            // 
            // FL50New
            // 
            this.FL50New.Location = new System.Drawing.Point(515, 440);
            this.FL50New.Name = "FL50New";
            this.FL50New.Size = new System.Drawing.Size(86, 20);
            this.FL50New.TabIndex = 21;
            // 
            // TT06Old
            // 
            this.TT06Old.Location = new System.Drawing.Point(92, 387);
            this.TT06Old.Name = "TT06Old";
            this.TT06Old.ReadOnly = true;
            this.TT06Old.Size = new System.Drawing.Size(86, 20);
            this.TT06Old.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "EHA01";
            // 
            // TT01Old
            // 
            this.TT01Old.Location = new System.Drawing.Point(92, 261);
            this.TT01Old.Name = "TT01Old";
            this.TT01Old.ReadOnly = true;
            this.TT01Old.Size = new System.Drawing.Size(86, 20);
            this.TT01Old.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "FL11";
            // 
            // TT04New
            // 
            this.TT04New.Location = new System.Drawing.Point(202, 337);
            this.TT04New.Name = "TT04New";
            this.TT04New.Size = new System.Drawing.Size(86, 20);
            this.TT04New.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(361, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empty Handlers";
            // 
            // TT06New
            // 
            this.TT06New.Location = new System.Drawing.Point(202, 387);
            this.TT06New.Name = "TT06New";
            this.TT06New.Size = new System.Drawing.Size(86, 20);
            this.TT06New.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "FL10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 289);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "TT02";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(361, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "ForkLifts";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(55, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "TT01";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(45, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Terminal Tractors";
            // 
            // EquipmentRunningHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TT06New);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TT04New);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TT01Old);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TT06Old);
            this.Controls.Add(this.FL50New);
            this.Controls.Add(this.TT04Old);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.FL30New);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TT05New);
            this.Controls.Add(this.FL32New);
            this.Controls.Add(this.TT03New);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.FL13New);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.EHA01Old);
            this.Controls.Add(this.TT05Old);
            this.Controls.Add(this.FL50Old);
            this.Controls.Add(this.TT03Old);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.TT01New);
            this.Controls.Add(this.FL30Old);
            this.Controls.Add(this.TT02New);
            this.Controls.Add(this.EHA01New);
            this.Controls.Add(this.TT02Old);
            this.Controls.Add(this.FL10Old);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FL32Old);
            this.Controls.Add(this.EHB02New);
            this.Controls.Add(this.FL13Old);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.EHB02Old);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.RS04New);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RS01Old);
            this.Controls.Add(this.FL31New);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RS04Old);
            this.Controls.Add(this.FL12New);
            this.Controls.Add(this.FL31Old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.RS03New);
            this.Controls.Add(this.FL12Old);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FL10New);
            this.Controls.Add(this.newDatePicker);
            this.Controls.Add(this.FL11New);
            this.Controls.Add(this.RS03Old);
            this.Controls.Add(this.FL11Old);
            this.Controls.Add(this.lastRegisterationDateTextbox);
            this.Controls.Add(this.RS01New);
            this.Controls.Add(this.RS02Old);
            this.Controls.Add(this.RS02New);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "EquipmentRunningHours";
            this.Size = new System.Drawing.Size(684, 492);
            this.Load += new System.EventHandler(this.EquipmentRunningHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox lastRegisterationDateTextbox;
        private DateTimePicker newDatePicker;
        private Label label25;
        private Label label26;
        private Button saveButton;
        private TextBox RS02New;
        private TextBox RS02Old;
        private TextBox RS01New;
        private TextBox FL11Old;
        private TextBox RS03Old;
        private TextBox FL11New;
        private TextBox FL10New;
        private Label label4;
        private TextBox FL12Old;
        private TextBox RS03New;
        private Label label15;
        private Label label3;
        private TextBox FL31Old;
        private TextBox FL12New;
        private TextBox RS04Old;
        private Label label10;
        private TextBox FL31New;
        private TextBox RS01Old;
        private Label label8;
        private Label label21;
        private TextBox RS04New;
        private Label label14;
        private TextBox EHB02Old;
        private Label label22;
        private TextBox FL13Old;
        private TextBox EHB02New;
        private TextBox FL32Old;
        private Label label2;
        private TextBox FL10Old;
        private TextBox TT02Old;
        private TextBox EHA01New;
        private TextBox TT02New;
        private TextBox FL30Old;
        private TextBox TT01New;
        private TextBox TT03Old;
        private TextBox FL50Old;
        private TextBox TT05Old;
        private TextBox EHA01Old;
        private Label label20;
        private TextBox FL13New;
        private Label label23;
        private Label label1;
        private TextBox TT03New;
        private TextBox FL32New;
        private TextBox TT05New;
        private Label label7;
        private Label label19;
        private TextBox FL30New;
        private Label label24;
        private Label label9;
        private TextBox TT04Old;
        private TextBox FL50New;
        private TextBox TT06Old;
        private Label label6;
        private TextBox TT01Old;
        private Label label13;
        private TextBox TT04New;
        private Label label5;
        private TextBox TT06New;
        private Label label12;
        private Label label18;
        private Label label11;
        private Label label17;
        private Label label16;
    }
}