using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;


namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Get(int id)
        {
            return _productDal.Get(p => p.ProductID.Equals(id));
        }
    }
}
