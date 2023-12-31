﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        List<User> GetUsers();
        void AddUser(User user);
        void DeleteUser(User user);
        User GetByID(int id);
        void UserUpdate(User user);
    }
}
