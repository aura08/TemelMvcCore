using System;
using System.Collections.Generic;
using System.Text;
using Temel.Nortwind.DAL.Abstract;
using Temel.Nortwind.Entities.Concrete;
using Temel.Core.DataAccess.EntityFreamwork;



namespace Temel.Nortwind.DAL.Concrete.EntityFreamwork
{
   public class EfProductDAL: EfEntityRepositoryBase<Product,NortwindContext>,IProductDAL
    {

    }
  
}
