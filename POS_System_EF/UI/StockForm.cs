using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            ComboBoxData();
        }

        private void ComboBoxData()
        {
            using (ManagerContext db = new ManagerContext())
            {
                var outlet = db.Outlets.ToList();
                cmbOutlet.DisplayMember = "Name";
                cmbOutlet.ValueMember = "Id";
                cmbOutlet.DataSource = outlet;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
