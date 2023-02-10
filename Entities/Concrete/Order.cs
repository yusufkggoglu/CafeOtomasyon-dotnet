using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderID { get; set; }
        public int TableID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public DateTime OrderTime { get; set; }
        public int UserID { get; set; }
        public string Note { get; set; }
    }
}
