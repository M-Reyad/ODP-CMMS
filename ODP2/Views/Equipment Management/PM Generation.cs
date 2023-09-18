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
            var equipmentList = home.dbContext.EQUIPMENTs.ToList();
            var pmWorkOrderList = home.dbContext.WORKORDERs.Where(wo => wo.WORKORDERTYPEID == "PM");

            //Create Last PM WOs
            var lastPMWorkOrderList = new List<WORKORDER>();
            foreach (EQUIPMENT equip in equipmentList.ToList())
            {
                if (pmWorkOrderList.Where(wo => wo.WORKORDEREQUIPMENTID == equip.EQUIPMENTID).OrderByDescending(wo => wo.WORKORDERREGISTERATIONDATE).Count() != 0)
                {
                    var lastEquipmentPM = pmWorkOrderList.Where(wo => wo.WORKORDEREQUIPMENTID == equip.EQUIPMENTID).OrderByDescending(wo => wo.WORKORDERREGISTERATIONDATE).First();
                    lastPMWorkOrderList.Add(lastEquipmentPM);
                }

            }

            //Customizing Generation Table
            var lastPMWorkOrders = lastPMWorkOrderList.Join(equipmentList,
                wo => wo.WORKORDEREQUIPMENTID,
                equip => equip.EQUIPMENTID,
                (wo, equip) => new
                {
                    equip.EQUIPMENTID,
                    equip.EQUIPMENTHR,
                    wo.EQUIPMENTRH,
                    wo.WORKORDERFINISHDATE,
                    wo.WORKORDERREGISTERATIONDATE,
                    wo.WORKORDERDIRECTIVE
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
                    MessageBox.Show("PM Didn't Exceed");
                    row.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("PM Exceeded");
                    row.ReadOnly = false;
                    var lastPMDirective = row.Cells["workOrderDirective"].Value;
                    string equip = row.Cells["equipmentID"].Value.ToString();
                    var eqFamily = home.dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == equip).First().EQUIPMENTFAMILYID.Trim();
                    var pmList = home.dbContext.PMTEMPLATEs.Where(pm => pm.EQUIPMENTFAMILY == eqFamily).ToList();
                    if (pmList.Count == 0) //Empty PM Templates Table//
                    {
                        MessageBox.Show("Found Empty Table for " + eqFamily + "Please Insert PM Templates");
                    }
                    else //Not Empty Table//
                    {
                        
                        if (pmList.Where(pm => pm.PMDIRECTIVE.Trim() == (string)lastPMDirective).Count() != 1) //Can't Locate last PM, will start Over from PM#01
                        {
                            MessageBox.Show("Can't Locate last PM, will start Over from PM#01");

                        }
                        else //Last PM is Located
                        {
                            PMTEMPLATE lastPM = home.dbContext.PMTEMPLATEs.Where(pm => pm.PMDIRECTIVE.Trim() == (string)lastPMDirective).First();
                            var pmNumber = pmList.IndexOf(pmList.Where(pm => pm.PMDIRECTIVE == lastPM.PMDIRECTIVE).First());
                            MessageBox.Show("Current PM Number is PM#" + pmNumber);
                            if (pmNumber < pmList.Count() - 1) //Not Last PM, get the next PM//
                            {
                                PMTEMPLATE nextPM = pmList[pmNumber + 1];
                                row.Cells["newPMDirective"].Value = nextPM.PMDIRECTIVE;
                                MessageBox.Show("Found next PM" + pmList.IndexOf(nextPM));
                            }
                            else if (pmNumber == pmList.Count() - 1) //Last PM, Start Over from PM#01//
                            {
                                PMTEMPLATE nextPM = pmList[0];
                                row.Cells["newPMDirective"].Value = nextPM.PMDIRECTIVE;
                                MessageBox.Show("PM is reset for " + eqFamily + "Will start over from PM#01");
                            }
                        }
                    }


                }
            }
        }
    }
}
