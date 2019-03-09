using System;
using System.Collections.Generic;
using System.Text;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.Business.Abstract
{
   public  interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int CategoryId);
        void Add(Product product);
        void Delete(int ProductId);
        void Update(Product product);
    }
}
