using System;
using System.Collections.Generic;
using System.Text;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.DAL.Abstract
{
    public interface ICategoryDAL : Core.DataAccess.IEntityRepository<Category>
    {
        //Special Prosedürler yazılabilir.
    }
}
