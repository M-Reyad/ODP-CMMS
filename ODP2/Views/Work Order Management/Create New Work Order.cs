using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ODP2.Models;
namespace ODP2.Views
{
    public partial class CreateNewWorkOrder : Form
    {
        private workOrder newWorkOrder = new workOrder();
        public Home home = new Home();

        public CreateNewWorkOrder()
        {
            InitializeComponent();
        }

        private void CreateNewWorkOrder_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = home.dbContext.users.Where(user => user.userID == home.user.userID).First();
            if (home.user.userLevel.Trim() == "Head")
            {
                creatorIDTextBox.ReadOnly = false;
            }
            var workOrderTypesList = home.dbContext.workOrderTypes.ToList();            
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
            else if (equipmentWHR.Text == "")
            {
                MessageBox.Show("Please Enter a Valid equipment Working HR.", "Invalid Data");
                equipmentWHR.Focus();
            }
            else
            {
                try
                {
                    newWorkOrder.user = (user)userBindingSource.DataSource;
                    newWorkOrder.workOrderDirective = workOrderDirective.Text;
                    newWorkOrder.equipment = (equipment)equipmentBindingSource.DataSource;
                    newWorkOrder.equipmentRH = Convert.ToInt32(equipmentWHR.Text);
                    newWorkOrder.workOrderRegisterationDate = regsiterationDatePicker.Value;
                    newWorkOrder.workOrderType = (workOrderType)workTypeTextBox.SelectedItem;
                    newWorkOrder.workOrderStatu = home.dbContext.workOrderStatus.Where(status => status.workOrderStatusID == "Work Request").First();
                    home.dbContext.workOrders.Add(newWorkOrder);
                    home.dbContext.SaveChanges();
                    workOrderBindingSource.DataSource = newWorkOrder;
                    DialogResult openWorkOrderQuesion = MessageBox.Show("Work Order " + newWorkOrder.workOrderID + " Created Successfully, " +
                        "Open the Work Order?", "Saved", MessageBoxButtons.YesNo);

                    if (openWorkOrderQuesion == DialogResult.Yes)
                    {
                        WorkOrder workOrder = new WorkOrder(newWorkOrder.workOrderID, home);
                        workOrder.Show();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding the WorkOrder " + ex, "Error Saving");
                }

    
            }
        }
    

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (sender == creatorIDTextBox)
            {
                if (home.dbContext.users.Where(user => user.userIDNumber == Convert.ToInt32(creatorIDTextBox.Text)).Count() != 1 && creatorIDTextBox.Text != "")
                {
                    MessageBox.Show("Error User ID, Please Enter a Valid ID", "Error Inputs");
                    
                }
                else if (creatorIDTextBox.Text == "")
                {
                    userBindingSource.DataSource = null;
                }
                else
                {
                    userBindingSource.DataSource = home.dbContext.users.Where(user => user.userID == home.user.userID).First();
                }
            }

            else if (sender == equipmentTextBox)
            {
                if (home.dbContext.equipments.Where(equipment => equipment.equipmentID == equipmentTextBox.Text).Count() != 1 && equipmentTextBox.Text != "")
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
                    equipmentBindingSource.DataSource = home.dbContext.equipments.Where(equipment => equipment.equipmentID == equipmentTextBox.Text).First();

                }
            }
            }
        }
    }
    


