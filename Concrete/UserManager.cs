using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DotNetSix;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        Hashing hashObj = new Hashing();

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            user.Password = hashObj.HashPassword(user.Password);
            _userDal.Insert(user);
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public User GetByID(int id)
        {
            return _userDal.Get(x => x.UserID == id);
        }

        public List<User> GetUsers()
        {
            return _userDal.Read();
        }
        public void UserUpdate(User user)
        {
            _userDal.Update(user);
        }
    }
}

namespace DotNetSix
{
    using BCrypt.Net;

    public class Hashing
    {
        public string HashPassword(string password)
        {
            return BCrypt.HashPassword(password);
        }
    } 
}