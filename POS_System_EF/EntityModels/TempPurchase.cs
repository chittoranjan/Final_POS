using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class TempPurchase
    {
        public int Id { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
        public bool IsDelete { get; set; }
    }
}
