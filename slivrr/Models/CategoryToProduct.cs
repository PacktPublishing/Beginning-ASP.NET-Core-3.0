using System.Collections.Generic;

namespace slivrr.Models
{
    public class CategoryToProduct
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        // Navigational Properties
        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}