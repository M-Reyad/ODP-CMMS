using ODP2.Models;
using ODP2;
using System.Collections.Generic;
using System;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Wpf;
using LiveCharts;

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

            kpiChart.Series[0].Dispose();
            

            if (KPISelector.GetItemText(KPISelector.SelectedItem) == "Preventive Maintenance")
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartType = SeriesChartType.Bar;
                var pmWOs = home.dbContext.WORKORDERs.Where(workOrder => workOrder.WORKORDERTYPEID == "PM").ToList();
                series.Name = "PM Adherence";
                series.Points.AddXY("Q-1", 100 * 5 / pmWOs.Count());
                series.Points.AddXY("Q-2", 100 * 3 / pmWOs.Count());
                series.Points.AddXY("Q-3", 100 * 7 / pmWOs.Count());
                series.Points.AddXY("Q-4", 100 * 9 / pmWOs.Count());

                kpiChart.Series.Add(series);
            }
            else if (KPISelector.GetItemText(KPISelector.SelectedItem) == "WorkOrder Types")
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series();

                series.ChartType = SeriesChartType.Pie;
                foreach (var type in home.dbContext.WORKORDERTYPEs)
                {

                    if (home.dbContext.WORKORDERs.Where(workOrder => workOrder.WORKORDERTYPEID == type.WORKORDERTYPEID).Count() != 0)
                    {
                        series.Points.AddXY(type.WORKORDERTYPEID, home.dbContext.WORKORDERs.Where(workOrder => workOrder.WORKORDERTYPEID == type.WORKORDERTYPEID).Count());
                    }
                }

                kpiChart.Series.Add(series);
            }
            else if (KPISelector.GetItemText(KPISelector.SelectedItem) == "Work Done Types")
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartType = SeriesChartType.Pie;
                foreach (var doneType in home.dbContext.WORKDONETYPES)
                {
                    if (home.dbContext.WORKORDERs.Where(workOrder => workOrder.WORKDONETYPE == doneType.WORKDONETYPEID).Count() != 0)
                    {
                        series.Points.AddXY(doneType.WORKDONETYPEID, home.dbContext.WORKORDERs.Where(workOrder => workOrder.WORKDONETYPE == doneType.WORKDONETYPEID).Count());
                    }

                }
            }
            else if (KPISelector.GetItemText(KPISelector.SelectedItem) == "Asset Reliability")
            {
                var seriesAV = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(seriesAV);
                var seriesBDN = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(seriesBDN);

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

                var seriesCons = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(seriesCons);
                var seriesPlanndCons = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(seriesPlanndCons);
                var seriesOPEX = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(seriesOPEX);
                var seriesPlanndOPEX = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(seriesPlanndOPEX);

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
                var lubCost = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(lubCost);
                var SPCost = new System.Windows.Forms.DataVisualization.Charting.Series();
                kpiChart.Series.Add(SPCost);

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
