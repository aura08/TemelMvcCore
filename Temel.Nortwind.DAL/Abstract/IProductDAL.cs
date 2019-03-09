using System;
using System.Collections.Generic;
using System.Text;
using Temel.Core.DataAccess;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.DAL.Abstract
{
   public interface IProductDAL:IEntityRepository<Product>
    {
        //Special Prosedürler yazılabilir.
    }
  

}
