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
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        public List<Payment> GetAll()
        {
            return _paymentDal.GetAll();
        }

        public void Add(Payment payment)
        {
            ValidationTool.Validate(new PaymentValidator(), payment);
            _paymentDal.Add(payment);
        }

        public void Update(Payment payment)
        {
            ValidationTool.Validate(new PaymentValidator(), payment);
            _paymentDal.Update(payment);
        }

        public void Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
        }

        public Payment Get(int id)
        {
            return _paymentDal.Get(p => p.PaymentID.Equals(id));
        }

        public List<Payment> GetByPaymentMethod(string method)
        {
            return _paymentDal.GetAll(p => p.PaymentMethod.Equals(method));
        }
    }
}
