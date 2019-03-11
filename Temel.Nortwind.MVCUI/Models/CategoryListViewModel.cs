using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.MVCUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
    }
}
