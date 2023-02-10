using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAll();
        void Add(Role role);
        void Update(Role role);
        void Delete(Role role);
        Role Get(int id);
    }
}
