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
        byte[] newPMAttachment;
        string selectedFamily;
        public Home home;
        public InsertNewPMTemp()
        {
            InitializeComponent();
        }

        private void InsertNewPMTemp_Load(object sender, EventArgs e)
        {
            equipmentFamilyBindingSource.DataSource = home.dbContext.EQUIPMENTFAMILIES.ToList();
            equipmentFamiliesBox_SelectedIndexChanged(sender, e);
        }
        private void equipmentFamiliesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFamily = equipmentFamiliesBox.GetItemText(equipmentFamiliesBox.SelectedItem).Trim();
            equipmentFamilyDirective.Text = home.dbContext.EQUIPMENTFAMILIES.Where(eq => eq.EQUIPMENTFAMILYCODE.Trim() == selectedFamily).First().EQUIPMENTTYPEDIRECTIVE.Trim();
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
                    newPMAttachment = fileReader.ReadBytes((Int32)new FileInfo(pmAttachFileDialog.FileName).Length);
                    attachFileStream.Close();
                    fileReader.Close();
                    attachmentLink.Text = pmAttachFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Attaching pdf file" + ex);
                }

            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PMTEMPLATE newPMTemplate = new PMTEMPLATE();


            if (pmDirective.Text == "")
            {
                MessageBox.Show("Please Insert a Valid Directive");
                pmDirective.Focus();
            }
            else
            {
                if (home.dbContext.PMTEMPLATES.Where(pm => pm.EQUIPMENTFAMILY == selectedFamily).Count() != 0)
                {
                    foreach (PMTEMPLATE pm in home.dbContext.PMTEMPLATES.Where(pm => pm.EQUIPMENTFAMILY == selectedFamily))
                    {
                        if (pm.PMDIRECTIVE == pmDirective.Text)
                        {
                            MessageBox.Show("This PM is registered Before, Kindly insert a different PM Directive");
                            pmDirective.Focus();
                            break;
                        }
                        else
                        {
                            if (pm.Equals(home.dbContext.PMTEMPLATES.Where(pmTemp => pmTemp.EQUIPMENTFAMILY == selectedFamily).ToList().Last()))
                            {
                                newPMTemplate.EQUIPMENTFAMILY = selectedFamily;
                                newPMTemplate.PMDIRECTIVE = pmDirective.Text;
                                newPMTemplate.PMATTACHMENT = newPMAttachment;
                            }

                        }

                    }
                    if (newPMTemplate.PMDIRECTIVE != null)
                    {
                        try
                        {


                            home.dbContext.PMTEMPLATES.AddOrUpdate(newPMTemplate);
                            home.dbContext.SaveChanges();
                            MessageBox.Show("Saved Successfully!");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Saving the new Template " + ex, "Error");
                        }
                    }

                }
                else
                {
                    try
                    {


                        newPMTemplate.EQUIPMENTFAMILY = selectedFamily;
                        newPMTemplate.PMDIRECTIVE = pmDirective.Text;
                        newPMTemplate.PMATTACHMENT = newPMAttachment;
                        home.dbContext.PMTEMPLATES.AddOrUpdate(newPMTemplate);
                        home.dbContext.SaveChanges();
                        MessageBox.Show("Saved Successfully!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Saving the new Template " + ex, "Error");
                    }
                }
            }
        }

    

        private void cancelButton_Click(object sender, EventArgs e)
        {

            Dispose();
            Close();
        }

        private void InsertNewPMTemp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<Home>().First().Controls.OfType<Panel>().Where(panel => panel.Name == "homeMainPanel").First().Refresh();

        }
    }
}
