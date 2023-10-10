using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ODP2.Models;
namespace ODP2.Views
{
    public partial class CreateNewWorkOrder : Form
    {

        public Home home = new Home();

        public CreateNewWorkOrder()
        {
            InitializeComponent();
        }

        private void CreateNewWorkOrder_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = home.dbContext.ODP_USER.Where(user => user.USERID.Trim() == home.user.USERID.Trim()).First();
            if (home.user.USERLEVEL.Trim() == "Head")
            {
                creatorIDTextBox.ReadOnly = false;
            }
            var workOrderTypesList = home.dbContext.WORKORDERTYPEs.ToList();
            //workOrderTypesList.RemoveAll(type => type.workOrderTypeID.Trim() == "PM");
            workOrderTypeBindingSource.DataSource = workOrderTypesList.ToList();

        }
        private void newWorkOrderButton_Click(object sender, EventArgs e)
        {
            Close();
            new CreateNewWorkOrder() { home = this.home }.Show();

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (equipmentBindingSource == null)
            {
                MessageBox.Show("Please Enter an Equipment", "Invalid Data");
                equipmentTextBox.Focus();
            }
            else if (workOrderDirective.Text == "")
            {
                MessageBox.Show("Please Enter a Valid Work Order Directive", "Invalid Data");
                workOrderDirective.Focus();
            }
            else if (userBindingSource == null)
            {
                MessageBox.Show("Please Enter a Valid Creator ID", "Invalid Data");
                creatorIDTextBox.Focus();
            }
            else if (equipmentWHR.Text == "" && !home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTFAMILYID.Trim() == "TR").ToList().Contains(equipmentBindingSource.DataSource))
            {
                    MessageBox.Show("Please Enter a Valid equipment Working HR.", "Invalid Data");
                    equipmentWHR.Focus();
            }
            else
            {
                //using (var dbContext = new ODPEntities_ORACLE())
                //{
                try
                {
                    WORKORDER newWorkOrder = new WORKORDER();
                    newWorkOrder.ODP_USER = (ODP_USER)userBindingSource.DataSource;
                    newWorkOrder.WORKORDERDIRECTIVE = workOrderDirective.Text;
                    newWorkOrder.EQUIPMENT = (EQUIPMENT)equipmentBindingSource.DataSource;
                    if (equipmentWHR.Text != "")
                    {
                        newWorkOrder.EQUIPMENTRH = Convert.ToInt32(equipmentWHR.Text);
                    }
                    newWorkOrder.WORKORDERREGISTERATIONDATE = regsiterationDatePicker.Value;
                    newWorkOrder.WORKORDERTYPE = (WORKORDERTYPE)workTypeTextBox.SelectedItem;
                    newWorkOrder.WORKORDERSTATU = home.dbContext.WORKORDERSTATUS.Where(status => status.WORKORDERSTATUSID == "Work Request").First();
                    home.dbContext.WORKORDERs.Add(newWorkOrder);
                    home.dbContext.SaveChanges();
                    workOrderBindingSource.DataSource = newWorkOrder;
                    saveButton.Enabled = false;
                    DialogResult openWorkOrderQuesion = MessageBox.Show("Work Order " + newWorkOrder.WORKORDERID + " Created Successfully, " +
                        "Open the Work Order?", "Saved", MessageBoxButtons.YesNo);

                    if (openWorkOrderQuesion == DialogResult.Yes)
                    {
                        WorkOrder workOrder = new WorkOrder(newWorkOrder.WORKORDERID, home);
                        workOrder.Show();
                        this.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding the WorkOrder " + ex, "Error Saving");
                }
                //}

            }
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            if (sender == creatorIDTextBox)
            {
                if (home.dbContext.ODP_USER.Where(user => user.USERIDNUMBER == Convert.ToInt32(creatorIDTextBox.Text)).Count() != 1 && creatorIDTextBox.Text != "")
                {
                    MessageBox.Show("Error User ID, Please Enter a Valid ID", "Error Inputs");

                }
                else if (creatorIDTextBox.Text == "")
                {
                    userBindingSource.DataSource = null;
                }
                else
                {
                    userBindingSource.DataSource = home.dbContext.ODP_USER.Where(user => user.USERID.Trim() == home.user.USERID.Trim()).First();
                }
            }

            else if (sender == equipmentTextBox)
            {
                if (home.dbContext.EQUIPMENTs.Where(equipment => equipment.EQUIPMENTID.Trim() == equipmentTextBox.Text).Count() != 1 && equipmentTextBox.Text != "")
                {
                    MessageBox.Show("Error Equipment ID, Please Enter a Valid ID", "Error Inputs");
                    equipmentTextBox.Focus();

                }
                else if (equipmentTextBox.Text == "")
                {
                    equipmentBindingSource.Clear();
                }
                else
                {
                    equipmentBindingSource.DataSource = home.dbContext.EQUIPMENTs.Where(equipment => equipment.EQUIPMENTID.Trim() == equipmentTextBox.Text).First();
                    configForTrailer();
                }
            }
        }
        private void configForTrailer()
        {
            if (home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTFAMILYID.Trim() == "TR").ToList().Contains(equipmentBindingSource.DataSource))
            {
                equipmentWHR.Text = "";
                equipmentWHR.Enabled = false;
            }
            else
            {
                equipmentWHR.Text = "";
                equipmentWHR.Enabled = true;

            }
        }
    }
}
    


