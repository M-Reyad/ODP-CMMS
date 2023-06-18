using ODP2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP2.Views.Equipment_Management
{
    public partial class InsertNewPMTemp : Form
    {
        pmTemplate newPMTemplate = new pmTemplate();
        public Home home;
        public InsertNewPMTemp()
        {
            InitializeComponent();
        }

        private void InsertNewPMTemp_Load(object sender, EventArgs e)
        {
            equipmentFamilyBindingSource.DataSource = home.dbContext.equipmentFamilies.ToList();
            equipmentFamiliesBox_SelectedIndexChanged(sender,e);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog pmAttachFileDialog = new OpenFileDialog();
            pmAttachFileDialog.Filter = "PDF Files|*.pdf";
            if (pmAttachFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream attachFileStream = new FileStream(pmAttachFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    var fileReader = new BinaryReader(attachFileStream);
                    newPMTemplate.pmAttachment = fileReader.ReadBytes((Int32)new FileInfo(pmAttachFileDialog.FileName).Length);
                    attachFileStream.Close();
                    fileReader.Close();
                    attachmentLink.Text = pmAttachFileDialog.FileName;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Attaching pdf file" + ex);
                }
                
            }

        }

        private void equipmentFamiliesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFamily = equipmentFamiliesBox.GetItemText(equipmentFamiliesBox.SelectedItem).Trim();
            newPMTemplate.equipmentFamily = selectedFamily;
            equipmentFamilyDirective.Text = home.dbContext.equipmentFamilies.Where(eq => eq.equipmentFamilyCode.Trim() == selectedFamily).First().equipmentTypeDirective.Trim();      
        }


        private void saveButton_Click(object sender, EventArgs e)
        {

            newPMTemplate.equipmentFamily = equipmentFamiliesBox.GetItemText(equipmentFamiliesBox.SelectedItem);
            if (pmDirective.Text == "")
            {
                MessageBox.Show("Please Insert a Valid Directive");
                pmDirective.Focus();
            }
            else
            {
                if (home.dbContext.pmTemplates.Where(pm => pm.equipmentFamily == newPMTemplate.equipmentFamily).Count() != 0)
                {

                    foreach (pmTemplate pm in home.dbContext.pmTemplates.Where(pm => pm.equipmentFamily == newPMTemplate.equipmentFamily))
                    {
                        if (pm.pmDirective == newPMTemplate.pmDirective)
                        {
                            MessageBox.Show("This PM is registered Before, Kindly insert a different PM Directive");
                            pmDirective.Focus();
                            break;
                        }
                        if (pm.Equals(home.dbContext.pmTemplates.Where(pmTemp => pmTemp.equipmentFamily == newPMTemplate.equipmentFamily).ToList().Last()))
                        {
                            MessageBox.Show("Found Last One");
                            try
                            {
                                newPMTemplate.pmDirective = pmDirective.Text;
                                home.dbContext.pmTemplates.AddOrUpdate(newPMTemplate);
                                home.dbContext.SaveChanges();
                                MessageBox.Show("Saved Successfully!");
                                this.Close();
                                //(PMAttachments) sender.

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error Saving new PM Template" + ex, "Error");
                            }
                        }
                    }
                }
                else
                {
                    try
                    {
                        newPMTemplate.pmDirective = pmDirective.Text;
                        home.dbContext.pmTemplates.AddOrUpdate(newPMTemplate);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Saved Successfully!");
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Saving new PM Template" + ex, "Error");
                    }
                }

            } 

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            Dispose();
            Close();
        }
    }
}
