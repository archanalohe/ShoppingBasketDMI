using ShoppingBasket.Model.BasketDetails;
using ShoppingBasket.Model.Products;
using System.Collections.Generic;

namespace ShoppingBasketRepository.Interface.BasketDetailsRepository
{
    public interface IBasketDetailsRepository
    {
        void AddProductToBasket(Product product);

        void RemoveProductFromBasket(Product product);

        void EmptyBasket();

        List<BasketDetail> GetBasketItems();
    }
}
