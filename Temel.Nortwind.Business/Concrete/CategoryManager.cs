using System;
using System.Collections.Generic;
using System.Text;
using Temel.Nortwind.Business.Abstract;
using Temel.Nortwind.DAL.Abstract;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.Business.Concrete
{
    class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDal;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDal = categoryDAL;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
                }
    }
}
