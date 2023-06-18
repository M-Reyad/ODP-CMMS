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
using System.Windows.Shapes;

namespace ODP2.Views.Equipment_Management
{
    public partial class PMGeneration : UserControl
    {
        public Home home;
        public PMGeneration()
        {
            InitializeComponent();
        }

        private void PMGeneration_Load(object sender, EventArgs e)
        {
            var equipmentList = home.dbContext.equipments.ToList();
            var pmWorkOrderList = home.dbContext.workOrders.Where(wo => wo.workOrderTypeID == "PM");
            var lastPMWorkOrderList = new List<workOrder>();
            foreach (equipment equip in equipmentList.ToList())
            {
                if (pmWorkOrderList.Where(wo => wo.workOrderEquipmentID == equip.equipmentID).OrderByDescending(wo => wo.workOrderRegisterationDate).Count() != 0)
                {
                    var lastEquipmentPM = pmWorkOrderList.Where(wo => wo.workOrderEquipmentID == equip.equipmentID).OrderByDescending(wo => wo.workOrderRegisterationDate).First();
                    lastPMWorkOrderList.Add(lastEquipmentPM);
                }

            }
            var lastPMWorkOrders = lastPMWorkOrderList.Join(equipmentList,
                wo => wo.workOrderEquipmentID,
                equip => equip.equipmentID,
                (wo, equip) => new
                {
                    equip.equipmentID,
                    equip.equipmentHR,
                    wo.equipmentRH,
                    wo.workOrderFinishDate,
                    wo.workOrderRegisterationDate,
                    wo.workOrderDirective
                });
            equipmentBindingSource.DataSource = lastPMWorkOrders;
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in pmRegisterationGridView.Rows)
            {
                var months = new TimeSpan(180, 0, 0, 0, 0);
                if ((Convert.ToInt32(row.Cells["equipmentHR"].Value) - Convert.ToInt32(row.Cells["equipmentRH"].Value) >= Convert.ToInt32(dueHRTextbox.Text)) || Convert.ToDateTime(row.Cells["workOrderRegisterationDate"].Value) - dueDatePicker.Value >= months)
                {
                    row.ReadOnly = false;
                    //Enable CheckList to Generate
                    //pmRegisterationGridView["generate",i]

                }
                else
                {
                    row.ReadOnly = true;

                }
            }
        }
    }
}

