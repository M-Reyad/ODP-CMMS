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
    public partial class EquipmentFamilyRunningHoursView : UserControl
    {
        public EquipmentFamilyRunningHoursView(string equipmentFamily,int equipmentCount)
        {

            InitializeComponent();
            equipmentFamilyLabel.Text = equipmentFamily.Trim();
            Height = (equipmentCount * 40 )+ 100;
        }

        private void EquipmentFamilyRunningHoursView_Load(object sender, EventArgs e)
        {

        }
    }
}
