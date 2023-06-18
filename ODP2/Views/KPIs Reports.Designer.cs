namespace ODP2.Views
{
    partial class KPIsReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.KPISelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kpiChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.kpiChart)).BeginInit();
            this.SuspendLayout();
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(44, 8);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(131, 20);
            this.fromDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CustomFormat = "yyyy/MM/dd hh:mm";
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(44, 34);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.toDateTimePicker.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // KPISelector
            // 
            this.KPISelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KPISelector.FormattingEnabled = true;
            this.KPISelector.Location = new System.Drawing.Point(44, 60);
            this.KPISelector.Name = "KPISelector";
            this.KPISelector.Size = new System.Drawing.Size(131, 21);
            this.KPISelector.TabIndex = 2;
            this.KPISelector.SelectedIndexChanged += new System.EventHandler(this.KPISelector_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "KPI";
            // 
            // kpiChart
            // 
            this.kpiChart.BackColor = System.Drawing.Color.Transparent;
            this.kpiChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.kpiChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.kpiChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.kpiChart.ChartAreas.Add(chartArea1);
            this.kpiChart.Location = new System.Drawing.Point(264, 8);
            this.kpiChart.Name = "kpiChart";
            this.kpiChart.Size = new System.Drawing.Size(475, 242);
            this.kpiChart.TabIndex = 3;
            this.kpiChart.Text = "chart1";
            // 
            // KPIsReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kpiChart);
            this.Controls.Add(this.KPISelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KPIsReports";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(747, 458);
            this.Load += new System.EventHandler(this.KPIs_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpiChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox KPISelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart kpiChart;
    }
}
