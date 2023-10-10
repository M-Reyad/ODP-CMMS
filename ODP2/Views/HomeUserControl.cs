using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;

namespace ODP2.Views
{
    public partial class HomeUserControl : UserControl
    {

        public Home home;
        public HomeUserControl()
        {
            InitializeComponent();


        }


        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            //Customizing User Panel
            userNameLabel.Text = home.user.userName;
            userTitleLabel.Text = home.user.userTitle;
            userIDNumber.Text = home.user.userIDNumber.ToString();
            try
            { 
                userPicture.Image = Image.FromStream(new MemoryStream(home.user.userImage));
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Cann't Load User Image " + ex);

            }

            //Customizing Charts
            //-1- Work Orders Types
            foreach (var type in home.dbContext.workOrderTypes)
            {
                if (home.dbContext.workOrders.Where(workOrder => workOrder.workOrderTypeID == type.workOrderTypeID).Count() != 0)
                {
                    workOrdersTyper.Series["Work Orders"].Points.AddXY(type.workOrderTypeID, home.dbContext.workOrders.Where(workOrder => workOrder.workOrderTypeID == type.workOrderTypeID).Count());
                }

            }
            

            //-2- PM KPIs
            var pmWOs = home.dbContext.workOrders.Where(workOrder => workOrder.workOrderTypeID == "PM").ToList();
            PMKPIsChart.Series["PM Adherence"].Points.AddXY("Q-1",100* 5 / pmWOs.Count());
            PMKPIsChart.Series["PM Adherence"].Points.AddXY("Q-2", 100*3 / pmWOs.Count());
            PMKPIsChart.Series["PM Adherence"].Points.AddXY("Q-3", 100*7/ pmWOs.Count());
            PMKPIsChart.Series["PM Adherence"].Points.AddXY("Q-4", 100*9/ pmWOs.Count());
            //PMKPIsChart.Series["PM Compliance"].Points.AddXY("2023", pmWOs.Where(wo => wo.workOrderStatusID != "Finished").Count

            //-3- Work Done Types
            foreach (var doneType in home.dbContext.workDoneTypes)
            {
                if (home.dbContext.workOrders.Where(workOrder => workOrder.workDoneType == doneType.workDoneTypeID).Count() != 0)
                {
                    workDoneTypes.Series["Work Done"].Points.AddXY(doneType.workDoneTypeID, home.dbContext.workOrders.Where(workOrder => workOrder.workDoneType == doneType.workDoneTypeID).Count());
                }

            }

            
            //-4- Assets Reliability 
            int MTTR = 18;
            mttr.From = 0;
            mttr.To = 20;
            mttr.ForeColor = System.Drawing.Color.Transparent;
            mttr.BackColor = System.Drawing.Color.Transparent;
            mttr.Value = MTTR;
            mttr.Text = "MTTR(min)";
            /*
            for (int i = 1; i <= 4; i ++)
            {

                meanTimes.Series["MTTR"].Points.AddXY("Q " + i.ToString(), MTTR);
                meanTimes.Series["MTBF"].Points.AddXY("Q " + i.ToString(), MTTR / 60);
                MTTR+=2;
            }
            */
            
            //-5- Budget Control
            int CONS = 50000;
            for (int i = 1; i <= 4; i++)
            {


                budgetControl.Series["Actual Cons."].Points.AddXY("Q " + i.ToString(), CONS);
                budgetControl.Series["Planned Cons."].Points.AddXY("Q " + i.ToString(), CONS + 25000);
                budgetControl.Series["OPEX Cons."].Points.AddXY("Q " + i.ToString(), CONS/12);
                budgetControl.Series["OPEX PL."].Points.AddXY("Q " + i.ToString(), CONS+25000 / 12);

                CONS+=20000;
            }


            //-4- Maintenance Cost

                maintenanceCost.Series["LUB Cost"].Points.AddXY("Q-1", 2500);
            maintenanceCost.Series["LUB Cost"].Points.AddXY("Q-2", 3200);
            maintenanceCost.Series["LUB Cost"].Points.AddXY("Q-3", 1900);
            maintenanceCost.Series["LUB Cost"].Points.AddXY("Q-4", 2100);


            maintenanceCost.Series["S/P Cost"].Points.AddXY("Q-1", 2700);
            maintenanceCost.Series["S/P Cost"].Points.AddXY("Q-2", 2100);
            maintenanceCost.Series["S/P Cost"].Points.AddXY("Q-3", 3200);
            maintenanceCost.Series["S/P Cost"].Points.AddXY("Q-4", 4000);
            //-5- Assets Reliability
            
                assetsReliability.Series["BDN"].Points.AddXY("Q-1", 100 - 85);
                assetsReliability.Series["AV."].Points.AddXY("Q-1", 85);
            assetsReliability.Series["BDN"].Points.AddXY("Q-2", 100 - 90);
            assetsReliability.Series["AV."].Points.AddXY("Q-2", 90);
            assetsReliability.Series["BDN"].Points.AddXY("Q-3", 100 - 89);
            assetsReliability.Series["AV."].Points.AddXY("Q-3", 89);
            assetsReliability.Series["BDN"].Points.AddXY("Q-4", 100 - 95);
            assetsReliability.Series["AV."].Points.AddXY("Q-4", 95);



            foreach (Chart chart in Controls.OfType<Chart>())
            {
                MessageBox.Show("Entered");
                chart.Titles["Month"].Text = DateTime.Today.Month.ToString();
                MessageBox.Show("Confirmed");
            }

        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            home.Close();
            Login newLoginPage = new Login();
            newLoginPage.Show();
            home.dbContext.Dispose();


        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordPage = new ChangePassword();
            changePasswordPage.userID = home.user.userID;
            changePasswordPage.Show();
        }


        private void changeUserPicture(object sender, EventArgs e)
        {
            OpenFileDialog attachPicture = new OpenFileDialog();
            if (attachPicture.ShowDialog() == DialogResult.OK)
            {
                userPicture.Image = Image.FromFile(attachPicture.FileName);
                home.dbContext.users.Where(user => user.userID == home.user.userID).First().userImage = (byte[])new ImageConverter().ConvertTo(userPicture.Image, typeof(byte[]));
                home.dbContext.SaveChanges();
                MessageBox.Show("Image Saved Successfully", "Saved");

            }
        }


    }
}
