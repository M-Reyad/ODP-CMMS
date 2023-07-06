using ODP2.Models;
using ODP2.Views.Equipment_Management;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;


namespace ODP2.Views
{

    public partial class PMAttachments : UserControl
    {
        public Home home;
        public PMAttachments()
        {
            InitializeComponent();
        }

        private void PMAttachments_Load(object sender, System.EventArgs e)
        {
            var equipmentFamilyList = home.dbContext.EQUIPMENTFAMILIES.ToList();
            equipmentFamilyBindingSource.DataSource = equipmentFamilyList;
            equipmentFamilyDirective.Text = "";
            equipmentFamilyBox_SelectedIndexChanged(sender, e);
        }

        private void equipmentFamilyBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedFamilyEquipment = equipmentFamilyBox.GetItemText(equipmentFamilyBox.SelectedItem);
            equipmentFamilyDirective.Text = home.dbContext.EQUIPMENTFAMILIES.Where(eq => eq.EQUIPMENTFAMILYCODE.Trim() == selectedFamilyEquipment).First().EQUIPMENTTYPEDIRECTIVE.Trim();
            pmTemplateBindingSource.DataSource = home.dbContext.PMTEMPLATES.Where(pmTemp => pmTemp.EQUIPMENTFAMILY.Trim() == selectedFamilyEquipment).ToList();
            //attachmentsDataGrid.Refresh();
            
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                home.dbContext.SaveChanges();
                MessageBox.Show("Saved Successfully");
                saveButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Templates " + ex);
            }

        }

        private void browseButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog insertAttach = new OpenFileDialog();
            if (insertAttach.ShowDialog() == DialogResult.OK)
            {
                //userPicture.Image = Image.FromFile(attachPicture.FileName);
                //home.dbContext.users.Where(user => user.userID == home.user.userID).First().userImage = (byte[])new ImageConverter().ConvertTo(userPicture.Image, typeof(byte[]));
                home.dbContext.SaveChanges();
                MessageBox.Show("Attach Inserted Successfully", "Saved");
            }
        }

        private void newPMTemplate_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<InsertNewPMTemp>().Count() != 0)
            {
                Application.OpenForms.OfType<InsertNewPMTemp>().ToList()[0].Focus();
            }
            else
            {
                InsertNewPMTemp newPMInsert = new InsertNewPMTemp();
                newPMInsert.home = home;
                newPMInsert.Show();
            }
        }

        private void attachmentsDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            saveButton.Enabled = true;
        }
    }
}