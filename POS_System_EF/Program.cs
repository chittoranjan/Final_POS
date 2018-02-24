using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System_EF.UI;

namespace POS_System_EF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //desktop-feb24-18
            Application.Run(new LoginForm());
            // Application.Run(new OutletForm());
            //Application.Run(new ItemCategoryForm());
           // Application.Run(new EmployeeForm());
           // Application.Run(new ItemForm());
            //Application.Run(new ExpenseCategoryForm());
           // Application.Run(new ExpenseItemForm());
        }
    }
}
