using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RoleAuthorityManager : IRoleAuthorityService
    {
        IRoleAuthortiyDal _roleAuthority;

        public RoleAuthorityManager(IRoleAuthortiyDal roleAuthority)
        {
            _roleAuthority = roleAuthority;
        }

        public void AddRoleAuthortiy(RoleAuthority roleAuthority)
        {
            _roleAuthority.Insert(roleAuthority);
        }

        public RoleAuthority GetByID(int id)
        {
            return _roleAuthority.Get(x => x.RoleAuthorityID == id);
        }

        public List<RoleAuthority> GetRoleAuthorities()
        {
            return _roleAuthority.Read();
        }

        public void RoleAuthorityRemove(RoleAuthority roleAuthortiy)
        {
            _roleAuthority.Delete(roleAuthortiy);
        }
        public void RoleAuthorityUpdate (RoleAuthority roleAuthortiy)
        {
            _roleAuthority.Update(roleAuthortiy);
        }
    }
}
