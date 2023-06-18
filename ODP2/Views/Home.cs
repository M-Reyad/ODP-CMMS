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
        public ODPEntities dbContext;
        public user user = new user();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Customizing User Panel
            userNameLabel.Text = user.userName;
            userTitleLabel.Text = user.userTitle;
            userIDNumber.Text = user.userIDNumber.ToString();
            try
            {
                userPicture.Image = Image.FromStream(new MemoryStream(user.userImage));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cann't Load User Image " + ex);

            }

            //Customizing Tabs according to Privillages
            if (user.userLevel.Trim() != "Head")
            {
                //Head Only 
                reportsTab.Enabled = false;
                
                //Stores Users Only 
                if (user.userSection.Trim() != "Stores")
                {
                    StoresTab.Enabled = false;

                }

                //Maintenance and Planning Only
                else if (user.userSection.Trim() == "Stores")
                {
                    WorkOrderManagementTab.Enabled = false;
                    AssetsManagementTab.Enabled = false;
                    reportsTab.Enabled = false;

                }

                //Planning Users Only
                else if (user.userSection.Trim() != "Planning")
                {
                    AssetsManagementTab.Enabled = false;
                }

            }

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Close();
            Login newLoginPage = new Login();
            newLoginPage.Show();
            dbContext.Dispose();


        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordPage = new ChangePassword();
            changePasswordPage.userID = user.userID;
            changePasswordPage.Show();
        }


        private void changeUserPicture(object sender, EventArgs e)
        {
            OpenFileDialog attachPicture = new OpenFileDialog();
            if (attachPicture.ShowDialog() == DialogResult.OK)
            {
                userPicture.Image = Image.FromFile(attachPicture.FileName);
                dbContext.users.Where(user => user.userID == user.userID).First().userImage = (byte[])new ImageConverter().ConvertTo(userPicture.Image, typeof(byte[]));
                dbContext.SaveChanges();
                MessageBox.Show("Image Saved Successfully", "Saved");

            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {


        }


        private void activeWorkOrders_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            var activeWorkOrder = new ActiveWorkOrders();
            activeWorkOrder.home = this;
            activeWorkOrder.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(activeWorkOrder);
        }

        private void closedWorkOrders_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            var closedWorkOrder = new ClosedWorkOrders();
            closedWorkOrder.home = this;
            closedWorkOrder.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(closedWorkOrder);
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
        }

        private void createNewSparePart_Click(object sender, EventArgs e)
        {

        }

        private void equipmentRunningHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            EquipmentRunningHours equipmentRunningHoursRegisteration = new EquipmentRunningHours();
            equipmentRunningHoursRegisteration.home = this;
            equipmentRunningHoursRegisteration.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(equipmentRunningHoursRegisteration);
        }
        

        private void fuelStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            FuelStation fuelStatiopn = new FuelStation();
            fuelStatiopn.home = this;
            fuelStatiopn.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(fuelStatiopn);
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
        }

        private void createNewSparePartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maintenanceMaterialInquiry_Click(object sender, EventArgs e)
        {

        }

        private void pmGeneration_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            PMGeneration generatePM = new PMGeneration();
            generatePM.home = this;
            generatePM.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(generatePM);
        }

        private void pMAttachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMainPanel.Controls.Clear();
            PMAttachments attachNewPM = new PMAttachments();
            attachNewPM.home = this;
            attachNewPM.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Add(attachNewPM);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DialogResult closingHome = MessageBox.Show("You are closing the Home Page without Signing Out" +
                        "Would you like to Sign Out firstly?", "Exit", MessageBoxButtons.YesNo);
            if (closingHome == DialogResult.Yes)
            {
                
            }
            else
            {
                workOrderStatusID.Focus();
            }
            */
        }

        private void kPIsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KPIsReports newKPIsReports = new KPIsReports();
            newKPIsReports.home = this;
            newKPIsReports.Size = homeMainPanel.Size;
            homeMainPanel.Controls.Clear();
            homeMainPanel.Controls.Add(newKPIsReports);
        }
    }
}
