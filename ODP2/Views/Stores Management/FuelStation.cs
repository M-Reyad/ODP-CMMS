using ODP2.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views.Stores_Management
{
    public partial class FuelStation : UserControl
    {
        public Home home;
        EQUIPMENT refueledEquipment = new EQUIPMENT();
        //EQUIPMENT refueledTank = new EQUIPMENT();
        string selectedEquipment;
        EQUIPMENT reportedEquipment = new EQUIPMENT();
        public FuelStation()
        {
            InitializeComponent();
        }
        private void FuelStation_Load(object sender, EventArgs e)
        {
            using (var dbContext = new ODPEntities_ORACLE())
            {

                equipmentIDIssue.DataSource = dbContext.EQUIPMENTs.Where(eq => eq.REFUELED == 1 && eq.EQUIPMENTSTATUSID != "HBN").ToList();
                equipmentIDReport.DataSource = dbContext.EQUIPMENTs.Where(eq => eq.REFUELED == 1 ).ToList();
                configFuelStationParameters();
            }
        }
        private void issueFuelSaveButton_Click(object sender, EventArgs e)
        {
            if (equipmentIDIssue.Text == "")
            {
                MessageBox.Show("Please select a Valid Equipment ID", "Missing Data");
            }
            else if (fuelQtyTextbox.Text == "")
            {
                MessageBox.Show("Please enter Fuel Quantity", "Missing Data");
            }
            else if (equipmentReadingTextbox.Text == "" || !int.TryParse(equipmentReadingTextbox.Text, out _))
            {
                MessageBox.Show("Please enter Equipment Reading", "Missing Data");
            }
            else if (!int.TryParse(equipmentReadingTextbox.Text, out _))
            {
                MessageBox.Show("Please enter a valid Quantity", "Error Data");
            }
            else if (uomComboBox.GetItemText(uomComboBox.SelectedItem).Trim() == "")
            {
                MessageBox.Show("Please Select Meter UoM");
            }
            else
            {
                try
                {
                    using (var dbContext = new ODPEntities_ORACLE())
                    {

                        FUELINGWORKORDER fuelingOrder = new FUELINGWORKORDER();
                        fuelingOrder.EQUIPMENTID = equipmentIDIssue.Text;
                        fuelingOrder.FUELQTY = Convert.ToInt32(fuelQtyTextbox.Text);
                        fuelingOrder.EQUIPMENTREADING = Convert.ToInt32(equipmentReadingTextbox.Text);
                        fuelingOrder.UOM = uomComboBox.GetItemText(uomComboBox.SelectedItem).Trim();
                        fuelingOrder.FUELINGDATE = fuelIssueDatePicker.Value;
                        fuelingOrder.COMMENTS = comments.Text;
                        dbContext.FUELINGWORKORDERs.Add(fuelingOrder);
                        dbContext.SPAREPARTs.Where(stock => stock.PARTCODE.Trim() == "CONS-FU").First().PARTSTOCKQTY -= fuelingOrder.FUELQTY;
                        dbContext.SaveChanges();
                        configFuelStationParameters();
                        MessageBox.Show("Successfully supplied " + fuelingOrder.EQUIPMENTID.Trim() + " with " + fuelingOrder.FUELQTY.ToString().Trim() + " litres \n Fueling Order " + fuelingOrder.FUELINGWORKORDER1 + " is registered Successfully", "Fuel Supply");
                        issueFuelSaveButton.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Issueing Fuel on " + ex);
                }
            }

        }
        private void recieveFuelSaveButton_Click(object sender, EventArgs e)
        {
            if (recievedFuelQty.Text == "" || !int.TryParse(recievedFuelQty.Text,out _))
            {
                MessageBox.Show("Please enter valid Fuel Quantity", "Missing Data");
            }
            else if (fuelRecievedDatePicker.Text == "")
            {
                MessageBox.Show("Please enter Recieving Date", "Missing Data");
            }
            else
            {
                try
                {
                    using (var dbContext = new ODPEntities_ORACLE())
                    {

                        FUELINGWORKORDER fuelingOrder = new FUELINGWORKORDER();
                        fuelingOrder.FUELQTY = Convert.ToInt32(recievedFuelQty.Text);
                        fuelingOrder.FUELINGDATE = fuelRecievedDatePicker.Value;
                        fuelingOrder.EQUIPMENTID = "FS";
                        dbContext.FUELINGWORKORDERs.Add(fuelingOrder);
                        dbContext.SPAREPARTs.Where(stock => stock.PARTCODE == "CONS-FU").First().PARTSTOCKQTY += fuelingOrder.FUELQTY;
                        dbContext.SaveChanges();
                        configFuelStationParameters();
                        MessageBox.Show("Successfully Supplied Fuel Station with" + fuelingOrder.FUELQTY.ToString().Trim() + " litres", "Fuel Supply ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Refueling the station " + ex);
                }
            }


        }
        private void equipmentID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var dbContext = new ODPEntities_ORACLE())
            {

                if (sender == equipmentIDReport)
                {
                    selectedEquipment = equipmentIDReport.GetItemText(equipmentIDReport.SelectedItem).Trim();
                    reportedEquipment = dbContext.EQUIPMENTs.Where(equipment => equipment.EQUIPMENTID.Trim() == selectedEquipment).First();
                    reportEquipmentDirective.Text = reportedEquipment.EQUIPMENTDIRECTIVE.Trim();
                }
                else
                {
                    selectedEquipment = equipmentIDIssue.GetItemText(equipmentIDIssue.SelectedItem).Trim();
                    refueledEquipment = dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == selectedEquipment).First();
                    issueEquipmentDirective.Text = refueledEquipment.EQUIPMENTDIRECTIVE.Trim();
                }
            }
            
        }
        private void configFuelStationParameters()
        {
            using (var dbContext = new ODPEntities_ORACLE())
            {

                var fuelStation = dbContext.SPAREPARTs.Where(item => item.PARTCODE.Trim() == "CONS-FU").First();
                fuelStockQty.Text = fuelStation.PARTSTOCKQTY.ToString().Trim() + " litres";
                fuelStockLevel.Value = (int)(100 * ((double)fuelStation.PARTSTOCKQTY / 21878));
                fuelStockPercentage.Text = fuelStockLevel.Value + " %";
                fuelStockQty.Text = (fuelStation.PARTSTOCKQTY).ToString().Trim() + " litres";
                fuelStockPercentage.Text = fuelStockLevel.Value + " %";
            }
        }
        private void configFuelStationReportGrid()
        {
            using (var dbContext = new ODPEntities_ORACLE())
            {
                refuelingDataGrid.DataSource = dbContext.FUELINGWORKORDERs.OrderByDescending(fwo => fwo.FUELINGWORKORDER1).ToList();
                foreach (DataGridViewRow row in refuelingDataGrid.Rows)
                {
                    if (row.Cells["equipmentID"].Value.ToString().Trim() == "FS")
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = DefaultBackColor;
                    }
                }
            }
        }
        private void newIssueDetected(object sender, EventArgs e)
        {
            issueFuelSaveButton.Enabled = true;
        }


#region Reports
        private void fromDateTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fromCheckBox.Checked == true)
            {
                fromDateTimePicker.Enabled = true;

            }
            else
            {
                fromDateTimePicker.Enabled = false;
            }
        }
        private void toDateTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (toCheckBox.Checked == true)
            {
                toDateTimePicker.Enabled = true;

            }
            else
            {
                toDateTimePicker.Enabled = false;
            }
        }
        private void FuelStationTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FuelStationTab.SelectedIndex == 2)
            {
                configFuelStationParameters();
                configFuelStationReportGrid();
            }
        }
        private void refuelingDataGrid_Scroll(object sender, ScrollEventArgs e)
        {
            //if(refuelingDataGrid.scroll)
            //MessageBox.Show(sender.ToString()) ;
        }
        private void generateReportButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ODPEntities_ORACLE())
            {
                var refuelingList = dbContext.FUELINGWORKORDERs.Where(fwo => fwo.EQUIPMENTID.Trim() == selectedEquipment).OrderByDescending(fwo => fwo.FUELINGWORKORDER1).ToList();

                if (fromCheckBox.Checked == true)
                {
                    refuelingList = dbContext.FUELINGWORKORDERs.Where(fwo => fwo.EQUIPMENTID.Trim() == selectedEquipment && fwo.FUELINGDATE >= fromDateTimePicker.Value).OrderByDescending(fwo => fwo.FUELINGWORKORDER1).ToList();
                }
                else if (toCheckBox.Checked == true)
                {
                    refuelingList = dbContext.FUELINGWORKORDERs.Where(fwo => fwo.EQUIPMENTID.Trim() == selectedEquipment && fwo.FUELINGDATE >= fromDateTimePicker.Value).OrderByDescending(fwo => fwo.FUELINGWORKORDER1).ToList();
                }
                refuelingDataGrid.DataSource = refuelingList;
            }
        }

        #endregion
    }


}
