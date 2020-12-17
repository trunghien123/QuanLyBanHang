using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang.Models
{
    public partial class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string CatalogId { get; set; }
        public int Amount { get; set; }
        public string Price { get; set; }
    }
}
