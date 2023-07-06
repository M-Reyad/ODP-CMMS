using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP2.Views.Equipment_Management
{
    public partial class AddNewEquipment : Form
    {
        public Home home;
        public AddNewEquipment()
        {
            InitializeComponent();
        }

        private void AddNewEquipment_Load(object sender, EventArgs e)
        {
            equipmentFamilyBindingSource.DataSource = home.dbContext.EQUIPMENTFAMILIES.ToList();
        }

        private void equipmentFamilyComboBox_Validated(object sender, EventArgs e)
        {
            //Recorded Equipment Family//
            if (home.dbContext.EQUIPMENTFAMILIES.Where(eqF => eqF.EQUIPMENTFAMILYCODE.Trim() == equipmentFamilyComboBox.Text).Count() == 1)
            {
                var selectedEqFamily = equipmentFamilyComboBox.Text.Trim();
                selectedEquipmentFamilyBindingSource.DataSource = home.dbContext.EQUIPMENTFAMILIES.Where(eqf => eqf.EQUIPMENTFAMILYCODE.Trim() == selectedEqFamily).First();
                var equipmentIndex = int.Parse(countTextBox.Text);
                equipmentIndex += 1;
                newEquipmentIDTextBox.Text = equipmentFamilyComboBox.Text.Trim() + equipmentIndex.ToString("00");
            }
            //Non-Recorded Equipment Family//
            else
            {
                //Add new Equipment Family

            }
        }
    }
}
