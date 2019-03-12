using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.MVCUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrtentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
