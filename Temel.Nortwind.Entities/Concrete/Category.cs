using System;
using System.Collections.Generic;
using System.Text;
using Temel.Core;

namespace Temel.Nortwind.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CatagoryName { get; set; }

    }
}
