using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BanHang.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BanHang.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {
            var cart = HttpContext.Session.GetString("SessionCart");
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = JsonConvert.DeserializeObject<List<CartItem>>(cart);
            }
            return View(list);
        }
        public IActionResult AddCart(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cart = HttpContext.Session.GetString("SessionCart");
            var product = _context.Products.FirstOrDefault(m => m.Id == id);
            var combo = _context.Combos.FirstOrDefault(m => m.Id == id);
            if (cart == null)
            {
                var item = new CartItem();
                item.Product = product;
                item.Combo = combo;
                item.Quantity = 1;
                var list = new List<CartItem>();
                list.Add(item);
                //  gán vào session
                HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(list));
            }
            else
            {
                List<CartItem> list = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                bool check = true;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Product != null)
                    {
                        if (list[i].Product.Id == id)
                        {
                            list[i].Quantity++;
                            check = false;
                        } 
                        else if(list[i].Combo != null){
                            if (list[i].Combo.Id == id)
                            {
                                list[i].Quantity++;
                                check = false;
                            }
                        } 
                            
                    }
                    else if (list[i].Combo.Id == id)
                    {
                        list[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    var item = new CartItem();
                    item.Product = product;
                    item.Combo = combo;
                    item.Quantity = 1;
                    list.Add(item);
                }
                //  Gán vào session
                HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(list));
            }

            return RedirectToAction("Index");
        }

        
        [HttpPost]
        public IActionResult AddCartWithoutRedic(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cart = HttpContext.Session.GetString("SessionCart");
            var product = _context.Products.FirstOrDefault(m => m.Id == id);
            var combo = _context.Combos.FirstOrDefault(m => m.Id == id);
            if (cart == null)
            {
                var item = new CartItem();
                item.Product = product;
                item.Combo = combo;
                item.Quantity = 1;
                var list = new List<CartItem>();
                list.Add(item);
                //  gán vào session
                HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(list));
            }
            else
            {
                List<CartItem> list = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                bool check = true;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Product != null)
                    {
                        if (list[i].Product.Id == id)
                        {
                            list[i].Quantity++;
                            check = false;
                        } 
                        else if(list[i].Combo != null){
                            if (list[i].Combo.Id == id)
                            {
                                list[i].Quantity++;
                                check = false;
                            }
                        } 
                            
                    }
                    else if (list[i].Combo.Id == id)
                    {
                        list[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    var item = new CartItem();
                    item.Product = product;
                    item.Combo = combo;
                    item.Quantity = 1;
                    list.Add(item);
                }
                //  Gán vào session
                HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(list));
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateCart(string id, int quantity)
        {
            var cart = HttpContext.Session.GetString("SessionCart");
            if (cart != null)
            {
                List<CartItem> list = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (quantity > 0)
                {
                    foreach (var item in list)
                    {
                        if (item.Product.Id == id)
                        {
                            item.Quantity = quantity;
                        } 
                        else if(item.Combo.Id == id){
                            item.Quantity = quantity;
                        }
                    }
                    HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(list));
                }
                return Ok(quantity);
            }
            return BadRequest();
        }

        public IActionResult deleteCart(string id)
        {
            var cart = HttpContext.Session.GetString("SessionCart");
            if (cart != null)
            {
                List<CartItem> list = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Product.Id == id)
                    {
                        list.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("SessionCart", JsonConvert.SerializeObject(list));
            }
            return RedirectToAction("Index");
        }
        public IActionResult Payment()
        {
            var cart = HttpContext.Session.GetString("SessionCart");
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = JsonConvert.DeserializeObject<List<CartItem>>(cart);
            }
            return View(list);
        }
        [HttpPost]
        public IActionResult PaymentOrder(string address)
        {
            var cart = HttpContext.Session.GetString("SessionCart");
            var list = JsonConvert.DeserializeObject<List<CartItem>>(cart);
            var order = new Invoice();
            string path = Path.GetRandomFileName().Replace(".", ""); //random text
            order.Id = path.Substring(0, 8);
            order.CreatedDate = "19/12/2020";
            order.InvoiceName = path.Substring(0, 4);
            order.ShipDate = "26/12/2020";
            double totalPriceProduct = 0;
            foreach (var item in list)
            {
                int priceParse = Int32.Parse(item.Product.Price) * item.Quantity;
                totalPriceProduct += priceParse;
            }
            order.TotalMoney = totalPriceProduct.ToString();
            order.CustomerAddress = address;
            order.ShipperId = "ship1";
            order.CustomerId = "cus1";

            _context.Invoices.Add(order);
            _context.SaveChanges();
            var ID = order.Id;

            //insert order detail

            foreach (var item in list)
            {
                var orderDetail = new InvoiceDetail();
                orderDetail.InvoiceId = ID;
                orderDetail.ProductId = item.Product.Id;
                orderDetail.Amount = item.Quantity;
                orderDetail.Price = item.Product.Price;

                _context.InvoiceDetails.Add(orderDetail);
                _context.SaveChanges();
            }
            HttpContext.Session.Clear();

            return RedirectToAction("HistoryOrder");
        }

        public IActionResult HistoryOrder()
        {
            var data = _context.Invoices.ToList();
            return View(data);
        }
    }
}