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
    public partial class OutletForm : Form
    {
        ManagerContext db = new ManagerContext();
        Outlet outlet = new Outlet();
        Organization org = new Organization();
        public OutletForm()
        {
            InitializeComponent();
            ComboBoxData();
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            outlet.OrganizationId = (int)cmbOrganizationName.SelectedValue;
            outlet.Name = textBoxOutletName.Text;
            outlet.ContactNo = txtContactNo.Text;
            outlet.Address = txtAddress.Text;
            outlet.Code = outlet.GenerateCode(outlet.Name, outlet.Address);
            outlet.IsDelete = false;
            bool IsExistContactNo = db.Outlets.Count(c => c.ContactNo == outlet.ContactNo) > 0;
            if(IsExistContactNo)
            {
                MessageBox.Show("Contact No Exist");
            }
            else
            {
                if(outlet.Id==0)
                {
                    db.Outlets.Add(outlet);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Saved");

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    db.Entry(outlet).State = System.Data.Entity.EntityState.Modified;
                    int count=db.SaveChanges();
                    if(count>0)
                    {
                        MessageBox.Show("Save Changed....! Updated");
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }

                }
            
            
            LoadDataGridView();
            ClearTextBoxAll();
        }

      
        private void ClearTextBoxAll()
        {
            textBoxOutletName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            txtOutletCode.Clear();
            cmbOrganizationName.SelectedIndex = -1;
        }

        private void ComboBoxData()
        {
            cmbOrganizationName.DataSource = db.Organizations.ToList();
            cmbOrganizationName.DisplayMember = "Name";
            cmbOrganizationName.ValueMember = "Id";
            cmbOrganizationName.SelectedIndex = -1;
        }
        private void LoadDataGridView()
        {
            var aOutlet = (from outlet in db.Outlets.Where(a=>a.IsDelete==false)
                           join org in db.Organizations on outlet.OrganizationId equals org.Id
                           select new
                           {

                               outlet.Id,
                               Organization = org.Name,
                               outlet.Name,
                                outlet.Code,
                                outlet.ContactNo,
                                outlet.Address
                            }).ToList();
                        dgvOutlet.DataSource = aOutlet;
            dgvOutlet.Columns["Id"].Visible = false;
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
            var outlet = (from o in db.Outlets
                                where o.Name.StartsWith(textSearch)|| o.Code.StartsWith(textSearch)
                                || o.Address.StartsWith(textSearch)|| o.ContactNo.StartsWith(textSearch)|| o.Organization.Name.StartsWith(textSearch)
                                select new
                                {
                                    o.Name,
                                    o.Code,
                                    o.ContactNo
                                }).ToList();
            dgvOutlet.DataSource = outlet;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearchCode.Text!=null)
            {
                var o = (from outlet in db.Outlets
                         where outlet.Code.StartsWith(txtSearchCode.Text)
                         select new
                         {
                             Outlet=outlet.Organization.Name,
                             outlet.Name,
                             outlet.Code,
                             outlet.Address,
                             outlet.ContactNo
                         }).ToList();
                dgvOutlet.DataSource = o;
            }
        }

        private void dgvOutlet_DoubleClick(object sender, EventArgs e)
        {
            if(dgvOutlet.CurrentRow.Index!=-1)
            {
                outlet.Id = Convert.ToInt32(dgvOutlet.CurrentRow.Cells["Id"].Value);
                outlet = db.Outlets.Where(c => c.Id == outlet.Id).FirstOrDefault();

                cmbOrganizationName.Text = org.Name;
                textBoxOutletName.Text = outlet.Name;
                txtAddress.Text = outlet.Address;
                txtContactNo.Text = outlet.ContactNo;
                txtOutletCode.Text = outlet.Code;

                btnSave.Text = "Update";
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to Delete this ","Pos System",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                //var selectOutlet = db.Entry(outlet);
                //outlet = db.Outlets.Where(c => c.Id == outlet.Id).FirstOrDefault();
                //if(selectOutlet.State==System.Data.Entity.EntityState.Detached)

                //    db.Outlets.Attach(outlet);
                //    db.Outlets.Remove(outlet);
                //    int count=db.SaveChanges();
                //if (count > 0)
                //{
                //    MessageBox.Show("Successfully Delete");
                //    LoadDataGridView();
                //    ClearTextBoxAll();
                //}
                //else
                //{
                //    MessageBox.Show("Something wrong");
                //}
                int selectedId = (int)dgvOutlet.CurrentRow.Cells["Id"].Value;
                var updateOutlet = db.Outlets.Where(c => c.Id == selectedId).FirstOrDefault();
                if(selectedId!=0)
                {
                    updateOutlet.IsDelete = true;
                    db.SaveChanges();
                    MessageBox.Show("Successfully Updated");
                    LoadDataGridView();
                    ClearTextBoxAll();
                }
                
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxAll();
        }
      
    }
}
