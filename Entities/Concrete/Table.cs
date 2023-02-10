using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
namespace Entities.Concrete
{
    public class Table:IEntity
    {
        public int TableID { get; set; }
        public string TableName { get; set; }
        public int Status { get; set; }
    }
}
