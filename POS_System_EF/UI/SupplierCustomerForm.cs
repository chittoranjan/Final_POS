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
    public partial class SupplierCustomerForm : Form
    {
        ManagerContext db = new ManagerContext();

        public SupplierCustomerForm()
        {
            InitializeComponent();
            LoadDataGridViewCustomr();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (chkSupplier.Checked)
                {
                    Supplier supplier = new Supplier();
                    supplier.Name = txtPartyName.Text;
                    supplier.ContactNo = txtContactNo.Text;
                    supplier.Email = txtEmail.Text;
                    supplier.Address = txtAddress.Text;
                    supplier.Code = supplier.GenerateCode(supplier.Name, supplier.Address, supplier.ContactNo);
                    supplier.IsDelete = false;
                    if (supplier.Id == 0)
                    {
                        db.Suppliers.Add(supplier);
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Successfully Saved");
                        }
                        else
                        {
                            MessageBox.Show("Save failed");
                        }
                    }
                    else
                    {
                        db.Entry(supplier).State = System.Data.Entity.EntityState.Modified;
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Successfully Updated");
                        }
                        else
                        {
                            MessageBox.Show("Went Wrong");
                        }
                    }

                    LoadDataGridViewSupplier();
                }
                else if (chkCustomer.Checked)
                {

                    Customer aCustomer = new Customer();
                    aCustomer.Name = txtPartyName.Text;
                    aCustomer.Email = txtEmail.Text;
                    aCustomer.ContactNo = txtContactNo.Text;
                    aCustomer.Address = txtAddress.Text;
                    aCustomer.Code = aCustomer.GenerateCode(aCustomer.Name, aCustomer.ContactNo);
                    aCustomer.IsDelete = false;
                    if (aCustomer.Id == 0)
                    {
                        db.Customers.Add(aCustomer);
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Successfully Saved");
                        }
                        else
                        {
                            MessageBox.Show("Save failed");
                        }
                    }
                    else
                    {
                        db.Entry(aCustomer).State = System.Data.Entity.EntityState.Modified;
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Successfully Updated");
                        }
                        else
                        {
                            MessageBox.Show("Went Wrong");
                        }
                    }

                    LoadDataGridViewCustomr();
                }
                else
                {
                    MessageBox.Show("Please select category!");
                    return;
                }


                ClearAllTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "Please fill text box!");
            }
        }

        private void ClearAllTextBox()
        {
            txtPartyName.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtPartyCode.Clear();
            txtAddress.Clear();
            chkCustomer.Checked = false;
            chkSupplier.Checked = false;

        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            LoadDataGridViewSupplier();
        }

        private void LoadDataGridViewSupplier()
        {

            var loadSuppliers = (from slr in db.Suppliers
                                where slr.IsDelete == false
                                select new
                                {
                                    slr.Id,
                                    slr.Name,
                                    slr.Code,
                                    slr.ContactNo,
                                    slr.Email,
                                    slr.Address
                                }).ToList();

            dataGridView.DataSource = loadSuppliers;
            dataGridView.Columns["Id"].Visible = false;
        }
        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            LoadDataGridViewCustomr();
        }

        private void LoadDataGridViewCustomr()
        {
            var loadCustomer = (from cmr in db.Customers
                where cmr.IsDelete == false
                select new
                {
                    cmr.Id,
                    cmr.Name,
                    cmr.Code,
                    cmr.ContactNo,
                    cmr.Email,
                    cmr.Address
                }).ToList();
            
            dataGridView.DataSource = loadCustomer;
            dataGridView.Columns["Id"].Visible = false;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm = new OpeningForm();
            //openingForm.Show();
            this.Hide();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            var customer = (from c in db.Customers
                            where c.Name.StartsWith(textSearch)
                            select new
                            {
                                c.Name,
                                c.Code,
                                c.ContactNo
                            }).ToList();
            dataGridView.DataSource = customer;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dataGridView.CurrentRow.Cells["Id"].Value;
            var updateOutlet = db.Suppliers.Where(c => c.Id == selectedId).FirstOrDefault();
            if (selectedId != 0)
            {
                updateOutlet.IsDelete = true;
                db.SaveChanges();
                MessageBox.Show("Successfully Deleted");
                LoadDataGridViewSupplier();
                ClearAllTextBox();
            }

        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                Supplier s = new Supplier();

                s.Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                var supplierObj = db.Suppliers.Where(c => c.Id == s.Id).FirstOrDefault();

                txtPartyName.Text = supplierObj.Name;
                txtAddress.Text = supplierObj.Address;
                txtContactNo.Text = supplierObj.ContactNo;
                txtPartyCode.Text = supplierObj.Code;

                btnSave.Text = "Update";
                btnDelete.Visible = true;
                btnDelete.Enabled = true;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            LoadDataGridViewCustomr();
        }

        private void chkSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSupplier.Checked)
            {
                chkCustomer.Checked = false;
            }
        }

        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomer.Checked)
            {
                chkSupplier.Checked = false;
            }
        }
    }
}
