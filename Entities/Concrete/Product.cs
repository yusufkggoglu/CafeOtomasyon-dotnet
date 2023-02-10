using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public decimal  Price  { get; set; }
    }
}
