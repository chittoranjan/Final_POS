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
    public partial class ExpenseForm : Form
    {
        ManagerContext db = new ManagerContext();
        private Expense expense = new Expense();
        bool isUpdateMode = false;
        public ExpenseForm()
        {
            InitializeComponent();
            LoadExpenseItem();
            LoadOrganization();
          
        }
        private void LoadExpenseItem()
        {
            var cmbExpense = (from expItem in db.ExpenseItems
                              where expItem.ExpenseCategoryId != 0
                              select new
                              {
                                  expItem.Name,
                                  expItem.Id
                              }).ToList();
            cmbExpenseItem.DataSource = cmbExpense;
            cmbExpenseItem.DisplayMember = "Name";
            cmbExpenseItem.ValueMember = "Id";
            cmbExpenseItem.SelectedIndex = -1;
        }
        private void LoadOrganization()
        {
            var cmbOrg1 = (from orgName in db.Organizations
                           where orgName.IsDelete == false
                           select new
                           {
                               orgName.Name,
                               orgName.Id
                           }).ToList();
            cmbOrganization.DataSource = cmbOrg1;
            cmbOrganization.DisplayMember = "Name";
            cmbOrganization.ValueMember = "Id";
            cmbOrganization.SelectedIndex = -1;
        }
        private void cmbOrganization_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadOutlet();
        }
        private void LoadOutlet()
        {
            var cmbout1 = (from outName in db.Outlets
                           where outName.OrganizationId == (int)cmbOrganization.SelectedValue
                           select new
                           {
                               outName.Name,
                               outName.Id
                           }).ToList();
            cmbOutlet.DataSource = cmbout1;
            cmbOutlet.DisplayMember = "Name";
            cmbOutlet.ValueMember = "Id";
            cmbOutlet.SelectedIndex = -1;
        }
        private void cmbOutlet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadEmployee();
        }
        
        private void LoadEmployee()
        {
            var cmbEmp = (from empName in db.Employees
                          where empName.OutletId == (int)cmbOutlet.SelectedValue
                          select new
                          {
                              empName.Name,
                              empName.Id
                          }).ToList();
            cmbEmployee.DataSource = cmbEmp;
            cmbEmployee.DisplayMember = "Name";
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.SelectedIndex = -1;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm = new OpeningForm();
            //openingForm.Show();
            this.Close();
        }
        List<ExpenseList>expenseLists=new List<ExpenseList>(); 
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ExpenseList expenseAdd=new ExpenseList();
            try
            {
                DialogResult result = MessageBox.Show("Do you want to Add?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    expenseAdd.ExpenseName = cmbExpenseItem.Text;
                    expenseAdd.Qty = Convert.ToInt32(txtQty.Text);
                    expenseAdd.Amount = Convert.ToDecimal(txtAmount.Text);
                    expenseAdd.Paid = Convert.ToDecimal(txtpaid.Text);
                    expenseAdd.Due = Convert.ToDecimal(txtAmount.Text) - Convert.ToDecimal(txtpaid.Text);

                    var name = db.ExpenseItems.Where(a => a.Name == expenseAdd.ExpenseName).ToList();
                    if (name.Count == 0)
                    {
                        MessageBox.Show("Item Does Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else if (name.Count>0)
                    {
                        expenseLists.Add(expenseAdd);
                        ShowDgvAddItems();

                        ShowExpenseSummary();
                        ClearAddItemTextBox();
                    }

                    MessageBox.Show("Expense added successfully!");
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("You have clicked Cancel Button");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ShowDgvAddItems()
        {
            var showAddItems = (from exList in expenseLists
                select new
                {
                    exList.ExpenseName,
                    exList.Qty,
                    exList.Amount,
                    exList.Paid,
                    exList.Due
                }).ToList();

            dgvExpense.DataSource = null;
            dgvExpense.DataSource = showAddItems;
        }

        private void ShowExpenseSummary()
        {

            decimal total = expenseLists.Sum(s => s.Amount);
            decimal paid = expenseLists.Sum(s => s.Paid);
            decimal due = total - paid;

            txtTotalShow.Text = total.ToString();
            txtPaidSho.Text = paid.ToString();
            txtDueShow.Text = due.ToString();
        }

        private void ClearAddItemTextBox()
        {
            cmbExpenseItem.SelectedIndex = -1;
            txtRemark.Clear();
            txtQty.Clear();
            txtAmount.Clear();
            txtpaid.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to Save", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    expense.ExpenseList = expenseLists;
                    expense.InvoiceNo = SetInvioceNo();
                    expense.Remarks = txtRemark.Text;
                    expense.TotalAmount = Convert.ToDecimal(txtTotalShow.Text);
                    expense.OrganizationId = (int)cmbOrganization.SelectedValue;
                    expense.OutletId = (int)cmbOutlet.SelectedValue;
                    expense.EmployeeId = (int)cmbEmployee.SelectedValue;
                    expense.Date = dateTimePicker.Value;

                    db.Expenses.Add(expense);
                    int count = db.SaveChanges();
                    MessageBox.Show(count > 0 ? "Expense save successfully!" : "Save failed");
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("You have clicked Cancel Button");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            ClearTextBoxAll();
        }
        private string SetInvioceNo()
        {
            var countId = db.Expenses.Count();
            if (countId <= 9)
            {
                string invNO = Convert.ToString("00" + countId++);
                return invNO;
            }
            if (countId <= 99)
            {
                string invNO = Convert.ToString("0" + countId++);
                return invNO;
            }
            else
            {
                string invNO =Convert.ToString( countId++);
                return invNO;
            }
        }

        private void ClearTextBoxAll()
        {
            txtDueShow.Clear();
            txtTotalShow.Clear();
            txtPaidSho.Clear();
            dateTimePicker.ResetText();
            cmbOrganization.SelectedIndex = -1;
            cmbOutlet.SelectedIndex = -1;
            cmbEmployee.SelectedIndex = -1;
            expenseLists.Clear();

            ClearAddItemTextBox();
        }

        private void dgvExpense_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to remove ?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    int index = dgvExpense.CurrentCell.RowIndex;
                    expenseLists.RemoveAt(index);

                    ShowDgvAddItems();

                    ShowExpenseSummary();

                    MessageBox.Show("Item has removed");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClearAddItem_Click(object sender, EventArgs e)
        {
            ClearAddItemTextBox();
            ShowDgvAddItems();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearTextBoxAll();
        }
    }
}
