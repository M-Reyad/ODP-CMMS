using ODP2.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views.Inventory_Spare_Parts_Management
{
    public partial class IssueSparePart : UserControl
    {
        public Home home = new Home();
        public IssueSparePart()
        {
            InitializeComponent();


        }


        private void IssueSparePart_Load(object sender, EventArgs e)
        {
            dateCheckBox.Checked = false;
            dateTimePicker.Enabled = false;
        }

        private void workOrderTextBox_Validated(object sender, EventArgs e)
        {
            if (workOrderTextBox.Text != "")
            {
                int workOrderID = Convert.ToInt32(workOrderTextBox.Text);
                if (home.dbContext.workOrders.Where(wo => wo.workOrderID == workOrderID).Count() != 1)
                {
                    MessageBox.Show("Cannot Find WorkOrder #" + workOrderID + " Please Enter a valid WO#", "Error");
                    workOrderTextBox.Focus();
                }
                else
                {
                    if (home.dbContext.workOrders.Where(wo => wo.workOrderID == workOrderID).First().workOrderStatusID.Trim() == "Finished")
                    {
                        MessageBox.Show("WorkOrder #" + workOrderID + " is Finished, Please enter an Active WO#", "Error");
                        workOrderTextBox.Focus();
                    }

                    else
                    {

                        issueBindingSource.DataSource = home.dbContext.issues.Where(issue => issue.workOrder1.workOrderID == workOrderID)
                .Join(home.dbContext.spareParts,
                issue => issue.sparePartCode,
                sp => sp.partCode,
                (issue, sp) => new
                {
                    issue.issueID,
                    issue.workOrder,
                    issue.qty,
                    issue.sparePartCode,
                    sp.partDirective,
                    sp.partPrice,
                    issue.totalPrice,
                    issue.issueDate
                }).ToList();

                    }
                }
            }
            else
            {
                
                issueBindingSource.Clear();
            }
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheckBox.Checked == true)
            {
                dateTimePicker.Enabled = true;
            }
            else if (dateCheckBox.Checked == false)
            {
                dateTimePicker.Enabled = false;
                issueBindingSource.Clear();
                issueGridView.Refresh();
            }
        }

        private void dateTimePicker_Validated(object sender, EventArgs e)
        {
            issueBindingSource.DataSource = home.dbContext.issues.Where(issue => issue.issueDate == dateTimePicker.Value.Date)
                .Join(home.dbContext.spareParts,
                issue => issue.sparePartCode,
                sp => sp.partCode,
                (issue, sp) => new
                {
                    issue.issueID,
                    issue.workOrder,
                    issue.qty,
                    issue.sparePartCode,
                    sp.partDirective,
                    sp.partPrice,
                    issue.totalPrice,
                    issue.issueDate
                }).ToList();

            issueGridView.Refresh();
        }

        private void partCodeTextBox_Validated(object sender, EventArgs e)
        {
            if (partCodeTextBox.Text != "")
            {


                if (home.dbContext.spareParts.Where(part => part.partCode == partCodeTextBox.Text).Count() == 1)
                {
                    partDescriptionTextBox.Text = home.dbContext.spareParts.Where(part => part.partCode == partCodeTextBox.Text).First().partDirective;
                }
                else
                {
                    MessageBox.Show("Error Part Code, Please Enter a Valid Code", "Error");
                    partCodeTextBox.Focus();
                }
            }
            else
            {
                partDescriptionTextBox.Text = "";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(workOrderTextBox.Text == "")
            {
                MessageBox.Show("Please Enter valid WorkOrder Number", "Error");
            }
            if (quantityTextbox.Text == "")
            {
                MessageBox.Show("Please Enter valid Quantity", "Error");
            }
            else if (partCodeTextBox.Text == "")
            {
                MessageBox.Show("Please Enter valid Part Code", "Error");
            }
            else
            {
                try
                {
                    var newIssue = new issue();
                    newIssue.issueDate = DateTime.Today;
                    newIssue.sparePartCode = partCodeTextBox.Text;
                    newIssue.qty = Convert.ToInt32(quantityTextbox.Text);
                    newIssue.workOrder = Convert.ToInt32(workOrderTextBox.Text);
                    newIssue.partPrice = home.dbContext.spareParts.Where(part => part.partCode.Trim() == partCodeTextBox.Text).First().partPrice;
                    home.dbContext.issues.Add(newIssue);
                    MessageBox.Show("Successfully added " + newIssue.qty + " * " + newIssue.sparePartCode);
                    home.dbContext.SaveChanges();
                    MessageBox.Show("Added Successfully");
                    issueGridView.Refresh();
                    partCodeTextBox.Text = "";
                    quantityTextbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding Issue" + ex, "Error");
                }
            }

        }


        private void issueGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int issueID = (int) issueGridView.SelectedRows[0].Cells["issueID"].Value;
            DialogResult result = MessageBox.Show("Are you sure to Delete Issue #" + issueID, "Un-issue Line #" + issueID, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var issueToRemove = home.dbContext.issues.Remove(home.dbContext.issues.Where(issue => issue.issueID == issueID).First());
                    home.dbContext.SaveChanges();
                    MessageBox.Show("Deleted Successfully");
                    issueGridView.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Un-issuing Line #" + issueID + ex, "Error Saving");
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}