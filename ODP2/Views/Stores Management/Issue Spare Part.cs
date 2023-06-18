using ODP2.Models;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
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
            int workOrder;
            if (workOrderTextBox.Text != "" )
            {
                //int workOrderID = Convert.ToInt32(workOrderTextBox.Text);
                if (int.TryParse(workOrderTextBox.Text, out workOrder) != false)
                {

                    if (home.dbContext.workOrders.Where(wo => wo.workOrderID == workOrder).Count() != 1)
                    {
                        MessageBox.Show("Cannot Find WorkOrder #" + workOrder + " Please Enter a valid WO#", "Error");
                        workOrderTextBox.Focus();
                    }
                    else
                    {
                        if (home.dbContext.workOrders.Where(wo => wo.workOrderID == workOrder).First().workOrderStatusID.Trim() == "Finished")
                        {
                            MessageBox.Show("WorkOrder #" + workOrder + " is Finished, Please enter an Active WO#", "Error");
                            workOrderTextBox.Focus();
                        }

                        else
                        {

                            issueBindingSource.DataSource = home.dbContext.issues.Where(issue => issue.workOrder1.workOrderID == workOrder)
                    .Join(home.dbContext.spareParts,
                    issue => issue.sparePartCode,
                    sp => sp.partCode,
                    (issue, sp) => new
                    {
                        issue.issueID,
                        issue.workOrder,
                        issue.qty,
                        sp.uom,
                        issue.sparePartCode,
                        sp.partDirective,
                        sp.partPrice,
                        issue.totalPrice,
                        issue.issueDate,
                        issue.issueState,
                        issue.requestDate

                    }).ToList();
                            foreach (DataGridViewRow issue in issueGridView.Rows)
                            {
                                if ((string)issue.Cells["issueState"].Value.ToString().Trim() == "Requested")
                                {
                                    issue.DefaultCellStyle.BackColor = Color.Yellow;
                                }
                                else if ((int)issue.Cells["qty"].Value < 0)
                                {
                                    issue.DefaultCellStyle.BackColor = Color.Red;
                                }
                            }
                            issueGridView.ReadOnly = false;
                            issueGridView.Refresh();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a valid WorkOrder #", "Invalid Data");
                    workOrderTextBox.Focus();
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
                    issue.issueDate,
                    issue.issueState,
                    issue.requestDate

                }).ToList();
            foreach (DataGridViewRow issue in issueGridView.Rows)
            {
                if ((string)issue.Cells["issueState"].Value.ToString().Trim() == "Requested")
                {
                    issue.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if ((int)issue.Cells["qty"].Value < 0)
                {
                    issue.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            issueGridView.Refresh();
        }


        private void issueButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow issue in issueGridView.Rows)
            {
                var rowCheckBox = (string)issue.Cells["selectColumn"].Value;
                if (rowCheckBox == "true")
                {
                    var issueID = (int)issue.Cells["issueID"].Value;
                    issue issueLineToBeIssued = home.dbContext.issues.Where(iss => iss.issueID == issueID).First();
                    try
                    {
                        issueLineToBeIssued.issueDate = DateTime.Today;
                        issueLineToBeIssued.issueState = "Issued";
                        var sparePart = home.dbContext.spareParts.Where(sp => sp.partCode == issueLineToBeIssued.sparePartCode).First();
                        sparePart.reservedStock -= issueLineToBeIssued.qty;
                        sparePart.partStockQty -= issueLineToBeIssued.qty;
                        home.dbContext.spareParts.AddOrUpdate(sparePart);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Successfully Issued Line #" + issueLineToBeIssued.issueID);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Adding Issue" + ex, "Error");
                    }
                }

            }
            issueBindingSource.ResetBindings(false);
            issueGridView.Refresh();
        }


        private void unissueButton_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow issue in issueGridView.Rows)
            {
                var rowCheckBox = (string) issue.Cells["selectColumn"].Value;
                if (rowCheckBox == "true")
                {
                    try
                    {

                        var newIssue = new issue();
                        newIssue.issueDate = DateTime.Today;
                        newIssue.sparePartCode = (string) issue.Cells["sparePartCode"].Value;
                        newIssue.qty = ((int) issue.Cells["qty"].Value)* -1;
                        newIssue.workOrder = (int) issue.Cells["workOrder"].Value;
                        newIssue.partPrice = home.dbContext.spareParts.Where(part => part.partCode.Trim() == newIssue.sparePartCode).First().partPrice;
                        newIssue.issueState = "Unissued";
                        newIssue.requestDate = DateTime.Today;
                        home.dbContext.issues.Add(newIssue);
                        var sparePart = home.dbContext.spareParts.Where(sp => sp.partCode == newIssue.sparePartCode).First();
                        sparePart.partStockQty -= newIssue.qty;
                        home.dbContext.spareParts.AddOrUpdate(sparePart);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Successfully Un-Issued " + newIssue.qty + " * " + newIssue.sparePartCode);

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error Un-issueing, " + ex);
                    }
                    
                }
            }
            issueBindingSource.ResetBindings(false);
            issueGridView.Refresh();

        }

        private void issueGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow issue in issueGridView.Rows)
            {
                label1.Focus();
                var rowCheckBox = (string) (issue.Cells["selectColumn"].Value);
                if (rowCheckBox == "true" && issue.Cells["issueState"].Value.ToString().Trim() == "Issued")
                {
                    unissueButton.Enabled = true;
                    break;
                }
                else if (rowCheckBox == "true" && issue.Cells["issueState"].Value.ToString().Trim() == "Requested")
                {
                    issueButton.Enabled = true;
                    break;
                }
                if (issue == issueGridView.Rows[issueGridView.Rows.Count - 1])
                {
                    unissueButton.Enabled = false;
                    issueButton.Enabled = false;
                }
            }
        }

    }
}