using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void AddRole(Role role)
        {
            _roleDal.Insert(role);
        }

        public Role GetByID(int id)
        {
            return _roleDal.Get(x => x.RoleID == id);
        }

        public List<Role> GetRoles()
        {
            return _roleDal.Read();
        }

        public void RoleRemove(Role role)
        {
            _roleDal.Delete(role);
        }
        public void RoleUpdate (Role role)
        {
            _roleDal.Update(role);
        }
    }
}
