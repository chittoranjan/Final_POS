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
    public partial class OrganizationForm : Form
    {
        ManagerContext db=new ManagerContext();
        Organization org=new Organization();
        private bool IsUpdateMode = false;
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
                               Id = org.Id,
                               org.Name,
                               org.Code,
                               org.ContactNo,
                               org.Address,
                               org.Logo
                           }).ToList();
            dgvOrganization.DataSource = dgvShow;
            
            dgvOrganization.Columns["Id"].Visible = false;
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
            try
            {
                org.Name = txtOranizationName.Text;
                org.ContactNo = txtContactNo.Text;
                org.Address = txtAddress.Text;
                org.IsDelete = false;
                org.Logo = org.Logo;
                if (txtCodeManual.Text==null)
                {
                    org.Code = txtCodeManual.Text;
                }
                else
                {
                    org.Code = txtOrgnizationCode.Text;
                }
                
                bool isContactNoExist = db.Organizations.Count(c => c.ContactNo == org.ContactNo) > 0;
                if(isContactNoExist)
                {
                    MessageBox.Show("Contact No Allready Exist");
                }
                else
                {
                    //Insert Data
                    if(org.Id==0)
                    {

                        db.Organizations.Add(org);
                        int result =db.SaveChanges();
                        if(result>0)
                        {
                            MessageBox.Show("Saved Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Save failed");
                        }
                    }
                    //Update Operation
                    else
                    {
                        db.Entry(org).State = EntityState.Modified;
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Save Changed !");
                        
                        }
                    else
                    {
                        MessageBox.Show("Save failed");
                    }
                }
                    
                    LoadDataGridView();
                    ClearTextBoxAll();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + " Please fill text Box!");
            }
            
        }

        private void ClearTextBoxAll()
        {
            txtOranizationName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtOrgnizationCode.Clear();
            txtCodeManual.Clear();
            txtOrgnizationCode.Clear();
            pictureBoxOrg.Image = null;
            btnSave.Text = "Save";
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
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
            if(textSearch.Length>2)
            { 
            ManagerContext db = new ManagerContext();
            var organization = (from org in db.Organizations
                                where org.Name.StartsWith(textSearch) || org.Address.StartsWith(textSearch) || org.ContactNo.StartsWith(textSearch)
                                select new
                                {
                                    org.Name,
                                    org.Code,
                                    org.ContactNo
                                }).ToList();
            dgvOrganization.DataSource = organization;

            }

        }
        private void dgvOrganization_DoubleClick(object sender, EventArgs e)
        {
            

            if(dgvOrganization.CurrentRow.Index != -1)
            {
                
                org.Id = Convert.ToInt32(dgvOrganization.CurrentRow.Cells["Id"].Value);
                org = db.Organizations.Where(c => c.Id == org.Id).FirstOrDefault();

                txtOranizationName.Text = org.Name;
                txtAddress.Text = org.Address;
                txtContactNo.Text = org.ContactNo;
                txtOrgnizationCode.Text = org.Code;
                byte[] data=(byte[])org.Logo;
                MemoryStream ms = new MemoryStream(data);
                pictureBoxOrg.Image = Image.FromStream(ms);

                btnSave.Text = "Update";
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
                tpDisplay.Show();
                txtShowName.Text = org.Name;
                txtShowAddress.Text = org.Address;
                txtShowContact.Text = org.ContactNo;
                txtShowCode.Text = org.Code;
                byte[] logo = (byte[])org.Logo;
                MemoryStream msl = new MemoryStream(logo);
                pbOrg.Image = Image.FromStream(msl);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Record", "Pos System", MessageBoxButtons.YesNo) == DialogResult.Yes);
            int id = (int)dgvOrganization.SelectedRows[0].Cells["Id"].Value;
            org = db.Organizations.Where(c => c.Id == org.Id).FirstOrDefault();
            if(org != null)
            {
                org.IsDelete = true;
                db.SaveChanges();
                LoadDataGridView();
                ClearTextBoxAll();
            }


            //var selectOrg=db.Entry(org);
            //if (selectOrg.State == EntityState.Detached)
            //    db.Organizations.Attach(org);
            //db.Organizations.Remove(org);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearchCode!=null)
            {
                var searchOrg = (from org in db.Organizations
                                 where org.Code.StartsWith(txtSearchCode.Text)
                                 select new
                                 {
                                     org.Id,
                                     org.Name,
                                     org.ContactNo,
                                     org.Code,
                                     org.Logo
                                 }).ToList();
                dgvOrganization.DataSource = searchOrg;
            }
        }

        private void AutoCodeShow()
        {
            int count = 1;
            count = db.Organizations.Include(c => c.Id).Count()+count;
            var firstThreeChars = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            txtOrgnizationCode.Text=firstThreeChars+"-"+ "00"+count.ToString();

        }

        private void txtOranizationName_TextChanged(object sender, EventArgs e)
        {
            AutoCodeShow();
        }

       
    }
}
