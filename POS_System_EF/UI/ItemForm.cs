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
    public partial class ItemForm : Form
    {
        ManagerContext db = new ManagerContext();
        Item item = new Item();
        public ItemForm()
        {
            InitializeComponent();
            ComboxData();
            LoadDataGridViewItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                item.ItemCategoryId = (int)cmbCategory.SelectedValue;
                item.Name = txtName.Text;
                item.CostPrice = Convert.ToDecimal(txtCostPrice.Text);
                item.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
                item.Code = item.GenearateCode(item.Name, cmbCategory.Text);
                item.Description = txtDescription.Text;

                db.Items.Add(item);
                int count = db.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Successfully Item Saved");
                }
                else
                {
                    MessageBox.Show("Failed Insertion");
                }
                LoadDataGridViewItem();
                ClearAllTextBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + "Please fill text box!");
            }
            
        }

        private void ClearAllTextBox()
        {
            txtName.Clear();
            txtCostPrice.Clear();
            txtSalePrice.Clear();
            txtCode.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void ComboxData()
        {
             var cat= db.ItemCategories.Where(c => c.CategoryId >0).ToList();
            //var subcat = db.ItemCategories.Where(c => c.CategoryId == c.Id).ToList();
            cmbCategory.DataSource = cat;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1;
        }
        private void LoadDataGridViewItem()
        {
            var item = (from items in db.Items
                select new
                {
                    items.Name,
                    items.Code,
                    items.CostPrice,
                    items.SalePrice,
                    items.Description
                }).ToList();
            dgvItem.DataSource = item;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm=new OpeningForm();
            //openingForm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        private void textBoxSrc_TextChanged(object sender, EventArgs e)
        {
            string textSearch = textBoxSrc.Text;
            ManagerContext db = new ManagerContext();
            var item = (from i in db.Items
                                where i.Name.StartsWith(textSearch)
                                select new
                                {
                                    i.Name,
                                    i.Code,
                                    i.CostPrice,
                                    i.SalePrice,
                                }).ToList();
            dgvItem.DataSource = item;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
