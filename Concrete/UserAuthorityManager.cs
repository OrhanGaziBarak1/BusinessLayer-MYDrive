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
    public class UserAuthorityManager : IUserAuthorityService
    {
        IUserAuthorityDal _userAuthoirtyDal;

        public UserAuthorityManager(IUserAuthorityDal userAuuthority)
        {
            _userAuthoirtyDal = userAuuthority;
        }

        public void AddUserAuthority(UserAuthority userAuthority)
        {
            _userAuthoirtyDal.Insert(userAuthority);
        }

        public UserAuthority GetByID(int id)
        {
            return _userAuthoirtyDal.Get(x => x.UserAuthorityID == id);
        }

        public List<UserAuthority> GetUserAuthorities()
        {
            return _userAuthoirtyDal.Read();
        }

        public void UserAuthorityRemove(UserAuthority userAuthority)
        {
            _userAuthoirtyDal.Delete(userAuthority);
        }
        public void UserAuthorityUpdate(UserAuthority userAuthority)
        {
            _userAuthoirtyDal.Update(userAuthority);
        }
    }
}
