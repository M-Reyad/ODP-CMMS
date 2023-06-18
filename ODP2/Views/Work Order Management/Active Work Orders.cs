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
           

            workOrderTypeBindingSource.DataSource = home.dbContext.workOrderTypes.ToList();
            workOrderStatuBindingSource.DataSource = home.dbContext.workOrderStatus.ToList();
            //workStatusBox.Items.Add(new workOrderStatu() { workOrderStatusID = "" });
            workTypeBox.Text = "";
            workStatusBox.Text = "";
            workTypeDirective.Text = "";
            
        }




        private void equipmentBox_LostFocus(object sender, EventArgs e)
        {
            var equipmentList = home.dbContext.equipments.Where(equipment => equipment.equipmentID == equipmentBox.Text);
            if (equipmentBox.Text != "")
            {
                if (equipmentList.Count() != 0)
                {
                    equipmentBindingSource.DataSource = equipmentList.First();
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
            var workOrders = home.dbContext.workOrders.Where(workOrder => workOrder.workOrderStatusID != "Finished");
            workOrders = workOrders.Where(workOrder => workOrder.workOrderStatusID != "Cancelled");

            if (workOrderBox.Text != "")
            {
                int workOrderNumber = Convert.ToInt32(workOrderBox.Text);
                workOrders = workOrders.Where(workOrder => workOrder.workOrderID == workOrderNumber);
            }

            if (equipmentBox.Text != "")
            {
                workOrders = workOrders.Where(workOrder => workOrder.workOrderEquipmentID == equipmentBox.Text);
            }

            if (workStatusBox.Text != "")
            {
                workOrders = workOrders.Where(workOrder => workOrder.workOrderStatusID == workStatusBox.Text);
            }

            if (directiveTextBox.Text != "")
            {
                if (directiveTextBox.Text.Contains("%"))
                {
                    string directive = directiveTextBox.Text.Trim('%');
                    workOrders = workOrders.Where(workOrder => workOrder.workOrderDirective.Contains(directive));
                }
                else
                {
                    workOrders = workOrders.Where(workOrder => workOrder.workOrderDirective == directiveTextBox.Text);
                }
                
            }

            if (dateCheckBox.Checked == true)
            {
                workOrders = workOrders.Where(workOrder => workOrder.workOrderRegisterationDate >= fromDatePicker.Value.Date);
            }
            if (workTypeBox.Text != "")
            {
                workOrders = workOrders.Where(workOrder => workOrder.workOrderTypeID == workTypeBox.Text);
            }

            if (workOrders.Count() > 0)
            {
                workOrderBindingSource.DataSource = workOrders.OrderByDescending(wo => wo.workOrderID).ToList();
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
