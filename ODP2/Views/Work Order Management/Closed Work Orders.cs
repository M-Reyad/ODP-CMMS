using ODP2.Views;
using System;
using System.Windows.Forms;
using System.Data;
using ODP2.Models;
using System.Linq;
using System.Collections.Generic;

namespace ODP2
{
    public partial class ClosedWorkOrders : UserControl
    {
        public Home home = new Home();

        public ClosedWorkOrders()
        {
            InitializeComponent();

        }

        private void ClosedWorkOrders_Load(object sender, EventArgs e)
        {


            fromDateCheckBox.Checked = false;
            fromDatePicker.Enabled = false;
            toDateCheckBox.Checked = false;
            toDatePicker.Enabled = false;

            workOrderTypeBindingSource.DataSource = home.dbContext.workOrderTypes.ToList();
            workTypeBox.Text = "";
            workTypeDirective.Text = "";

        }




        private void equipmentBox_LostFocus(object sender, EventArgs e)
        {
            var equipmentList = new List<equipment>();
            if (equipmentBox.Text != "")
            {
                if (home.dbContext.equipments.Where(equipment => equipment.equipmentID == equipmentBox.Text).Count() != 0)
                {
                    equipmentList = home.dbContext.equipments.Where(equipment => equipment.equipmentID == equipmentBox.Text).ToList();
                    equipmentDirective.Text = equipmentList.First().equipmentDirective.Trim();
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

        private void toDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (toDateCheckBox.Checked == true)
            {
                toDatePicker.Enabled = true;
            }
            else
            {
                toDatePicker.Enabled = false;
            }
        }
        private void fromDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fromDateCheckBox.Checked == true)
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
            var workOrders = home.dbContext.workOrders.Where(workOrder => workOrder.workOrderStatusID == "Finished" ||  workOrder.workOrderStatusID == "Cancelled");

            if (workOrderBox.Text != "")
            {
                int workOrderNumber = Convert.ToInt32(workOrderBox.Text);
                workOrders = workOrders.Where(workOrder => workOrder.workOrderID == workOrderNumber);
            }

            if (equipmentBox.Text != "")
            {
                workOrders = workOrders.Where(workOrder => workOrder.workOrderEquipmentID == equipmentBox.Text);
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

            if (fromDateCheckBox.Checked == true)
            {
                workOrders = workOrders.Where(workOrder => workOrder.workOrderRegisterationDate >= fromDatePicker.Value.Date);
            }

            if (toDateCheckBox.Checked == true)
            {
                workOrders = workOrders.Where(workOrder => workOrder.workOrderRegisterationDate <= toDatePicker.Value.Date);
            }

            if (workTypeBox.Text != "")
            {
                workOrders = workOrders.Where(workOrder => workOrder.workOrderTypeID == workTypeBox.Text);
            }

            if (workOrders.Count() > 0)
            {
                workOrderBindingSource.DataSource = workOrders.OrderByDescending(wo => wo.workOrderID).ToList();
                closedWorkOrdersGrid.Refresh();
            }
            else
            {
                MessageBox.Show("No Work Orders Found with these Inputs", "Zero Results");
            }


        }

        private void closedWorkOrdersGrid_MouseDoubleClick(object sender, EventArgs e)
        {
            int selectedWorkOrder = (int)closedWorkOrdersGrid.SelectedRows[0].Cells[0].Value;
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

            workTypeDirective.Text = workTypeBox.ValueMember.Trim();

        }
    }
}
