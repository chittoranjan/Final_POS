using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        internal string GenearateCodeExpRoot(string Name)
        {
            int sl = 0;
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            //var firstThreeCharsCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" + sl++;
        }

        internal string GenearateCodeExpSub(string Name)
        {
            int sl = 0;
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            //var firstThreeCharsCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" + sl++;
        }
    }
}
