using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using slivrr.Models;
using slivrr.Data;

namespace slivrr.Controllers
{
    public class HomeController : Controller
    {
        private static Cart _Cart = new Cart();
        private TimepieceContext _context;

        public HomeController(TimepieceContext context)
        {
            _context = context;
        }

        public void CartItemCount()
        {
            var total = _Cart.CartItems.Sum(c => c.Quantity);
            ViewData["Shopping Cart Quantity"] = total;
        }

        public IActionResult Index()
        {
            CartItemCount();
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Details(int Id)
        {
            CartItemCount();
            var product = _context.Products.SingleOrDefault(p => p.Id == Id);

            var categories = _context.Products
                .Where(p => p.Id == Id)
                .SelectMany(ctp => ctp.CategoriesToProducts
                    .Select(c => c.Category))
                .ToList();

            var vm = new DetailsViewModel {
                Product = product,
                Categories = categories
            };

            if (product != null)
            {
                return View(vm);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult ShowCart()
        {
            var cartVM = new CartViewModel();
            cartVM.CartItems = _Cart.CartItems;
            cartVM.OrderTotal = _Cart.CartItems.Sum(c => c.getTotalPrice());
            CartItemCount();
            return View("Cart", cartVM);
        }

        public IActionResult AddToCart(int itemId)
        {
            var product = _context.Products.SingleOrDefault(p => p.ItemId == itemId);

            if (product != null)
            {
                var cartItem = new CartItem {
                    Item = product.Item,
                    Quantity = 1
                };
                _Cart.addItem(cartItem);
            }
            return RedirectToAction("ShowCart");
        }

        public IActionResult RemoveFromCart(int itemId)
        {
            _Cart.removeItem(itemId);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            CartItemCount();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            CartItemCount();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
