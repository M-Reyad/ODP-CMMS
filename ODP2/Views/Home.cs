using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ODP2.Models;
using ODP2.Views;
using ODP2.Views.Equipment_Management;
using ODP2.Views.Inventory_Spare_Parts_Management;
using ODP2.Views.Stores_Management;

namespace ODP2
{
    public partial class Home : Form
    {
        public ODPEntities_ORACLE dbContext;
        //public ODPEntites_ORACLE dbContext_SW;
        public ODP_USER user = new ODP_USER();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            customizngUserPanel();
            customizeUserPrivilage();
            homeButton_Click(this,e);

        }
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordPage = new ChangePassword();
            changePasswordPage.userID = user.USERID.Trim();
            changePasswordPage.Show();
        }
        private void changeUserPicture(object sender, EventArgs e)
        {
            OpenFileDialog attachPicture = new OpenFileDialog();
            if (attachPicture.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    userPicture.Image = Image.FromFile(attachPicture.FileName);
                    dbContext.ODP_USER.Where(ODPuser => ODPuser.USERID == user.USERID).First().USERIMAGE = (byte[])new ImageConverter().ConvertTo(userPicture.Image, typeof(byte[]));
                    dbContext.SaveChanges();
                    MessageBox.Show("Image Saved Successfully", "Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Saving Image " + ex.Message, "Error");
                }
            }
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            homeMainPanel.Controls.Add(userPanel);
            windowLabel.Text = "Home";
        }
        private void activeWorkOrders_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            var activeWorkOrder = new ActiveWorkOrders();
            activeWorkOrder.home = this;
            activeWorkOrder.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(activeWorkOrder);
            windowLabel.Text = "Active Work Orders";
        }
        private void closedWorkOrders_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            var closedWorkOrder = new ClosedWorkOrders();
            closedWorkOrder.home = this;
            closedWorkOrder.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(closedWorkOrder);
            windowLabel.Text = "Historical Work Orders";
        }
        private void createWorkOrder_Click(object sender, EventArgs e)
        {
            var newWorkOrder = new CreateNewWorkOrder();
            newWorkOrder.home = this;
            newWorkOrder.Show();
            
        }
        private void inventorySpareParts_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            var inventorySparePart = new InventorySpareParts();
            inventorySparePart.home = this;
            inventorySparePart.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(inventorySparePart);
            windowLabel.Text = "Inventory Spare Parts";
        }
        private void equipmentRunningHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            EquipmentRunningHours equipmentRunningHoursRegisteration = new EquipmentRunningHours();
            equipmentRunningHoursRegisteration.home = this;
            equipmentRunningHoursRegisteration.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(equipmentRunningHoursRegisteration);
            windowLabel.Text = "EQUIPMENT Running Hours";
        }
        private void fuelStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            FuelStation fuelStatiopn = new FuelStation();
            fuelStatiopn.home = this;
            fuelStatiopn.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(fuelStatiopn);
            windowLabel.Text = "Fuel Station";
        }
        private void breakDowns_Click(object sender, EventArgs e)
        {

        }
        private void issuePartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            IssueSparePart newIssue = new IssueSparePart();
            newIssue.home = this;
            newIssue.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(newIssue);
            windowLabel.Text = "Issue Spare Parts";
        }
        private void maintenanceMaterialInquiry_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            MaintenanceMaterialInquiry newMaintenanceMaterialInquiry = new MaintenanceMaterialInquiry();
            newMaintenanceMaterialInquiry.home = this;
            newMaintenanceMaterialInquiry.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(newMaintenanceMaterialInquiry);
            windowLabel.Text = "Maintenance Material";
        }
        private void pmGeneration_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            PMGeneration generatePM = new PMGeneration();
            generatePM.home = this;
            generatePM.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(generatePM);
            windowLabel.Text = "PM Generation";
        }
        private void pMAttachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            PMAttachments attachNewPM = new PMAttachments();
            attachNewPM.home = this;
            attachNewPM.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(attachNewPM);
            windowLabel.Text = "PM Attachments";
        }
        private void kPIsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KPIsReports newKPIsReports = new KPIsReports();
            newKPIsReports.home = this;
            newKPIsReports.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Clear();
            homeMainPanel.Controls.Add(newKPIsReports);
            windowLabel.Text = "KPIs Reports";
        }
        private void assetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssetsInformation newAssetsView = new AssetsInformation();
            newAssetsView.home = this;
            newAssetsView.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Clear();
            homeMainPanel.Controls.Add(newAssetsView);
            windowLabel.Text = "Equipment Management";
        }
        private void oPEXToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login newLoginPage = new Login();
            newLoginPage.Show();
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closingHome = MessageBox.Show(
                "You are signing out of the CMMS.\n Are you sure to Sign-Out?"
                , "Exit", 
                MessageBoxButtons.YesNo);
            if (closingHome == DialogResult.Yes)
            {
                logOutButton_Click(sender, e);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void customizngUserPanel()
        {
            userNameLabel.Text = user.USERNAME;
            userTitleLabel.Text = user.USERTITLE;
            userIDNumber.Text = user.USERIDNUMBER.ToString();
            try
            {
                userPicture.Image = Image.FromStream(new MemoryStream(user.USERIMAGE));
            }
            catch (Exception)
            {
                //MessageBox.Show("Cann't Load User Image " + ex);

            }
        }
        private void customizeUserPrivilage()
        {
            if (user.USERLEVEL.Trim() != "Head")
            {
                //Head Only 
                reportsTab.Enabled = false;

                //Stores Users Only 
                if (user.USERSECTION.Trim() != "Stores")
                {
                    StoresTab.Enabled = false;

                }

                //Maintenance and Planning Only
                else if (user.USERSECTION.Trim() == "Stores")
                {
                    WorkOrderManagementTab.Enabled = false;
                    AssetsManagementTab.Enabled = false;
                    reportsTab.Enabled = false;

                }

                //Planning Users Only
                else if (user.USERSECTION.Trim() != "Planning")
                {
                    AssetsManagementTab.Enabled = false;
                }

            }
        }

        private void openNewPanel(UserControl selectedControl)
        {
            homeMainPanel.Controls.Clear();
            var activeWorkOrder = new ActiveWorkOrders();
            activeWorkOrder.home = this;
            activeWorkOrder.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(activeWorkOrder);
            windowLabel.Text = "Active Work Orders";
        }
    }
}
