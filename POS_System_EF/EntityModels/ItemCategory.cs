using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class ItemCategory
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(12)]
        public string Code { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public ItemCategory Category { get; set; }
        public List<ItemCategory> ListOfSubCategory { get; set; }
        public bool IsDelete { get; set; }

        internal string GenearateCodeRoot(string Name)
        {
            int sl = 0;
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            //var firstThreeCharsCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" +sl++;
        }

        internal string GenearateCodeSub(string Name)
        {
            int sl = 0;
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            //var firstThreeCharsCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" + sl++;
        }
    }
}
