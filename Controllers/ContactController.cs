using BanHang.Models;
using Microsoft.AspNetCore.Mvc;

namespace BanHang.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            return View();
        }
    }
}