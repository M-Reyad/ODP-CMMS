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
    public partial class ReservedQuantites : Form
    {
        public string selectedSparePartCode;
        private sparePart selectedSparePart;
        public Home home;

        public ReservedQuantites()
        {   
            InitializeComponent();
        }

        private void ReservedQuantites_Load(object sender, EventArgs e)
        {
            Text += " - " + selectedSparePartCode;
            if (home.dbContext.spareParts.Where(sp => sp.partCode.Trim() == selectedSparePartCode).Count() != 1)
            {
                MessageBox.Show("Error Finding Spare Part " + selectedSparePartCode, "Error");
            }
            else
            {
                selectedSparePart = home.dbContext.spareParts.Where(sp => sp.partCode.Trim() == selectedSparePartCode).First();
                var reservedList = home.dbContext.issues.Where(iss => iss.sparePartCode == selectedSparePartCode && iss.issueState.Trim() == "Requested").ToList();
                var reservedQtyWorkOrders = reservedList.Join(home.dbContext.workOrders,
                    iss => iss.workOrder,
                    wo => wo.workOrderID, 
                    (iss,wo) => new
                    {
                        iss.issueID,
                        wo.workOrderID,
                        wo.workOrderEquipmentID,
                        wo.workOrderDirective,
                        iss.sparePartCode,
                        iss.qty,
                        iss.requestDate
                    }
                    );

                issueBindingSource.DataSource = reservedQtyWorkOrders;

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedWorkOrder = (int)ReservedIssuesGridView.SelectedRows[0].Cells["workOrderID"].Value;
            DialogResult openWorkOrderQuesion = MessageBox.Show("Open WorkOrder #" + selectedWorkOrder, "Open Work Order", MessageBoxButtons.YesNo);
            if (openWorkOrderQuesion == DialogResult.Yes)
            {

                if (Application.OpenForms.OfType<WorkOrder>().Count() != 0)
                {
                    foreach (WorkOrder openedWorkOrder in Application.OpenForms.OfType<WorkOrder>().ToList())
                    {
                        if (openedWorkOrder.workOrder.workOrderID == selectedWorkOrder)
                        {
                            openedWorkOrder.Focus();
                        }
                        else
                        {
                            WorkOrder workOrder = new WorkOrder(selectedWorkOrder, home);
                            workOrder.Show();
                        }
                    }
                }
                else
                {
                    WorkOrder workOrder = new WorkOrder(selectedWorkOrder, home);
                    workOrder.Show();
                }
            }
        }


    }
}
