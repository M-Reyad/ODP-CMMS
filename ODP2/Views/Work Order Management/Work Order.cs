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
using MenuItem = System.Windows.Forms.MenuItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using System.ComponentModel;

namespace ODP2.Views
{
    public partial class WorkOrder : Form
    {
        public WORKORDER workOrder = new WORKORDER();
        public Home home = new Home();
        public string status;
        public string notes;
        private ODPEntities_ORACLE dbContext = new ODPEntities_ORACLE();
        public WorkOrder(int workOrderNumber, Home home)
        {
                this.home = home;
                var availableWorkOrders = dbContext.WORKORDERs.Where(workOrder => workOrder.WORKORDERID == workOrderNumber);
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
            status = workOrder.WORKORDERSTATUSID.Trim();
            wORKORDERBindingSource.DataSource = workOrder;
            Text += workOrder.WORKORDERID.ToString();
            configIssuesView();
            configBDNView();
            configWorkDoneStatus();
            configStatus();
            configWorkOrderTime();
            configAttachmentButton();
            saveButton.Enabled = false;
            configDateTimePickers();
        }

        #region Materials

        private void partCodeTextBox_Validated(object sender, EventArgs e)
        {
            if (partCodeTextBox.Text != "")
            {
                if (dbContext.SPAREPARTs.Where(sp => sp.PARTCODE.Trim() == partCodeTextBox.Text).Count() != 0)
                {
                    partDirectiveTextBox.Text = dbContext.SPAREPARTs.Where(sp => sp.PARTCODE.Trim() == partCodeTextBox.Text).First().PARTDIRECTIVE.Trim();
                    requestButton.Enabled = true;
                    quantityTextBox.Focus();

                }
                else
                {
                    MessageBox.Show("Please Enter a valid Part Code", "Invaild Part Code");
                }

            }
            else
            {
                partDirectiveTextBox.Text = "";
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
        private void requestButton_Click(object sender, EventArgs e)
        {

            int requestedQty;
            if (int.TryParse(quantityTextBox.Text, out requestedQty) && quantityTextBox.Text != "")
            {

                try
                {


                        ISSUE newIssueRequest = new ISSUE();
                        newIssueRequest.SPAREPARTCODE = partCodeTextBox.Text;
                        newIssueRequest.SPAREPART = dbContext.SPAREPARTs.Where(part => part.PARTCODE.Trim() == newIssueRequest.SPAREPARTCODE.Trim()).First();
                        var availableQty = dbContext.SPAREPARTs.Where(part => part.PARTCODE.Trim() == newIssueRequest.SPAREPARTCODE.Trim()).First().AVAILABLESTOCK;
                        if (requestedQty < 0)
                        {
                            MessageBox.Show("Please Enter Valid Quantity");
                            quantityTextBox.Focus();
                            return;
                        }

                        else if (requestedQty > availableQty && availableQty != 0)
                        {
                            DialogResult issueAvQtyOnly = MessageBox.Show("Available Stock is less than the requested Quantity!\n" +
                                "Only " + availableQty + " will be requested", "Un-sufficient Quantity");
                            if (issueAvQtyOnly == DialogResult.Yes)
                            {
                                newIssueRequest.QTY = (int)availableQty;
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
                        else
                        {
                            newIssueRequest.QTY = requestedQty;
                        }
                        newIssueRequest.WORKORDER1 = workOrder;
                        newIssueRequest.REQUESTDATE = DateTime.Today;
                        newIssueRequest.PARTPRICE = newIssueRequest.SPAREPART.PARTPRICE;
                        newIssueRequest.ISSUESTATE = "Requested";
                    newIssueRequest.REQUESTERID = home.user.USERID;
                        var sparePart = dbContext.SPAREPARTs.Where(sp => sp.PARTCODE.Trim() == newIssueRequest.SPAREPARTCODE).First();
                        sparePart.RESERVEDSTOCK += newIssueRequest.QTY;
                        dbContext.SPAREPARTs.AddOrUpdate(sparePart);
                        dbContext.ISSUEs.Add(newIssueRequest);
                        dbContext.SaveChanges();
                        MessageBox.Show("Successfully requested " + newIssueRequest.QTY + " * " + newIssueRequest.SPAREPARTCODE);
                        configIssuesView();
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding Issue" + ex.Message, "Error");
                }
            

            }
            else
            {
                MessageBox.Show("Please Enter a valid Quantity", "Invalid Quantity");
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
                        var releasedIssue = dbContext.ISSUEs.Where(iss => iss.ISSUEID == issueNumber).First();
                        var sparePart = dbContext.SPAREPARTs.Where(sp => sp.PARTCODE.Trim() == releasedIssue.SPAREPARTCODE.Trim()).First();
                        sparePart.RESERVEDSTOCK -= releasedIssue.QTY;
                        dbContext.SPAREPARTs.AddOrUpdate(sparePart);
                        dbContext.ISSUEs.Remove(releasedIssue);
                        dbContext.SaveChanges();
                        MessageBox.Show("Released Successfully");
                        this.Close();
                        WorkOrder newWorkOrder = new WorkOrder(workOrder.WORKORDERID, home);
                        newWorkOrder.Show();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Releasing Request #" + materialsGridView.SelectedRows[0].Cells["issueID"] + ex.Message);
                }

            }



        }
        private void materialsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (materialsGridView.Columns[e.ColumnIndex].Name == "ISSUESTATE")
            {


                if (e.Value.ToString().Trim() == "Requested")
                {
                    materialsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (e.Value.ToString().Trim() == "Unissued")
                {
                    materialsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    materialsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = default;
                }
            }
        }
        #endregion

        #region Status
        private void statusSelected(object sender, EventArgs e)
        {
            if (sender == statusContextMenuStrip.Items["workRequest"])
            {
                //statusBox.Text = "Work Request";
            }
            else if (sender == statusContextMenuStrip.Items["workStarted"])
            {
                if (status != "Work Started")
                {
                    statusBox.Text = "Work Started";
                    MessageBox.Show("Please Enter Starting Date", "Mandatory Data");
                    startDatePicker.Enabled = true;
                    startDatePicker.Show();
                    workStartDate.Hide();
                }
            }
            else if (sender == statusContextMenuStrip.Items["workDone"])
            {
                if (status != "Work Done")
                {
                    statusBox.Text = "Work Done";
                    if (status == "Work Request")
                    {
                        startDatePicker.Show();
                        startDatePicker.Enabled = true;
                        workStartDate.Hide();
                        doneDatePicker.Show();
                        doneDatePicker.Enabled = true;
                        workDoneDate.Hide();
                        selectDoneType();
                    }
                    else if (status == "Work Started")
                    {
                        doneDatePicker.Show();
                        doneDatePicker.Enabled = true;
                        workDoneDate.Hide();
                        selectDoneType();
                    }
                    else if (status == "Finished")
                    {
                        DialogResult reopenedWO = MessageBox.Show("You are about to re-Open the WorkOrder, \n Re-Open the WorkOrder?", "Re-Open WorkOrder", MessageBoxButtons.YesNo);
                        if (reopenedWO == DialogResult.Yes)
                        {
                            saveButton.Enabled = true;
                        }
                    }
                }
            }
            else if (sender == statusContextMenuStrip.Items["Finished"])
            {
                statusBox.Text = "Finished";
                if (checkForOpenBDNs())
                {
                    MessageBox.Show("Can't Finish WorkOrder #" + workOrder.WORKORDERID + ".\n Some BDNs are Still Opened, Please close these BDNs.", "Opened BDN");
                    statusBox.Text = status;
                }
                else if (checkForRequestedMaterial())
                {
                    MessageBox.Show("Can't Finish WorkOrder #" + workOrder.WORKORDERID + ".\nSome Materials are Still Reserved", "Reserved Materials");
                    statusBox.Text = status;
                }
                else if (checkForRecordedBDNs())
                {
                    MessageBox.Show("Can't Finish WorkOrder #" + workOrder.WORKORDERID + ",No Down Time recorded on.", "No Down Time");
                    statusBox.Text = status;
                }
                else
                {
                    DialogResult closeWorkOrder = MessageBox.Show("You are about to Close the work Order.\n" +
    "Are you sure to Finish the Work Order?", "Finish Work Order", MessageBoxButtons.YesNo);
                    if (closeWorkOrder == DialogResult.Yes)
                    {
                        if (status == "Work Request")
                        {
                            MessageBox.Show("Enter Starting Date, Done Date and then Finished Date", "Required Data");
                            workStartDate.Focus();
                            startDatePicker.Show();
                            startDatePicker.Enabled = true;
                            workStartDate.Hide();
                            doneDatePicker.Show();
                            doneDatePicker.Enabled = true;
                            workDoneDate.Hide();
                            finishDatePicker.Show();
                            finishDatePicker.Enabled = true;
                            workOrderFinishDate.Hide();
                        }
                        else if (status == "Work Started")
                        {
                            MessageBox.Show("Enter Work Done Date firstly", "Required Data");
                            doneDatePicker.Show();
                            doneDatePicker.Enabled = true;
                            workDoneDate.Hide();
                            finishDatePicker.Show();
                            finishDatePicker.Enabled = true;
                            workOrderFinishDate.Hide();
                        }
                        else if (status == "Work Done")
                        {
                            MessageBox.Show("Please Enter Finish Date", "Required Data");
                            finishDatePicker.Show();
                            finishDatePicker.Enabled = true;
                            workOrderFinishDate.Hide();
                            //saveButton.Enabled = true;
                        }

                    }
                    else
                    {
                        statusBox.Text = status;
                        saveButton.Enabled = false;
                    }
                }
                
            }
            else if (sender == statusContextMenuStrip.Items["Cancelled"])
            {
                if (status != "Cancelled")
                {
                    statusBox.Text = "Cancelled";
                    if (dbContext.ISSUEs.Where(issueList => issueList.WORKORDER == workOrder.WORKORDERID).Count() != 0)
                    {
                        MessageBox.Show("Can't Cancel Work Order #" + workOrder.WORKORDERID + " , some materials are issued on.");
                        statusBox.Text = status;

                    }
                    else if (dbContext.BREAKDOWNs.Where(bdn => bdn.WORKORDER == workOrder.WORKORDERID).Count() != 0)
                    {
                        MessageBox.Show("Can't Cancel Work Order #" + workOrder.WORKORDERID + " , some BDNs are registered on.");
                        statusBox.Text = status;
                    }
                    else
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
                }
            }
            saveButton.Enabled = true;
        }
        private void workOrderAttributeChanged(object sender, EventArgs e)
        { 
            if (sender == workOrderNotes)
            {
                if (workOrderNotes.Text != notes)
                {
                    saveButton.Enabled = true;
                }
            }
            else
            {
                saveButton.Enabled = true;
            }

        }
        private void doneDatePicker_Validated(object sender, EventArgs e)
        {
            if (doneDatePicker.Value < startDatePicker.Value)
            {
                MessageBox.Show("Work Done Date Can't be before Work Start Date");
                doneDatePicker.Focus();
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (statusBox.Text != status)
            {
                if (statusBox.Text == "Work Started")
                {

                    try
                    {
                        workOrder.WORKSTARTDATE = startDatePicker.Value;
                        startDatePicker.Hide();
                        workStartDate.Show();
                        updateWorkOrder();
                        MessageBox.Show("Saved Successfully", "Saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Saving the WorkOrder!" + ex.Message, "Error!");
                    }


                }
                else if (statusBox.Text == "Work Done")
                {
                    if (status.Trim() != "Finished")
                    {
                       if (workOrderNotes.Text == "")
                        {
                            MessageBox.Show("Please Enter Work Done", "Missing Data");
                            workOrderNotes.Focus();
                        }
                        else
                        {
                            try
                            {
                                workOrder.WORKSTARTDATE = startDatePicker.Value;
                                workOrder.WORKDONEDATE = doneDatePicker.Value;
                                startDatePicker.Hide();
                                workStartDate.Show();
                                doneDatePicker.Hide();
                                workDoneDate.Show();
                                workDoneType.Enabled = false;
                                //workOrderNotes.Enabled = false;
                                workOrder.WORKDONETYPE1 = (WORKDONETYPE)workDoneType.SelectedItem;
                                if (dbContext.BREAKDOWNs.Where(bdn => bdn.WORKORDER == workOrder.WORKORDERID).Count() == 0)
                                {
                                    DialogResult insertBDN = MessageBox.Show("Do you want to record the Job Hours into the Breakdown? ", "Breakdown Recording", MessageBoxButtons.YesNo);
                                    if (insertBDN == DialogResult.Yes)
                                    {
                                        BREAKDOWN workOrderBDN = new BREAKDOWN();
                                        workOrderBDN.EQUIPMENTID = workOrder.WORKORDEREQUIPMENTID;
                                        workOrderBDN.FROMTIME = workOrder.WORKSTARTDATE;
                                        workOrderBDN.TOTIME = workOrder.WORKDONEDATE;
                                        workOrderBDN.WORKORDER = workOrder.WORKORDERID;
                                        workOrderBDN.BDNREASON = workOrder.WORKORDERTYPEID.Trim() + " - " + workOrder.WORKORDERDIRECTIVE.Trim();
                                        dbContext.BREAKDOWNs.Add(workOrderBDN);
                                    }
                                }
                                updateWorkOrder();
                                MessageBox.Show("Saved Successfully", "Saved");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error Saving the WorkOrder!" + ex.Message, "Error!");
                            }
                        }
                    }
                    else
                    {
                        updateWorkOrder();
                        MessageBox.Show("Work Order is re-Opened");
                    }
                }
                else if (statusBox.Text == "Finished")
                {

                    try
                    {
                        workOrder.WORKSTARTDATE = startDatePicker.Value;
                        workOrder.WORKDONEDATE = doneDatePicker.Value;
                        workOrder.WORKORDERFINISHDATE = finishDatePicker.Value;
                        workDoneType.Enabled = false;
                        workOrderNotes.Enabled = false;
                        updateWorkOrder();
                        MessageBox.Show("Saved Successfully", "Saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Saving the WorkOrder!" + ex.Message, "Error!");
                    }
                }
                else if (statusBox.Text == "Cancelled")
                {
                    try
                    {
                        workOrder.WORKSTARTDATE = null;
                        workOrder.WORKDONEDATE = null;
                        workOrder.WORKORDERFINISHDATE = null;
                        workOrder.WORKDONETYPE = null;
                        updateWorkOrder();
                        MessageBox.Show("Saved Successfully", "Saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Saving the WorkOrder!" + ex.Message, "Error!");
                    }

                }
                else
                {
                    try
                    {
                        workOrder.WORKSTARTDATE = null;
                        workOrder.WORKDONEDATE = null;
                        workOrder.WORKORDERFINISHDATE = null;
                        workOrder.WORKDONETYPE = null;
                        updateWorkOrder();
                        MessageBox.Show("Saved Successfully", "Saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Saving the WorkOrder!" + ex.Message, "Error!");
                    }

                }

            }

            //Directive Changed or Work Order Comments addad
            else
            {
                try
                {
                    updateWorkOrder();
                    MessageBox.Show("Saved Successfully", "Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Saving Work Order " + ex.Message, "Error");
                }
            }
        }
        private void workDoneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workDoneType.SelectedIndex >= 0)
            {
                var selectedDoneType = workDoneType.GetItemText(workDoneType.SelectedItem).Trim();
                if (dbContext.WORKDONETYPES.Where(type => type.WORKDONETYPEID.Trim() == selectedDoneType).Count() != 0)
                {


                    workDoneTypeDirectiveLabel.Text = dbContext.WORKDONETYPES.Where(type => type.WORKDONETYPEID.Trim() == selectedDoneType).First().WORKDONETYPEDIRECTIVE.Trim();
                }
            }
        }
        #endregion

        #region Attachments
        private void pmChecklist_Button(object sender, EventArgs e)
        {
            string filePath = @"D:\" + workOrder.WORKORDEREQUIPMENTID.Trim() + " - WO#" + workOrder.WORKORDERID + " - " + workOrder.WORKORDERDIRECTIVE + " Attachment.pdf";

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            var fileWriter = new BinaryWriter(File.OpenWrite(filePath));
            var data = (byte[])workOrder.WORKORDERATTACH;

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

        #region BreakDown Registeration
        private void startBDNButton_Click(object sender, EventArgs e)
        {
            try
            {
                    BREAKDOWN newBDN = new BREAKDOWN();
                    newBDN.WORKORDER = workOrder.WORKORDERID;
                    newBDN.EQUIPMENTID = workOrder.WORKORDEREQUIPMENTID;
                    newBDN.FROMTIME = bdnFromDateTimePicker.Value;
                    dbContext.BREAKDOWNs.Add(newBDN);
                    dbContext.SaveChanges();
                    MessageBox.Show("BreakDown #" + newBDN.BREAKDOWNID + " is Started");
                    configBDNView();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Opening BDN!" + ex.Message);
            }
            
        }
        private void bdnGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (bdnGridView.SelectedRows.Count > 0)
            {
                if (bdnGridView.SelectedRows[0].Cells["BDNTOTIME"].Value == null)
                {
                    startBDNButton.Enabled = false;
                    bdnFromDateTimePicker.Enabled = false;
                    endBDNbutton.Enabled = true;
                    bdnToDateTimePicker.Enabled = true;
                    BDNReasonTextBox.Enabled = true;
                }
                else
                {


                    endBDNbutton.Enabled = false;
                    bdnToDateTimePicker.Enabled = false;
                    BDNReasonTextBox.Enabled = false;
                    startBDNButton.Enabled = true;
                    bdnFromDateTimePicker.Enabled = true;
                }
            }
        }
        private void endBDNbutton_Click(object sender, EventArgs e)
        {
            int bdnID = (int)bdnGridView.SelectedRows[0].Cells[0].Value;
            BREAKDOWN closedBDN = dbContext.BREAKDOWNs.Where(bdn => bdn.BREAKDOWNID == bdnID).First();

            if (BDNReasonTextBox.Text == "")
            {
                MessageBox.Show("Please Insert BDN Reason to End the BDN");
            }
            else if (bdnToDateTimePicker.Value < closedBDN.FROMTIME || bdnToDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Please Enter a valid End Time after Start Time");
            }
            else
            {

                try
                {
                        closedBDN.TOTIME = bdnToDateTimePicker.Value;
                        closedBDN.BDNREASON = BDNReasonTextBox.Text;
                        dbContext.BREAKDOWNs.AddOrUpdate(closedBDN);
                        dbContext.SaveChanges();
                        MessageBox.Show("BDN #" + bdnGridView.SelectedRows[0].Cells[0].Value + " is Closed successfully");
                        configBDNView();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Closing BDN #" + bdnGridView.SelectedRows[0].Cells[0].Value + " " + ex.Message);
                }
            }
        }
        private void bdnGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Formating BDN Total Time to be in TimeSpan//
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null)
                {
                    var doubleBDNTime = decimal.ToDouble((decimal)e.Value);
                    e.Value = TimeSpan.FromSeconds(doubleBDNTime).ToString();
                }
            }

            //Formating Row Color
            if (bdnGridView.Columns[e.ColumnIndex].Name == "BDNTOTIME")
            {
                if( e.Value == null)
                {
                    bdnGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    bdnGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = default;
                }
            }

        }
        #endregion

        #region Functions
        private void configIssuesView()


        {
            var issueList =
        dbContext.ISSUEs.Where(issue => issue.WORKORDER1.WORKORDERID == workOrder.WORKORDERID)
        .Join
        (dbContext.SPAREPARTs,
        issue => issue.SPAREPARTCODE.Trim(),
        part => part.PARTCODE.Trim(),
        (issue, part) => new
        {
            issue.ISSUEID,
            issue.QTY,
            part.UOM,
            issue.SPAREPARTCODE,
            part.PARTDIRECTIVE,
            part.PARTPRICE,
            issue.TOTALPRICE,
            issue.ISSUEDATE,
            issue.ISSUESTATE,
            issue.REQUESTDATE,
            issuer = issue.ODP_USER.USERNAME,
            requester = issue.ODP_USER1.USERNAME

        })
        .ToList();


            iSSUEBindingSource.DataSource = issueList;
            var totalCost = issueList.Sum(issue => issue.TOTALPRICE);
            totalCostTextbox.Text = totalCost.ToString();
        }
        private void configBDNView()
        {
            var bdnList = dbContext.BREAKDOWNs.Where(bdn => bdn.WORKORDER == workOrder.WORKORDERID).OrderByDescending(bdn => bdn.BREAKDOWNID).ToList();
            bREAKDOWNBindingSource.DataSource = bdnList;
            var totalBDNDuration = bdnList.Sum(bdn => bdn.BDNTOTALTIME);
            if (totalBDNDuration != null)
            {
                bdnHoursTextbox.Text = TimeSpan.FromSeconds((double)totalBDNDuration).ToString();
            }
            else
            {
                bdnHoursTextbox.Text = "---";
            }
        }
        private void configWorkDoneStatus()
        {
            if (workOrder.WORKORDERSTATUSID.Trim() == "Finished")
            {
                partCodeTextBox.Enabled = false;
                quantityTextBox.Enabled = false;
                startBDNButton.Enabled = false;
                workDoneType.Enabled = false;
                workOrderNotes.Enabled = false;
                registerationDate.Enabled = false;
                workOrderDirective.Enabled = false;
            }
            else
            {
                partCodeTextBox.Enabled = true;
                quantityTextBox.Enabled = true;
                startBDNButton.Enabled = true;
                workOrderNotes.Enabled = true;
                registerationDate.Enabled = true;
                workOrderDirective.Enabled = true;

                if (workOrder.WORKDONETYPE == null)
                {
                    workDoneType.Enabled = false;
                }
                else
                {
                    wORKDONETYPEBindingSource.DataSource = dbContext.WORKDONETYPES.ToList();
                    workDoneType.SelectedItem = workOrder.WORKDONETYPE1;
                    workDoneTypeDirectiveLabel.Text = workOrder.WORKDONETYPE1.WORKDONETYPEDIRECTIVE;
                }
            }

            //workOrderNotes.DataBindings.Add(Text, workOrder, workOrder.WORKORDERNOTES);
        }
        private void configStatus()
        {
            //Reset All Context Items
            //statusBindingSource.DataSource = workOrder.WORKORDERSTATU;
            statusBox.Text = workOrder.WORKORDERSTATUSID.Trim();
            status = workOrder.WORKORDERSTATUSID.Trim();
            notes = workOrder.WORKORDERNOTES != null ? workOrder.WORKORDERNOTES.Trim() : "";

            //Disable all Date Pickers
            registerationDatePicker.Enabled = false;
            startDatePicker.Enabled = false;
            doneDatePicker.Enabled = false;
            finishDatePicker.Enabled = false;

            //Enable all WO Status
            statusContextMenuStrip.Items["workRequest"].Enabled = false;
            statusContextMenuStrip.Items["workStarted"].Enabled = true;
            statusContextMenuStrip.Items["workDone"].Enabled = true;
            statusContextMenuStrip.Items["finished"].Enabled = true;
            statusContextMenuStrip.Items["cancelled"].Enabled = true;

            //Cancelled WOs can't be Active again
            if (workOrder.WORKORDERSTATUSID.Trim() == "Cancelled")
            {
                workOrderDirective.Enabled = false;
                registerationDate.ReadOnly = true;
                statusContextMenuStrip.Items["workRequest"].Enabled = false;
                statusContextMenuStrip.Items["workStarted"].Enabled = false;
                statusContextMenuStrip.Items["workDone"].Enabled = false;
                statusContextMenuStrip.Items["finished"].Enabled = false;
                statusContextMenuStrip.Items["cancelled"].Enabled = false;
            }

            //WO Status Privilages
            else
            {

                //Ordinary Users Privilages//
                if (home.user.USERLEVEL.Trim() != "Head")
                {
                    statusContextMenuStrip.Items["finished"].Enabled = false;
                    statusContextMenuStrip.Items["workRequest"].Enabled = false;
                    if (workOrder.WORKORDERSTATUSID.Trim() == "Work Done" || workOrder.WORKORDERSTATUSID.Trim() == "Finished")
                    {
                        workOrderNotes.ReadOnly = true;
                        workDoneType.Enabled = false;
                        workOrderDirective.Enabled = false;
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                        statusContextMenuStrip.Items["workDone"].Enabled = false;
                        statusContextMenuStrip.Items["cancelled"].Enabled = false;
                    }
                    else if (workOrder.WORKORDERSTATUSID.Trim() == "Work Started")
                    {
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                    }
                }

                //Super User Privilages//
                else
                {
                    registerationDate.ReadOnly = false;
                    if (workOrder.WORKORDERSTATUSID.Trim() == "Work Request")
                    {
                        statusContextMenuStrip.Items["workRequest"].Enabled = false;
                    }
                    else if (workOrder.WORKORDERSTATUSID.Trim() == "Work Started")
                    {
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                    }
                    else if (workOrder.WORKORDERSTATUSID.Trim() == "Work Done")
                    {
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                        statusContextMenuStrip.Items["workDone"].Enabled = false;
                    }
                    else if (workOrder.WORKORDERSTATUSID.Trim() == "Finished")
                    {
                        statusContextMenuStrip.Items["workStarted"].Enabled = false;
                        statusContextMenuStrip.Items["workRequest"].Enabled = false;
                        statusContextMenuStrip.Items["finished"].Enabled = false;
                        statusContextMenuStrip.Items["cancelled"].Enabled = false;
                        statusContextMenuStrip.Items["workDone"].Enabled = true;
                    }

                }
            }

        }
        private bool checkForRequestedMaterial()
        {
            foreach (DataGridViewRow issue in materialsGridView.Rows)
            {
                if (issue.Cells["ISSUESTATE"].Value.ToString().Trim() == "Requested")
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkForOpenBDNs()
        {
            foreach (DataGridViewRow bdn in bdnGridView.Rows)
            {
                if (bdn.Cells["bdnToTime"].Value == null)
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkForRecordedBDNs()
        {
            if (bdnGridView.Rows.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void configWorkOrderTime()
        {
            if(workOrder.WORKORDERREGISTERATIONDATE != null)
            {
                registerationDate.Text = workOrder.WORKORDERREGISTERATIONDATE.ToString().Trim();
            }
            if (workOrder.WORKSTARTDATE != null)
            {
                workStartDate.Text = workOrder.WORKSTARTDATE.ToString().Trim();
            }
            if (workOrder.WORKDONEDATE != null)
            {
                workDoneDate.Text = workOrder.WORKDONEDATE.ToString().Trim();
            }
            if (workOrder.WORKORDERFINISHDATE != null)
            {
                workOrderFinishDate.Text = workOrder.WORKORDERFINISHDATE.ToString().Trim();
            }
        }
        private void updateWorkOrder()
        {
                    workOrder.WORKORDERSTATUSID = statusBox.Text;
                    dbContext.WORKORDERs.AddOrUpdate(workOrder);
                    dbContext.SaveChanges();
                    configStatus();
                    configBDNView();
                    configIssuesView();
                    configWorkOrderTime();
                    saveButton.Enabled = false;
        }
        private void materialsGridView_Leave(object sender, EventArgs e)
        {
            materialsGridView.ClearSelection();
        }
        private void bdnGridView_Leave(object sender, EventArgs e)
        {
            bdnGridView.ClearSelection();
        }
        private void WorkOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveButton.Enabled == true)
            {
                if (MessageBox.Show("You didn't Save the Changes\nWould you like to Save Changes?","Saving", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = true;
                    updateWorkOrder();
                    MessageBox.Show("Saved Successfully");
                }   
            }
        }
        private void configAttachmentButton()
        {
            if (workOrder.WORKORDERATTACH == null)
            {
                pmCheclistButton.Enabled = false;
            }
            else
            {
                pmCheclistButton.Enabled = true;
            }
        }
        private void configDateTimePickers()
        {
            startDatePicker.Value = workOrder.WORKSTARTDATE != null ? Convert.ToDateTime(workStartDate.Text.Trim()) : DateTime.Now;
            doneDatePicker.Value = workOrder.WORKDONEDATE != null ? Convert.ToDateTime(workDoneDate.Text.Trim()) : DateTime.Now;
            finishDatePicker.Value = workOrder.WORKORDERFINISHDATE != null ? Convert.ToDateTime(workOrderFinishDate.Text.Trim()) : DateTime.Now;
        }
        private void selectDoneType()
        {
            wORKDONETYPEBindingSource.DataSource = dbContext.WORKDONETYPES.ToList();
            workDoneType.Enabled = true;
            workOrderTabs.SelectedTab = stepsAndNotesTab;
            workDoneType.DroppedDown = true;
        }
        #endregion


    }
}