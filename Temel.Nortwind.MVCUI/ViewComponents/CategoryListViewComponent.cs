using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temel.Nortwind.Business.Abstract;
using Temel.Nortwind.MVCUI.Models;

namespace Temel.Nortwind.MVCUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ViewViewComponentResult Invoke()
        {

            var model = new CategoryListViewModel {
            Categories = _categoryService.GetAll()
            };
            return View(model);

        }
    }
}
