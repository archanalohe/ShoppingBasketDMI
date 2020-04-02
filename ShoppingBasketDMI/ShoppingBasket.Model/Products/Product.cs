using ShoppingBasket.Model.Enum;

namespace ShoppingBasket.Model.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Cost { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
