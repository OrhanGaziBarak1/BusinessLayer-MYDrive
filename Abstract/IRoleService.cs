using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRoleService
    {
        List<Role> GetRoles();
        void AddRole (Role role);
        Role GetByID(int id);
        void RoleRemove(Role role);
        void RoleUpdate(Role role);
    }
}
