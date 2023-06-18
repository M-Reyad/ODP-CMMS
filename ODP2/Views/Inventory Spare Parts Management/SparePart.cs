using System.Linq;
using System.Windows.Forms;

namespace ODP2.Views
{
    public partial class SparePart : Form
    {
        public Home home;
        public SparePart()
        {
            InitializeComponent();
        }

        private void partCodeTextBox_Validated(object sender, System.EventArgs e)
        {
            if (partCodeTextBox.Text != "")
            {


                if (home.dbContext.spareParts.Where(part => part.partCode == partCodeTextBox.Text).Count() == 1)
                {
                    sparePartBindingSource.DataSource = home.dbContext.spareParts.Where(part => part.partCode == partCodeTextBox.Text).First();
                }
                else
                {
                    MessageBox.Show("Error Part Code, Please Enter a Valid Code", "Error");
                    partCodeTextBox.Focus();
                }
            }
            else
            {
                sparePartBindingSource.Clear();
            }
        }
    }
}
