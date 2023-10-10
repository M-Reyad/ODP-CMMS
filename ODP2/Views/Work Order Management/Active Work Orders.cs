using ODP2.Views;
using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ODP2.Models;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ODP2
{
    public partial class ActiveWorkOrders : UserControl
    {
        public Home home = new Home();
        public List<WORKORDER> workOrders = new List<WORKORDER>();

        public ActiveWorkOrders()
        {
            InitializeComponent();

        }

        private void ActiveWorkOrders_Load(object sender, EventArgs e)
        {
            configSearch();
        }
        private void equipmentBox_LostFocus(object sender, EventArgs e)
        {
            var equipmentList = new List<EQUIPMENT>();
            if (equipmentBox.Text != "")
            {
                if (home.dbContext.EQUIPMENTs.Where(equipment => equipment.EQUIPMENTID.Trim().ToUpper() == equipmentBox.Text.ToUpper()).Count() != 0)
                {
                    equipmentList = home.dbContext.EQUIPMENTs.Where(equipment => equipment.EQUIPMENTID.Trim().ToUpper() == equipmentBox.Text.ToUpper()).ToList();
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
            using (var dbContext = new ODPEntities_ORACLE())
            {


                workOrders = dbContext.WORKORDERs.Where(workOrder => workOrder.WORKORDERSTATUSID.Trim() != "Finished" && workOrder.WORKORDERSTATUSID.Trim() != "Cancelled").ToList();
                if (workOrderBox.Text != "")
                {
                    int workOrderNumber = Convert.ToInt32(workOrderBox.Text);
                    workOrders = workOrders.Where(workOrder => workOrder.WORKORDERID == workOrderNumber).ToList();
                }

                if (equipmentBox.Text != "")
                {
                    workOrders = workOrders.Where(workOrder => workOrder.WORKORDEREQUIPMENTID.Trim().ToUpper() == equipmentBox.Text.Trim().ToUpper()).ToList();
                }

                if (workStatusBox.GetItemText(workStatusBox.SelectedItem).Trim() != "")
                {
                    workOrders = workOrders.Where(workOrder => workOrder.WORKORDERSTATUSID.Trim() == workStatusBox.GetItemText(workStatusBox.SelectedItem).Trim()).ToList();
                }

                if (directiveTextBox.Text != "")
                {

                    if (directiveTextBox.Text.Contains("%"))
                    {
                        string directive = directiveTextBox.Text.Trim('%');
                        workOrders = workOrders.Where(workOrder => workOrder.WORKORDERDIRECTIVE.ToUpper().Contains(directive.ToUpper())).ToList();
                    }
                    else
                    {
                        workOrders = workOrders.Where(workOrder => workOrder.WORKORDERDIRECTIVE.Trim().ToUpper() == directiveTextBox.Text.Trim().ToUpper()).ToList();

                    }
                }

                if (dateCheckBox.Checked == true)
                {
                    workOrders = workOrders.Where(workOrder => workOrder.WORKORDERREGISTERATIONDATE >= fromDatePicker.Value.Date).ToList();
                }
                if (workTypeBox.Text != "")
                {
                    workOrders = workOrders.Where(workOrder => workOrder.WORKORDERTYPEID == workTypeBox.Text).ToList();
                }

                if (workOrders.Count() > 0)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        /*await Task.Run(() => */
                        workOrderBindingSource.DataSource = workOrders.OrderByDescending(wo => wo.WORKORDERID);
                        this.Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    //workOrderBindingSource.DataSource = null;
                    MessageBox.Show("No Work Orders Found with these Inputs", "Zero Results");
                }
            }

        }
        private void activeWorkOrdersGrid_MouseDoubleClick(object sender, EventArgs e)
        {
                int selectedWorkOrder = (int)activeWorkOrdersGrid.SelectedRows[0].Cells[0].Value;
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
                if (workTypeBox.GetItemText(workTypeBox.SelectedItem).Trim() != "")
                {
                    string selectedWorkOrderType = workTypeBox.GetItemText(workTypeBox.SelectedItem).Trim();
                    workTypeDirective.Text = home.dbContext.WORKORDERTYPEs.Where(woType => woType.WORKORDERTYPEID.Trim() == selectedWorkOrderType).First().WORKORDERTYPEDIRECTIVE.Trim();
                }
            }
        }
        private void configSearch()
        {
            activeWorkOrdersGrid.AutoGenerateColumns = false;
            dateCheckBox.Checked = false;
            fromDatePicker.Enabled = false;            
            workOrderTypeBindingSource.DataSource = home.dbContext.WORKORDERTYPEs.ToList();
            var workStatusList = new List<WORKORDERSTATU>();
            workStatusList.Add(new WORKORDERSTATU
            {
                WORKORDERSTATUSID = ""
            });
            workStatusList.AddRange(home.dbContext.WORKORDERSTATUS.Where(status => status.WORKORDERSTATUSID.Trim() != "Cancelled" && status.WORKORDERSTATUSID.Trim() != "Finished").ToArray());
            workOrderStatuBindingSource.DataSource = workStatusList;
            workTypeBox.Text = "";
            workStatusBox.Text = "";
            workTypeDirective.Text = "";
        }
    }
}
