using System;
using System.Collections.Generic;

#nullable disable

namespace BanHang.Models
{
    public partial class Employee
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string JoinDate { get; set; }
        public string RoleId { get; set; }
    }
}
