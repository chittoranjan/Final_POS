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
using System.Data.Entity;

namespace POS_System_EF.UI
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            ComboBoxData();
        }
        DataTable table = new DataTable();
        List<SalesItem> listOfSalesItem=new List<SalesItem>();
        private void btnSalesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SalesItem item = new SalesItem();
                item.SalesItemName = cmbSalesItem.Text;
                item.Quantity = Convert.ToInt32(txtSalesQty.Text);
                item.SalePrice = Convert.ToDecimal(txtSaletPrice.Text);
                item.LineTotal = item.Quantity * item.SalePrice;
                table.Rows.Add(item.SalesItemName, item.Quantity, item.SalePrice, item.LineTotal);
                listOfSalesItem.Add(item);
                dgvSalesList.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetTotal(decimal lineTotalPrice)
        {
            
            txtTotalAmount.Text= lineTotalPrice.ToString();
        }

        private void ComboBoxData()
        {
            ManagerContext db = new ManagerContext();
            var itemName = db.TempPurchases.ToList();
            cmbSalesItem.DataSource = itemName;
            cmbSalesItem.DisplayMember = "Name";
            cmbSalesItem.ValueMember = "Id";

            cmbOutlet.DataSource = db.Outlets.ToList();
            cmbOutlet.DisplayMember = "Name";
            cmbOutlet.ValueMember = "Id";


            cmbEmployee.DataSource = db.Employees.ToList();
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "Id";
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Quantiy", typeof(int));
            table.Columns.Add("Cost Price", typeof(decimal));
            table.Columns.Add("Total Price", typeof(decimal));
            dgvSalesList.DataSource = table;
        }

        private void dgvSalesList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            cmbSalesItem.Text = dgvSalesList.CurrentRow.Cells[0].Value.ToString();
            txtSalesQty.Text = dgvSalesList.CurrentRow.Cells[1].Value.ToString();
            txtSaletPrice.Text = dgvSalesList.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvSalesList.SelectedRows.Count > 0)
            {
                dgvSalesList.Rows.RemoveAt(dgvSalesList.SelectedRows[0].Index);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void ClearTextBox()
        {

            cmbSalesItem.SelectedIndex = -1;
            txtSalesQty.Clear();
            txtSaletPrice.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbOutlet.Text = null;
            cmbEmployee.Text = null;
            txtCustomerName.Clear();
            txtContactNo.Clear();
            txtVat.Clear();
            txtDiscount.Clear();
            txtRemarks.Clear();
            txtSubTotal.Clear();
            txtTotalAmount.Clear();
            ClearTextBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Sale sales = new Sale();
                sales.InvoiceNo = "0000";
                sales.listOfItem = listOfSalesItem;
                sales.CustomerName = txtCustomerName.Text;
                sales.CustomerContactNo = txtContactNo.Text;
                sales.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
                sales.Vat = Convert.ToDecimal(txtVat.Text);
                sales.Remarks = txtRemarks.Text;
                sales.Discount = Convert.ToDecimal(txtDiscount.Text);
                sales.OutletId = (int)cmbOutlet.SelectedValue;
                sales.EmployeeId = (int)cmbEmployee.SelectedValue;
                ManagerContext db = new ManagerContext();
                db.Sales.Add(sales);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Sales Saved Success");
                }
                else
                {
                    MessageBox.Show("Operation Failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private decimal GetTotalAmount()
        {
            decimal total;
            total = 1000;
            return total;
        }

        private string GetInvoiceNo()
        {
            string InvoiceNo = "001";
            return InvoiceNo;
        }
    }
}
