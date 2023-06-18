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


            var inventoryPartsList = home.dbContext.spareParts.ToList();
            //MessageBox.Show(home.dbContext_SW.ODP_ONHAND_QTY.ToList().Count().ToString());
            //MessageBox.Show(home.dbContext_SW.ODP_ONHAND_QTY.ToList().ToString());
            //var inventoryQuantities = home.dbContext_SW.ODP_ONHAND_QTY.ToList();


            //With Part Code
            if (partCodeTextBox.Text != "")
            {
                if (partCodeTextBox.Text.Contains("%"))
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.partCode.Contains(partCodeTextBox.Text.Trim('%'))).ToList();
                }
                else
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.partCode == partCodeTextBox.Text).ToList();
                }
                
            }

            //With Part Description
            if (partDescriptionTextBox.Text != "")
            {
                if (partDescriptionTextBox.Text.Contains("%"))
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.partDirective.Contains(partDescriptionTextBox.Text.Trim('%'))).ToList();
                }
                else
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.partDirective == partDescriptionTextBox.Text).ToList();
                }
            }

            //With Man. PN
            if (manPNTextBox.Text != "")
            {
                if (manPNTextBox.Text.Contains("%"))
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.manufacturerPN.Contains(manPNTextBox.Text.Trim('%'))).ToList();
                }
                else
                {
                    inventoryPartsList = inventoryPartsList.Where(sp => sp.manufacturerPN == manPNTextBox.Text).ToList();
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
            var selectedPartCode = (string) sparePartGridView.SelectedRows[0].Cells["partCode"].Value;

            if (Application.OpenForms.OfType<SparePart>().Count() != 0)
            {
                foreach (SparePart openedSparePart in Application.OpenForms.OfType<SparePart>().ToList())
                {
                    if (openedSparePart.selectedSparePart.partCode == selectedPartCode)
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
    }
}
