using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ComplexTypes;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll(int id);
        List<Order> GetAllOrders();
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
        Order Get(int id);
        List<OrderDetail> OrderDetails(int id);
    }
}
