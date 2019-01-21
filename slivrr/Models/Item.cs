namespace slivrr.Models
{
    public class Item
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        // Navigational Properties
        public Product Product { get; set; }
    }
}