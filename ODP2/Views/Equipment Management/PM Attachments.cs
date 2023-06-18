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

            var equipmentFamilyList = home.dbContext.equipmentFamilies.ToList();
            equipmentFamilyBindingSource.DataSource = equipmentFamilyList;
            equipmentFamilyDirective.Text = "";
            equipmentFamilyBox_SelectedIndexChanged(sender, e);
        }

        private void equipmentFamilyBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedFamilyEquipment = equipmentFamilyBox.GetItemText(equipmentFamilyBox.SelectedItem);
            pmTemplateBindingSource.DataSource = home.dbContext.pmTemplates.Where(pmTemp => pmTemp.equipmentFamily.Trim() == selectedFamilyEquipment).ToList();
            attachmentsDataGrid.Refresh();
            equipmentFamilyDirective.Text = home.dbContext.equipmentFamilies.Where(eq => eq.equipmentFamilyCode.Trim() == selectedFamilyEquipment).First().equipmentTypeDirective.Trim();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in attachmentsDataGrid.Rows)
                {
                    pmTemplate newTemp = new pmTemplate();
                    newTemp.equipmentFamily = row.Cells["equipmentFamily"].FormattedValue.ToString();
                    newTemp.pmDirective = row.Cells["pmDirective"].FormattedValue.ToString();
                    newTemp.pmAttachment = null;
                    foreach (pmTemplate PMTemp in home.dbContext.pmTemplates.Where(pm => pm.equipmentFamily.Trim() == newTemp.equipmentFamily).ToList())
                    {
                        if (PMTemp.pmDirective == newTemp.pmDirective)
                        {
                            MessageBox.Show("PM Already Registered Before, Edit the record Instead");
                        }
                        else
                        {
                            home.dbContext.pmTemplates.AddOrUpdate(newTemp);
                            home.dbContext.SaveChanges();
                            MessageBox.Show("Saved Successfully");
                            saveButton.Enabled = false;
                            attachmentsDataGrid.Refresh();
                        }
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Adding Template " + ex);
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

        private void attachmentsDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void newPMTemplate_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<InsertNewPMTemp>().Count() != 0)
            {
                Application.OpenForms.OfType<InsertNewPMTemp>().ToList()[0].Show();
            }
            else
            {
                InsertNewPMTemp newPMInsert = new InsertNewPMTemp();
                newPMInsert.home = home;
                newPMInsert.Show();
            }
        }
    }
}