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
    public partial class ExpenseReportForm : Form
    {
        ManagerContext db = new ManagerContext();
        public ExpenseReportForm()
        {
            InitializeComponent();
            LoadDataGridView();
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
                                ex.InvoiceNo,
                                ex.TotalAmount,
                                ex.Date,
                                ex.Remarks,
                                EmployeeName = ex.Employee.Name,
                                OutletName = ex.Outlet.Name,
                                OrganizationName = ex.Organization.Name
                            }).ToList();
            dgvExpenseReport.DataSource = loadData;
            var dgvColumn = dgvExpenseReport.Columns["Id"];
            if (dgvColumn != null)
            {
                dgvColumn.Visible = false;
            }
        }
        private void dgvExpenseReport_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvExpenseReport.CurrentRow != null)
                {
                    int selectedId = (int)dgvExpenseReport.CurrentRow.Cells["Id"].Value;

                    txtShowInvioceNo.Text = dgvExpenseReport.CurrentRow.Cells["InvoiceNo"].Value.ToString();
                    txtShowOrg.Text = dgvExpenseReport.CurrentRow.Cells["OrganizationName"].Value.ToString();
                    txtShowOutlet.Text = dgvExpenseReport.CurrentRow.Cells["OutletName"].Value.ToString();
                    txtShowEmployee.Text = dgvExpenseReport.CurrentRow.Cells["EmployeeName"].Value.ToString();
                    txtShowDate.Text = dgvExpenseReport.CurrentRow.Cells["Date"].Value.ToString();

                    List<ExpenseList> expenseItemLst = db.ExpenseLists.Where(ex => ex.ExpenseId == selectedId).ToList();

                    var loadListItem = (from exLst in expenseItemLst
                        select new
                        {
                            exLst.ExpenseName,
                            exLst.Qty,
                            exLst.Amount,
                            exLst.Paid,
                            exLst.Due,
                        }).
                        ToList();
                    dgvExpensePrint.DataSource = null;
                    dgvExpensePrint.DataSource = loadListItem;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtSrcExpense_TextChanged(object sender, EventArgs e)
        {
            var srcData = (from exp in db.Expenses
                           where exp.Employee.Name.StartsWith(txtSrcExpense.Text) && exp.IsDelete == false || exp.Organization.Name.StartsWith(txtSrcExpense.Text) && exp.IsDelete == false
                           || exp.Outlet.Name.StartsWith(txtSrcExpense.Text) && exp.IsDelete == false || exp.InvoiceNo.StartsWith(txtSrcExpense.Text) && exp.IsDelete == false
                           || exp.TotalAmount.ToString().StartsWith(txtSrcExpense.Text) && exp.IsDelete == false

                           select new
                           {
                               exp.Id,
                               exp.InvoiceNo,
                               exp.TotalAmount,
                               exp.Date,
                               exp.Remarks,
                               EmployeeName = exp.Employee.Name,
                               OutletName = exp.Outlet.Name,
                               OrganizationName = exp.Organization.Name
                           }).ToList();
            dgvExpenseReport.DataSource = srcData;
            var dgvColumn = dgvExpenseReport.Columns["Id"];
            if (dgvColumn != null)
            {
                dgvColumn.Visible = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
