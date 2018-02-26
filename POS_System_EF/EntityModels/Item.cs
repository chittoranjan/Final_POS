using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_System_EF.Managers;

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

        [NotMapped]
        public string CodeName
        {
            get
            {
                return Code + " - "+Name;
            }
        }

        public string Description { get; set; }

        public int ItemCategoryId { get; set; }

        public ItemCategory ItemCategory { get; set; }
        public bool IsDelete { get; set; }

        ManagerContext db = new ManagerContext();
        private string SetInvioceNo()
        {
            var countId = db.Items.Count();
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
        internal string GenearateCode(string Name)
        {
            var firstThreeCharsItemName = Name.Length <= 3 ? Name : Name.Substring(0, 3);
            return firstThreeCharsItemName + "-" +SetInvioceNo();
        }
    }
}
