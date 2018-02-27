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
            txtQty.Text = 1.ToString();
        }

        DataTable table = new DataTable();
        List<TempPurchase> listPurchase = new List<TempPurchase>();
        List<decimal> tamount = new List<decimal>();
        List<Stock> listofstock = new List<Stock>();
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
                    //Save Stock into Database
                    SaveStock();
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

        private void SaveStock()
        {
            
            try
            {
                using (ManagerContext db = new ManagerContext())
                {
                    foreach (Stock itemId in listofstock)
                    {
                        var IsAvailableItem = db.Stocks.FirstOrDefault(a => a.ItemId == itemId.ItemId);
                        var quantity = itemId.AvailableQuantity;

                        if (IsAvailableItem != null)
                        {
                            IsAvailableItem.AvailableQuantity += itemId.AvailableQuantity;
                        }
                        else
                        {
                            db.Stocks.AddRange(listofstock);
                        }
                    }

                    db.SaveChanges();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
                        lblTotalAmount.Text = tamount.Sum().ToString();
                        InStock(temp.ItemId, temp.Quantity, temp.CostPrice,cmbItem.Text);
                        ClearTextBox();
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
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
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
            try
            {
                ManagerContext db = new ManagerContext();
                var loadItem = db.Items.Where(i => i.IsDelete == false);

                cmbItem.DisplayMember = "CodeName";
                cmbItem.ValueMember = "Id";
                cmbItem.DataSource = loadItem.ToList();
                cmbItem.SelectedIndex = -1;




                cmbOutlet.DisplayMember = "Name";
                cmbOutlet.ValueMember = "Id";
                cmbOutlet.DataSource = db.Outlets.ToList();


                cmbEmployee.DisplayMember = "Name";
                cmbEmployee.ValueMember = "Id";
                cmbEmployee.DataSource = db.Employees.ToList();



                cmbSupplier.DisplayMember = "Name";
                cmbSupplier.ValueMember = "Id";
                cmbSupplier.DataSource = db.CustomerAndSuppliers.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            try
            {
                if (dgvPurchaseList.CurrentCell.ColumnIndex.Equals(4))
                    if (dgvPurchaseList.CurrentCell != null && dgvPurchaseList.CurrentCell.Value != null)
                    {
                        dgvPurchaseList.Rows.RemoveAt(e.RowIndex);
                        listofstock.RemoveAt(e.RowIndex);
                        tamount.RemoveAt(e.RowIndex);
                    }

                lblTotalAmount.Text = tamount.Sum().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void InStock(int itemId, int quantity, decimal price, string name)
        {
            try
            {
                Stock stock = new Stock();
                stock.ItemId = itemId;
                stock.ItemName = name;
                stock.AvailableQuantity = quantity;
                stock.AveragePrice = price;
                listofstock.Add(stock);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }

        

        private void cmbItem_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int cmbId;
                if (cmbItem.SelectedValue != null && cmbItem.Text != "")
                {
                    bool isValidItemId = int.TryParse(cmbItem.SelectedValue.ToString(), out cmbId);
                    if (isValidItemId)
                    {
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
                }


                if (string.IsNullOrEmpty(cmbItem.Text))
                {
                    txtCostPrice.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

 }
