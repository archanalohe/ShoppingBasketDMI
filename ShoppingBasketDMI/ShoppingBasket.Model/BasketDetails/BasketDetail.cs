using ShoppingBasket.Model.Products;

namespace ShoppingBasket.Model.BasketDetails
{
    public class BasketDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
