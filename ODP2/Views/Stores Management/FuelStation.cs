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
            equipmentIDIssue.DataSource = home.dbContext.EQUIPMENTS.ToList();
            equipmentIDReport.DataSource = home.dbContext.EQUIPMENTS.ToList();
            var fuelStation = home.dbContext.SPAREPARTS.Where(item => item.PARTCODE == "CONS-FU");
            fuelStockLevel.Value = (int)(100 * ((double)fuelStation.First().PARTSTOCKQTY / 21878));
            fuelStockPercentage.Text = fuelStockLevel.Value + " %";
            fuelStockQty.Text = (fuelStation.First().PARTSTOCKQTY).ToString() + " litres";
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
                FUELINGWORKORDER fuelingOrder = new FUELINGWORKORDER();
                fuelingOrder.EQUIPMENTID = equipmentIDIssue.Text;
                fuelingOrder.FUELQTY = Convert.ToInt32(fuelQtyTextbox.Text);
                fuelingOrder.EQUIPMENTREADING = Convert.ToInt32(equipmentReadingTextbox.Text);
                fuelingOrder.FUELINGDATE = fuelIssueDatePicker.Value;
               

                home.dbContext.FUELINGWORKORDERS.Add(fuelingOrder);
                home.dbContext.SPAREPARTS.Where(stock => stock.PARTCODE == "CONS-FU").First().PARTSTOCKQTY -= fuelingOrder.FUELQTY;


                MessageBox.Show("Fueling Order " + fuelingOrder.FUELINGWORKORDER1 + " is registered Successfully, updated Fuel Qty is ");
                home.dbContext.SaveChanges();
                var fuelStation = home.dbContext.SPAREPARTS.Where(item => item.PARTCODE == "CONS-FU");
                fuelStockLevel.Value = (int)(100 * ((double)fuelStation.First().PARTSTOCKQTY / 21878));

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
                FUELINGWORKORDER fuelingOrder = new FUELINGWORKORDER();
                fuelingOrder.FUELQTY = Convert.ToInt32(recievedFuelQty.Text);
                fuelingOrder.FUELINGDATE = fuelRecievedDatePicker.Value;
                fuelingOrder.EQUIPMENTID = "EHA01";

                home.dbContext.FUELINGWORKORDERS.Add(fuelingOrder);
                home.dbContext.SPAREPARTS.Where(stock => stock.PARTCODE == "CONS-FU").First().PARTSTOCKQTY += fuelingOrder.FUELQTY;

                MessageBox.Show("Fueling Order " + fuelingOrder + " is registered Successfully, updated Fuel Qty is ");
                home.dbContext.SaveChanges();
                var fuelStation = home.dbContext.SPAREPARTS.Where(item => item.PARTCODE == "CONS-FU");
                fuelStockLevel.Value = (int)(100 * ((double)fuelStation.First().PARTSTOCKQTY / 21878));
            }


        }
        private void fuelLevelChanged(object sender, EventArgs e)
        {
            fuelStockPercentage.Text = fuelStockLevel.Value + " %";
            fuelStockQty.Text = (home.dbContext.SPAREPARTS.Where(item => item.PARTCODE == "CONS-FU").First().PARTSTOCKQTY).ToString() + " litres";
        }

        private void equipmentID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var senderCombo = (ComboBox)sender;
            if (senderCombo == equipmentIDIssue)
            {
                equipmentBindingSource.DataSource = home.dbContext.EQUIPMENTS.Where(equipment => equipment.EQUIPMENTID == senderCombo.Text).First();
            }
            else if (senderCombo == equipmentIDReport)
            {
                equipmentBindingSource1.DataSource = home.dbContext.EQUIPMENTS.Where(equipment => equipment.EQUIPMENTID == senderCombo.Text).First();
            }
            
        }

        private void fuelStockLevel1_Validated(object sender, EventArgs e)
        {

        }
    }
}
