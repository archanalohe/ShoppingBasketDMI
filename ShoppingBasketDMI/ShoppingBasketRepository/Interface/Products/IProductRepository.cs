using ShoppingBasket.Model.Products;

namespace ShoppingBasketRepository.Interface.Products
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
    }
}
