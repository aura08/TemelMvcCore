using System;
using System.Collections.Generic;
using System.Text;
using Temel.Core;

namespace Temel.Nortwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }


    }
}
