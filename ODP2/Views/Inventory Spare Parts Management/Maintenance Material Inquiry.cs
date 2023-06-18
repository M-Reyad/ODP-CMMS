﻿using ODP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP2.Views.Inventory_Spare_Parts_Management
{
    public partial class MaintenanceMaterialInquiry : UserControl
    {
        public Home home;
        public MaintenanceMaterialInquiry()
        {
            InitializeComponent();
        }

        private void MaintenanceMaterialInquiry_Load(object sender, EventArgs e)
        {
            fromDateCheckBox.Checked = false;
            fromDatePicker.Enabled = false;
            toDateCheckBox.Checked = false;
            toDatePicker.Enabled = false;
        }


            private void partCode_LostFocus(object sender, EventArgs e)
        {
            if (partCode.Text != "")
            {

                if (home.dbContext.spareParts.Where(part => part.partCode.Trim() == partCode.Text).Count() != 0)
                {
                    partDescription.Text = home.dbContext.spareParts.Where(part => part.partCode.Trim() == partCode.Text).First().partDirective;
                }
                else
                {
                    MessageBox.Show("Wrong Part Code, Please Enter a Valid Part Code","Wrong Data");
                    partCode.Focus();
                }
            }
            else
            {
                partDescription.Text = "";
            }
        }


        private void equipmentBox_LostFocus(object sender, EventArgs e)
        {
            if (equipmentBox.Text != "")
            {
                if (home.dbContext.equipments.Where(equip => equip.equipmentID == equipmentBox.Text).Count() != 0)
                {
                    equipmentDirective.Text = home.dbContext.equipments.Where(equip => equip.equipmentID == equipmentBox.Text).First().equipmentDirective;
                }
                else
                {
                    MessageBox.Show("Wrong Equipment ID, Please Enter a Valid Equipment ID");
                    equipmentBox.Focus();
                }
            }
            else
            {
                equipmentDirective.Text = "";
            }
        }


        private void toDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (toDateCheckBox.Checked == true)
            {
                toDatePicker.Enabled = true;
            }
            else
            {
                toDatePicker.Enabled = false;
            }
        }
        private void fromDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fromDateCheckBox.Checked == true)
            {
                fromDatePicker.Enabled = true;
            }
            else
            {
                fromDatePicker.Enabled = false;
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            if (partCode.Text == "" && equipmentBox.Text == "" && fromDateCheckBox.Checked == false && toDateCheckBox.Checked == false)
            {
                MessageBox.Show("Please Insert attributes to search with", "Missing Data");
            }
            else
            {
                var issuedMaterials = home.dbContext.issues.ToList();

                if (partCode.Text != "")
                {
                    issuedMaterials = issuedMaterials.Where(iss => iss.sparePartCode == partCode.Text).ToList();
                }

                if (equipmentBox.Text != "")
                {
                    issuedMaterials = issuedMaterials.Where(iss => iss.workOrder1.workOrderEquipmentID.Trim() == equipmentBox.Text).ToList();
                }

                if (fromDateCheckBox.Checked == true)
                {
                    issuedMaterials = issuedMaterials.Where(iss => iss.issueDate >= fromDatePicker.Value.Date).ToList();
                }

                if (toDateCheckBox.Checked == true)
                {
                    issuedMaterials = issuedMaterials.Where(iss => iss.issueDate <= toDatePicker.Value.Date).ToList();
                }

                if (issuedMaterials.Count() != 0)
                {
                    issueBindingSource.DataSource = issuedMaterials.Join(home.dbContext.workOrders,
                        issue => issue.workOrder,
                        wo => wo.workOrderID,
                        (issue, wo) => new
                        {
                            wo.workOrderID,
                            wo.workOrderEquipmentID,
                            wo.workOrderDirective,
                            issue.sparePartCode,
                            issue.sparePart.partDirective,
                            issue.qty,
                            issue.issueDate,
                            issue.issueState
                        }).ToList();

                }
                else
                {
                    MessageBox.Show("No Issues found with these Attributes, insert other attributes", "Missing Data");
                }

            }
        }

    }
}

