using ODP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP2.Views.Inventory_Spare_Parts_Management
{
    public partial class InventorySpareParts : UserControl
    {
        
        public Home home;
        public InventorySpareParts()
        {
            InitializeComponent();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {


            var inventoryPartsList = home.dbContext.SPAREPARTs.ToList();
            //MessageBox.Show(home.dbContext_SW.ODP_ONHAND_QTY.ToList().Count().ToString());
            //MessageBox.Show(home.dbContext_SW.ODP_ONHAND_QTY.ToList().ToString());
            //var inventoryQuantities = home.dbContext_SW.ODP_ONHAND_QTY.ToList();


            //With Part Code
            if (partCodeTextBox.Text != "")
            {
                if (partCodeTextBox.Text.Contains("%"))
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.PARTCODE.Contains(partCodeTextBox.Text.Trim('%'))).ToList();
                }
                else
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.PARTCODE.Trim() == partCodeTextBox.Text).ToList();
                }
                
            }

            //With Part Description
            if (partDescriptionTextBox.Text != "")
            {
                if (partDescriptionTextBox.Text.Contains("%"))
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.PARTDIRECTIVE.Contains(partDescriptionTextBox.Text.Trim('%'))).ToList();
                }
                else
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.PARTDIRECTIVE.Trim() == partDescriptionTextBox.Text).ToList();
                }
            }

            //With Man. PN
            if (manPNTextBox.Text != "")
            {
                if (manPNTextBox.Text.Contains("%"))
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.MANUFACTURERPN.Contains(manPNTextBox.Text.Trim('%'))).ToList();
                }
                else
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.MANUFACTURERPN.Trim() == manPNTextBox.Text).ToList();
                }
            }
            if (inventoryPartsList.Count() != 0)
            {
                sparePartBindingSource.DataSource = inventoryPartsList;
            }
            else
            {
                MessageBox.Show("No Spare Parts Found with these attributes, try with other attribures", "Missing Data");
            }

            
            //sparePartBindingSource.DataSource = home.dbContext_SW.ODP_ONHAND_QTY.ToList() ;

        }
        private void sparePartGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedPartCode = (string) sparePartGridView.SelectedRows[0].Cells["partCodeColumn"].Value.ToString().Trim();

            if (Application.OpenForms.OfType<SparePart>().Count() != 0)
            {
                foreach (SparePart openedSparePart in Application.OpenForms.OfType<SparePart>().ToList())
                {
                    if (openedSparePart.selectedSparePart.PARTCODE == selectedPartCode)
                    {
                        openedSparePart.Focus();
                    }
                    else
                    {
                        SparePart selectedSparePart = new SparePart(home, selectedPartCode);
                        selectedSparePart.Show();
                    }
                }
            }
            else
            {
                SparePart selectedSparePart = new SparePart(home, selectedPartCode);
                selectedSparePart.Show();
            }
        }
        #region See Reserved Quantities
        private void sparePartcontextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (sparePartGridView.SelectedRows.Count == 1)
            {
                if ((int)sparePartGridView.SelectedRows[0].Cells["reservedStock"].Value == 0)
                {
                    sparePartcontextMenuStrip.Items["reservedWorkOrders"].Enabled = false;
                }

                else
                {
                    sparePartcontextMenuStrip.Items["reservedWorkOrders"].Enabled = true;
                }
            }
        }
        private void reservedWorkOrders_Click(object sender, EventArgs e)
        {

            ReservedQuantites showReservedQuantitiesView = new ReservedQuantites();
            showReservedQuantitiesView.home = home;
            showReservedQuantitiesView.selectedSparePartCode = sparePartGridView.SelectedRows[0].Cells["partCodeColumn"].Value.ToString().Trim();
            showReservedQuantitiesView.Show();
        
        }
        #endregion
    }
}
