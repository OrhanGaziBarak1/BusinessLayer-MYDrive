using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserAuthorityService
    {
        List<UserAuthority> GetUserAuthorities();
        void AddUserAuthority(UserAuthority userAuthority);
        void UserAuthorityRemove(UserAuthority userAuthority);
        UserAuthority GetByID(int id);
        void UserAuthorityUpdate(UserAuthority userAuthority);
    }
}
