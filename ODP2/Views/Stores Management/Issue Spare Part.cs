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

                    if (home.dbContext.WORKORDERS.Where(wo => wo.WORKORDERID == workOrder).Count() != 1)
                    {
                        MessageBox.Show("Cannot Find WorkOrder #" + workOrder + " Please Enter a valid WO#", "Error");
                        workOrderTextBox.Focus();
                    }
                    else
                    {
                        if (home.dbContext.WORKORDERS.Where(wo => wo.WORKORDERID == workOrder).First().WORKORDERSTATUSID.Trim() == "Finished")
                        {
                            MessageBox.Show("WorkOrder #" + workOrder + " is Finished, Please enter an Active WO#", "Error");
                            workOrderTextBox.Focus();
                        }

                        else
                        {

                            issueBindingSource.DataSource = home.dbContext.ISSUES.Where(issue => issue.WORKORDER == workOrder)
                    .Join(home.dbContext.SPAREPARTS,
                    issue => issue.SPAREPARTCODE,
                    sp => sp.PARTCODE,
                    (issue, sp) => new
                    {
                        issue.ISSUEID,
                        issue.WORKORDER,
                        issue.QTY,
                        sp.UOM,
                        issue.SPAREPARTCODE,
                        sp.PARTDIRECTIVE,
                        sp.PARTPRICE,
                        issue.TOTALPRICE,
                        issue.ISSUEDATE,
                        issue.ISSUESTATE,
                        issue.REQUESTDATE

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
            issueBindingSource.DataSource = home.dbContext.ISSUES.Where(issue => issue.ISSUEDATE == dateTimePicker.Value.Date)
                .Join(home.dbContext.SPAREPARTS,
                issue => issue.SPAREPARTCODE,
                sp => sp.PARTCODE,
                (issue, sp) => new
                {
                    issue.ISSUEID,
                    issue.WORKORDER,
                    issue.QTY,
                    issue.SPAREPARTCODE,
                    sp.PARTDIRECTIVE,
                    sp.PARTPRICE,
                    issue.TOTALPRICE,
                    issue.ISSUEDATE,
                    issue.ISSUESTATE,
                    issue.REQUESTDATE

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
                    ISSUE issueLineToBeIssued = home.dbContext.ISSUES.Where(iss => iss.ISSUEID == issueID).First();
                    try
                    {
                        issueLineToBeIssued.ISSUEDATE = DateTime.Today;
                        issueLineToBeIssued.ISSUESTATE = "Issued";
                        var sparePart = home.dbContext.SPAREPARTS.Where(sp => sp.PARTCODE == issueLineToBeIssued.SPAREPARTCODE).First();
                        sparePart.RESERVEDSTOCK -= issueLineToBeIssued.QTY;
                        sparePart.PARTSTOCKQTY -= issueLineToBeIssued.QTY;
                        home.dbContext.SPAREPARTS.AddOrUpdate(sparePart);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Successfully Issued Line #" + issueLineToBeIssued.ISSUEID);

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

                        var newIssue = new ISSUE();
                        newIssue.ISSUEDATE = DateTime.Today;
                        newIssue.SPAREPARTCODE = (string) issue.Cells["sparePartCode"].Value;
                        newIssue.QTY = ((int) issue.Cells["qty"].Value)* -1;
                        newIssue.WORKORDER = (int) issue.Cells["workOrder"].Value;
                        newIssue.PARTPRICE = home.dbContext.SPAREPARTS.Where(part => part.PARTCODE.Trim() == newIssue.SPAREPARTCODE).First().PARTPRICE;
                        newIssue.ISSUESTATE = "Unissued";
                        newIssue.REQUESTDATE = DateTime.Today;
                        home.dbContext.ISSUES.Add(newIssue);
                        var sparePart = home.dbContext.SPAREPARTS.Where(sp => sp.PARTCODE == newIssue.SPAREPARTCODE).First();
                        sparePart.PARTSTOCKQTY -= newIssue.QTY;
                        home.dbContext.SPAREPARTS.AddOrUpdate(sparePart);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Successfully Un-Issued " + newIssue.QTY + " * " + newIssue.SPAREPARTCODE);

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