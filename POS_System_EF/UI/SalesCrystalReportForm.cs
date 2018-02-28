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
                string name = cmbOutlets.Text;
                //DateTime FromDate = dtpFrom.Value.Date;
                //DateTime ToDate = dtpToDate.Value.Date;
                using (ManagerContext db = new ManagerContext())
                {
                    var outlet = db.Sales.Where(a => a.Outlet.Name == name).ToList();
                    if (name != null)
                    {
                        var Data = (from d in db.Sales
                                     //d in db.Sales.AsEnumerable().Where(a => a.SalesDate.Date >= FromDate && a.SalesDate.Date <= ToDate)
                                    join o in db.Outlets on d.OutletId equals o.Id
                                    join emp in db.Employees on d.EmployeeId equals emp.Id
                                    select new
                                    {
                                        d.InvoiceNo,
                                        d.Customer.Name,
                                        Outlet=d.Outlet.Name,
                                        Employee=d.Employee.Name,
                                        d.TotalAmount
                                        
                                    }).ToList();

                        dgvSales.DataSource = Data;
                        foreach (var t in Data)
                        {
                            txtTotalSale.Text = t.TotalAmount.ToString();
                        }
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

        private void txtSearchInvoice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (ManagerContext db = new ManagerContext())
                {
                    var Data = (from d in db.Sales
                                    //d in db.Sales.AsEnumerable().Where(a => a.SalesDate.Date >= FromDate && a.SalesDate.Date <= ToDate)
                                join o in db.Outlets on d.OutletId equals o.Id
                                join emp in db.Employees on d.EmployeeId equals emp.Id
                                where d.InvoiceNo.ToString().StartsWith(txtSearchInvoice.Text)
                                select new
                                {
                                    d.InvoiceNo,
                                    d.Customer.Name,
                                    Outlet = d.Outlet.Name,
                                    Employee = d.Employee.Name,
                                    d.TotalAmount

                                }).ToList();

                    dgvSales.DataSource = Data;
                    foreach (var t in Data)
                    {
                        txtTotalSale.Text = t.TotalAmount.ToString();
                    }
                    
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
