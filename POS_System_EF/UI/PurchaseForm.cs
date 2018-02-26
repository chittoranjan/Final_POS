﻿using POS_System_EF.Managers;
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
using System.Globalization;

namespace POS_System_EF.UI
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
            //ClearTextBox();
            ComboBoxData();
        }

        DataTable table = new DataTable();
        List<TempPurchase> listPurchase = new List<TempPurchase>();
        List<decimal> tamount = new List<decimal>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerContext db = new ManagerContext();
                Purchase purchase = new Purchase();
                purchase.ListOfPurchase = listPurchase;
                purchase.OutletId = (int)cmbOutlet.SelectedValue;
                purchase.PurchaseDate = dtpPurchase.Value;
                purchase.Remarks = txtRemarks.Text;
                purchase.EmployeeId = (int)cmbEmployee.SelectedValue;
                purchase.SupplierId = (int)cmbSupplier.SelectedValue;
                purchase.InvoiceNo = SetInvoiceNo();
                purchase.TotalAmount = Convert.ToDecimal(lblTotalAmount.Text);
                db.Purchases.Add(purchase);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Saved Successfully");
                    InStock();
                    
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TempPurchase temp = new TempPurchase();
                temp.ItemId = (int)cmbItem.SelectedValue;
                temp.Quantity = Convert.ToInt32(txtQty.Text);
                temp.CostPrice = Convert.ToDecimal(txtCostPrice.Text);
                temp.TotalPrice = temp.Quantity * temp.CostPrice;
                using (ManagerContext db = new ManagerContext())
                {
                    var itemid = db.Items.Where(a => a.Id==temp.ItemId).ToList();
                    if(itemid.Count == 0)
                    {
                        MessageBox.Show("Item Does Not Found","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        table.Rows.Add(cmbItem.Text, temp.Quantity, temp.CostPrice, temp.TotalPrice);

                        listPurchase.Add(temp);
                        tamount.Add(temp.TotalPrice);
                        dgvPurchaseList.DataSource = table;
                        ClearTextBox();
                        lblTotalAmount.Text = tamount.Sum().ToString();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            GridViewColumAdd();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        //private string AutoCompleteData()
        //{
        //    using (ManagerContext db = new ManagerContext())
        //    {
        //        var item = from i in db.Items select i.Name;
        //        AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        //        collection.AddRange(item.ToArray());
        //        cmbItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        cmbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //        cmbItem.AutoCompleteCustomSource = collection;
        //        return collection.ToString();
        //    }

        //}

        private void GridViewColumAdd()
        {
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Quantiy", typeof(int));
            table.Columns.Add("Cost Price", typeof(decimal));
            table.Columns.Add("Total Price", typeof(decimal));
            dgvPurchaseList.DataSource = table;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnDelete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dgvPurchaseList.Columns.Add(btn);
        }

        
        private int SetInvoiceNo()
        {
            ManagerContext db = new ManagerContext();
            int no = db.Purchases.Count();
            no = 100 + no++;
            return no;
        }
        private void ComboBoxData()
        {
            ManagerContext db = new ManagerContext();
            var loadItem = db.Items.Where(i => i.IsDelete == false);
            cmbItem.DataSource = loadItem.ToList();
            cmbItem.DisplayMember = "Name";
            cmbItem.ValueMember = "Id";
            cmbItem.SelectedIndex = -1;
            


            
            cmbOutlet.DisplayMember = "Name";
            cmbOutlet.ValueMember = "Id";
            cmbOutlet.DataSource = db.Outlets.ToList();

            
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.DataSource = db.Employees.ToList();


            
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";
            cmbSupplier.DataSource = db.Suppliers.ToList();
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
            cmbItem.SelectedIndex = -1;
        }
      

        private void dgvPurchaseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPurchaseList.CurrentCell.ColumnIndex.Equals(4))
                if (dgvPurchaseList.CurrentCell != null && dgvPurchaseList.CurrentCell.Value != null)
                {
                    dgvPurchaseList.Rows.RemoveAt(e.RowIndex);
                    tamount.RemoveAt(e.RowIndex);
                }

            lblTotalAmount.Text = tamount.Sum().ToString();
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    var cmbId = (int)cmbItem.SelectedValue;
            //    using (ManagerContext db = new ManagerContext())
            //    {
            //        var objItem = db.Items.FirstOrDefault(a => a.Id == cmbId);

            //        if (objItem.Id > 0)
            //        {
            //            txtCostPrice.Text = objItem.CostPrice.ToString();
            //        }
            //        else
            //        {
            //            txtCostPrice.Clear();
            //        }
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void InStock()
        {
            Stock stock = new Stock();
            stock.ItemId = (int)listPurchase[0].ItemId;
            stock.AvailableQuantity = listPurchase[0].Quantity;
            using (ManagerContext db = new ManagerContext())
            {
                db.Stocks.Add(stock);
                db.SaveChanges();
            }
        }
        private void cmbItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                var cmbId = (int)cmbItem.SelectedValue;
                using (ManagerContext db = new ManagerContext())
                {
                    var objItem = db.Items.FirstOrDefault(a => a.Id == cmbId);

                    if (objItem.Id > 0)
                    {
                        txtCostPrice.Text = objItem.CostPrice.ToString();
                    }
                    else
                    {
                        txtCostPrice.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}