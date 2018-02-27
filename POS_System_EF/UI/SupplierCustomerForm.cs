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
        CustomerAndSupplier customerAndSupplier = new CustomerAndSupplier();
        private bool isUpdateMode = false;

        public SupplierCustomerForm()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!isUpdateMode)
                {
                    GetTextBoxValue();


                    db.CustomerAndSuppliers.Add(customerAndSupplier);
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


                if (isUpdateMode)
                {
                    GetTextBoxValue();
                    db.CustomerAndSuppliers.Attach(customerAndSupplier);
                    db.Entry(customerAndSupplier).State = System.Data.Entity.EntityState.Modified;
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Successfully Updated");
                    }
                    else
                    {
                        MessageBox.Show("Update failed");
                    }
                }

                LoadDataGridView();

                ClearAllTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "Please fill text box!");
            }
        }
        private void GetTextBoxValue()
        {
            customerAndSupplier.Name = txtPartyName.Text;
            customerAndSupplier.ContactNo = txtContactNo.Text;
            customerAndSupplier.Email = txtEmail.Text;
            customerAndSupplier.Address = txtAddress.Text;

            if (chkCustomer.Checked && chkSupplier.Checked)
            {
                string joinType = chkCustomer.Text + chkSupplier.Text;
                customerAndSupplier.Type = joinType;
            }
            else if (chkCustomer.Checked)
            {
                customerAndSupplier.Type = chkCustomer.Text;
            }
            else if (chkSupplier.Checked)
            {
                customerAndSupplier.Type = chkSupplier.Text;
            }
            else
            {
                MessageBox.Show("Please select a category !");
            }

            if (txtCodeManual.Text.Trim() != string.Empty)
            {
                customerAndSupplier.Code = txtCodeManual.Text;
            }
            else
            {
                customerAndSupplier.Code = txtPartyCode.Text;
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
        private string GenerateCode()
        {
            var firstThreeChars = "Party";
            return firstThreeChars + "-" + customerAndSupplier.SetInvioceNo();
        }

        private void txtPartyName_TextChanged(object sender, EventArgs e)
        {
            txtPartyCode.Text = GenerateCode();
        }
        private void SetFormNewMode()
        {
            btnSave.Text = "Save";
            btnDelete.Visible = false;
            isUpdateMode = false;
        }

        private void LoadDataGridView()
        {

            var loadData = (from c in db.CustomerAndSuppliers
                            where c.IsDelete == false
                            select new
                            {
                                c.Id,
                                c.Name,
                                c.Code,
                                c.ContactNo,
                                c.Email,
                                c.Type,
                                c.Address
                            }).ToList();

            dataGridView.DataSource = loadData;
            var dataGridViewColumn = dataGridView.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
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
            if (Equals(dataGridView.DataSource, db.CustomerAndSuppliers))
            {
                var srcData = (from c in db.CustomerAndSuppliers
                               where c.Name.StartsWith(textSearch) && c.IsDelete == false || c.Code.StartsWith(textSearch) && c.IsDelete == false
                               || c.ContactNo.StartsWith(textSearch) && c.IsDelete == false || c.Email.StartsWith(textSearch) && c.IsDelete == false
                               select new
                               {
                                   c.Id,
                                   c.Name,
                                   c.Code,
                                   c.ContactNo,
                                   c.Email,
                                   c.Type,
                                   c.Address
                               }).ToList();
                dataGridView.DataSource = srcData;
                dataGridView.Columns["Id"].Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int selectedId = (int)dataGridView.CurrentRow.Cells["Id"].Value;
                var updateOutlet = db.CustomerAndSuppliers.FirstOrDefault(c => c.Id == selectedId);
                if (updateOutlet != null)
                {
                    updateOutlet.IsDelete = true;
                    db.SaveChanges();
                    MessageBox.Show("Successfully Deleted");
                    LoadDataGridView();
                    ClearAllTextBox();
                }
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {

                var id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value);
                var updateObj = db.CustomerAndSuppliers.FirstOrDefault(c => c.Id == id);
                customerAndSupplier = updateObj;

                if (updateObj != null)
                {
                    txtPartyName.Text = updateObj.Name;
                    txtPartyCode.Text = updateObj.Code;
                    txtContactNo.Text = updateObj.ContactNo;
                    txtEmail.Text = updateObj.Email;
                    txtAddress.Text = updateObj.Address;
                    if (updateObj.Type == "CustomerSupplier")
                    {
                        chkCustomer.Checked = true;
                        chkSupplier.Checked = true;
                    }
                    else if (updateObj.Type == "Customer")
                    {
                        chkCustomer.Checked = true;
                    }
                    else if (updateObj.Type == "Supplier")
                    {
                        chkSupplier.Checked = true;
                    }
                }

                SetFormUpdateMode();
            }
        }
        private void SetFormUpdateMode()
        {
            btnSave.Text = "Update";
            btnDelete.Visible = true;
            isUpdateMode = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            LoadDataGridView();
        }

        private void btnSrcClear_Click(object sender, EventArgs e)
        {
            textBoxSrc.Clear();
            LoadDataGridView();
        }
    }
}
