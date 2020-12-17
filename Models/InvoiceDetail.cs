using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang.Models
{
    public partial class InvoiceDetail
    {
        public int Id { get; set; }
        public string InvoiceId { get; set; }
        public string ProductId { get; set; }
        public string ComboId { get; set; }
        public int Amount { get; set; }
        public string Price { get; set; }
    }
}
