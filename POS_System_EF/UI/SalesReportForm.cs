using POS_System_EF.EntityModels;
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
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            ManagerContext db = new ManagerContext();
            var salesList = (from s in db.Sales
                             join o in db.Outlets on s.OutletId equals o.Id
                             join emp in db.Employees on s.EmployeeId equals emp.Id
                             select new
                             {
                                 s.Id,
                                 s.InvoiceNo,
                                 s.Employee.Name,
                                 Outlet = s.Outlet.Name,
                                 Customer = s.CustomerName,
                                 Contact = s.CustomerContactNo
                             }).ToList();
            dgvSalesList.DataSource = salesList;
            dgvSalesList.Columns["Id"].Visible = false;


            itemListView.View = View.Details;
            itemListView.GridLines = true;
            itemListView.FullRowSelect = true;

            //Add column header
            itemListView.Columns.Add("Product Name", 200);
            itemListView.Columns.Add("Quantity", 100);
            itemListView.Columns.Add("CostPrice", 100);
            itemListView.Columns.Add("TotalPrice", 100);

        }

        private void dgvSalesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = (int)dgvSalesList.CurrentRow.Cells["Id"].Value;
            if (dgvSalesList.SelectedRows.Count > 0)
            {
                lblInvoice.Visible = true;
                lblOutlet.Visible = true;
                lblCustomerName.Visible = true;
                lblContact.Visible = true;
                txtInvoiceNo.Visible = true;
                txtOutletName.Visible = true;
                txtCustomerName.Visible = true;
                txtContactNo.Visible = true;
                txtInvoiceNo.Text = dgvSalesList.SelectedRows[0].Cells[1].Value.ToString();
                txtOutletName.Text = dgvSalesList.SelectedRows[0].Cells[3].Value.ToString();
                txtCustomerName.Text = dgvSalesList.SelectedRows[0].Cells[2].Value.ToString();
                txtContactNo.Text = dgvSalesList.SelectedRows[0].Cells[5].Value.ToString();



                ManagerContext db = new ManagerContext();
                List<SalesItem> listOfSalesItem = db.SalesItem.Where(c => c.Id == selectedId).ToList();
                string[] item = new string[4];
                ListViewItem itms;
                itemListView.Items.Clear();
                foreach (var i in listOfSalesItem)
                {
                    item[0] = i.SalesItemName;
                    item[1] = i.Quantity.ToString();
                    item[2] = i.SalePrice.ToString();
                    item[3] = i.LineTotal.ToString();
                    itms = new ListViewItem(item);
                    itemListView.Items.Add(itms);
                }
                btnPdf.Visible = true;
                btnPdf.Enabled = true;
            }
        }
    }
}
