using POS_System_EF.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF
{
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
        }

        private void addorganizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.Show();
        }

        private void addBranchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OutletForm outForm = new OutletForm();
            outForm.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm eForm = new EmployeeForm();
            eForm.Show();
        }
        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemCategoryForm itemCategoryForm = new ItemCategoryForm();
            itemCategoryForm.Show();
        }
        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm iForm = new ItemForm();
            iForm.Show();
        }
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierCustomerForm partyForm = new SupplierCustomerForm();
            partyForm.Show();
        }

        private void addPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierCustomerForm partyForm = new SupplierCustomerForm();
            partyForm.Show();
        }

        private void addPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm pForm = new PurchaseForm();
            pForm.Show();
        }

        private void purchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportForm PRForm = new PurchaseReportForm();
            PRForm.Show();

        }

        private void addSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm sForm = new SalesForm();
            sForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoginForm login=new LoginForm();
            //login.Show();
            this.Close();
        }

        private void expenseCategorySetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseCategoryForm expenseCategoryForm=new ExpenseCategoryForm();
            expenseCategoryForm.Show();
        }

        private void itemSetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpenseItemForm expenseItemForm=new ExpenseItemForm();
            expenseItemForm.Show();
        }

        private void salesRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReportForm srForm = new SalesReportForm();
            srForm.Show();
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseForm expense = new ExpenseForm();
            expense.Show();
        }

        private void expReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseReportForm exReport=new ExpenseReportForm();
            exReport.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesCrystalReportForm sForm = new SalesCrystalReportForm();
            sForm.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportForm pForm = new PurchaseReportForm();
            pForm.Show();
        }

        private void expenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseReportForm eForm = new ExpenseReportForm();
            eForm.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockForm sForm = new StockForm();
            sForm.Show();
        }
    }
}
