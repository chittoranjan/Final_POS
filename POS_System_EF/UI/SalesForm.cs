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
            ClearAllBox();
        }
        DataTable table = new DataTable();
        List<SalesItem> listOfSalesItem = new List<SalesItem>();
        List<decimal> totalAmount = new List<decimal>();

        private void btnSalesAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                SalesItem item = new SalesItem();
                item.SalesItemName = cmbSalesItem.Text;
                item.Quantity = Convert.ToInt32(txtSalesQty.Text);
                if (txtSalePrice.Text == "")
                {
                    item.SalePrice = Convert.ToDecimal(txtSalePriceRO.Text);
                }
                else
                {
                    item.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
                }


                using (ManagerContext db = new ManagerContext())
                {

                    var name = db.Items.Where(a => a.Name == item.SalesItemName).ToList();
                    if (name.Count == 0)
                    {
                        MessageBox.Show("Item Does Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        item.LineTotal = item.Quantity * item.SalePrice;
                        table.Rows.Add(item.SalesItemName, item.Quantity, item.SalePrice, item.LineTotal);
                        listOfSalesItem.Add(item);
                        totalAmount.Add(item.LineTotal);
                        dgvSalesList.DataSource = table;
                        ClearTextBox();
                        txtTotalAmount.Text = totalAmount.Sum().ToString();
                        txtSubTotal.Text = txtTotalAmount.Text;
                    }
                }
                txtDiscount.Text = 0.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ComboBoxData()
        {
            ManagerContext db = new ManagerContext();
            //var itemName = (from i in db.Items
            //                select new
            //                {
            //                    name=i.Name,
            //                    code=i.Code
            //                }).ToList();
            //cmbSalesItem.DataSource = itemName;
            var itemName = db.Items.ToList();
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

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnDelete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dgvSalesList.Columns.Add(btn);
        }
        private void dgvSalesList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //btnDelete.Visible = true;
            //btnDelete.Enabled = true;
            //cmbSalesItem.Text = dgvSalesList.CurrentRow.Cells[0].Value.ToString();
            //txtSalesQty.Text = dgvSalesList.CurrentRow.Cells[1].Value.ToString();
            //txtSaletPrice.Text = dgvSalesList.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void ClearTextBox()
        {

            cmbSalesItem.SelectedIndex = -1;
            txtSalesQty.Clear();
            txtSalePrice.Clear();
            txtSalesQty.Clear();
            txtSalePriceRO.Clear();
            txtStock.Clear();
        }
        private void button4_Click_1(object sender, EventArgs e)
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                Sale sales = new Sale();
                sales.InvoiceNo = GetInvoiceNo().ToString();
                sales.listOfItem = listOfSalesItem;

                sales.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
                sales.Vat = Convert.ToDecimal(lblVat.Text);
                sales.SalesDate = dtpSales.Value;
                sales.Remarks = txtRemarks.Text;
                sales.Discount = Convert.ToDecimal(txtDiscount.Text);

                sales.TotalAmount = sales.SubTotal + sales.Vat;
                sales.OutletId = (int)cmbOutlet.SelectedValue;
                sales.EmployeeId = (int)cmbEmployee.SelectedValue;

                if (lblCustomerId.Text == "")
                {
                    Customer cus = new Customer();
                    cus.ContactNo = txtContactNo.Text;
                    cus.Name = txtCustomerName.Text;
                    cus.Code = cus.GenerateCode(cus.Name);
                    using (ManagerContext db = new ManagerContext())
                    {
                        bool customerIdExist = db.Customers.Count(a => a.ContactNo == cus.ContactNo) > 0;
                        if (customerIdExist)
                        {
                            MessageBox.Show("This number is Exist");

                        }
                        else
                        {

                            db.Customers.Add(cus);
                            db.SaveChanges();
                            sales.CustomerId = db.Customers.Count();
                        }

                    }
                }
                else
                {

                    sales.CustomerId = Convert.ToInt32(lblCustomerId.Text);
                }


                using (ManagerContext db = new ManagerContext())
                {
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
                ClearAllBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int GetInvoiceNo()
        {
            ManagerContext db = new ManagerContext();
            int no = db.Sales.Count();
            no = 100 + no++;
            return no;
        }

        private void cmbSalesItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSalesQty.Text = 1.ToString();
                SalesItem item = new SalesItem();
                item.SalesItemName = cmbSalesItem.Text;
                using (ManagerContext db = new ManagerContext())
                {
                    var ObjItem = db.Items.FirstOrDefault(a => a.Name == item.SalesItemName);
                    if (ObjItem != null)
                    {
                        txtSalePriceRO.Text = ObjItem.SalePrice.ToString();
                    }

                }
                using (ManagerContext db = new ManagerContext())
                {
                    var purchaseObj = db.TempPurchases.FirstOrDefault(a => a.Name == item.SalesItemName);
                    if (purchaseObj != null)
                    {
                        txtStock.Text = purchaseObj.Quantity.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSalesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSalesList.CurrentCell.ColumnIndex.Equals(4))
                if (dgvSalesList.CurrentCell != null && dgvSalesList.CurrentCell.Value != null)
                {
                    dgvSalesList.Rows.RemoveAt(e.RowIndex);
                    totalAmount.RemoveAt(e.RowIndex);
                    listOfSalesItem.RemoveAt(e.RowIndex);
                }

            txtTotalAmount.Text = totalAmount.Sum().ToString();
            txtSubTotal.Text = txtTotalAmount.Text;
        }

        private void ClearAllBox()
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
            cmbSalesItem.SelectedIndex = -1;
            txtSalesQty.Clear();
            txtSalePrice.Clear();
            txtSalesQty.Clear();
            txtSalePriceRO.Clear();
            txtStock.Clear();
        }

        private void txtContactNo_Leave(object sender, EventArgs e)
        {
            using (ManagerContext db = new ManagerContext())
            {
                var customer = db.Customers.FirstOrDefault(a => a.ContactNo == txtContactNo.Text);
                if (customer != null)
                {
                    txtCustomerName.Text = customer.Name;
                    lblCustomerId.Text = customer.Id.ToString();
                    lblCustomerId.Hide();
                }
            }
        }

        private void txtVat_Leave(object sender, EventArgs e)
        {
            try
            {

                decimal TotalWithDiscount = Convert.ToDecimal(txtSubTotal.Text) - Convert.ToDecimal(txtDiscount.Text);
                double vat = Convert.ToDouble(txtSubTotal.Text) / Convert.ToDouble(txtVat.Text);
                lblVat.Text = vat.ToString();
                txtVat.Clear();
                decimal totalAmount = TotalWithDiscount + Convert.ToDecimal(vat);
                lblTotal.Text = totalAmount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
