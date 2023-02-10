using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TableManager : ITableService
    {
        private ITableDal _tabledal;
        public TableManager(ITableDal tableDal)
        {
            _tabledal = tableDal;
        }
        public void Add(Table table)
        {
            ValidationTool.Validate(new TableValidator(), table);
            _tabledal.Add(table);        }

        public void Delete(Table table)
        {
            _tabledal.Delete(table);
        }

        public Table Get(int id)
        {
            return _tabledal.Get(p => p.TableID.Equals(id));
        }

        public List<Table> GetAll()
        {
            return _tabledal.GetAll();
        }

        public void Update(Table table)
        {
            ValidationTool.Validate(new TableValidator(), table);
            _tabledal.Update(table);
        }
    }
}
