using POS_System_EF.EntityModels;
using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.codec;

namespace POS_System_EF.UI
{
    public partial class OrganizationForm : Form
    {
        ManagerContext db=new ManagerContext();
        private Organization org=new Organization();
        private bool _isUpdateMode = false;
        public OrganizationForm()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            var dgvShow = (from org in db.Organizations where(org.IsDelete==false)
                           select new
                           {
                               org.Id,
                               org.Name,
                               org.Code,
                               org.ContactNo,
                               org.Address,
                               org.Logo
                           }).ToList();
            dgvOrganization.DataSource = dgvShow;

            var dataGridViewColumn = dgvOrganization.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            for (int i = 0; i < dgvOrganization.Columns.Count; i++)
            {
                var column = dgvOrganization.Columns[i] as DataGridViewImageColumn;
                if (column == null) continue;
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                break;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOranizationName.Text.Trim()==string.Empty && txtContactNo.Text.Trim()==string.Empty && txtAddress.Text.Trim()==string.Empty)
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

                        bool isContactNoExist = db.Organizations.Count(c => c.ContactNo == org.ContactNo) > 0;
                        if (isContactNoExist)
                        {
                            MessageBox.Show("Contact No Allready Exist");
                            return;
                        }
                        DialogResult dialogResult=MessageBox.Show("Are you sure want to save ?", "Information", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
                        if (dialogResult==DialogResult.Yes)
                        {
                            db.Organizations.Add(org);
                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Organization saved Successfully");
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
                        bool isContactNoExist = db.Organizations.Count(c => c.ContactNo == org.ContactNo) > 1;
                        if (isContactNoExist )
                        {
                            MessageBox.Show("Contact No Allready Exist");
                            return;
                        }
                        DialogResult dialogResult=MessageBox.Show("Are you sure want to update ?", "Information", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.Organizations.Attach(org);
                            db.Entry(org).State = EntityState.Modified;
                            int count = db.SaveChanges();
                            if (count > 0)
                            {
                                MessageBox.Show("Organization updated");

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

                    MessageBox.Show(ex.Message + " \n" + " Find system error! ",MessageBoxIcon.Warning.ToString());
                } 
        }

        private void TextBoxValue()
        {
            org.Name = txtOranizationName.Text;
            org.ContactNo = txtContactNo.Text;
            org.Address = txtAddress.Text;
            org.Logo = org.Logo;
            if (txtCodeManual.Text.Trim() != string.Empty)
            {
                org.Code = txtCodeManual.Text;
            }
            else
            {
                org.Code = txtOrgnizationCode.Text;
            }
        }

        private void ClearTextBoxAll()
        {
            txtOranizationName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtOrgnizationCode.Clear();
            txtCodeManual.Clear();
            pictureBoxOrg.Image = null;
            SetFormNewMode();
        }

        private void SetFormNewMode()
        {
            _isUpdateMode = false;
            btnSave.Text = "Save";
            btnDelete.Visible = false;
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
                    pictureBoxOrg.ImageLocation = logo;
                }
                FileStream fs = new FileStream(logo, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                org.Logo = br.ReadBytes((int)fs.Length);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + "Image format is not valid");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxAll();
            
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pictureBoxOrg.Image = null;
            org.Logo = null;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm=new OpeningForm();
            //openingForm.Show();
            this.Hide();
        }
        private void textSrcQuick_TextChanged(object sender, EventArgs e)
        {

            string textSearch = textSrcQuick.Text;
            if(textSearch.Length>2)
            { 
                ManagerContext db = new ManagerContext();
                var organization = (from org in db.Organizations
                                    where org.Name.StartsWith(textSearch) && org.IsDelete == false || org.Address.StartsWith(textSearch) && org.IsDelete == false
                                    || org.ContactNo.StartsWith(textSearch) && org.IsDelete == false || org.Code.StartsWith(textSearch) && org.IsDelete == false
                                    select new
                                    {
                                        org.Id,
                                        org.Name,
                                        org.Code,
                                        org.ContactNo,
                                        org.Address,
                                        org.Logo
                                    }).ToList();
                dgvOrganization.DataSource = organization;
           }

        }
        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCode != null)
            {
                var searchOrg = (from org in db.Organizations
                                 where org.Code.StartsWith(txtSearchCode.Text)
                                 select new
                                 {
                                     org.Id,
                                     org.Name,
                                     org.Code,
                                     org.ContactNo,
                                     org.Address,
                                     org.Logo
                                 }).ToList();
                dgvOrganization.DataSource = searchOrg;
            }
        }
        private void btnSrcClear_Click(object sender, EventArgs e)
        {
            txtSearchCode.Clear();
            textSrcQuick.Clear();
            LoadDataGridView();
        }
        private void dgvOrganization_DoubleClick(object sender, EventArgs e)
        {
            if (dgvOrganization.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvOrganization.CurrentRow.Cells["Id"].Value);
                var orgRetrive = db.Organizations.FirstOrDefault(c => c.Id == id);
                org = orgRetrive;
                if (org != null)
                {
                    txtOranizationName.Text = org.Name;
                    txtAddress.Text = org.Address;
                    txtContactNo.Text = org.ContactNo;
                    txtOrgnizationCode.Text = org.Code;
                    if (org.Logo!=null)
                    {
                        byte[] data = (byte[])org.Logo;
                        MemoryStream ms = new MemoryStream(data);
                        pictureBoxOrg.Image = Image.FromStream(ms);
                        pbOrg.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pictureBoxOrg.Image = null;
                        pbOrg.Image = null;
                    }

                    SetFormUpdateMode();

                    tpDisplay.Show();
                    txtShowName.Text = org.Name;
                    txtShowAddress.Text = org.Address;
                    txtShowContact.Text = org.ContactNo;
                    txtShowCode.Text = org.Code;
                }
            }
         }

        private void SetFormUpdateMode()
        {
            btnSave.Text = "Update";
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            _isUpdateMode = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=MessageBox.Show("Are you sure want to delete ?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)dgvOrganization.SelectedRows[0].Cells["Id"].Value;
                org = db.Organizations.FirstOrDefault(c => c.Id == id);
                if (org != null)
                {
                    org.IsDelete = true;
                    db.SaveChanges();
                }
            }
            ClearTextBoxAll();
            LoadDataGridView();
        }

        private string SetInvioceNo()
        {
            var countId = db.Organizations.Count();
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
            txtOrgnizationCode.Text=firstThreeChars+"-"+ SetInvioceNo();

        }

        private void txtOranizationName_TextChanged(object sender, EventArgs e)
        {
            AutoCodeShow();
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
            Image i = pbOrg.Image;
            if (i!=null)
            {
                float newWidth = i.Width * 20 / i.HorizontalResolution;
                float newHeight = i.Height * 20 / i.VerticalResolution;
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
                e.Graphics.DrawImage(i, 600, 100, (int)newWidth, (int)newHeight);
            }
            e.Graphics.DrawString("Organization Name :  "+txtShowName.Text , new Font("Arial", 18, FontStyle.Bold) ,Brushes.Black, new Point(30, 150));
            e.Graphics.DrawString("Code                        :  "+ txtShowCode.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 200));
            e.Graphics.DrawString("Contact No              :  "+ txtShowContact.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 250));
            e.Graphics.DrawString("Address                   :  "+ txtShowAddress.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 300));

            
            //e.Graphics.DrawImage(bmp, 0, 0);
 
        }

        private void CaptureScreen()
        {
            //Graphics myGraphics = this.CreateGraphics();
            //bmp=new Bitmap(this.Size.Width, this.Size.Height,myGraphics);
            //Graphics memoryGraphics = Graphics.FromImage(bmp);
            //memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 10, 10, this.TabControlOrgPrint.Size);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }  
    }
}
