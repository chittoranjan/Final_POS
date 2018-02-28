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
    public partial class ExpenseItemForm : Form
    {
        ManagerContext db = new ManagerContext();
        ExpenseItem expenseItem = new ExpenseItem();
        public ExpenseItemForm()
        {
            InitializeComponent();
            ComboxData();
            LoadDataGridViewItem();
        }
        private void ComboxData()
        {
            var loadRootCat = (from exCat in db.ExpenseCategories
                               where exCat.RootCategoryId > 0 && exCat.IsDelete==false 
                               select exCat).ToList();

            cmbCategory.DataSource = loadRootCat.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                expenseItem.ExpenseCategoryId = (int)cmbCategory.SelectedValue;
                expenseItem.Name = txtName.Text;
                if (txtCodeManual.Text.Trim()!=String.Empty)
                {
                    expenseItem.Code = txtCodeManual.Text;
                }else
                {
                    expenseItem.Code = txtCode.Text;
                }
                
                expenseItem.Description = txtDescription.Text;

                db.ExpenseItems.Add(expenseItem);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Successfully Item Saved");
                }
                else
                {
                    MessageBox.Show("Failed Insertion");
                }
                ClearAllTextBox();
                LoadDataGridViewItem();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + "Please fill text box!");
            }
        }
        private void ClearAllTextBox()
        {
            cmbCategory.SelectedIndex = -1;
            txtName.Clear();
            txtCode.Clear();
            txtCodeManual.Clear();
            txtDescription.Clear();
            
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCode.Text = expenseItem.GenearateExpItemCode();
        }
        private void LoadDataGridViewItem()
        {
            var item = (from expItems in db.ExpenseItems where expItems.IsDelete==false
                        select new
                        {
                            expItems.Id,
                            expItems.Name,
                            expItems.Code,
                            expItems.Description,
                            ExpenseCategoryName = expItems.ExpenseCategory.Name
                        }).ToList();
            dgvItem.DataSource = item;
            var dataGridViewColumn = dgvItem.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
            LoadDataGridViewItem();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //OpeningForm opening=new OpeningForm();
            //opening.Show();
            this.Close();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            var item = (from ei in db.ExpenseItems
                        where ei.Name.StartsWith(textSearch)&& ei.IsDelete==false||ei.Code.StartsWith(textSearch)&&ei.IsDelete==false
                        select new
                        {
                            ei.Id,
                            ei.Name,
                            ei.Code,
                            ei.Description,
                            ExpenseCategoryName = ei.ExpenseCategory.Name
                        }).ToList();
            dgvItem.DataSource = item;
            var dataGridViewColumn = dgvItem.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }

        private void buttonSrcClear_Click(object sender, EventArgs e)
        {
            textBoxSrc.Clear();
            LoadDataGridViewItem();
        }

       
    }
}
