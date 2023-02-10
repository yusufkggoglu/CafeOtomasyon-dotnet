﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal=roleDal;
        }
        public void Add(Role role)
        {
            _roleDal.Add(role);
        }

        public void Delete(Role role)
        {
            _roleDal.Delete(role);
        }

        public Role Get(int id)
        {
            return _roleDal.Get(p => p.RoleID.Equals(id));
        }

        public List<Role> GetAll()
        {
            return _roleDal.GetAll();
        }

        public void Update(Role role)
        {
            _roleDal.Update(role);
        }
    }
}
