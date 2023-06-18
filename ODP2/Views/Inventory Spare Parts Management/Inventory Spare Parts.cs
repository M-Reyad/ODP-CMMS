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

            sparePartBindingSource.DataSource = inventoryPartsList;

        }
    }
}
