using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using slivrr.Data;
using slivrr.Models;

namespace slivrr.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TimepieceContext _Context;

        public IndexModel(TimepieceContext context)
        {
            _Context = context;
        }

        public IEnumerable<Product> Watches { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        
        public void OnGet()
        {
            Watches = _Context.Products.ToList();
            Categories = _Context.Categories.ToList();
        }
    }
}