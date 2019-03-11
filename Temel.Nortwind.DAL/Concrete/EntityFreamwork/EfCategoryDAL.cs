using System;
using System.Collections.Generic;
using System.Text;
using Temel.Core.DataAccess.EntityFreamwork;
using Temel.Nortwind.DAL.Abstract;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.DAL.Concrete.EntityFreamwork
{
   public class EfCategoryDAL:EfEntityRepositoryBase<Category,NortwindContext>,ICategoryDAL
    {
    }
}
