using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, CafeContext>, ICategoryDal
    {
    }
}
