using ODP2.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views.Equipment_Management
{
    public partial class AssetsInformation : UserControl
    {
        public Home home;
        string selectedEquipmentString;
        EQUIPMENT selectedEquipment;
        public AssetsInformation()
        {
            InitializeComponent();
        }

        private void AssetsInformation_Load(object sender, EventArgs e)
        {
            if (home.dbContext.EQUIPMENTs.ToList().Count() > 0)
            {
                eQUIPMENTBindingSource.DataSource = home.dbContext.EQUIPMENTs.ToArray();
                equipmentComboBox_SelectedIndexChanged(sender, e);
            }
        }

        private void equipmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEquipmentString = equipmentComboBox.GetItemText(equipmentComboBox.SelectedItem).Trim();
            selectedEquipment = home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == selectedEquipmentString).First();
            selectedEquipmentBindingSource.DataSource = selectedEquipment;
            componentGridView.DataSource = home.dbContext.COMPONENTs.Where(comp => comp.COMPONENTEQUIPMENT.Trim() == selectedEquipmentString).ToList();
            configSelectedEquipmentView(selectedEquipment);
         
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
        private void configSelectedEquipmentView(EQUIPMENT selectedEquipment)
        {
            if (selectedEquipment.EQUIPMENTSTATUSID != "HBN")
            {
                hibernateEquipmebtButton.Enabled = true;
            }
            else
            {
                hibernateEquipmebtButton.Enabled = false;
            }
        }

        private void hibernatedEquipmentButton_Click(object sender, EventArgs e)
        {
            DialogResult hibernateMessageResult = MessageBox.Show("Are you sure to Hibernate " +selectedEquipment.EQUIPMENTID.Trim()+ " ? \n " +
                "Hibernated Equipments means it will get out of Service!","Hibernation",MessageBoxButtons.YesNo);
            if (hibernateMessageResult == DialogResult.Yes)
            {
                try
                {
                    selectedEquipment.EQUIPMENTSTATUSID = "HBN";
                    hibernateEquipmebtButton.Enabled = false;
                    home.dbContext.SaveChanges();
                    MessageBox.Show("Equipment " + selectedEquipment.EQUIPMENTID + " Hibernated Successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Hibernating Equipment " + selectedEquipment.EQUIPMENTID.Trim() + ex.Message);
                }
            }
        }
    }
}
