using ODP2.Models;
using ODP2.Views.NIBs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views
{
    public partial class EquipmentRunningHours : UserControl
    {
        public Home home;
        private List<EQUIPMENTFAMILY> generatedEquipmentFamilies = new List<EQUIPMENTFAMILY>();
        private List<EQUIPMENT> equipmentList = new List<EQUIPMENT>();
        public EquipmentRunningHours()
        {
            InitializeComponent();
        }

        private void EquipmentRunningHours_Load(object sender, EventArgs e)
        {
            reloadThePage();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var textBoxlist = new List<TextBox>();
            prepareTextBoxesList(textBoxlist);
            int newRunningHour;
            //MessageBox.Show(textBoxlist.Count().ToString());
            foreach (TextBox newRH in textBoxlist)
            {
                if (newRH.Text == "")
                {
                    MessageBox.Show("Please Enter " + newRH.Name + " Running Hours");
                    break;
                }
                else if (newDatePicker.Value < Convert.ToDateTime(lastRHDate.Text))
                {
                    MessageBox.Show("Please Enter a Valid New Date \n New RH Date should be After Previous RH Date","Invalid Date");
                    break;
                }
                else
                {
                    if (int.TryParse(newRH.Text, out newRunningHour))
                    {
                        try
                        {
                            using (var dbContext = new ODPEntities_ORACLE())
                            {
                                dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == newRH.Name.Trim()).First().EQUIPMENTHR = newRunningHour;
                                dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == newRH.Name.Trim()).First().EQUIPMENTHRDATE = newDatePicker.Value;
                                dbContext.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Saving new Running Hours\n" + ex.Message, "Error Saving");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a Valid RH for " + newRH.Name, "Error Running Hours");
                        break;
                    }

                }
                if (newRH.Equals(textBoxlist.Last())) 
                {
                    MessageBox.Show("Saved Successfully", "Saved");
                    saveButton.Enabled = false;
                }
            }
        }
        private void configEquipmentFamiliesList() 
        {

                var readableEquipmentFamilies = home.dbContext.EQUIPMENTFAMILies.Where(eqFamily => eqFamily.EQUIPMENTSCOPE.Trim() == "CHE" || eqFamily.EQUIPMENTSCOPE.Trim() == "MHE")

                /*
            eqFamily.EQUIPMENTFAMILYCODE == "RS" ||
            eqFamily.EQUIPMENTFAMILYCODE == "TT" ||
            eqFamily.EQUIPMENTFAMILYCODE == "FL" ||
            eqFamily.EQUIPMENTFAMILYCODE == "EH" ||
            eqFamily.EQUIPMENTFAMILYCODE == "RTG" ||
            eqFamily.EQUIPMENTFAMILYCODE == "RMG" ||
            eqFamily.EQUIPMENTFAMILYCODE == "GEN")*/.ToList();

                foreach (EQUIPMENTFAMILY eqFamily in readableEquipmentFamilies)
                {

                    if (home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTFAMILYID.Trim() == eqFamily.EQUIPMENTFAMILYCODE.Trim()).Count() > 0)
                    {
                        generatedEquipmentFamilies.Add(eqFamily);
                    }
                }

                equipmentList =home.dbContext.EQUIPMENTs.ToList();
            
        }
        private void configFlowLayout()
        {
            foreach (EQUIPMENTFAMILY eqFamily in generatedEquipmentFamilies)
            {
                var equipmentListOfOneFamily = equipmentList.Where(eq => eq.EQUIPMENTFAMILY == eqFamily).ToList();
                var newEquipmentFamily = new EquipmentFamilyRunningHoursView(eqFamily.EQUIPMENTFAMILYCODE.Trim(), equipmentListOfOneFamily.Count);
                foreach (EQUIPMENT eq in equipmentList)
                {
                    if (eq.EQUIPMENTFAMILY == eqFamily)
                    {
                        var newEquipment = new EquipmentRunningHoursView(eq.EQUIPMENTID.Trim());
                        newEquipmentFamily.equipmentFlowLayout.Controls.Add(newEquipment);
                    }
                }
                equipmentFamilyLayout.Controls.Add(newEquipmentFamily);
            }
        }
        private void configDate()
        {
            lastRHDate.Text = home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == "RSA01").First().EQUIPMENTHRDATE.ToString();
        }
        private void prepareTextBoxesList(List<TextBox> textBoxlist)
        {
            var equipmentFamiliesViewslist = equipmentFamilyLayout.Controls.OfType<EquipmentFamilyRunningHoursView>().ToList();
            //MessageBox.Show(equipmentFamiliesViewslist.Count().ToString());
            foreach (EquipmentFamilyRunningHoursView eqFamilyView in equipmentFamiliesViewslist)
            {
                var equipmentViewsList = eqFamilyView.equipmentFlowLayout.Controls.OfType<EquipmentRunningHoursView>().ToList();
                //MessageBox.Show(equipmentViewsList.Count().ToString());
                foreach (EquipmentRunningHoursView eq in equipmentViewsList)
                {
                    //MessageBox.Show(eq.Controls.OfType<Panel>().First().Controls.OfType<TextBox>().Where(tb => tb.ReadOnly == false).Count().ToString());
                    var newRHTextVBox = eq.Controls.OfType<Panel>().First().Controls.OfType<TextBox>().Where(tb => tb.ReadOnly == false).First();
                    textBoxlist.Add(newRHTextVBox);
                }
            }
        }
        private void reloadThePage()
        {
            configDate();
            configEquipmentFamiliesList();
            configFlowLayout();
            saveButton.Enabled = false;
        }
    }
}
