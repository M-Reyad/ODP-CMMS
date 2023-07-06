using ODP2.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views.Equipment_Management
{
    public partial class AssetsInformation : UserControl
    {
        public Home home;
        public AssetsInformation()
        {
            InitializeComponent();
        }

        private void AssetsInformation_Load(object sender, EventArgs e)
        {
            equipmentBindingSource.DataSource = home.dbContext.EQUIPMENTS.ToList();
            //equipmentComboBox.DataSource = home.dbContext.equipments.ToList();
        }

        private void equipmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedEquipmentBindingSource.DataSource = (equipment) equipmentComboBox.SelectedItem;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            { 
                home.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving" + ex);
            }
        }

        private void newEquipment_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddNewEquipment>().Count() != 0)
            {
                Application.OpenForms.OfType<AddNewEquipment>().ToList()[0].Focus();
            }
            else
            {
                AddNewEquipment addNewEquipment = new AddNewEquipment();
                addNewEquipment.home = home;
                addNewEquipment.Show();
            }
        }
    }
}
