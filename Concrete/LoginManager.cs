using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DotNetSix;
using EntityLayer.Concrete;
using System.Linq;


namespace BusinessLayer.Concrete
{
    public class LoginManager : ILoginService
    {
        Context context = new Context();

        public User isUser;

        public Verifying verifyObj = new Verifying();
        public bool Login(User user)
        {
            bool passwordVerifyingResult = false;
            isUser = context.Users.FirstOrDefault(x => x.Mail == user.Mail);

            if (isUser != null)
            {
                passwordVerifyingResult = verifyObj.verifyPassword(user.Password, isUser.Password);
                
            }

            return passwordVerifyingResult;
        }
    }
}

namespace DotNetSix
{
    using BCrypt.Net;
    public class Verifying
    {
        public bool verifyPassword(string userPassword, string tablePassword)
        {
            return BCrypt.Verify(userPassword, tablePassword);
        }
    }
}
