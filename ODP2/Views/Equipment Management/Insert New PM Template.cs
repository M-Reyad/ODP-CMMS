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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            equipmentFamilyBindingSource.DataSource = home.dbContext.EQUIPMENTFAMILies.ToList();
            equipmentFamiliesBox_SelectedIndexChanged(sender, e);
        }
        private void equipmentFamiliesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFamily = equipmentFamiliesBox.GetItemText(equipmentFamiliesBox.SelectedItem).Trim();
            equipmentFamilyDirective.Text = home.dbContext.EQUIPMENTFAMILies.Where(eq => eq.EQUIPMENTFAMILYCODE.Trim() == selectedFamily).First().EQUIPMENTTYPEDIRECTIVE.Trim();
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
                    MessageBox.Show("Error Attaching pdf file" + ex.Message);
                }

            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (/*Empty Directive*/ pmDirective.Text == "")
            {
                MessageBox.Show("Please Insert a Valid Directive");
                pmDirective.Focus();
            }
            else if (newPMAttachment == null)
            {
                DialogResult recordWithoutAttach = MessageBox.Show("Are you sure to save the Template withouth Attachment?", "Missing Attachment", MessageBoxButtons.YesNo);
                if (recordWithoutAttach == DialogResult.Yes)
                {
                    recordNewTemplate();
                }
                else
                {
                    browseButton_Click(sender, e);
                }
            }
            else
            {
                if (home.dbContext.PMTEMPLATEs.Where(pm => pm.EQUIPMENTFAMILY.Trim() == selectedFamily).Count() != 0)
                {
                    if (isRegisteredPM(selectedFamily, pmDirective.Text.Trim()))
                    {
                        MessageBox.Show("This PM is registered Before, Kindly insert a different PM Directive");
                        pmDirective.Focus();
                    }
                    else
                    {
                        recordNewTemplate();
                    }
                }
                else
                {
                    recordNewTemplate();
                }
            }
        }
        private bool isRegisteredPM(string selectedFamily, string pmDirective)
        {
            foreach (PMTEMPLATE pm in home.dbContext.PMTEMPLATEs.Where(pm => pm.EQUIPMENTFAMILY.Trim() == selectedFamily))
            {
                if (pm.PMDIRECTIVE.Trim() == pmDirective)
                {
                    return true;
                }
            }
            return false;
        }
        private void recordNewTemplate()
        {
            try
            {
                PMTEMPLATE newPMTemplate = new PMTEMPLATE();
                newPMTemplate.EQUIPMENTFAMILY = selectedFamily;
                newPMTemplate.PMDIRECTIVE = pmDirective.Text.Trim();
                newPMTemplate.PMATTACHMENT = newPMAttachment;
                home.dbContext.PMTEMPLATEs.Add(newPMTemplate);
                home.dbContext.SaveChanges();
                MessageBox.Show("Saved Successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving the new Template " + ex.Message, "Error");
            }

        }
    }
}
