using System;

namespace BanHang.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public Combo Combo { get; set; }
        public int Quantity { get; set; }
    }
}