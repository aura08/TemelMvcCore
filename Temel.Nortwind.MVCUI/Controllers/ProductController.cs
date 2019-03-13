using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Temel.Nortwind.Business.Abstract;
using Temel.Nortwind.MVCUI.Models;

namespace Temel.Nortwind.MVCUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int page = 1,int Category=0)
        { int pageSize = 10;
            var products = Category == 0 ? _productService.GetAll() : _productService.GetByCategory(Category);
            ProductListViewModel model = new ProductListViewModel
            {

                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrtentCategory = Category,
                CurrentPage = page
            };


            return View(model);
        }
        //public IActionResult AddToCart()
        //{

        //}
        
    }
}