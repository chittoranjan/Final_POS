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
    public partial class SalesCrystalReportForm : Form
    {
        public SalesCrystalReportForm()
        {
            InitializeComponent();
            ComboBoxData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                int SerialNo = 1;
                string name = cmbOutlets.Text;
                DateTime FromDate = dtpFrom.Value.Date;
                DateTime ToDate = dtpToDate.Value.Date;
                using (ManagerContext db = new ManagerContext())
                {
                    var outlet = db.Sales.Where(a => a.Outlet.Name == name).ToList();
                    if (name != null)
                    {
                        var Data = db.Sales.AsEnumerable().Where(a => a.SalesDate.Date >= FromDate && a.SalesDate.Date <= ToDate).ToList();
                        dgvSales.DataSource = Data;
                        dgvSales.Columns["Id"].Visible = false;

                        dgvSales.Columns["IsDelete"].Visible = false;
                        dgvSales.Columns["CustomerId"].Visible = false;
                        dgvSales.Columns["EmployeeId"].Visible = false;
                        dgvSales.Columns["Vat"].Visible = false;
                        dgvSales.Columns["SubTotal"].Visible = false;
                        dgvSales.Columns["Discount"].Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBoxData()
        {
            using (ManagerContext db = new ManagerContext())
            {
                var outlet = db.Outlets.ToList();
                cmbOutlets.DataSource = outlet;
                cmbOutlets.DisplayMember = "Name";
                cmbOutlets.ValueMember = "Id";
            }
        }
    }
}
