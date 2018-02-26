using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_System_EF.Managers;

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

        ManagerContext db = new ManagerContext();
        private string SetInvioceNo()
        {
            var countId = db.ExpenseItems.Count();
            countId++;
            if (countId <= 9)
            {
                string invNo = Convert.ToString("00" + countId);
                return invNo;
            }
            if (countId <= 99)
            {
                string invNo = Convert.ToString("0" + countId);
                return invNo;
            }
            else
            {
                string invNo = Convert.ToString(countId);
                return invNo;
            }
        }
        internal string GenearateExpItemCode( string Name)
        {
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" +SetInvioceNo() ;
        }
    }
}
