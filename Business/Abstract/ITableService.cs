using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface ITableService
    {
        List<Table> GetAll();
        void Add(Table table);
        void Update(Table table);
        void Delete(Table table);
        Table Get(int id);
    }
}
