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
        private bool _isUpdateMode = false;
        public ItemCategoryForm()
        {
            InitializeComponent();
            LoadDataGridView();
            HideRootCategory();
        }

        private void LoadCombobox()
        {
            var loadCategory = db.ItemCategories.Where(c => c.CategoryId == null && c.IsDelete==false).ToList();
            cmbRootCategory.DataSource = loadCategory;
            cmbRootCategory.DisplayMember = "Name";
            cmbRootCategory.ValueMember = "Id";
            cmbRootCategory.SelectedIndex = -1;
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty && txtDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill text box !");
                return;
            }
            try
            {
                if (!_isUpdateMode)
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
                            itemCategory.CategoryId = (int) cmbRootCategory.SelectedValue;
                            itemCategory.Name = txtName.Text;
                            itemCategory.Code = itemCategory.GenearateCodeSub(itemCategory.Name);
                            itemCategory.Description = txtDescription.Text;
                            //itemCategory.listOfSubCategory.Add(itemCategory);

                            DialogResult dialogResult = MessageBox.Show("Are you sure want to save ?", "Information",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.Yes)
                            {
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
                }

                if (_isUpdateMode)
                {
                    TextBoxValue();

                    if (rbRootCategory.Checked)
                    {   
                        itemCategory.CategoryId = null;
                        itemCategory.Name = txtName.Text;
                        itemCategory.Code = itemCategory.GenearateCodeRoot(itemCategory.Name);
                        itemCategory.Description = txtDescription.Text;
                        db.SaveChanges();
                       
                    }
                    else if (rbSubCategory.Checked)
                    {
                        VisibleRootCategory();
                        itemCategory.CategoryId = (int)cmbRootCategory.SelectedValue;
                        itemCategory.Name = txtName.Text;
                        itemCategory.Code = itemCategory.GenearateCodeSub(itemCategory.Name);
                        itemCategory.Description = txtDescription.Text;                                           
                        db.SaveChanges();                                              

                    }
                    else
                    {
                        MessageBox.Show("Please Select Category!");
                    }

                    DialogResult dialogResult = MessageBox.Show("Are you sure want to update ?", "Information", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.ItemCategories.Attach(itemCategory);
                        db.Entry(itemCategory).State = System.Data.Entity.EntityState.Modified;
                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show(" updated");
                        }
                        else
                        {
                            MessageBox.Show(" failed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + " Find system error! ", MessageBoxIcon.Warning.ToString());
            }
            LoadDataGridView();
            ClearAllTextBox();
            SetFormNewMode();
            HideRootCategory();
        }

        private void SetFormNewMode()
        {
            btnSaveCategory.Text = "Save";
            buttonDelete.Visible = false;
            _isUpdateMode = false;
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
        private void TextBoxValue()
        {

            itemCategory.Name = txtName.Text;
            itemCategory.Code = txtCode.Text;
            itemCategory.Description = txtDescription.Text;

        }
        private void LoadDataGridView()
        {
            var dgvLoad = (from itemCategory in db.ItemCategories
                           where (itemCategory.IsDelete == false)
                           select new
                           {
                               itemCategory.Id,
                               itemCategory.Name,
                               itemCategory.Code,
                               itemCategory.Description,
                               SubCategory = itemCategory.Category.Name
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
                            where cat.Name.StartsWith(textSearch) && cat.IsDelete == false || cat.Code.StartsWith(textSearch) && cat.IsDelete == false
                                select new
                                {
                                    cat.Name,
                                    cat.Code,
                                    cat.Description,
                                }).ToList();
            dgvCategoryList.DataSource = category;
        }

        private void rbRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRootCategory.Checked)
            {
                HideRootCategory();
            }
        }

        private void rbSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSubCategory.Checked)
            {
                VisibleRootCategory();
                LoadCombobox();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            LoadDataGridView();
            HideRootCategory();
        }

        private void buttonSrcClear_Click(object sender, EventArgs e)
        {
            textBoxSrc.Clear();
            LoadDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)dgvCategoryList.CurrentRow.Cells["Id"].Value;
                itemCategory = db.ItemCategories.FirstOrDefault(c => c.Id == id);
                if (itemCategory != null)
                {
                    itemCategory.IsDelete = true;
                    db.SaveChanges();
                    MessageBox.Show("Successfully deleted");
                }
            }
            ClearAllTextBox();
            LoadDataGridView();
            SetFormNewMode();
            HideRootCategory();

        }

        private void dgvCategoryList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCategoryList.CurrentRow != null)
            {
                int itemCategoryId = Convert.ToInt32(dgvCategoryList.CurrentRow.Cells["Id"].Value);
                var itemCategoryRetrive = db.ItemCategories.FirstOrDefault(c => c.Id == itemCategoryId);
                itemCategory = itemCategoryRetrive;

                if (itemCategory != null)
                {
                    txtName.Text = itemCategory.Name;

                    txtCode.Text = itemCategory.Code;
                    txtDescription.Text = itemCategory.Description;
                }

                SetFormUpdateMode();
            }
        }
        private void SetFormUpdateMode()
        {
            btnSaveCategory.Text = "Update";
            buttonDelete.Visible = true;
            _isUpdateMode = true;
        }
    }
}
