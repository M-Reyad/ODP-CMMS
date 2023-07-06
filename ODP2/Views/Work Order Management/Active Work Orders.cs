using ODP2.Views;
using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ODP2.Models;
using System.Linq;

namespace ODP2
{
    public partial class ActiveWorkOrders : UserControl
    {
        public Home home = new Home();

        public ActiveWorkOrders()
        {
            InitializeComponent();

        }

        private void ActiveWorkOrders_Load(object sender, EventArgs e)
        {

            dateCheckBox.Checked = false;  
            fromDatePicker.Enabled = false;
           

            workOrderTypeBindingSource.DataSource = home.dbContext.WORKORDERTYPES.ToList();
            workOrderStatuBindingSource.DataSource = home.dbContext.WORKORDERSTATUS.ToList();
            workStatusBox.Items.Remove((new WORKORDERSTATU() { WORKORDERSTATUSID = "Cancelled" }));
            
            workTypeBox.Text = "";
            workStatusBox.Text = "";
            workTypeDirective.Text = "";
            
        }




        private void equipmentBox_LostFocus(object sender, EventArgs e)
        {
            var equipmentList = new List<EQUIPMENT>();
            if (equipmentBox.Text != "")
            {
                if (home.dbContext.EQUIPMENTS.Where(equipment => equipment.EQUIPMENTID == equipmentBox.Text).Count() != 0)
                {
                    equipmentList = home.dbContext.EQUIPMENTS.Where(equipment => equipment.EQUIPMENTID == equipmentBox.Text).ToList();
                    equipmentDirective.Text = equipmentList.First().EQUIPMENTDIRECTIVE.Trim();
                }
                else
                {
                    MessageBox.Show("Wrong Equipment ID, Please Enter a Valid Equipment ID");
                    equipmentBox.Focus();
                }
            }
            else
            {
                equipmentDirective.Text = "";
            }
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheckBox.Checked == true)
            {
                fromDatePicker.Enabled = true;
            }
            else
            {
                fromDatePicker.Enabled = false;
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            var workOrders = home.dbContext.WORKORDERS.Where(workOrder => workOrder.WORKORDERSTATUSID != "Finished");
            workOrders = workOrders.Where(workOrder => workOrder.WORKORDERSTATUSID != "Cancelled");

            if (workOrderBox.Text != "")
            {
                int workOrderNumber = Convert.ToInt32(workOrderBox.Text);
                workOrders = workOrders.Where(workOrder => workOrder.WORKORDERID == workOrderNumber);
            }

            if (equipmentBox.Text != "")
            {
                workOrders = workOrders.Where(workOrder => workOrder.WORKORDEREQUIPMENTID == equipmentBox.Text);
            }

            if (workStatusBox.Text != "")
            {
                workOrders = workOrders.Where(workOrder => workOrder.WORKORDERSTATUSID == workStatusBox.Text);
            }

            if (directiveTextBox.Text != "")
            {
                if (directiveTextBox.Text.Contains("%"))
                {
                    string directive = directiveTextBox.Text.Trim('%');
                    workOrders = workOrders.Where(workOrder => workOrder.WORKORDERDIRECTIVE.Contains(directive));
                }
                else
                {
                    workOrders = workOrders.Where(workOrder => workOrder.WORKORDERDIRECTIVE == directiveTextBox.Text);
                }
                
            }

            if (dateCheckBox.Checked == true)
            {
                workOrders = workOrders.Where(workOrder => workOrder.WORKORDERREGISTERATIONDATE >= fromDatePicker.Value.Date);
            }
            if (workTypeBox.Text != "")
            {
                workOrders = workOrders.Where(workOrder => workOrder.WORKORDERTYPEID == workTypeBox.Text);
            }

            if (workOrders.Count() > 0)
            {
                workOrderBindingSource.DataSource = workOrders.OrderByDescending(wo => wo.WORKORDERID).ToList();
                activeWorkOrdersGrid.Refresh();
            }
            else
            {
                //workOrderBindingSource.DataSource = null;
                MessageBox.Show("No Work Orders Found with these Inputs", "Zero Results");
            }


        }

        private void activeWorkOrdersGrid_MouseDoubleClick(object sender, EventArgs e) 
        {
            int selectedWorkOrder = (int)activeWorkOrdersGrid.SelectedRows[0].Cells[0].Value;
            DialogResult openWorkOrderQuesion = MessageBox.Show("Open WorkOrder #" + selectedWorkOrder , "Open Work Order", MessageBoxButtons.YesNo);
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

        //Work Type Box Functions
        private void workTypeBox_TextUpdate(object sender, EventArgs e)
        {
            if (workTypeBox.Text == "")
            {
                workTypeDirective.Text = "";
            }
        }

        private void workTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == workTypeBox)
            {
                workTypeDirective.Text = workTypeBox.ValueMember.Trim();
            }
        }
    }
}
