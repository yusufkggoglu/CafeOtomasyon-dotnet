using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using Ninject.Planning.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
          public override void Load()
          {
            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();

            Bind<IOrderService>().To<OrderManager>();
            Bind<IOrderDal>().To<EfOrderDal>();

            Bind<IOutGoingService>().To<OutGoingManager>();
            Bind<IOutGoingDal>().To<EfOutGoingDal>();

            Bind<IPaymentService>().To<PaymentManager>();
            Bind<IPaymentDal>().To<EfPaymentDal>();

            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();

            Bind<IRoleService>().To<RoleManager>();
            Bind<IRoleDal>().To<EfRoleDal>();

            Bind<ITableService>().To<TableManager>();
            Bind<ITableDal>().To<EfTableDal>();

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();
        }
    }
}
