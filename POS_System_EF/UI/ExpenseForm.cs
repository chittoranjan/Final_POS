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
        private Expense expense;
        bool isUpdateMode = false;
        public ExpenseForm()
        {
            InitializeComponent();
            LoadDataGridView();
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
        private void LoadDataGridView()
        {
            var loadData = (from ex in db.Expenses
                            join emp in db.Employees on ex.EmployeeId equals emp.Id
                            join outlet1 in db.Outlets on ex.OutletId equals outlet1.Id
                            join org in db.Organizations on ex.OrganizationId equals org.Id

                            select new
                            {
                                ex.Id,
                                ex.ExpenseName,
                                ex.Qty,
                                ex.Amount,
                                ex.Paid,
                                ex.Due,
                                ex.Date,
                                ex.Remarks,
                                EmployeeName = ex.Employee.Name,
                                OutletName = ex.Outlet.Name,
                                OrganizationName = ex.Organization.Name
                            }).ToList();
            dgvExpense.DataSource = loadData;
            var dgvColumn = dgvExpense.Columns["Id"];
            if (dgvColumn != null)
            {
                dgvColumn.Visible = false;
            }
        }
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            //OpeningForm openingForm = new OpeningForm();
            //openingForm.Show();
            this.Close();
        }
        private List<Expense> _expnseItems = new List<Expense>();
        Expense anExpense = new Expense();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            expense=new Expense();
            expense.ExpenseName = cmbExpenseItem.Text;
            expense.ExpenseItemId = (int)cmbExpenseItem.SelectedValue;
                expense.Remarks = txtRemark.Text;
                expense.Qty = Convert.ToInt32(txtQty.Text);
                expense.Amount = Convert.ToDecimal(txtAmount.Text);
                expense.Paid = Convert.ToDecimal(txtpaid.Text);
                expense.Due = (Convert.ToDecimal(txtAmount.Text)-Convert.ToDecimal(txtpaid.Text));
                expense.OrganizationId = (int)cmbOrganization.SelectedValue;
                expense.OutletId = (int)cmbOutlet.SelectedValue;
                expense.EmployeeId = (int)cmbEmployee.SelectedValue;
                expense.Date = dateTimePicker.Value;

                DialogResult result = MessageBox.Show("Do you want to Save?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    _expnseItems.Add(expense);

                    MessageBox.Show("Expense added successfully!");
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("You have clicked Cancel Button");
                }
                dgvExpense.DataSource = null;
            var addExpItem = (from ex in _expnseItems
                select new
                {
                    ex.ExpenseName,
                    ex.Qty,
                    ex.Amount,
                    ex.Paid,
                    ex.Date
                }).ToList();
            
                dgvExpense.DataSource = addExpItem;
            ShowExpenseSummary();
                ClearAddItemTextBox();
        }

        private void ShowExpenseSummary()
        {
            decimal total = 0; 
            decimal paid = 0;
            decimal due = 0;
            total+=Convert.ToDecimal(txtAmount.Text);
            paid += Convert.ToDecimal(txtpaid.Text);
            due += total - paid;

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
            DialogResult result = MessageBox.Show("Do you want to Save", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                db.Expenses.AddRange(_expnseItems);
                int count = db.SaveChanges();
                MessageBox.Show(count > 0 ? "Expense save successfully!" : "Save failed");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("You have clicked Cancel Button");
            }
            
            LoadDataGridView();
            ClearTextBoxAll();
        }
        private void ClearTextBoxAll()
        {
            txtDueShow.Clear();
            txtTotalShow.Clear();
            txtPaidSho.Clear();
            cmbOrganization.SelectedIndex = -1;
            cmbOutlet.SelectedIndex = -1;
            cmbEmployee.SelectedIndex = -1;
            _expnseItems.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxAll();
            LoadDataGridView();
        }
    }
}
