using System.Windows.Forms;
using System;
using System.Data;
using ODP2.Models;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Windows.Controls;
using System.IO;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Data.Entity.Core.Objects;

namespace ODP2.Views
{
    public partial class WorkOrder : Form
    {
        public workOrder workOrder = new workOrder();
        public Home home = new Home();
        public string status;

        public WorkOrder(int workOrderNumber, Home home)
        {
            this.home = home;
            var availableWorkOrders = home.dbContext.workOrders.Where(workOrder => workOrder.workOrderID == workOrderNumber);
            if (availableWorkOrders.Count() != 1)
            {
                MessageBox.Show("Error Loading WorkOrder!", "Error Loading");
            }
            else
            {
                workOrder = availableWorkOrders.First();

                InitializeComponent();
            }


        }

        private void WorkOrder_Load(object sender, EventArgs e)
        {
            status = workOrder.workOrderStatusID;
            workOrderBindingSource.DataSource = workOrder;
            Text += workOrder.workOrderID.ToString();

            //Issue List
            var issueList =
                home.dbContext.issues.Where(issue => issue.workOrder1.workOrderID == workOrder.workOrderID)
                .Join
                (home.dbContext.spareParts,
                issue => issue.sparePartCode,
                part => part.partCode,
                (issue, part) => new
                {
                    issue.issueID,
                    issue.qty,
                    part.uom,
                    issue.sparePartCode,
                    part.partDirective,
                    part.partPrice,
                    issue.totalPrice,
                    issue.issueDate,
                    issue.issueState,
                    issue.requestDate

                })
                .ToList();
            issueBindingSource.DataSource = issueList;
            foreach (DataGridViewRow issue in materialsGridView.Rows)
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
            var totalCost = issueList.Sum(issue => issue.totalPrice);
            totalCostTextbox.Text = totalCost.ToString();


            //BDN List
            var bdnList = home.dbContext.breakDowns.Where(bdn => bdn.workOrder == workOrder.workOrderID).ToList();
            breakDownBindingSource.DataSource = bdnList;

            //Work Status and Work Done Type Customization//
            workDoneTypeBindingSource.DataSource = home.dbContext.workDoneTypes.ToList();
            if (workOrder.workDoneType == null)
            {
                workDoneType.Enabled = false;
            }
            else
            {
                workDoneType.SelectedItem = workOrder.workDoneType1;

            }


            //Work Order Status//
            saveButton.Enabled = false;
            //Cancelled Work Orders Can't be Re-Opened Again//
            if (workOrder.workOrderStatusID.Trim() == "Cancelled")
            {
                workOrderDirective.Enabled = false;
            }
            else
            {

                //Ordinary Users Privilages//
                if (home.user.userLevel.Trim() != "Head")
                {
                    if (workOrder.workOrderStatusID.Trim() == "Work Done" || workOrder.workOrderStatusID.Trim() == "Finished")
                    {
                        workOrderNotes.ReadOnly = true;
                        workDoneType.Enabled = false;
                        workOrderDirective.Enabled = false;
                    }
                }
                //Super User Privilages//
                else
                {
                    registerationDate.ReadOnly = false;
                }
            }

        }

        //========================================================//
        #region Materials

        private void partCodeTextBox_Validated(object sender, EventArgs e)
        {
            if (partCodeTextBox.Text != "")
            {
                if (home.dbContext.spareParts.Where(sp => sp.partCode == partCodeTextBox.Text).Count() != 0)
                {
                    partDirectiveTextBox.Text = home.dbContext.spareParts.Where(sp => sp.partCode == partCodeTextBox.Text).First().partDirective.Trim();
                    requestButton.Enabled = true;
                    quantityTextBox.Focus();

                }
                else
                {
                    MessageBox.Show("Please Enter a valid Part Code", "Invaild Part Code");
                }

            }

        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            int requestedQty;
            if (int.TryParse(quantityTextBox.Text, out requestedQty) && quantityTextBox.Text != "")
            {

                try
                {
                    issue newIssueRequest = new issue();
                    newIssueRequest.requestDate = DateTime.Today;
                    newIssueRequest.sparePartCode = partCodeTextBox.Text;
                    var availableQty = home.dbContext.spareParts.Where(part => part.partCode.Trim() == newIssueRequest.sparePartCode).First().availableStock;
                    if (requestedQty > availableQty)
                    {
                        DialogResult issueAvQtyOnly = MessageBox.Show("Available Stock is less than the requested Quantity! /n" +
                            "Only " + availableQty + " will be requested", "Un-sufficient Quantity");
                        if (issueAvQtyOnly == DialogResult.Yes)
                        {
                            newIssueRequest.qty = (int)availableQty;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (availableQty == 0)
                    {
                        MessageBox.Show("Zero Stock Quantity", "Zero Stock");
                        return;
                    }
                    else if (requestedQty < 0)
                    {
                        MessageBox.Show("Please Enter a Positive Quantity", "Wrong Data");
                        quantityTextBox.Focus();
                        return;
                    }
                    else
                    {
                        newIssueRequest.qty = requestedQty;
                    }
                    newIssueRequest.workOrder = workOrder.workOrderID;
                    newIssueRequest.partPrice = home.dbContext.spareParts.Where(part => part.partCode.Trim() == newIssueRequest.sparePartCode).First().partPrice;
                    newIssueRequest.issueState = "Requested";
                    var sparePart = home.dbContext.spareParts.Where(sp => sp.partCode == newIssueRequest.sparePartCode).First();
                    sparePart.reservedStock += newIssueRequest.qty;
                    home.dbContext.spareParts.AddOrUpdate(sparePart);
                    home.dbContext.issues.Add(newIssueRequest);
                    home.dbContext.SaveChanges();
                    MessageBox.Show("Successfully requested " + newIssueRequest.qty + " * " + newIssueRequest.sparePartCode);
                    this.Close();
                    WorkOrder newWorkOrder = new WorkOrder(workOrder.workOrderID, home);
                    newWorkOrder.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding Issue" + ex, "Error");
                }


            }
            else
            {
                MessageBox.Show("Please Enter a valid Quantity", "Invalid Quantity");
            }

        }

        private void materialsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (materialsGridView.SelectedRows.Count > 0)
            {
                if (materialsGridView.SelectedRows[0].Cells["issueState"].Value.ToString().Trim() == "Requested")
                {
                    releaseButton.Enabled = true;
                }
                else
                {
                    releaseButton.Enabled = false;
                }
            }
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            DialogResult releaseRequestedMaterials = MessageBox.Show("Are you sure to Release Request #" + materialsGridView.SelectedRows[0].Cells["issueID"].Value, "Release Requested Materials", MessageBoxButtons.YesNo);
            if (releaseRequestedMaterials == DialogResult.Yes)
            {
                try
                {
                    int issueNumber = (int)materialsGridView.SelectedRows[0].Cells["issueID"].Value;
                    var releasedIssue = home.dbContext.issues.Where(iss => iss.issueID == issueNumber).First();
                    var sparePart = home.dbContext.spareParts.Where(sp => sp.partCode == releasedIssue.sparePartCode).First();
                    sparePart.reservedStock -= releasedIssue.qty;
                    home.dbContext.spareParts.AddOrUpdate(sparePart);
                    home.dbContext.issues.Remove(releasedIssue);
                    home.dbContext.SaveChanges();
                    MessageBox.Show("Released Successfully");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Releasing Request #" + materialsGridView.SelectedRows[0].Cells["issueID"] + ex);
                }
            }



        }
        #endregion
        //========================================================//

        //========================================================//
        #region Status
        private void workOrderAttributeChanged(object sender, EventArgs e)
        {
            if (sender == registerationDatePicker)
            {
                registerationDate.Text = registerationDatePicker.Value.ToString();
            }
            else if (sender == startDatePicker)
            {

                workStartDate.Text = startDatePicker.Value.ToString();
            }
            else if (sender == doneDatePicker)
            {

                workDoneDate.Text = doneDatePicker.Value.ToString();
            }
            else if (sender == finishDatePicker)
            {
                workOrderFinishDate.Text = finishDatePicker.Value.ToString();
            }

            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (statusBox.Text != status)
            {

                if (statusBox.Text == "Work Started")
                {
                    if (workStartDate.Text != "")
                    {
                        try
                        {
                            workOrder.workStartDate = Convert.ToDateTime(workStartDate.Text);
                            startDatePicker.Hide();
                            workStartDate.Show();
                            home.dbContext.workOrders.AddOrUpdate(workOrder);
                            home.dbContext.SaveChanges();
                            MessageBox.Show("Saved Successfully", "Saved");
                            this.Close();
                            WorkOrder newWorkOrder = new WorkOrder(workOrder.workOrderID, home);
                            newWorkOrder.Show();

                            saveButton.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Saving the WorkOrder!" + ex, "Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Work Start Date", "Missing Start Date");
                        startDatePicker.Show();
                        workStartDate.Hide();
                    }


                }

                else if (statusBox.Text == "Work Done")
                {
                    if (workDoneDate.Text != "")
                    {
                        if (workDoneType.Enabled == false)
                        {
                            MessageBox.Show("Please Enter Work Done Types", "Missing Data");
                            workDoneType.Enabled = true;
                            workOrderTabs.SelectTab(2);
                            workDoneType.Focus();
                        }
                        else if (workOrderNotes.Text == "")
                        {
                            MessageBox.Show("Please Enter Work Done", "Missing Data");
                            workOrderNotes.Focus();
                        }
                        else
                        {
                            try
                            {
                                workOrder.workStartDate = Convert.ToDateTime(workStartDate.Text);

                                workOrder.workDoneDate = Convert.ToDateTime(workDoneDate.Text);
                                MessageBox.Show(workDoneDate.Text);
                                startDatePicker.Hide();
                                workStartDate.Show();
                                doneDatePicker.Hide();
                                workDoneDate.Show();
                                workDoneType.Enabled = false;
                                workOrderNotes.Enabled = false;
                                workOrder.workDoneType1 = (workDoneType)workDoneType.SelectedItem;
                                home.dbContext.workOrders.AddOrUpdate(workOrder);
                                home.dbContext.SaveChanges();
                                MessageBox.Show("Saved Successfully", "Saved");
                                this.Close();
                                WorkOrder newWorkOrder = new WorkOrder(workOrder.workOrderID, home);
                                newWorkOrder.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error Saving the WorkOrder!" + ex, "Error!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Done Date", "Missing Done Date");
                        doneDatePicker.Show();
                        workDoneDate.Hide();
                    }


                }

                else if (statusBox.Text == "Finished")
                {
                    if (workOrderFinishDate.Text != "")
                    {
                        try
                        {
                            workOrder.workStartDate = Convert.ToDateTime(workStartDate.Text);
                            workOrder.workDoneDate = Convert.ToDateTime(workDoneDate.Text);
                            workOrder.workOrderFinishDate = Convert.ToDateTime(workOrderFinishDate.Text);
                            workDoneType.Enabled = false;
                            workOrderNotes.Enabled = false;
                            home.dbContext.workOrders.AddOrUpdate(workOrder);
                            home.dbContext.SaveChanges();
                            MessageBox.Show("Saved Successfully", "Saved");
                            this.Close();
                            WorkOrder newWorkOrder = new WorkOrder(workOrder.workOrderID, home);
                            newWorkOrder.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Saving the WorkOrder!" + ex, "Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Finish Date", "Missing Finish Date");
                        finishDatePicker.Show();
                        workOrderFinishDate.Hide();
                    }
                }

                else if (statusBox.Text == "Cancelled")
                {
                    try
                    {
                        workOrder.workStartDate = null;
                        workOrder.workDoneDate = null;
                        workOrder.workOrderFinishDate = null;
                        workOrder.workDoneType = null;
                        home.dbContext.workOrders.AddOrUpdate(workOrder);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Work Order #" + workOrder.workOrderID + " is Cancelled");
                        this.Close();
                        WorkOrder newWorkOrder = new WorkOrder(workOrder.workOrderID, home);
                        newWorkOrder.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Saving the WorkOrder!" + ex, "Error!");
                    }

                }
                else
                {
                    try
                    {
                        workOrder.workStartDate = null;
                        workOrder.workDoneDate = null;
                        workOrder.workOrderFinishDate = null;
                        workOrder.workDoneType = null;
                        home.dbContext.workOrders.AddOrUpdate(workOrder);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Work Order #" + workOrder.workOrderID + " is re-Opened");
                        this.Close();
                        WorkOrder newWorkOrder = new WorkOrder(workOrder.workOrderID, home);
                        newWorkOrder.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Saving the WorkOrder!" + ex, "Error!");
                    }

                }

            }

            //Directive only Changed
            else
            {
                try
                {
                    home.dbContext.SaveChanges();
                    MessageBox.Show("Saved Successfully", "Saving");
                    this.Close();
                    WorkOrder newWorkOrder = new WorkOrder(workOrder.workOrderID, home);
                    newWorkOrder.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Saving Work Order " + ex, "Error");
                }
            }
        }

        private void statusSelected(object sender, EventArgs e)
        {
            var selectedStatus = sender as ToolStripMenuItem;
            statusBox.Text = selectedStatus.Text.Trim();
        }

        private void statusChanged(object sender, EventArgs e)
        {

            if (statusBox.Text != status)
            {
                if (statusBox.Text == "Work Request")
                {
                    workStartDate.Text = "";
                    workDoneDate.Text = "";
                    workOrderFinishDate.Text = "";
                    saveButton.Enabled = true;
                }
                else if (statusBox.Text == "Work Started")
                {

                    MessageBox.Show("Please Enter Starting Date", "Missing Data");
                    startDatePicker.Show();
                    workStartDate.Hide();

                }
                else if (statusBox.Text == "Work Done")
                {
                    if (status == "Work Request")
                    {
                        MessageBox.Show("Enter Starting Date Firstly, then Enter Work Done Date", "Missing Dates");
                        startDatePicker.Show();
                        workStartDate.Hide();
                        doneDatePicker.Show();
                        workDoneDate.Hide();
                    }
                    else if (status == "Work Started")
                    {
                        MessageBox.Show("Please Enter Work Done Date", "Done Date Missing");
                        doneDatePicker.Show();
                        workDoneDate.Hide();
                    }
                }
                else if (statusBox.Text == "Finished")
                {

                    if (materialsGridView.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow issue in materialsGridView.Rows)
                        {
                            if (issue.Cells["issueState"].Value.ToString().Trim() == "Requested")
                            {
                                MessageBox.Show("Can't Finish WorkOrder #" + workOrder.workOrderID + ", Some Materials are Still Reserved", "Reserved Materials");
                                statusBox.Text = status;
                                break;
                            
                            }
                            else
                            {
                                //Got last of List and found no Requested
                                if (issue.Index == materialsGridView.Rows.Count - 1)
                                {
                                    DialogResult closeWorkOrder = MessageBox.Show("You are about to Close the work Order." +
    "Are you sure to Finish the Work Order?", "Finish Work Order", MessageBoxButtons.YesNo);
                                    if (closeWorkOrder == DialogResult.Yes)
                                    {
                                        if (status == "Work Request")
                                        {
                                            MessageBox.Show("Enter Starting Date, Done Date and then Finished Date", "Missing Data");

                                            workStartDate.Focus();
                                            startDatePicker.Show();
                                            workStartDate.Hide();
                                            doneDatePicker.Show();
                                            workDoneDate.Hide();
                                            finishDatePicker.Show();
                                            workOrderFinishDate.Hide();
                                        }
                                        else if (status == "Work Started")
                                        {
                                            MessageBox.Show("Enter Work Done Date firstly", "Missing Data");
                                            doneDatePicker.Show();
                                            workDoneDate.Hide();
                                            finishDatePicker.Show();
                                            workOrderFinishDate.Hide();
                                        }
                                        else if (status == "Work Done")
                                        {
                                            MessageBox.Show("Please Enter Finish Date", "Missing Finish Date");
                                            finishDatePicker.Show();
                                            workOrderFinishDate.Hide();
                                            saveButton.Enabled = true;
                                        }

                                    }
                                }
                            }
                        }
                    }


                    else
                    {
                        statusBox.Text = status;
                    }


                }
                else if (statusBox.Text == "Cancelled")
                {
                    if (home.dbContext.issues.Where(issueList => issueList.workOrder == workOrder.workOrderID).Count() == 0)
                    {
                        DialogResult cancelWorkOrder = MessageBox.Show(" You are about to Cancel the work Order." +
        "Are you sure to Cancel the Work Order?", "Cancelled Work Order", MessageBoxButtons.YesNo);
                        if (cancelWorkOrder == DialogResult.Yes)
                        {
                            saveButton.Enabled = true;
                            saveButton_Click(sender, e);
                        }
                        else
                        {
                            statusBox.Text = status;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Can't Cancel Work Order #" + workOrder.workOrderID + " , some materials are issued on.");
                        statusBox.Text = status;
                    }
                }
            }
        }

        private void statusContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (workOrder.workOrderStatusID.Trim() == "Cancelled")
            {
                statusContextMenuStrip.Items["workRequest"].Enabled = false;
                statusContextMenuStrip.Items["workStarted"].Enabled = false;
                statusContextMenuStrip.Items["workDone"].Enabled = false;
                statusContextMenuStrip.Items["finished"].Enabled = false;
                statusContextMenuStrip.Items["cancelled"].Enabled = false;
            }
            else
            {

                //Ordinary Users Privilages//
                if (home.user.userLevel.Trim() != "Head")
                {
                    statusContextMenuStrip.Items["finished"].Enabled = false;
                    statusContextMenuStrip.Items["workRequest"].Enabled = false;
                    if (workOrder.workOrderStatusID.Trim() == "Work Done" || workOrder.workOrderStatusID.Trim() == "Finished")
                    {
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                        statusContextMenuStrip.Items["workDone"].Enabled = false;
                        statusContextMenuStrip.Items["cancelled"].Enabled = false;
                    }
                    else if (workOrder.workOrderStatusID.Trim() == "Work Started")
                    {
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                    }
                }
                //Super User Privilages//
                else
                {
                    if (workOrder.workOrderStatusID.Trim() == "Work Request")
                    {
                        statusContextMenuStrip.Items["workRequest"].Enabled = false;
                    }
                    else if (workOrder.workOrderStatusID.Trim() == "Work Started" || workOrder.workOrderStatusID.Trim() == "Work Done")
                    {
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                        statusContextMenuStrip.Items["workDone"].Enabled = false;
                    }
                    else if (workOrder.workOrderStatusID.Trim() == "Finished")
                    {
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                        statusContextMenuStrip.Items["workDone"].Enabled = false;
                        statusContextMenuStrip.Items["finished"].Enabled = false;
                        statusContextMenuStrip.Items["cancelled"].Enabled = false;
                    }

                }
            }

        }

        private void workOrderNotes_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }


        #endregion

        //========================================================//

        #region Attachments
        private void pmChecklist_Button(object sender, EventArgs e)
        {
            string filePath = @"D:\" + workOrder.workOrderEquipmentID.Trim() + " - WO#" + workOrder.workOrderID + " - " + workOrder.workOrderDirective + " Attachment.pdf";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            var fileWriter = new BinaryWriter(File.OpenWrite(filePath));
            var data = (byte[])workOrder.workOrderAttach;

            if (data == null)
            {
                MessageBox.Show("Empty File");
            }
            else
            {
                fileWriter.Write(data);
                fileWriter.Close();
                Process.Start(filePath);
            }
        }

        #endregion
    }
}