using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_System_EF.Managers;

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

        ManagerContext db=new ManagerContext();
        private string SetInvioceNo()
        {
            var countId = db.ItemCategories.Count();
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
        internal string GenearateCodeRoot(string Name)
        {
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" +SetInvioceNo();
        }

        internal string GenearateCodeSub(string Name)
        {
            var firstThreeCategoryName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCategoryName + "-" + SetInvioceNo();
        }
    }
}
