using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(12)]
        public string Code { get; set; }
        [Required]
        [MaxLength(11)]
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsDelete { get; set; }
        public string GenerateCode(string name, string contactno)
        {
            int sl = 0;

            var firstThreeChars = name.Length <= 3 ? name : name.Substring(0, 3);
            //var firstThreeCharsAddress = address.Length <= 3 ? address : address.Substring(0, 3);
            var firstThreeCharsContactNo = contactno.Length <= 3 ? contactno : contactno.Substring(0, 3);
            return firstThreeChars + "-" + firstThreeCharsContactNo + "-" + sl++;
        }
    }
}
