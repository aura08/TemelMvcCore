using System;
using System.Collections.Generic;
using System.Text;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product product);
        void RemoveFromCart(Cart cart,int productId);
        List<CartLine> List(Cart cart);
    }
}
