using ODP2.Models;
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
        private string selectedBatch;
        private string selectedEqFamily;
        private string selectedEquipmentID;
        private string selectedComponent;
        EQUIPMENT selectedEquipment = new EQUIPMENT();
        public AddNewEquipment()
        {
            InitializeComponent();

        }

        private void AddNewEquipment_Load(object sender, EventArgs e)
        {
            eQUIPMENTFAMILYBindingSource.DataSource = home.dbContext.EQUIPMENTFAMILies.ToList().Count() > 0 ? home.dbContext.EQUIPMENTFAMILies.ToList() : null;
            equipmentFamilyComboBox_SelectionChanged(sender, e);
            configEquipmentList();
            warrantyEndCheckBox.Enabled = false;
        }

        #region New Equipment

        private void equipmentFamilyComboBox_SelectionChanged(object sender, EventArgs e)
        {
            //Recorded Equipment Family//

            selectedEqFamily = equipmentFamilyComboBox.GetItemText(equipmentFamilyComboBox.SelectedItem).Trim();
            
                if (home.dbContext.EQUIPMENTFAMILies.Where(eqF => eqF.EQUIPMENTFAMILYCODE.Trim() == selectedEqFamily.Trim()).Count() == 1)
                {
                configEquipmentFamily();
                }
                //Non-Recorded Equipment Family//
                else
                {
                //Add new Equipment Family
                //MessageBox.Show("No Equipment Family Found");
                }
        }
        private void configEquipmentFamily()
        {
            configTextBoxes();
            equipmentFamilyDirectiveTextBox.Text = home.dbContext.EQUIPMENTFAMILies.Where(eqf => eqf.EQUIPMENTFAMILYCODE.Trim() == selectedEqFamily).First().EQUIPMENTTYPEDIRECTIVE.Trim();
            equipmentBatchComboBox.Enabled = true;
            equipmentBatchComboBox.Focus();

        }
        private void equipmentBatchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBatch = equipmentBatchComboBox.GetItemText(equipmentBatchComboBox.SelectedItem);
            configTextBoxes();
            configEquipmentID();
            configEquipmentDirective();
        }
        private void configEquipmentID()
        {
            var equipmentCount = home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTFAMILYID.Trim() == selectedEqFamily.Trim()).Count();
            countTextBox.Text = equipmentCount.ToString();
            if (equipmentCount > 0 ) //Similar Equipment found at the Port
            {
                if (home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTFAMILYID.Trim() == selectedEqFamily && eq.EQUIPMENTBATCH.Trim() == selectedBatch).Count() > 0)
                {
                    manufacturerTextBox.Text = home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim().Contains(selectedEqFamily + selectedBatch)).First().EQUIPMENTMANUFACTURER.Trim();
                    capacityTextBox.Text = home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim().Contains(selectedEqFamily + selectedBatch)).First().EQUIPMENTCAPACITY.ToString();
                    modelTextBox.Text = home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim().Contains(selectedEqFamily + selectedBatch)).First().EQUIPMENTMODEL.ToString();
                }
                else
                {
                    manufacturerTextBox.ReadOnly = false;
                    capacityTextBox.ReadOnly = false;
                    manufacturerTextBox.Focus();
                }
                newEquipmentIDTextBox.Text = selectedEqFamily + selectedBatch + (equipmentCount + 1).ToString("00");

            }
            else //New Equipment at the Port of this Type
            {
                newEquipmentIDTextBox.Text = selectedEqFamily + selectedBatch + "01";
                manufacturerTextBox.ReadOnly = false;
                capacityTextBox.ReadOnly = false;
                manufacturerTextBox.Focus();
            }
            equipmentSerialNumberTextBox.ReadOnly = false;
            inServiceDatePicker.Enabled = true;
            warrantyDateTimePicker.Enabled = true;
            equipmentHourTextBox.ReadOnly = false;
            refueledCheckBox.Enabled = true;
            enterEquipmentDirectiveCheckBox.Enabled = true;
            enterEquipmentIDCheckBox.Enabled = true;
            modelTextBox.ReadOnly = false;
            warrantyEndCheckBox.Enabled = true;
        }
        private void configEquipmentDirective() 
        {
            equipmentDirectiveTextBox.Text = equipmentFamilyDirectiveTextBox.Text.Trim() + " #" + newEquipmentIDTextBox.Text.Trim().Substring(newEquipmentIDTextBox.Text.Trim().Count() - 2) + " - " + manufacturerTextBox.Text.Trim() + " - " + modelTextBox.Text.Trim();
        }
        private void enterEquipmentDirectiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enterEquipmentDirectiveCheckBox.Checked == true)
            {
                equipmentDirectiveTextBox.ReadOnly = false;
                equipmentDirectiveTextBox.Text = "";
            }
            else
            {
                equipmentDirectiveTextBox.ReadOnly = true;
                configEquipmentDirective();
            }
        }
        private void newEquipmentIDTextBox_Validated(object sender, EventArgs e)
        {
            var newEquipmentID = newEquipmentIDTextBox.Text.Trim();
            if (home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == newEquipmentID).Count() != 0)
            {
                MessageBox.Show("Duplicated Equipment, Please enter another Equipment ID", "Duplicated ID");
            } 
            else
            {
                saveButton.Enabled = true;
            }
            
        }
        private void enterEquipmentIDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enterEquipmentIDCheckBox.Checked == true)
            {
                newEquipmentIDTextBox.ReadOnly = false;
                newEquipmentIDTextBox.Text = "";
            }
            else
            {
                newEquipmentIDTextBox.ReadOnly = true;
                configEquipmentID();
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (newEquipmentIDTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Equipment ID");
            }
            else if (equipmentSerialNumberTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Equipment S/N");
            }
            else if (equipmentDirectiveTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Equipment Directive");
            }
            else if (manufacturerTextBox.Text == "")
            {
                MessageBox.Show("Please enter Equipment Manufacturer");
            }
            else if (modelTextBox.Text == "")
            {
                MessageBox.Show("Please enter Equipment Model");
            }
            else if (capacityTextBox.Text == "")
            {
                if (!int.TryParse(capacityTextBox.Text, out int _))
                {
                    MessageBox.Show("Please Enter Capacity in Numbers of Tons");
                }
            }
            else if (equipmentHourTextBox.Text == "")
            {
                if (!int.TryParse(equipmentHourTextBox.Text, out int _))
                {
                    MessageBox.Show("Please Enter Capacity in Numbers of Tons");
                }
            }
            else
            {
                EQUIPMENT newEquipment = new EQUIPMENT();
                newEquipment.EQUIPMENTBATCH = equipmentBatchComboBox.Text;
                newEquipment.EQUIPMENTCAPACITY = decimal.Parse(capacityTextBox.Text);
                newEquipment.EQUIPMENTFAMILYID = selectedEqFamily;
                newEquipment.EQUIPMENTID = newEquipmentIDTextBox.Text;
                newEquipment.EQUIPMENTDIRECTIVE = equipmentDirectiveTextBox.Text;
                newEquipment.EQUIPMENTMANUFACTURER = manufacturerTextBox.Text;
                newEquipment.EQUIPMENTSN = equipmentSerialNumberTextBox.Text;
                newEquipment.INSERVICEDATE = inServiceDatePicker.Value;
                newEquipment.EQUIPMENTSTATUSID = "RUN";
                newEquipment.EQUIPMENTHR = int.Parse(equipmentHourTextBox.Text);
                newEquipment.REFUELED = refueledCheckBox.Checked == true ? 1 : 0;
                newEquipment.EQUIPMENTMODEL = modelTextBox.Text;
                
                if (warrantyEndCheckBox.Checked == true)
                {
                    newEquipment.WARRANTYENDDATE = warrantyDateTimePicker.Value;
                }
                try
                {
                    home.dbContext.EQUIPMENTs.Add(newEquipment);
                    home.dbContext.SaveChanges();
                    MessageBox.Show("Equipment " + newEquipment.EQUIPMENTID + " added to your fleet");
                    configEquipmentList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding Equipment " + ex.Message);
                }

            }
        }
        private void configEquipmentList()
            {
            if (home.dbContext.EQUIPMENTs.Count() > 0)
            {
                eQUIPMENTBindingSource.DataSource = home.dbContext.EQUIPMENTs.ToList();

            }
            else
            {
                MessageBox.Show("Please Insert Equipments to your Fleet firstly", "Empty Fleet");
            }
            }
        private void configTextBoxes()
        {
            newEquipmentIDTextBox.Text = "";
            manufacturerTextBox.Text = "";
            equipmentDirectiveTextBox.Text = "";
            capacityTextBox.Text = "";
            equipmentHourTextBox.Text = "";
            equipmentSerialNumberTextBox.Text = "";
            modelTextBox.Text = "";
        }
        private void enterWarrantyEndDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (warrantyEndCheckBox.Checked == true)
            {
                warrantyDateTimePicker.Enabled = true;
            }
            else
            {
                warrantyDateTimePicker.Enabled = false;
            }
        }
        #endregion

        #region Insert New Components
        private void equipmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEquipmentID = equipmentComboBox.GetItemText(equipmentComboBox.SelectedItem).Trim();
            selectedEquipment = home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == selectedEquipmentID).First();
            equipmentDirective.Text = selectedEquipment.EQUIPMENTDIRECTIVE.Trim();
            configEquipmentComponents();
        }

        void configEquipmentComponents()
        {
            componentSNTextBox.Text = "";
            componentManufacturerTextBox.Text = "";
            componentModelTextBox.Text = "";
            componentGridView.DataSource = home.dbContext.COMPONENTs.Where(comp => comp.COMPONENTEQUIPMENT == selectedEquipmentID).ToList();
        }
        private void componentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            configComponentData();
        }
        private void configComponentData()
        {
            componentPartCode.Text = "";
            componentModelTextBox.Text = "";
            componentManufacturerTextBox.Text = "";
            componentSNTextBox.Text = "";
            var componentDictionary = new Dictionary<string, string>()
            {
                { "Engine" , "P-EN" },
                 { "Transmission","D-TN" },
                 { "Drive Axle","D-DX" }
            };
            selectedComponent = componentComboBox.GetItemText(componentComboBox.SelectedItem);
            if (selectedComponent != "")
            {
                componentPartCode.Text = selectedEquipment.EQUIPMENTFAMILYID.Trim() + selectedEquipment.EQUIPMENTBATCH.Trim() + componentDictionary[selectedComponent] + "-**-**0100";

            }
        }
        private void componentInsertButton_Clicked(object sender, EventArgs e)
        {
            if(componentManufacturerTextBox.Text == "")
            {
                MessageBox.Show("Please Insert Component Manufacturer");
            }
            else if (componentModelTextBox.Text == "")
            {
                MessageBox.Show("Please Insert Component Model");
            }
            else if (componentPartCode.Text == "")
            {
                MessageBox.Show("Please Insert Component Part Code");
            }
            else if (componentSNTextBox.Text == "")
            {
                MessageBox.Show("Please Insert Component S/N");
            }
            else
            {
                try
                {
                    COMPONENT newComponent = new COMPONENT();
                    newComponent.COMPONENTEQUIPMENT = selectedEquipmentID;
                    newComponent.COMPONENTMANFACTURER = componentManufacturerTextBox.Text;
                    newComponent.COMPONENTPARTCODE = componentPartCode.Text;
                    newComponent.COMPONENTMODEL = componentModelTextBox.Text;
                    newComponent.COMPONENTSTATUS = "NEW";
                    newComponent.COMPONENTSN = componentSNTextBox.Text;
                    home.dbContext.COMPONENTs.Add(newComponent);
                    home.dbContext.SaveChanges();
                    configEquipmentComponents();
                    MessageBox.Show("Added new Component", "Success");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Adding Equipment " + ex);
                }
            }

        }

        #endregion

        private void shallUpdateDirective(object sender, EventArgs e)
        {
            configEquipmentDirective();
        }


    }
}
