using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class ExpenseList
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string ExpenseName { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal Paid { get; set; }
        public decimal Due { get; set; }
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }
    }
}
