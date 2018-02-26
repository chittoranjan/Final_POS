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

        private string SetInvioceNo()
        {
            var countId = db.Outlets.Count();
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
        private void AutoCodeShow()
        {
            var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            txtOutletCode.Text = firstThreeChars + "-" + SetInvioceNo();

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

                    //prin preview text box fill...

                    txtShowOrgName.Text = dgvOutlet.CurrentRow.Cells["Organization"].Value.ToString();
                    txtShowOutletName.Text = _outlet.Name;
                    txtShowOutletCode.Text = _outlet.Code;
                    txtShowContactNo.Text = _outlet.ContactNo;
                    txtShowAddress.Text = _outlet.Address;
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
            int id = (int)dgvOutlet.SelectedRows[0].Cells["Id"].Value;
            var updateOutlet = db.Outlets.FirstOrDefault(c => c.Id == id);
            if (updateOutlet != null)
            {
                _outlet = updateOutlet;
                updateOutlet.IsDelete = true;


                DialogResult result = MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        db.SaveChanges();
                        MessageBox.Show("Successfully deleted");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("You have clicked Cancel Button");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Delete failed");
            }
           
            LoadDataGridView();
            ClearTextBoxAll();
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxAll();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            //CaptureScreen();
            printPreviewDialog.ShowDialog();
        }
        private Bitmap bmp;

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Organization Name :  " + txtShowOrgName.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 150));
            e.Graphics.DrawString("Outlet Name             :  " + txtShowOutletName.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 200));
            e.Graphics.DrawString("Code                         :  " + txtShowOutletCode.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 250));
            e.Graphics.DrawString("Contact No               :  " + txtShowContactNo.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("Address                   :  " + txtShowAddress.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 350));


            //e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void CaptureScreen()
        {
            //Graphics myGraphics = this.CreateGraphics();
            //bmp=new Bitmap(this.Size.Width, this.Size.Height,myGraphics);
            //Graphics memoryGraphics = Graphics.FromImage(bmp);
            //memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 10, 10, this.TabControlOrgPrint.Size);
        }
    }
}
