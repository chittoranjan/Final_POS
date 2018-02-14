using POS_System_EF.EntityModels;
using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class EmployeeForm : Form
    {
        private ManagerContext db = new ManagerContext();
        private Employee aEmployee = new Employee();

        public EmployeeForm()
        {
            InitializeComponent();
            ComboBoxData();
            LoadDataGridView();
        }

        private void ComboBoxData()
        {
            cmbOrg.DataSource = db.Organizations.ToList();
            cmbOrg.DisplayMember = "Name";
            cmbOrg.ValueMember = "Id";
            cmbOrg.SelectedIndex = -1;
        }

        private void cmbOrg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbOrg.SelectedValue != null)
            {
                var cmboutletdata = (from outlet in db.Outlets
                    where outlet.OrganizationId == (int) cmbOrg.SelectedValue
                    select outlet);

                cmbOutlet.DataSource = cmboutletdata.ToList();
            }
            cmbOutlet.DisplayMember = "Name";
            cmbOutlet.ValueMember = "Id";
            cmbOutlet.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            var dgvShow = (from emp in db.Employees
                join outlet in db.Outlets on emp.OutletId equals outlet.Id
                select new
                {
                    emp.Id,
                    OutletName = outlet.Name,
                    emp.Name,
                    emp.Code,
                    emp.ContactNo,
                    emp.Email,
                    emp.Image,
                    emp.JoiningDate,
                    emp.FathersName,
                    emp.MothersName,
                    emp.PresentAddress,
                    emp.PermanentAddress
                }).ToList();
            dataGridViewEmployee.DataSource = dgvShow;
            dataGridViewEmployee.Columns["Id"].Visible = false;
            for (int i = 0; i < dataGridViewEmployee.Columns.Count; i++)
            {
                var column = dataGridViewEmployee.Columns[i] as DataGridViewImageColumn;
                if (column == null) continue;
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                break;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                aEmployee.Name = txtName.Text;

                aEmployee.OrganizationId = (int) cmbOrg.SelectedValue;
                aEmployee.OutletId = (int) cmbOutlet.SelectedValue;
                aEmployee.JoiningDate = dtpJoining.Value;
                aEmployee.ContactNo = txtContactNo.Text;
                aEmployee.Email = txtEmail.Text;
                aEmployee.Reference = txtReference.Text;
                aEmployee.FathersName = txtFathersName.Text;
                aEmployee.MothersName = txtMothersName.Text;
                aEmployee.EmergencyContactNo = txtEmergencyContact.Text;
                aEmployee.NID = txtNID.Text;
                aEmployee.PresentAddress = txtPresentAddress.Text;
                aEmployee.PermanentAddress = txtPermanentAddress.Text;
                aEmployee.Code = aEmployee.GenerateCode(aEmployee.Name, aEmployee.ContactNo);
                aEmployee.Image = aEmployee.Image;
                bool IsExistContactNo = db.Employees.Count(c => c.ContactNo == aEmployee.ContactNo) > 0;
                bool IsMailExist = db.Employees.Count(mail => mail.Email == aEmployee.Email) > 0;
                if (IsExistContactNo)
                {
                    MessageBox.Show("Contact No Exist.......Try Another one");
                }

                else if (IsMailExist)
                {
                    MessageBox.Show("Email Exist");
                }
                else
                {
                    db.Employees.Add(aEmployee);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Employee Saved");
                    }
                    else
                    {
                        MessageBox.Show(" Save Failed");
                    }

                }

                LoadDataGridView();
                ClearTextBoxAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + "Pleas fill taxt box!");
            }

        }

        private void ClearTextBoxAll()
        {
            txtName.Clear();
            txtNID.Clear();
            txtCode.Clear();
            cmbOrg.SelectedIndex = -1;
            cmbOutlet.SelectedIndex = -1;
            txtContactNo.Clear();
            txtEmail.Clear();
            txtReference.Clear();
            txtFathersName.Clear();
            txtMothersName.Clear();
            txtEmergencyContact.Clear();
            txtPresentAddress.Clear();
            txtPermanentAddress.Clear();
            dtpJoining.ResetText();
            pictureBoxEmp.Image = null;
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string logo = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPG Files (*.Jpg)|*.JPG|GIF Files(*.gif)|*.GIF|All Files(*.*)|*.*";
                openFileDialog.FileName = "Upload Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    logo = openFileDialog.FileName;
                    pictureBoxEmp.ImageLocation = logo;
                }
                FileStream fs = new FileStream(logo, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                aEmployee.Image = br.ReadBytes((int) fs.Length);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + "Image format is not valid");
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pictureBoxEmp.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxAll();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm=new OpeningForm();
            //openingForm.Show();
            this.Hide();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            ManagerContext db = new ManagerContext();
            var employees = (from emp in db.Employees
                where emp.Code.StartsWith(textSearch)
                select new
                {
                    emp.Name,
                    emp.Code,
                    emp.ContactNo,
                    emp.FathersName,
                    emp.MothersName,
                    emp.NID,
                    emp.PresentAddress,
                    emp.PermanentAddress
                }).ToList();
            dataGridViewEmployee.DataSource = employees;
        }

        private void textBoxQuickSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxQuickSrc.Text;
            if (textSearch.Length > 2)
            {
                ManagerContext db = new ManagerContext();
                var organization = (from emp in db.Employees
                    where
                        emp.Name.StartsWith(textSearch) || emp.NID.StartsWith(textSearch) ||
                        emp.ContactNo.StartsWith(textSearch)
                        || emp.Code.StartsWith(textSearch)
                    select new
                    {
                        emp.Name,
                        emp.Code,
                        emp.ContactNo,
                        emp.FathersName,
                        emp.MothersName,
                        emp.NID,
                        emp.PresentAddress,
                        emp.PermanentAddress
                    }).ToList();
                dataGridViewEmployee.DataSource = organization;
            }


        }

        private void buttonSrcClear_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            ClearTextBoxAll();
        }
    }
}
