using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class OutGoing:IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
