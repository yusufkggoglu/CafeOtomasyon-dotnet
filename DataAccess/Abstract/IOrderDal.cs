using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ComplexTypes;
using Entities.Concrete;
namespace DataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {
        List<OrderDetail> OrderDetails(Expression<Func<OrderDetail, bool>> filter = null);
    }
}
