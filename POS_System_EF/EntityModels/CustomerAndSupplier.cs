﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_System_EF.Managers;

namespace POS_System_EF.EntityModels
{
    public class CustomerAndSupplier
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(12)]
        public string Code { get; set; }
        public string Type { get; set; }
        [Required]
        [MaxLength(11)]
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsDelete { get; set; }

        public string SetInvioceNo()
        {
            ManagerContext db = new ManagerContext();
            var countId = db.CustomerAndSuppliers.Count();
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
    }
}
