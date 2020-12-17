using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang.Models
{
    public partial class Storage
    {
        public string ProductId { get; set; }
        public int Amount { get; set; }
        public string ImportDate { get; set; }
        public string ExportDate { get; set; }
    }
}
