using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temel.Nortwind.Business.Abstract;
using Temel.Nortwind.Business.Concrete;
using Temel.Nortwind.MVCUI.Services;

namespace Temel.Nortwind.MVCUI.Controllers
{
    public class CartController:Controller
    {
        private ICartServiceSession CartSessionService;
        private ICartService cartService;
        private IProductService productSevice;
        public CartController(ICartServiceSession CartSessionService, ICartService cartService, IProductService productSevice)
        {
            this.CartSessionService = CartSessionService;
            this.cartService = cartService;
            this.productSevice = productSevice;
        }
        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = productSevice.GetById(productId);

            var cart = CartSessionService.GetCart();
            cartService.AddToCart(cart, productToBeAdded);
            CartSessionService.SetCart(cart);
            TempData.Add("message",String.Format("Your product,{0}, was succesfully added to cart",productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }


    }
}
