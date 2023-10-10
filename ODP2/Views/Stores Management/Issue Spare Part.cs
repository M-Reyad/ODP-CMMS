using ODP2;
using ODP2.Models;
using ODP2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views.Inventory_Spare_Parts_Management
{
    public partial class IssueSparePart : UserControl
    {
        public Home home = new Home();
        private int workOrderID;
        private DateTime sinceDate;

        public IssueSparePart()
        {
            InitializeComponent();


        }
        private void IssueSparePart_Load(object sender, EventArgs e)
        {
            dateCheckBox.Checked = false;
            dateTimePicker.Enabled = false;
            issueGridView.ClearSelection();
        }

        #region Inputs
        private void workOrderTextBox_Validated(object sender, EventArgs e)
        {
            if (workOrderTextBox.Text != "")
            {
                if (int.TryParse(workOrderTextBox.Text, out workOrderID) != false)
                {

                    if (home.dbContext.WORKORDERs.Where(wo => wo.WORKORDERID == workOrderID).Count() != 1)
                    {
                        MessageBox.Show("Cannot Find WorkOrder #" + workOrderID + " Please Enter a valid WO#", "Error");
                        workOrderTextBox.Focus();
                    }
                    else
                    {
                        if (home.dbContext.WORKORDERs.Where(wo => wo.WORKORDERID == workOrderID).First().WORKORDERSTATUSID.Trim() == "Finished")
                        {
                            MessageBox.Show("WorkOrder #" + workOrderID + " is Finished, Please enter an Active WO#", "Error");
                            workOrderTextBox.Focus();
                        }

                        else
                        {

                            configSearch();
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
                sinceDate = dateTimePicker.Value;
            }
            else if (dateCheckBox.Checked == false)
            {
                dateTimePicker.Enabled = false;
            }
        }
        private void dateTimePicker_Validated(object sender, EventArgs e)
        {
            sinceDate = dateTimePicker.Value;
            configSearch();
        }
        #endregion

        #region Selecting Lines to be Issued/Unissued
        private void issueGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Focus();
            if (e.ColumnIndex == issueGridView.Columns["selectColumn"].Index)
            {
                if (checkForSelectedLinesToBeIssued() == true)
                {
                    issueButton.Enabled = true;
                }
                else
                {
                    issueButton.Enabled = false;
                }
                if (checkForSelectedLinesToBeUnissued() == true)
                {
                    unissueButton.Enabled = true;
                }
                else
                {
                    unissueButton.Enabled = false;
                }
            }
        }
        private bool checkForSelectedLinesToBeIssued()
        {
            if (issueGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow issue in issueGridView.Rows)
                {
                    var rowCheckBox = (string)issue.Cells["selectColumn"].Value;
                    if (rowCheckBox == "true" && issue.Cells["issueState"].Value.ToString().Trim() == "Requested")
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }
        private bool checkForSelectedLinesToBeUnissued()
        {
            if (issueGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow issue in issueGridView.Rows)
                {
                    var rowCheckBox = (string)issue.Cells["selectColumn"].Value;
                    if (rowCheckBox == "true" && issue.Cells["issueState"].Value.ToString().Trim() == "Issued")
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Issueing and Un-issuening 
        private void issueButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow issue in issueGridView.Rows)
            {
                var rowCheckBox = (string)issue.Cells["selectColumn"].Value;
                if (rowCheckBox == "true" && issue.Cells["issueState"].Value.ToString().Trim() == "Requested")
                {
                    var issueID = (int)issue.Cells["issueIDColumn"].Value;
                    ISSUE issueLineToBeIssued = home.dbContext.ISSUEs.Where(iss => iss.ISSUEID == issueID).First();
                    try
                    {
                        issueLineToBeIssued.ISSUEDATE = DateTime.Today;
                        issueLineToBeIssued.ISSUERID = home.user.USERID;
                        issueLineToBeIssued.ISSUESTATE = "Issued";
                        var sparePart = home.dbContext.SPAREPARTs.Where(sp => sp.PARTCODE == issueLineToBeIssued.SPAREPARTCODE).First();
                        sparePart.RESERVEDSTOCK -= issueLineToBeIssued.QTY;
                        sparePart.PARTSTOCKQTY -= issueLineToBeIssued.QTY;
                        home.dbContext.SPAREPARTs.AddOrUpdate(sparePart);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Successfully Issued Line #" + issueLineToBeIssued.ISSUEID);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Adding Issue" + ex.Message, "Error");
                    }
                }

            }
            configSearch();
        }
        private void unissueButton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow issue in issueGridView.Rows)
            {
                var rowCheckBox = (string)issue.Cells["selectColumn"].Value;
                if (rowCheckBox == "true" && issue.Cells["issueState"].Value.ToString().Trim() == "Issued")
                {
                    MessageBox.Show(issue.Cells["issueState"].Value.ToString().Trim());
                    /*try
                    {*/
                        var newIssue = new ISSUE();
                        newIssue.ISSUEDATE = DateTime.Today;
                        newIssue.REQUESTDATE = DateTime.Today;
                        newIssue.SPAREPARTCODE = issue.Cells["partCode"].Value.ToString().Trim();
                        newIssue.QTY = ((int)issue.Cells["qty"].Value) * -1;
                        newIssue.WORKORDER = (int)issue.Cells["workOrder"].Value;
                        newIssue.PARTPRICE = home.dbContext.SPAREPARTs.Where(part => part.PARTCODE.Trim() == newIssue.SPAREPARTCODE).First().PARTPRICE;
                        newIssue.ISSUESTATE = "Unissued";
                    newIssue.ISSUERID = home.user.USERID;
                        home.dbContext.ISSUEs.Add(newIssue);
                        var sparePart = home.dbContext.SPAREPARTs.Where(sp => sp.PARTCODE.Trim() == newIssue.SPAREPARTCODE).First();
                        sparePart.PARTSTOCKQTY -= newIssue.QTY;
                        home.dbContext.SPAREPARTs.AddOrUpdate(sparePart);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Successfully Un-Issued " + newIssue.QTY + " * " + newIssue.SPAREPARTCODE);

                    /*}
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Un-issueing, " + ex.Message);
                    }*/

                }
            }
            configSearch();

        }

        #endregion

        #region Functions
        private void configSearch()
        {
            using (var dbContext = new ODPEntities_ORACLE())
            {

                List<ISSUE> issuesList = new List<ISSUE>();
                if (workOrderTextBox.Text != "")
                {
                    issuesList = dbContext.ISSUEs.Where(issue => issue.WORKORDER == workOrderID).ToList();
                }
                if (dateCheckBox.Checked == true)
                {
                    issuesList = dbContext.ISSUEs.Where(issue => issue.REQUESTDATE == sinceDate || issue.ISSUEDATE == sinceDate).ToList();
                }
                if (issuesList.Count != 0)
                {
                    issueBindingSource.DataSource = issuesList
                        .Join(dbContext.SPAREPARTs,
                                issue => issue.SPAREPARTCODE,
                                sp => sp.PARTCODE,
                                (issue, sp) => new
                                {
                                    issue.ISSUEID,
                                    issue.WORKORDER,
                                    issue.QTY,
                                    issue.SPAREPARTCODE,
                                    issue.TOTALPRICE,
                                    issue.ISSUEDATE,
                                    issue.ISSUESTATE,
                                    issue.REQUESTDATE,
                                    sp.UOM,
                                    sp.PARTDIRECTIVE,
                                    sp.PARTPRICE,
                                    requesterName = issue.REQUESTERID,
                                    issuerName = issue.ISSUERID
                                });
                    issueGridView.ClearSelection();
                    issueButton.Enabled = false;
                    unissueButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Issues found with these Criteria", "No Issues Found");
                }
            }
        }
        private void issueGridView_Leave(object sender, EventArgs e)
        {
            issueGridView.ClearSelection();
        }
        private void issueGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == issueGridView.Columns["issueState"].Index)
            {
                if (e.Value.ToString().Trim() == "Requested")
                {
                    issueGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (e.Value.ToString().Trim() == "Unissued")
                {
                    issueGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    issueGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = default;
                }
            }


        }

        #endregion
    }

}