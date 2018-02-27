using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_EF.EntityModels
{
    public class Sale
    {
        public int Id { get; set; }
        public List<SalesItem> listOfItem { get; set; }
        public string InvoiceNo { get; set; }
        public string Remarks { get; set; }
        public int CustomerId { get; set; }
        public CustomerAndSupplier Customer { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Vat { get; set; }
        public decimal Discount { get; set; }
        public int OutletId { get; set; }
        public Outlet Outlet { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public bool IsDelete { get; set; }

    }
}
