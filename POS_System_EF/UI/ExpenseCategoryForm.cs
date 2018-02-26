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

namespace POS_System_EF
{
    public partial class ExpenseCategoryForm : Form
    {
        ManagerContext db = new ManagerContext();
        ExpenseCategory expenseCategory = new ExpenseCategory();
        private bool _isUpdateMode = false;
        public ExpenseCategoryForm()
        {
            InitializeComponent();
            LoadCombobox();
            LoadDataGridView();
            RootCategoryVisibleFalse();
        }
        private void LoadCombobox()
        {
            var loadCategory = (from expenseCategory in db.ExpenseCategories
                                where expenseCategory.RootCategoryId == 0 && expenseCategory.IsDelete==false
                                select expenseCategory
                ).ToList();
           
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

                            expenseCategory.Name = txtName.Text;
                            if (txtCodeManual.Text.Trim() != string.Empty)
                            {

                                expenseCategory.Code = txtCodeManual.Text;
                            }
                            else
                            {
                                
                                expenseCategory.Code = txtCode.Text;
                            }
                            expenseCategory.Description = txtDescription.Text;
                            db.ExpenseCategories.Add(expenseCategory);
                            int count = db.SaveChanges();
                            if (count > 0)
                            {
                                MessageBox.Show("Root Category saved!");
                            }
                            else
                            {
                                MessageBox.Show("Save failed!");
                            }
                            LoadCombobox();
                        }
                        else if (rbSubCategory.Checked)
                        {

                            expenseCategory.RootCategoryId = (int)cmbRootCategory.SelectedValue;
                            expenseCategory.RootCategoryName = cmbRootCategory.Text;
                            expenseCategory.Name = txtName.Text;
                            if (txtCodeManual.Text.Trim() != string.Empty)
                            {
                                expenseCategory.Code = txtCodeManual.Text;
                            }
                            else
                            {
                                
                                expenseCategory.Code = txtCode.Text;
                            }
                            expenseCategory.Description = txtDescription.Text;
                            db.ExpenseCategories.Add(expenseCategory);
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
                    RootCategoryVisibleFalse();
                }

                if (_isUpdateMode)
                {
                    TextBoxValue();

                    if (rbRootCategory.Checked)
                    {
                        
                        expenseCategory.Name = txtName.Text;
                        if (txtCodeManual.Text.Trim() != string.Empty)
                        {
                            expenseCategory.Code = txtCodeManual.Text;
                        }
                        else
                        {
                            expenseCategory.Code = txtCode.Text;
                        }

                        expenseCategory.Description = txtDescription.Text;
                        
                        db.SaveChanges();                                             
                    }
                    else if (rbSubCategory.Checked)
                    {

                        expenseCategory.RootCategoryId = (int)cmbRootCategory.SelectedValue;
                        expenseCategory.RootCategoryName = cmbRootCategory.Text;
                        expenseCategory.Name = txtName.Text;
                        if (txtCodeManual.Text.Trim() != string.Empty)
                        {
                            expenseCategory.Code = txtCodeManual.Text;
                        }
                        else
                        {
                            expenseCategory.Code = txtCode.Text;
                        }
                        expenseCategory.Description = txtDescription.Text;
                      
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
                        db.ExpenseCategories.Attach(expenseCategory);
                        db.Entry(expenseCategory).State = System.Data.Entity.EntityState.Modified;
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
            RootCategoryVisibleFalse();
        }
        private void rbRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            txtCode.Text = GenearateCodeExpRoot();
            RootCategoryVisibleFalse();
        }
        private void TextBoxValue()
        {

            expenseCategory.Name = txtName.Text;
            expenseCategory.Code = txtCode.Text;
            expenseCategory.Description = txtDescription.Text;

        }
        private void ClearAllTextBox()
        {
            rbRootCategory.Checked = false;
            rbSubCategory.Checked = false;
            cmbRootCategory.SelectedIndex = -1;
            txtName.Clear();
            txtCode.Clear();
            txtDescription.Clear();
            SetFormNewMode();
            txtCodeManual.Clear();
        }

        private void SetFormNewMode()
        {
            btnSaveCategory.Text = "Save";
            buttonDelete.Visible = false;
            _isUpdateMode = false;
        }

        private void LoadDataGridView()
        {
            var item = (from expenseCategory in db.ExpenseCategories
                        where (expenseCategory.IsDelete == false)
                        select new
                        {
                            expenseCategory.Id,
                            expenseCategory.Name,
                            expenseCategory.Code,
                            expenseCategory.Description,
                            expenseCategory.RootCategoryName
                        }).ToList();
            dgvCategoryList.DataSource = item;

            dgvCategoryList.Columns["Id"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            RootCategoryVisibleFalse();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //MainForm mainForm=new MainForm();
            //mainForm.Show();
            this.Close();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            ManagerContext db = new ManagerContext();
            var item = (from exp in db.ExpenseCategories
                        where exp.Name.StartsWith(textSearch) && exp.IsDelete==false||exp.Code.StartsWith(textSearch) && exp.IsDelete==false
                        select new
                        {
                            exp.Name,
                            exp.Code,
                            exp.Description,
                            exp.RootCategoryName
                        }).ToList();
            dgvCategoryList.DataSource = item;
        }

        private void buttonSrcClear_Click(object sender, EventArgs e)
        {
            textBoxSrc.Clear();
            LoadDataGridView();
        }

        private void RootCategoryVisibleFalse()
        {
            labeRootcat.Visible = false;
            cmbRootCategory.Visible = false;
        }
        private void RootCategoryVisibleTrue()
        {
            labeRootcat.Visible = true;
            cmbRootCategory.Visible = true;
        }
        private void rbSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSubCategory.Checked)
            {
                RootCategoryVisibleTrue();
            }
            txtCode.Text = GenearateCodeExpSub();
        }
        private string SetInvioceNo()
        {
            var countId = db.ExpenseCategories.Count();
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
        private  string GenearateCodeExpRoot()
        {

            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" + SetInvioceNo();
        }

        private  string GenearateCodeExpSub()
        {
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" + SetInvioceNo();
        }
        private void dgvCategoryList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCategoryList.CurrentRow != null)
            {
                int expenseCategoryId = Convert.ToInt32(dgvCategoryList.CurrentRow.Cells["Id"].Value);
                var expenseCategoryRetrive = db.ExpenseCategories.FirstOrDefault(c => c.Id == expenseCategoryId);
                expenseCategory = expenseCategoryRetrive;

                if (expenseCategory != null)
                {
                    txtName.Text = expenseCategory.Name;
                    txtCode.Text = expenseCategory.Code;
                    txtDescription.Text = expenseCategory.Description;

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)dgvCategoryList.CurrentRow.Cells["Id"].Value;
                expenseCategory = db.ExpenseCategories.FirstOrDefault(c => c.Id == id);
                if (expenseCategory != null)
                {
                    expenseCategory.IsDelete = true;
                    db.SaveChanges();
                    MessageBox.Show("Successfully deleted");
                }
            }
            ClearAllTextBox();
            LoadDataGridView();
        }
    }
}
