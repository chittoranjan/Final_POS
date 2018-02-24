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
        private bool _isUpdateMode = false;
        public ItemForm()
        {
            InitializeComponent();
            ComboxData();
            LoadDataGridViewItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty && txtCostPrice.Text.Trim() == string.Empty
                 && txtSalePrice.Text.Trim() == string.Empty && txtCode.Text.Trim() == string.Empty
                 && txtDescription.Text.Trim() == string.Empty)
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

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + "\n" + "Please fill text box!");
                    }
                }

                if (_isUpdateMode)
                {
                    TextBoxValue();

                    DialogResult dialogResult = MessageBox.Show("Are you sure want to update ?", "Information", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.Items.Attach(item);
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;

                        int count = db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("item updated");
                        }
                        else
                        {
                            MessageBox.Show("item update failed");
                        }
                    }
                }

                LoadDataGridViewItem();
                ClearAllTextBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n" + " Find system error! ", MessageBoxIcon.Warning.ToString());
            } 
        }
        private void TextBoxValue()
        {

            item.Name = txtName.Text;
            item.CostPrice = Convert.ToDecimal(txtCostPrice.Text);
            item.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
            item.Code = item.GenearateCode(item.Name, cmbCategory.Text);
            item.Description = txtDescription.Text;

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
                        where items.IsDelete == false
                        select new
                        {
                            items.Id,
                            items.Name,
                            items.Code,
                            items.CostPrice,
                            items.SalePrice,
                            items.Description
                        }).ToList();
            dgvItem.DataSource = item;
            dgvItem.Columns["Id"].Visible = false;
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

        private void dgvItem_DoubleClick(object sender, EventArgs e)
        {

            if (dgvItem.CurrentRow != null)
            {
                int itemId = Convert.ToInt32(dgvItem.CurrentRow.Cells["Id"].Value);
                var itemRetrive = db.Items.FirstOrDefault(c => c.Id == itemId);
                item = itemRetrive;

                if (item != null)
                {
                    txtName.Text = item.Name;
                    txtCostPrice.Text = item.CostPrice.ToString();
                    txtSalePrice.Text = item.SalePrice.ToString();
                    txtCode.Text = item.Code;
                    txtDescription.Text = item.Description;

                }

                SetFormUpdateMode();
            }
        }
        private void SetFormUpdateMode()
        {
            btnSave.Text = "Update";
            buttonDelete.Visible = true;
            _isUpdateMode = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)dgvItem.CurrentRow.Cells["Id"].Value;
                item = db.Items.FirstOrDefault(c => c.Id == id);
                if (item != null)
                {
                    item.IsDelete = true;
                    db.SaveChanges();
                }
            }
            ClearAllTextBox();
            LoadDataGridViewItem();
        }
    }
}
