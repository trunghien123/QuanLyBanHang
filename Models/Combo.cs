using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang.Models
{
    public partial class Combo
    {
        public string Id { get; set; }
        public string ComboName { get; set; }
        public string ProductList { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TotalMoney { get; set; }
        public string Discount { get; set; }
        public string DiscountMoney { get; set; }
    }
}
