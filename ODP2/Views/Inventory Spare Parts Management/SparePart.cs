using ODP2.Models;
using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views
{
    public partial class SparePart : Form
    {
        public Home home;
        public SPAREPART selectedSparePart;
        public SparePart(Home home, string sparePart)
        {
            this.home = home;
            MessageBox.Show(sparePart);
            if (home.dbContext.SPAREPARTs.Where(sp => sp.PARTCODE.Trim() == sparePart).Count() != 1)
            {
                MessageBox.Show("Error Finding Spare Part " + sparePart, "Error");
            }
            else
            {
                selectedSparePart = home.dbContext.SPAREPARTs.Where(sp => sp.PARTCODE.Trim() == sparePart).First();
            }
            InitializeComponent();
        }

        private void SparePart_Load(object sender, System.EventArgs e)
        {
            sparePartBindingSource.DataSource = selectedSparePart;
        }
    }
}
