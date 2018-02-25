using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_System_EF.Managers;

namespace POS_System_EF.EntityModels
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(12)]
        public string Code { get; set; }
        public string Description { get; set; }
        public int RootCategoryId { get; set; }
        public string RootCategoryName { get; set; }
        public bool  IsDelete { get; set; }

        ManagerContext db = new ManagerContext();
        private string SetInvioceNo()
        {
            var countId = db.ExpenseCategories.Count();
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
                string invNO = Convert.ToString(countId++);
                return invNO;
            }
        }
        internal string GenearateCodeExpRoot(string Name)
        {

            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" + SetInvioceNo();
        }

        internal string GenearateCodeExpSub(string Name)
        {
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" + SetInvioceNo();
        }
    }
}
