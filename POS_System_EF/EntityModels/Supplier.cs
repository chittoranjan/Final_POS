using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_System_EF.Managers;

namespace POS_System_EF.EntityModels
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(12)]
        public string Code { get; set; }
        [Required]
        [MaxLength(11)]
        public string ContactNo { get; set; }
        public string Email { get; set; }
        [Required]
        [MaxLength(250)]
        public string Address { get; set; }
        public bool IsDelete { get; set; }

        ManagerContext db = new ManagerContext();
        private string SetInvioceNo()
        {
            var countId = db.Suppliers.Count();
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

        public string GenerateCode(string name)
        {
            var firstThreeChars = name.Length <= 3 ? name : name.Substring(0, 3);
            return firstThreeChars + "-"+SetInvioceNo();
        }
    }
}
