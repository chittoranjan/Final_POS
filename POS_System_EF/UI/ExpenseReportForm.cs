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

        private List<ExpenseList> expenseItemLst;
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

                    expenseItemLst = db.ExpenseLists.Where(ex => ex.ExpenseId == selectedId).ToList();

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
            printPreviewDialog.Document = printDocument;
            //CaptureScreen();
            printPreviewDialog.ShowDialog();
        }
        private Bitmap bmp;
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)

        {
            e.Graphics.DrawString("Expense Invoice", new Font("Arial", 28, FontStyle.Bold), Brushes.Black, new Point(250,80) );
            e.Graphics.DrawString("Organization Name : " + txtShowOrg.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 150));
            e.Graphics.DrawString("Outlet Name             :  " + txtShowOutlet.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 200));
            e.Graphics.DrawString("Employee Name       :  " + txtShowEmployee.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 250));
            e.Graphics.DrawString("Invoice No                :  " + txtShowInvioceNo.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("Date                          :  " + txtShowDate.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 350));

            e.Graphics.DrawString(".................................................................................................................",new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(20, 380));
           
            e.Graphics.DrawString("Expense Name" , new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, 410));
            e.Graphics.DrawString("Qty ", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(250, 410));
            e.Graphics.DrawString("Amount", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(350, 410));
            e.Graphics.DrawString("Paid", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(500, 410));
            e.Graphics.DrawString("Due", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(650, 410));
            e.Graphics.DrawString(".................................................................................................................", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(20, 430));
           
            int pHight = 460;
            foreach (var eL in expenseItemLst)
            {
                e.Graphics.DrawString(eL.ExpenseName, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(30, pHight));
                e.Graphics.DrawString(eL.Qty.ToString(), new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(250, pHight));
                e.Graphics.DrawString(eL.Amount.ToString(), new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(350, pHight));
                e.Graphics.DrawString(eL.Paid.ToString(), new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(500, pHight));
                e.Graphics.DrawString(eL.Due.ToString(), new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(650, pHight));

                pHight += 35;
            }
            //e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void CaptureScreen()
        {
            //Graphics myGraphics = this.CreateGraphics();
            //bmp=new Bitmap(this.Size.Width, this.Size.Height,myGraphics);
            //Graphics memoryGraphics = Graphics.FromImage(bmp);
            //memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 10, 10, this.TabControlOrgPrint.Size);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
