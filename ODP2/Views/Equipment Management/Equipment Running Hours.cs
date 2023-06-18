using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views
{
    public partial class EquipmentRunningHours : UserControl
    {
        public Home home;
        public EquipmentRunningHours()
        {
            InitializeComponent();
        }

        private void EquipmentRunningHours_Load(object sender, EventArgs e)
        {

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.ReadOnly == true)
                {
                    if (textBox == lastRegisterationDateTextbox)
                    {
                        textBox.Text = home.dbContext.equipments.First().equipmentHRDate.ToString();

                    }
                    else
                    {
                        textBox.Text = home.dbContext.equipments.Where(equipment => equipment.equipmentID == textBox.Name.Remove(textBox.Name.Length - 3)).First().equipmentHR.ToString();
                    }

                }
                else if (textBox.ReadOnly == false)
                {
                    textBox.Text = "";
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {

                if (textBox.ReadOnly == false)
                {
                    if (textBox.Text == "")
                    {
                        MessageBox.Show("Please Enter All Equipment Working Hours", "Missing Data");
                        textBox.Focus();
                        break;
                    }
                    else
                    {
                        home.dbContext.equipments.Where(equipment => equipment.equipmentID == textBox.Name.Remove(textBox.Name.Length - 3)).First().equipmentHR = Convert.ToInt32(textBox.Text);
                        home.dbContext.equipments.Where(equipment => equipment.equipmentID == textBox.Name.Remove(textBox.Name.Length - 3)).First().equipmentHRDate = newDatePicker.Value.Date;
                        home.dbContext.SaveChanges();

                    }
                }
                if (textBox.Equals(Controls.OfType<TextBox>().Last()))
                {
                    MessageBox.Show("Saved Successfully", "Saved");
                    EquipmentRunningHours_Load(sender, e);
                }
            }


        }

    }
}
