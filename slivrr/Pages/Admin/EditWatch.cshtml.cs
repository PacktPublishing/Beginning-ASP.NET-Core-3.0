using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using slivrr.Data;
using slivrr.Models;

namespace slivrr.Pages
{
    public class EditWatchPageModel: PageModel
    {
        private TimepieceContext _Context;

        public EditWatchPageModel(TimepieceContext context)
        {
            _Context = context;
        }

        [BindProperty()]
        public AddItemModel AIM { get; set; }

        public IEnumerable<int> ProductCategories { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public void OnGet(int id)
        {
            var product = _Context.Products
                    .FirstOrDefault(p => p.Id == id);
            AIM = new AddItemModel {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Item.Price,
                QuantityInStock = product.Item.QuantityInStock
            };

            ProductCategories = _Context.CategoriesToProducts
                                .Where(ctp => ctp.ProductId == id)
                                .Select (ctp => ctp.CategoryId)
                                .ToList();
            
            Categories = _Context.Categories.ToList();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("EditItem", new { id = id});
            }

            var product = _Context.Products.FirstOrDefault(p => p.Id == id);
            product.Name = AIM.Name;
            product.Description = AIM.Description;
            product.Item.Price = AIM.Price;
            product.Item.QuantityInStock = AIM.QuantityInStock;
            _Context.SaveChanges();

            var cats = _Context.CategoriesToProducts
                    .Where(ctp => ctp.ProductId == id).ToList();
            
            _Context.CategoriesToProducts.RemoveRange(cats);

            var newCats = new List<CategoryToProduct>();

            foreach (var catId in AIM.Categories.Split(','))
            {
                var cid =int.Parse(catId);
                newCats.Add(new CategoryToProduct {
                    ProductId = product.Id,
                    CategoryId = cid
                });
            }

            _Context.CategoriesToProducts.AddRange(newCats);
            _Context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}