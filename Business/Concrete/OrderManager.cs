using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public Order Get(int id)
        {
            return _orderDal.Get(p => p.OrderID.Equals(id));
        }

        public List<Order> GetAll(int id)
        {
            return _orderDal.GetAll(p => p.TableID.Equals(id));
        }

        public List<Order> GetAllOrders()
        {
            return _orderDal.GetAll();
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
