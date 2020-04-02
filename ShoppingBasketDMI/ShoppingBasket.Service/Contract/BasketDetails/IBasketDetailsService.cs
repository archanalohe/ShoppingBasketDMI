using Basket.Library.OfferVoucher;
using ShoppingBasketRepository.Interface.BasketDetailsRepository;
using System.Collections.Generic;

namespace ShoppingBasket.Service.Contract.BasketDetails
{
    public interface IBasketDetailsService
    {
        List<OfferVoucherCategoryType> AddVoucher(OfferVoucherCategoryType offerVoucherCategoryType);
        (string errorMessage, double totalAmount) GetBasketTotalAmount(IBasketDetailsRepository basketDetailsRepository, List<OfferVoucherCategoryType> voucherCategoryTypeInfo = null);
    }
}
