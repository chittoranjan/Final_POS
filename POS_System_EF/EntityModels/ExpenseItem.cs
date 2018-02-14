using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class ExpenseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public bool  IsDelete { get; set; }

        internal string GenearateExpItemCode(string name, string Name)
        {
            var firstThreeCharsItemName = name.Length <= 3 ? name : name.Substring(0, 3);
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCharsItemName + "-" + firstThreeCategoryName;
        }
    }
}
