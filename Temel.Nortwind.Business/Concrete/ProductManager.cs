using System;
using System.Collections.Generic;
using System.Text;
using Temel.Nortwind.Business.Abstract;
using Temel.Nortwind.DAL.Abstract;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.Business.Concrete
{
   public class ProductManager : IProductService
    {
        private IProductDAL _productDal;
        public ProductManager(IProductDAL productDAL)
        {
            _productDal = productDAL;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int ProductId)
        {
            _productDal.Delete(new Product { ProductId = ProductId });

        }

        public List<Product> GetAll()
        {
            return _productDal.GetList(); 
        }

        public List<Product> GetByCategory(int CategoryId)
        {
            return _productDal.GetList(p =>p.CategoryId== CategoryId);
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
