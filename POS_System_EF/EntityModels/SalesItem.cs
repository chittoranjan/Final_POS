using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class SalesItem
    {
        public int Id { get; set; }
        [ForeignKey("Item")]
        public int? ItemId { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public decimal LineTotal { get; set; }
        public decimal Total { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
    }
}
