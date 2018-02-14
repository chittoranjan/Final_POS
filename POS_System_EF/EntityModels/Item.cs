using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public decimal CostPrice { get; set; }
        [Required]
        public decimal SalePrice { get; set; }
        [Required]
        public string Code { get; set; }

        public string Description { get; set; }

        public int ItemCategoryId { get; set; }

        public ItemCategory ItemCategory { get; set; }
        public bool IsDelete { get; set; }

        internal string GenearateCode(string name, string Name)
        {
            var firstThreeCharsItemName = name.Length <= 3 ? name : name.Substring(0, 3);
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCharsItemName + "-" + firstThreeCategoryName;
        }
    }
}
