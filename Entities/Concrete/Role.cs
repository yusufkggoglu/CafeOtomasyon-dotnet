using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Role:IEntity
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
