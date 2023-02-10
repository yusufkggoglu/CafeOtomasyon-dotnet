using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int RoleID { get; set; }
        public string Password { get; set; }

    }
}
