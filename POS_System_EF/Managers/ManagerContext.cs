using POS_System_EF.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.Managers
{
    public class ManagerContext:DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Outlet> Outlets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseList> ExpenseLists { get; set; } 
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<TempPurchase> TempPurchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesItem> SalesItem { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}
