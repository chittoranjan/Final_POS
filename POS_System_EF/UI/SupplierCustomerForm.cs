﻿using POS_System_EF.EntityModels;
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
        private bool isDelete = false;

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
                    if (txtCodeManual.Text.Trim() != string.Empty)
                    {
                        supplier.Code = txtCodeManual.Text;
                    }
                    else
                    {
                        supplier.Code = txtPartyCode.Text;
                    }
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
                    aCustomer.Code = aCustomer.GenerateCode(aCustomer.Name);
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

            SetFormNewMode();

        }
        private string SetInvioceNo()
        {
            var countId = db.Suppliers.Count();
            countId++;
            if (countId <= 9)
            {
                string invNo = Convert.ToString("00" + countId);
                return invNo;
            }
            if (countId <= 99)
            {
                string invNo = Convert.ToString("0" + countId);
                return invNo;
            }
            else
            {
                string invNo = Convert.ToString(countId);
                return invNo;
            }
        }

        private string GenerateCodeCustomer()
        {
            var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeChars + "-" + SetInvioceNo();
        }
        private string SetInvioceNo1()
        {
            var countId = db.Customers.Count();
            countId++;
            if (countId <= 9)
            {
                string invNo = Convert.ToString("00" + countId);
                return invNo;
            }
            if (countId <= 99)
            {
                string invNo = Convert.ToString("0" + countId);
                return invNo;
            }
            else
            {
                string invNo = Convert.ToString(countId);
                return invNo;
            }
        }

        private string GenerateCodeSuppliers()
        {
            var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeChars + "-" + SetInvioceNo();
        }
        private void SetFormNewMode()
        {
            btnSave.Text = "Save";
            btnDelete.Visible = false;
            isDelete = false;
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
                            where c.Name.StartsWith(textSearch)&&c.IsDelete==false||c.Code.StartsWith(textSearch)&&c.IsDelete==false
                            ||c.ContactNo.StartsWith(textSearch)&&c.IsDelete==false||c.Email.StartsWith(textSearch)&&c.IsDelete==false
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
            var updateOutlet = db.Suppliers.FirstOrDefault(c => c.Id == selectedId);
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
                var supplierObj = db.Suppliers.FirstOrDefault(c => c.Id == s.Id);

                txtPartyName.Text = supplierObj.Name;
                txtAddress.Text = supplierObj.Address;
                txtContactNo.Text = supplierObj.ContactNo;
                txtPartyCode.Text = supplierObj.Code;
                txtEmail.Text = supplierObj.Email;

                SetFormUpdateMode();
            }
        }

        private void SetFormUpdateMode()
        {
            btnSave.Text = "Update";
            btnDelete.Visible = true;
            isDelete = true;
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
            txtPartyCode.Text = GenerateCodeSuppliers();
        }

        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomer.Checked)
            {
                chkSupplier.Checked = false;
            }
            txtPartyCode.Text = GenerateCodeCustomer();
        }

        
    }
}
