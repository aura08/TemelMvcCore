using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.MVCUI.Services
{
    public interface ICartServiceSession
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
