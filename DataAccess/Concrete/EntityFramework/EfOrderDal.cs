using DataAccess.Abstract;
using DataAccess.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, CafeContext>, IOrderDal
    {
        public List<OrderDetail> OrderDetails(Expression<Func<OrderDetail, bool>> filter = null)
        {
            using(CafeContext context = new CafeContext())
            {
                var result = from o in context.Orders
                             join u in context.Users on o.UserID equals u.UserID
                             select new OrderDetail
                             {
                                 ID = o.OrderID,
                                 Masa = o.TableID,
                                 Ürün = o.ProductName,
                                 Fiyat = o.Price,
                                 Miktar = o.Amount,
                                 Tarih = o.OrderTime,
                                 Kullanıcı = u.Ad,
                                 Not = o.Note,
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
