using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(11)]
        public string ContactNo { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        [Required]
        [MaxLength(12)]
        public string Code { get; set; }
        [Required]
        public byte[] Image { get; set; }
        public string EmergencyContactNo { get; set; }
        [Required]
        [MaxLength(50)]
        public string FathersName { get; set; }
        [Required]
        [MaxLength(50)]
        public string MothersName { get; set; }
        [Required]
        [MaxLength(17)]
        public string NID { get; set; }
        public string Reference { get; set; }
        [Required]
        [MaxLength(250)]
        public string PresentAddress { get; set; }
        [Required]
        [MaxLength(250)]
        public string PermanentAddress { get; set; }
        public string Email { get; set; }
        public int? OutletId { get; set; }
        public Outlet Outlet { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public bool IsDelete { get; set; }
    }
}
