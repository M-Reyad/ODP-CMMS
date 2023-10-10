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

namespace ODP2.Views.NIBs
{
    public partial class EquipmentRunningHoursView : UserControl
    {
        public EquipmentRunningHoursView(string eqID)
        {
            using (var dbContext = new ODPEntities_ORACLE())
            {

                InitializeComponent();
                equipmentLabel.Text = eqID;
                newRunningHours.Name = eqID;
                oldRunningHours.Text = dbContext.EQUIPMENTs.Where(eq => eq.EQUIPMENTID.Trim() == eqID.Trim()).First().EQUIPMENTHR.ToString(); ;
            }
        }

        private void EquipmentRunningHoursView_Load(object sender, EventArgs e)
        {

        }

    }
}
