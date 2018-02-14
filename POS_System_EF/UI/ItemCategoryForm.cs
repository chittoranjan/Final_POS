using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System_EF.EntityModels;
using POS_System_EF.Managers;

namespace POS_System_EF.UI
{
    public partial class ItemCategoryForm : Form
    {
        ManagerContext db = new ManagerContext();
        ItemCategory itemCategory = new ItemCategory();
        public ItemCategoryForm()
        {
            InitializeComponent();
            LoadDataGridView();
            HideRootCategory();
        }

        private void LoadCombobox()
        {
            var loadCategory = db.ItemCategories.ToList();
            cmbRootCategory.DataSource = loadCategory;
            cmbRootCategory.DisplayMember = "Name";
            cmbRootCategory.ValueMember = "Id";
            cmbRootCategory.SelectedIndex = -1;
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbRootCategory.Checked)
                {
                    
                    itemCategory.Name = txtName.Text;
                    itemCategory.Code = itemCategory.GenearateCodeRoot(itemCategory.Name);
                    itemCategory.Description = txtDescription.Text;
                    db.ItemCategories.Add(itemCategory);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Root Category saved!");
                    }
                    else
                    {
                        MessageBox.Show("Save failed!");
                    }
                    
                }
                else if (rbSubCategory.Checked)
                {
                    VisibleRootCategory();
                    itemCategory.CategoryId = (int)cmbRootCategory.SelectedValue;
                    itemCategory.Name = txtName.Text;
                    itemCategory.Code = itemCategory.GenearateCodeSub(itemCategory.Name);
                    itemCategory.Description = txtDescription.Text;
                    //itemCategory.listOfSubCategory.Add(itemCategory);
                    db.ItemCategories.Add(itemCategory);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Sub Category saved!");
                    }
                    else
                    {
                        MessageBox.Show("Save failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Category!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + "[NB] Operating system found error!");
            }
            LoadDataGridView();
            ClearAllTextBox();
        }

        private void VisibleRootCategory()
        {
            labeRootCat.Visible = true;
            cmbRootCategory.Visible = true;
        }

        private void ClearAllTextBox()
        {
            rbRootCategory.Checked = false;
            rbSubCategory.Checked = false;
            cmbRootCategory.SelectedIndex = -1;
            txtName.Clear();
            txtCode.Clear();
            txtDescription.Clear();
        }
        private void LoadDataGridView()
        {
            var dgvLoad = (from itemCategory in db.ItemCategories
                           select new
                           {
                               itemCategory.Id,
                               itemCategory.Name,
                               itemCategory.Code,
                               itemCategory.Description,
                               SubCategory= itemCategory.Category.Name
                           }).ToList();

            dgvCategoryList.DataSource = dgvLoad;
            dgvCategoryList.Columns["Id"].Visible = false;
        }
        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            //OpeningForm openingForm=new OpeningForm();
            //openingForm.Show();
            this.Hide();
        }

        private void HideRootCategory()
        {
            labeRootCat.Visible = false;
            cmbRootCategory.Visible = false;
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            ManagerContext db = new ManagerContext();
            var category = (from cat in db.ItemCategories
                                where cat.Name.StartsWith(textSearch)
                                select new
                                {
                                    cat.Name,
                                    cat.Code,
                                    cat.Description
                                }).ToList();
            dgvCategoryList.DataSource = category;
        }

        

        private void rbRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRootCategory.Checked)
            {
                rbSubCategory.Checked = false;
                cmbRootCategory.Visible = false;
            }
        }

        private void rbSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSubCategory.Checked)
            {
                cmbRootCategory.Visible = true;
                rbRootCategory.Checked = false;
                LoadCombobox();
            }
        }

        private void cmbRootCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbSubCategory.Checked)
            { 
            cmbRootCategory.DataSource = db.ItemCategories.Where(c => c.CategoryId == null).ToList();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            LoadDataGridView();
        }

        private void buttonSrcClear_Click(object sender, EventArgs e)
        {
            textBoxSrc.Clear();
            LoadDataGridView();
        }
    }
}
