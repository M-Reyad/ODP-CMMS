using ODP2.Models;
using System;
using System.Data;

using System.Linq;

using System.Windows.Forms;

namespace ODP2.Views.Stores_Management
{
    public partial class FuelStation : UserControl
    {
        public Home home;

        public FuelStation()
        {
            InitializeComponent();
        }

        private void FuelStation_Load(object sender, EventArgs e)
        {
            //Customizing Fuel Station Panel // Later will be customized only for Stores
            equipmentIDIssue.DataSource = home.dbContext.equipments.ToList();
            equipmentIDReport.DataSource = home.dbContext.equipments.ToList();
            var fuelStation = home.dbContext.spareParts.Where(item => item.partCode == "CONS-FU");
            fuelStockLevel.Value = (int)(100 * ((double)fuelStation.First().partStockQty / 21878));
            fuelStockPercentage.Text = fuelStockLevel.Value + " %";
            fuelStockQty.Text = (fuelStation.First().partStockQty).ToString() + " litres";
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
            else if (equipmentReadingTextbox.Text == "")
            {
                MessageBox.Show("Please enter Equipment Reading", "Missing Data");
            }
            else
            {
                fuelingWorkOrder fuelingOrder = new fuelingWorkOrder();
                fuelingOrder.equipmentID = equipmentIDIssue.Text;
                fuelingOrder.fuelQty = Convert.ToInt32(fuelQtyTextbox.Text);
                fuelingOrder.equipmentReading = Convert.ToInt32(equipmentReadingTextbox.Text);
                fuelingOrder.fuelingDate = fuelIssueDatePicker.Value;
               

                home.dbContext.fuelingWorkOrders.Add(fuelingOrder);
                home.dbContext.spareParts.Where(stock => stock.partCode == "CONS-FU").First().partStockQty -= fuelingOrder.fuelQty;


                MessageBox.Show("Fueling Order " + fuelingOrder.fuelingWorkOrder1 + " is registered Successfully, updated Fuel Qty is ");
                home.dbContext.SaveChanges();
                var fuelStation = home.dbContext.spareParts.Where(item => item.partCode == "CONS-FU");
                fuelStockLevel.Value = (int)(100 * ((double)fuelStation.First().partStockQty / 21878));

            }

        }

        private void recieveFuelSaveButton_Click(object sender, EventArgs e)
        {
            if (recievedFuelQty.Text == "")
            {
                MessageBox.Show("Please enter Fuel Quantity", "Missing Data");
            }
            else if (fuelRecievedDatePicker.Text == "")
            {
                MessageBox.Show("Please enter Recieving Date", "Missing Data");
            }
            else
            {
                fuelingWorkOrder fuelingOrder = new fuelingWorkOrder();
                fuelingOrder.fuelQty = Convert.ToInt32(recievedFuelQty.Text);
                fuelingOrder.fuelingDate = fuelRecievedDatePicker.Value;
                fuelingOrder.equipmentID = "EHA01";

                home.dbContext.fuelingWorkOrders.Add(fuelingOrder);
                home.dbContext.spareParts.Where(stock => stock.partCode == "CONS-FU").First().partStockQty += fuelingOrder.fuelQty;

                MessageBox.Show("Fueling Order " + fuelingOrder + " is registered Successfully, updated Fuel Qty is ");
                home.dbContext.SaveChanges();
                var fuelStation = home.dbContext.spareParts.Where(item => item.partCode == "CONS-FU");
                fuelStockLevel.Value = (int)(100 * ((double)fuelStation.First().partStockQty / 21878));
            }


        }
        private void fuelLevelChanged(object sender, EventArgs e)
        {
            fuelStockPercentage.Text = fuelStockLevel.Value + " %";
            fuelStockQty.Text = (home.dbContext.spareParts.Where(item => item.partCode == "CONS-FU").First().partStockQty).ToString() + " litres";
        }

        private void equipmentID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var senderCombo = (ComboBox)sender;
            if (senderCombo == equipmentIDIssue)
            {
                equipmentBindingSource.DataSource = home.dbContext.equipments.Where(equipment => equipment.equipmentID == senderCombo.Text).First();
            }
            else if (senderCombo == equipmentIDReport)
            {
                equipmentBindingSource1.DataSource = home.dbContext.equipments.Where(equipment => equipment.equipmentID == senderCombo.Text).First();
            }
            
        }

        private void fuelStockLevel1_Validated(object sender, EventArgs e)
        {

        }
    }
}
