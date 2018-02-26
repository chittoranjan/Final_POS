using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Stock
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int AvailableQuantity { get; set; }
    }
}
