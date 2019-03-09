using System;
using System.Collections.Generic;
using System.Text;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();


    }
}
