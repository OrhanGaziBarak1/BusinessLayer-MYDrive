using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRoleAuthorityService
    {
        List<RoleAuthority> GetRoleAuthorities();
        void AddRoleAuthortiy (RoleAuthority roleAuthority);
        RoleAuthority GetByID(int id);
        void RoleAuthorityRemove(RoleAuthority roleAuthortiy);
        void RoleAuthorityUpdate(RoleAuthority roleAuthortiy);
    }
}
