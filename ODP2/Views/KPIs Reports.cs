using ODP2.Models;
using ODP2;
using System.Collections.Generic;
using System;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Wpf;

namespace ODP2.Views
{
    public partial class KPIsReports : System.Windows.Forms.UserControl
    {
        public Home home;
        List<string> KPIsList = new List<string>
            {"Preventive Maintenance",
                "WorkOrder Types",
                "Work Done Types",
                "Asset Reliability",
                "Budget Control",
                "Maintenance Cost" };
        

        public KPIsReports()
        {
            InitializeComponent();
        }
        private void KPIs_Reports_Load(object sender, System.EventArgs e)
        {
            KPISelector.DataSource = KPIsList;
        }

        private void KPISelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            kpiChart.Dispose();

            if (KPISelector.GetItemText(KPISelector.SelectedItem) == "Preventive Maintenance")
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartType = SeriesChartType.Pie;
                var pmWOs = home.dbContext.workOrders.Where(workOrder => workOrder.workOrderTypeID == "PM").ToList();
                series.Name = "PM Adherence";
                series.Points.AddXY("Q-1", 100 * 5 / pmWOs.Count());
                series.Points.AddXY("Q-2", 100 * 3 / pmWOs.Count());
                series.Points.AddXY("Q-3", 100 * 7 / pmWOs.Count());
                series.Points.AddXY("Q-4", 100 * 9 / pmWOs.Count());

                kpiChart.Series.Add(series);
            }
            else if (KPISelector.GetItemText(KPISelector.SelectedItem) == "WorkOrder Types")
            {
                var series = kpiChart.Series[0];
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                foreach (var type in home.dbContext.workOrderTypes)
                {

                    if (home.dbContext.workOrders.Where(workOrder => workOrder.workOrderTypeID == type.workOrderTypeID).Count() != 0)
                    {
                        series.Points.AddXY(type.workOrderTypeID, home.dbContext.workOrders.Where(workOrder => workOrder.workOrderTypeID == type.workOrderTypeID).Count());
                    }
                }
            }
            else if (KPISelector.GetItemText(KPISelector.SelectedItem) == "Work Done Types")
            {
                var series = kpiChart.Series[0];
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                foreach (var doneType in home.dbContext.workDoneTypes)
                {
                    if (home.dbContext.workOrders.Where(workOrder => workOrder.workDoneType == doneType.workDoneTypeID).Count() != 0)
                    {
                        series.Points.AddXY(doneType.workDoneTypeID, home.dbContext.workOrders.Where(workOrder => workOrder.workDoneType == doneType.workDoneTypeID).Count());
                    }

                }
            }
            else if (KPISelector.GetItemText(KPISelector.SelectedItem) == "Asset Reliability")
            {
                var newSeries1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(newSeries1);
                var newSeries2 = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(newSeries2);


                var seriesAV = kpiChart.Series[0];
                var seriesBDN = kpiChart.Series[1];

                /*
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

                int MTTR = 18;
                series.From = 0;
                series.To = 20;
                series.ForeColor = System.Drawing.Color.Transparent;
                series.BackColor = System.Drawing.Color.Transparent;
                series.Value = MTTR;
                series.Text = "MTTR(min)";
                */
                seriesBDN.Points.AddXY("Q-1", 100 - 85);
                seriesAV.Points.AddXY("Q-1", 85);
                seriesBDN.Points.AddXY("Q-2", 100 - 90);
                seriesAV.Points.AddXY("Q-2", 90);
                seriesBDN.Points.AddXY("Q-3", 100 - 89);
                seriesAV.Points.AddXY("Q-3", 89);
                seriesBDN.Points.AddXY("Q-4", 100 - 95);
                seriesAV.Points.AddXY("Q-4", 95);
                seriesAV.Color = System.Drawing.Color.Green;
                seriesBDN.Color = System.Drawing.Color.Red;

                /*
                foreach (Chart chart in Controls.OfType<Chart>())
                {
                    MessageBox.Show("Entered");
                    chart.Titles["Month"].Text = DateTime.Today.Month.ToString();
                    MessageBox.Show("Confirmed");
                }
                */
            }
            else if (KPISelector.GetItemText(KPISelector.SelectedItem) == "Budget Control")
            {

                var newSeries1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(newSeries1);
                var newSeries2 = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(newSeries2);
                var newSeries3 = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(newSeries3);
                var newSeries4 = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(newSeries4);

                var seriesCons = kpiChart.Series[0];
                var seriesPlanndCons = kpiChart.Series[1];
                var seriesOPEX = kpiChart.Series[2];
                var seriesPlanndOPEX = kpiChart.Series[3];

                seriesCons.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                seriesPlanndCons.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                seriesOPEX.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                seriesPlanndCons.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                int CONS = 50000;
                for (int i = 1; i <= 4; i++)
                {


                    seriesCons.Points.AddXY("Q " + i.ToString(), CONS);
                    seriesPlanndCons.Points.AddXY("Q " + i.ToString(), CONS + 25000);
                    seriesOPEX.Points.AddXY("Q " + i.ToString(), CONS / 12);
                    seriesPlanndOPEX.Points.AddXY("Q " + i.ToString(), CONS + 25000 / 12);

                    CONS += 20000;
                }

            }

            else if (KPISelector.GetItemText(KPISelector.SelectedItem) == "Maintenance Cost")
            {
                var newSeries1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(newSeries1);
                var newSeries2 = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(newSeries2);

                var lubCost = kpiChart.Series[0];
                var SPCost = kpiChart.Series[1];
                lubCost.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
                SPCost.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;

                lubCost.Points.AddXY("Q-1", 2500);
                lubCost.Points.AddXY("Q-2", 3200);
                lubCost.Points.AddXY("Q-3", 1900);
                lubCost.Points.AddXY("Q-4", 2100);


                SPCost.Points.AddXY("Q-1", 2700);
                SPCost.Points.AddXY("Q-2", 2100);
                SPCost.Points.AddXY("Q-3", 3200);
                SPCost.Points.AddXY("Q-4", 4000);
            }

        }
    }
}
