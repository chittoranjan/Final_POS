using POS_System_EF.EntityModels;
using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        private bool isUpdateMode = false;

        public EmployeeForm()
        {
            InitializeComponent();
            ComboBoxData();
            LoadDataGridView();
            AutoCodeShow();
        }

        private void ComboBoxData()
        {
            var cmbLoad = (from org in db.Organizations
                           where (org.IsDelete == false)
                           select new
                           {
                               org.Id,
                               org.Name,

                           }).ToList();
            cmbOrg.DataSource = cmbLoad;
            cmbOrg.DisplayMember = "Name";
            cmbOrg.ValueMember = "Id";
            cmbOrg.SelectedIndex = -1;
        }

        private void cmbOrg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbOrg.SelectedValue != null)
            {
                var cmboutletdata = (from outlet in db.Outlets
                    where outlet.OrganizationId == (int) cmbOrg.SelectedValue && outlet.IsDelete==false
                    select new
                    {
                        outlet.Id,
                        outlet.Name
                    }).ToList();

                cmbOutlet.DataSource = cmboutletdata;
            }
            cmbOutlet.DisplayMember = "Name";
            cmbOutlet.ValueMember = "Id";
            cmbOutlet.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            var dgvShow = (from emp in db.Employees
                join outlet in db.Outlets on emp.OutletId equals outlet.Id
                where emp.IsDelete==false
                select new
                {
                    emp.Id,
                    Organization=outlet.Organization.Name,
                    OutletName = outlet.Name,
                    emp.Name,
                    emp.Code,
                    emp.ContactNo,
                    emp.Email,
                    emp.NID,
                    emp.Image,
                    emp.JoiningDate,
                    emp.FathersName,
                    emp.MothersName,
                    emp.PresentAddress,
                    emp.PermanentAddress
                }).ToList();
            dataGridViewEmployee.DataSource = dgvShow;
            var dataGridViewColumn = dataGridViewEmployee.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
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
                if (!isUpdateMode)
                {
                    TextBoxValue();
                    bool isExistContactNo = db.Employees.Count(c => c.ContactNo == aEmployee.ContactNo) > 0;
                    bool isMailExist = db.Employees.Count(mail => mail.Email == aEmployee.Email) > 0;
                    if (isExistContactNo)
                    {
                        MessageBox.Show("Contact no already exist");
                        return;
                    }

                    if (isMailExist)
                    {
                        MessageBox.Show("Email Id already Exist");
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Are you sure want to Save ?", "Information", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.Employees.Add(aEmployee);
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Employee Save");
                        }
                        else
                        {
                            MessageBox.Show(" Save Failed");
                        }
                    }
                }
                if (isUpdateMode)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure want to update ?", "Information", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TextBoxValue();
                        db.Employees.Attach(aEmployee);
                        db.Entry(aEmployee).State = EntityState.Modified;
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Employee updated");
                        }
                        else
                        {
                            MessageBox.Show(" Update Failed");
                        }
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

        private void TextBoxValue()
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
            aEmployee.Image = aEmployee.Image;
            if (txtCodeManual.Text.Trim() != string.Empty)
            {
                aEmployee.Code = txtCodeManual.Text;
            }
            else
            {
                aEmployee.Code = txtCode.Text;
            }
        }

        private void ClearTextBoxAll()
        {
            txtName.Clear();
            txtNID.Clear();
            txtCode.Clear();
            txtCodeManual.Clear();
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
            SetFormNewMode();
        }

        private void SetFormNewMode()
        {
            btnDelete.Visible = false;
            btnSave.Text = "Save";
            isUpdateMode = false;
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
            LoadDataGridView();
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
                    emp.Id,
                    Organization = emp.Organization.Name,
                    OutletName = emp.Name,
                    emp.Name,
                    emp.Code,
                    emp.ContactNo,
                    emp.Email,
                    emp.NID,
                    emp.Image,
                    emp.JoiningDate,
                    emp.FathersName,
                    emp.MothersName,
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
                        emp.ContactNo.StartsWith(textSearch)||emp.Email.StartsWith(textSearch)||emp.PermanentAddress.StartsWith(textSearch)
                        || emp.Code.StartsWith(textSearch)
                    select new
                    {
                        emp.Id,
                        Organization = emp.Organization.Name,
                        OutletName = emp.Name,
                        emp.Name,
                        emp.Code,
                        emp.ContactNo,
                        emp.Email,
                        emp.NID,
                        emp.Image,
                        emp.JoiningDate,
                        emp.FathersName,
                        emp.MothersName,
                        emp.PresentAddress,
                        emp.PermanentAddress
                    }).ToList();
                dataGridViewEmployee.DataSource = organization;
            }
        }

        private void buttonSrcClear_Click(object sender, EventArgs e)
        {
            textBoxSrc.Clear();
            textBoxQuickSrc.Clear();
            ClearTextBoxAll();
            LoadDataGridView();
        }

        private void dataGridViewEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow != null)
            {
                int dgvIndex = (int) dataGridViewEmployee.CurrentRow.Cells["Id"].Value;
                var dgvObj = db.Employees.FirstOrDefault(c => c.Id == dgvIndex);

                aEmployee = dgvObj;
            }
            if (aEmployee!=null )
            {
                txtName.Text = aEmployee.Name;
                cmbOrg.SelectedValue = aEmployee.OrganizationId;
                cmbOutlet.SelectedValue = aEmployee.OutletId;
                dtpJoining.Value = aEmployee.JoiningDate;
                txtContactNo.Text = aEmployee.ContactNo;
                txtEmail.Text = aEmployee.Email;
                txtReference.Text = aEmployee.Reference;
                txtFathersName.Text = aEmployee.FathersName;
                txtMothersName.Text = aEmployee.MothersName;
                txtEmergencyContact.Text = aEmployee.EmergencyContactNo;
                txtNID.Text = aEmployee.NID;
                txtPresentAddress.Text = aEmployee.PresentAddress;
                txtPermanentAddress.Text = aEmployee.PermanentAddress;
                txtCode.Text=aEmployee.Code;
                if (aEmployee.Image != null)
                {
                    byte[] data = (byte[])aEmployee.Image;
                    MemoryStream ms = new MemoryStream(data);
                    pictureBoxEmp.Image = Image.FromStream(ms);
                    pictureBox.Image=Image.FromStream(ms);
                }
                else
                {
                    pictureBoxEmp.Image = null;
                    pictureBox.Image = null;
                }

                //print form load........

                txtShowEmpName.Text = aEmployee.Name;
                if (dataGridViewEmployee.CurrentRow != null)
                {
                    txtShowOrg.Text = dataGridViewEmployee.CurrentRow.Cells["Organization"].Value.ToString();
                    txtShowOutlet.Text = dataGridViewEmployee.CurrentRow.Cells["OutletName"].Value.ToString();
                }
                txtShowDate.Text = aEmployee.JoiningDate.ToShortDateString();
                txtShowContactNo.Text = aEmployee.ContactNo;
                txtShowEmail.Text = aEmployee.Email;
                txtShowRef.Text = aEmployee.Reference;
                txtShowFatherName.Text = aEmployee.FathersName;
                txtShowMotherName.Text = aEmployee.MothersName;
                txtShowEmgContNo.Text = aEmployee.EmergencyContactNo;
                txtShowNID.Text = aEmployee.NID;
                txtShowPresentAddress.Text = aEmployee.PresentAddress;
                txtShowPermanentAddress.Text = aEmployee.PermanentAddress;
                txtShowCode.Text = aEmployee.Code;
            }
            SetFormUpdateMode();
        }

        private void SetFormUpdateMode()
        {
            btnDelete.Visible = true;
            btnSave.Text = "Update";
            isUpdateMode = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControlEmployee.SelectedIndex = 1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabControlEmployee.SelectedIndex = 0;
        }
        private string SetInvioceNo()
        {
            var countId = db.Employees.Count();
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
            txtCode.Text = firstThreeChars + "-" + SetInvioceNo();

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            AutoCodeShow();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)dataGridViewEmployee.CurrentRow.Cells["Id"].Value;
                aEmployee = db.Employees.FirstOrDefault(c => c.Id == id);
                if (aEmployee != null)
                {
                    aEmployee.IsDelete = true;
                    db.SaveChanges();
                }
            }
            ClearTextBoxAll();
            LoadDataGridView();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image i = pictureBox.Image;
            if (i != null)
            {
                float newWidth = i.Width * 30 / i.HorizontalResolution;
                float newHeight = i.Height * 30 / i.VerticalResolution;
                float widthFactor = newWidth / e.MarginBounds.Width;
                float heightFactor = newHeight / e.MarginBounds.Height;
                if (widthFactor > 1 | heightFactor > 1)
                {
                    if (widthFactor > heightFactor)
                    {
                        newWidth = newWidth / widthFactor;

                        newHeight = newHeight / widthFactor;
                    }
                    else
                    {
                        newWidth = newWidth / heightFactor;
                        newHeight = newHeight / heightFactor;
                    }
                }
                e.Graphics.DrawImage(i, 600, 80, (int)newWidth, (int)newHeight);
            }
            e.Graphics.DrawString("Organization Name       :  " + txtShowOrg.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 150));
            e.Graphics.DrawString("Outlet Name                   :  " + txtShowOutlet.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 200));
            e.Graphics.DrawString("Employee Name            :  " + txtShowEmpName.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 250));
            e.Graphics.DrawString("Code                                :  " + txtShowCode.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("Contact No                     :  " + txtShowContactNo.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 350));
            e.Graphics.DrawString("Email                               :  " + txtShowEmail.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 400));
            e.Graphics.DrawString("Reference                       :  " + txtShowRef.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 450));
            e.Graphics.DrawString("Joining Date                   :  " + txtShowDate.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 500));
            e.Graphics.DrawString("Father Name                   :  " + txtShowFatherName.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 550));
            e.Graphics.DrawString("Mother Name                  :  " + txtShowMotherName.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 600));
            e.Graphics.DrawString("Emergency Contact No :  " + txtShowEmgContNo.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 650));
            e.Graphics.DrawString("NID                                  :  " + txtShowNID.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 700));
            e.Graphics.DrawString("Present Address            :  " + txtShowPresentAddress.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 750));
            e.Graphics.DrawString("Permanent Address       :  " + txtShowPermanentAddress.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 800));

        }

    }
}
