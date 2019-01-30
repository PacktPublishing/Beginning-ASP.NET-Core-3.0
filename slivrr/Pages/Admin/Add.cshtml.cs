using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using slivrr.Data;
using slivrr.Models;

namespace slivrr.Pages
{
    public class AddPageModel : PageModel
    {
        private TimepieceContext _Context;
        private IHostingEnvironment _Env;

        public AddPageModel (TimepieceContext context, IHostingEnvironment env)
        {
            _Context = context;
            _Env = env;
            Categories = _Context.Categories.ToList();
        }

        [BindProperty()]
        public AddItemModel AIM { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var item = new Item {
                Price = AIM.Price,
                QuantityInStock = AIM.QuantityInStock
            };

            var product = new Product {
                Name = AIM.Name,
                Description = AIM.Description,
                Item = item
            };

            _Context.Products.Add(product);
            _Context.SaveChanges();
            product.ItemId = product.Id;
            _Context.SaveChanges();

            // In development we are running from the current slivrr directory.
            // In Production we are running from a location inside C:\Windows\System32...
            // so we need the correct Current Directory.
            var rootPath = (_Env.IsDevelopment()) ? 
                            Directory.GetCurrentDirectory() : 
                            AppDomain.CurrentDomain.BaseDirectory;

            var filePath = Path.Combine(
                rootPath,
                "wwwroot",
                "images",
                product.Id + ".jpg"
            );

            if (AIM.Picture?.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    AIM.Picture.CopyTo(stream);
                }
            }

            var ctp = new List<CategoryToProduct>();
            foreach (var catId in AIM.Categories.Split(','))
            {
                var cid = int.Parse(catId);
                ctp.Add(new CategoryToProduct{
                    ProductId = product.Id,
                    CategoryId = cid
                });
            }

            _Context.CategoriesToProducts.AddRange(ctp);
            _Context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}