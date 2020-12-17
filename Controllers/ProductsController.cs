using System.Linq;
using System.Threading.Tasks;
using BanHang.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BanHang.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            ViewBag.category = _context.Catalogs.ToList();
            return View( _context.Products.ToList());
        }
        public IActionResult Combo()
        {
            ViewBag.category = _context.Catalogs.ToList();
            return View(_context.Combos.ToList());
        }
    }
}