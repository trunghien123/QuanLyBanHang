using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang.Models
{
    public partial class Invoice
    {
        public string Id { get; set; }
        public string InvoiceName { get; set; }
        public string CustomerId { get; set; }
        public string ShipperId { get; set; }
        public string TotalMoney { get; set; }
        public string CreatedDate { get; set; }
        public string CustomerAddress { get; set; }
        public string ShipDate { get; set; }
    }
}
