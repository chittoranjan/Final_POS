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
using POS_System_EF.EntityModels;
using System.Data.Entity;

namespace POS_System_EF.UI
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
            ComboBoxData();
            ClearTextBox();
        }
        ManagerContext db = new ManagerContext();
        DataTable table = new DataTable();
        List<TempPurchase> listPurchase=new List<TempPurchase>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Purchase purchase = new Purchase();
                purchase.ListOfPurchase = listPurchase;
                purchase.OutletId = (int)cmbOutlet.SelectedValue;
                purchase.PurchaseDate = dtpPurchase.Value;
                purchase.Remarks = txtRemarks.Text;
                purchase.EmployeeId = (int)cmbEmployee.SelectedValue;
                purchase.SupplierId = (int)cmbSupplier.SelectedValue;
                purchase.InvoiceNo = SetInvoiceNo();
                db.Purchases.Add(purchase);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Try Again !");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + "Please fill taxt box!");
            }
            
            ClearTextBox();
        }
        private int SetInvoiceNo()
        {
            int no = db.Purchases.Count();
            no= 100+ no++;
            return no;
        }
        private void ComboBoxData()
        {
            
            var item = db.Items.ToList();
            cmbItem.DataSource = item;
            cmbItem.DisplayMember = "Name";
            cmbItem.ValueMember = "Id";


            cmbOutlet.DataSource = db.Outlets.ToList();
            cmbOutlet.DisplayMember = "Name";
            cmbOutlet.ValueMember = "Id";


            cmbEmployee.DataSource = db.Employees.ToList();
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "Id";


            cmbSupplier.DataSource = db.Suppliers.ToList();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TempPurchase temp = new TempPurchase();
            temp.Name = cmbItem.Text;
            temp.Quantity = Convert.ToInt32(txtQty.Text);
            temp.CostPrice = Convert.ToDecimal(txtCostPrice.Text);
            temp.TotalPrice = temp.Quantity * temp.CostPrice;
            table.Rows.Add(temp.Name,temp.Quantity,temp.CostPrice,temp.TotalPrice);
            //temp.listOfPurchase.Add(temp);
            listPurchase.Add(temp);
            dgvPurchaseList.DataSource = table;
            ClearTextBox();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {

            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Quantiy", typeof(int));
            table.Columns.Add("Cost Price", typeof(decimal));
            table.Columns.Add("Total Price", typeof(decimal));
            dgvPurchaseList.DataSource = table;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (dgvPurchaseList.SelectedRows.Count> 0)
            {
                dgvPurchaseList.Rows.RemoveAt(dgvPurchaseList.SelectedRows[0].Index);
            }
        }

      

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void dgvPurchaseList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            cmbItem.Text = dgvPurchaseList.CurrentRow.Cells[0].Value.ToString();
            txtQty.Text = dgvPurchaseList.CurrentRow.Cells[1].Value.ToString();
            txtCostPrice.Text = dgvPurchaseList.CurrentRow.Cells[2].Value.ToString();
        }
        private void ClearTextBox()
        {
            txtQty.Clear();
            txtCostPrice.Clear();
            cmbItem.Text = null;
            txtQty.Clear();
            txtCostPrice.Clear();
            cmbEmployee.Text = null;
            cmbOutlet.Text = null;
            cmbSupplier.Text = null;
            txtRemarks.Clear();
        }
    }
}
