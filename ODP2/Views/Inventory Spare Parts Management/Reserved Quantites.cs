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
        public Home home;

        public ReservedQuantites()
        {   
            InitializeComponent();
        }

        private void ReservedQuantites_Load(object sender, EventArgs e)
        {
            Text += " - " + selectedSparePartCode;
            if (home.dbContext.SPAREPARTs.Where(sp => sp.PARTCODE.Trim() == selectedSparePartCode).Count() != 1)
            {
                MessageBox.Show("Error Finding Spare Part " + selectedSparePartCode, "Error");
            }
            else
            {
                var reservedList = home.dbContext.ISSUEs.Where(iss => iss.SPAREPARTCODE.Trim() == selectedSparePartCode && iss.ISSUESTATE.Trim() == "Requested").ToList();
                var reservedQtyWorkOrders = reservedList.Join(home.dbContext.WORKORDERs,
                    iss => iss.WORKORDER,
                    wo => wo.WORKORDERID, 
                    (iss,wo) => new
                    {
                        iss.ISSUEID,
                        wo.WORKORDERID,
                        wo.WORKORDEREQUIPMENTID,
                        wo.WORKORDERDIRECTIVE,
                        iss.SPAREPARTCODE,
                        iss.QTY,
                        iss.REQUESTDATE
                    }
                    );

                issueBindingSource.DataSource = reservedQtyWorkOrders.ToList();

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedWorkOrder = (int)ReservedIssuesGridView.SelectedRows[0].Cells["workOrderIDNumber"].Value;
            DialogResult openWorkOrderQuesion = MessageBox.Show("Open WorkOrder #" + selectedWorkOrder, "Open Work Order", MessageBoxButtons.YesNo);
            if (openWorkOrderQuesion == DialogResult.Yes)
            {

                if (Application.OpenForms.OfType<WorkOrder>().Count() != 0)
                {
                    foreach (WorkOrder openedWorkOrder in Application.OpenForms.OfType<WorkOrder>().ToList())
                    {
                        if (openedWorkOrder.workOrder.WORKORDERID == selectedWorkOrder)
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
