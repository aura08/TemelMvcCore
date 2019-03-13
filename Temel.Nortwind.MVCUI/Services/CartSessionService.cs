using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temel.Nortwind.Entities.Concrete;
using Temel.Nortwind.MVCUI.ExtensionMethod;

namespace Temel.Nortwind.MVCUI.Services
{
    public class CartSessionService : ICartServiceSession
    {
        IHttpContextAccessor httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
           Cart cartToChech= httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToChech == null)
            {
                httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cartToChech= httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartToChech;
        }

        public void SetCart(Cart cart)
        {
            httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
