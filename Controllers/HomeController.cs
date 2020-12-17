using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BanHang.Models;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace BanHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            dynamic product = new ExpandoObject();
            product.Products = await _context.Products.Take(4).ToListAsync();
            product.Combos = await _context.Combos.Take(4).ToListAsync();
            return View(product);
        }
        public IActionResult ProductDetails(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products
                .FirstOrDefault(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.product = _context.ProductDetails.FirstOrDefault(m => m.ProductId == id);
            ViewBag.category = _context.Catalogs.FirstOrDefault(m => m.Id == product.CatalogId);
            return View(product);
        }

        public IActionResult ComboDetails(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var combos = _context.Combos
                .FirstOrDefault(m => m.Id == id);
            if (combos == null)
            {
                return NotFound();
            } 
            return View(combos);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
