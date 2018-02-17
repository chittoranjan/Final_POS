using POS_System_EF.EntityModels;
using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class OutletForm : Form
    {
        ManagerContext db = new ManagerContext();
        Outlet _outlet = new Outlet();
        private bool _isUpdateMode = false;
        public OutletForm()
        {
            InitializeComponent();
            ComboBoxData();
            LoadDataGridView();
        }
        private void ComboBoxData()
        {
            var dgvShow = (from org in db.Organizations
                           where (org.IsDelete == false)
                           select new
                           {
                               org.Id,
                               org.Name,

                           }).ToList();
            cmbOrganizationName.DataSource = dgvShow;
            cmbOrganizationName.DisplayMember = "Name";
            cmbOrganizationName.ValueMember = "Id";
            cmbOrganizationName.SelectedIndex = -1;
        }
        private void LoadDataGridView()
        {
            var aOutlet = (from outlet in db.Outlets.Where(a => a.IsDelete == false)
                           join org in db.Organizations on outlet.OrganizationId equals org.Id
                           select new
                           {

                               outlet.Id,
                               Organization = org.Name,
                               Outlet=outlet.Name,
                               outlet.Code,
                               outlet.ContactNo,
                               outlet.Address
                           }).ToList();
            dgvOutlet.DataSource = aOutlet;
            var dataGridViewColumn = dgvOutlet.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxOutletName.Text.Trim()==string.Empty && txtContactNo.Text.Trim()==string.Empty && txtAddress.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please fill text box !");
                return;
            }
            int no;
            bool isInteger = int.TryParse(txtContactNo.Text.Trim(), out no);
            if (!isInteger)
            {
                MessageBox.Show("Mobile no invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContactNo.Clear();
                return;
            }
            try
            {
                if (!_isUpdateMode)
                {
                    TextBoxValue();
                    bool isExistContactNo = db.Outlets.Count(c => c.ContactNo == _outlet.ContactNo) > 0;
                    if (isExistContactNo)
                    {
                        MessageBox.Show("Contact no already exist");
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Are you sure want to save ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.Outlets.Add(_outlet);
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Outlet saved");

                        }
                        else
                        {
                            MessageBox.Show("Save failed");
                        }
                    }
                }

                if (_isUpdateMode)
                {
                    TextBoxValue();
                    bool isExistContactNo = db.Outlets.Count(c => c.ContactNo == _outlet.ContactNo) > 1;
                    if (isExistContactNo)
                    {
                        MessageBox.Show("Contact no already exist");
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Are you sure want to update ?", "Information", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.Outlets.Attach(_outlet);
                        db.Entry(_outlet).State = System.Data.Entity.EntityState.Modified;
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Outlet updated");
                        }
                        else
                        {
                            MessageBox.Show("Update failed");
                        }
                    }
                }

                LoadDataGridView();
                ClearTextBoxAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + " Find system error! ", MessageBoxIcon.Warning.ToString());
            }
            
        }

        private void TextBoxValue()
        {
            _outlet.OrganizationId = (int) cmbOrganizationName.SelectedValue;
            _outlet.Name = textBoxOutletName.Text;
            _outlet.ContactNo = txtContactNo.Text;
            _outlet.Address = txtAddress.Text;
            if (textCodeManual.Text.Trim() != string.Empty)
            {
                _outlet.Code = textCodeManual.Text;
            }
            else
            {
                _outlet.Code = txtOutletCode.Text;
            }
        }


        private void ClearTextBoxAll()
        {
            textBoxOutletName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtOutletCode.Clear();
            cmbOrganizationName.SelectedIndex = -1;
            SetFormNewMode();
        }

        private void SetFormNewMode()
        {
            btnDelete.Visible = false;
            btnSave.Text = "Save";
            _isUpdateMode = false;
        }
        private void AutoCodeShow()
        {
            int count = 1;
            count = db.Outlets.Include(c => c.Id).Count()+count;
            var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            txtOutletCode.Text = firstThreeChars + "-" + "00" + count.ToString();

        }
        private void textBoxOutletName_TextChanged(object sender, EventArgs e)
        {
            AutoCodeShow();
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm=new OpeningForm();
            //openingForm.Show();
            this.Hide();
        }

        private void txtQuickSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = txtQuickSrc.Text;
            if (textSearch.Length > 2)
            {
                ManagerContext db = new ManagerContext();
                var organization = (from outlet in db.Outlets
                    where
                        outlet.Name.StartsWith(textSearch) || outlet.Address.StartsWith(textSearch) ||
                        outlet.ContactNo.StartsWith(textSearch) || outlet.Code.StartsWith(textSearch)
                    select new
                    {
                        outlet.Id,
                        Organization = outlet.Organization.Name,
                        Outlet = outlet.Name,
                        outlet.Code,
                        outlet.ContactNo,
                        outlet.Address
                    }).ToList();
                dgvOutlet.DataSource = organization;
            }
        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            string textSearch = txtQuickSrc.Text;
            if (textSearch.Length > 2)
            {
                ManagerContext db = new ManagerContext();
                var organization = (from outlet in db.Outlets
                                    where
                                        outlet.Code.StartsWith(textSearch)
                                    select new
                                    {
                                        outlet.Id,
                                        Organization=outlet.Organization.Name,
                                        outlet.Name,
                                        outlet.Code,
                                        outlet.ContactNo,
                                        outlet.Address,
                                    }).ToList();
                dgvOutlet.DataSource = organization;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuickSrc.Clear();
            txtSearchCode.Clear();
            LoadDataGridView();
        }
        private void dgvOutlet_DoubleClick(object sender, EventArgs e)
        {
            if(dgvOutlet.CurrentRow != null )
            {
                int outId = Convert.ToInt32(dgvOutlet.CurrentRow.Cells["Id"].Value);
                var outletRetrive = db.Outlets.FirstOrDefault(c => c.Id == outId);
                _outlet = outletRetrive;

                if (_outlet != null)
                {
                    textBoxOutletName.Text = _outlet.Name;
                    txtAddress.Text = _outlet.Address;
                    txtContactNo.Text = _outlet.ContactNo;
                    txtOutletCode.Text = _outlet.Code;
                }

                SetFormUpdateMode();
            }
        }

        private void SetFormUpdateMode()
        {
            btnSave.Text = "Update";
            btnDelete.Visible = true;
            _isUpdateMode = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult==DialogResult.Yes)
            {
                int selectedId = (int)dgvOutlet.CurrentRow.Cells["Id"].Value;
                _outlet = db.Outlets.FirstOrDefault(c => c.Id == selectedId);
                if (_outlet!=null)
                {
                    _outlet.IsDelete = true;
                    db.Outlets.Add(_outlet);
                }
            }
            ClearTextBoxAll();
            LoadDataGridView();
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxAll();
        }
    }
}
