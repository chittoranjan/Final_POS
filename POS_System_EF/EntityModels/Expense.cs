﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Expense
    {
        public int Id { get; set; }

        public string InvoiceNo { get; set; }
        public decimal TotalAmount { get; set; }

        [Required]
        public DateTime Date { get; set; }
        [MaxLength(250)]
        public string Remarks { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int OutletId { get; set; }
        public Outlet Outlet { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public List<ExpenseList> ExpenseList { get; set; }
        public bool IsDelete { get; set; }
    }
}
