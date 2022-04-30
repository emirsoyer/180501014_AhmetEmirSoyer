﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using DAL.EF;
using DAL.Interfaces;
using DAL.Repository;
using Entity.Concrete;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
         IUserDal _userDal;

         public UserManager(IUserDal userDal)
         {
             _userDal = userDal;
         }
        public void UserAdd(User user)
        {
            _userDal.Add(user);
        }

        public void UserDelete(User user)
        {
            _userDal.Delete(user);
        }

        public void UserUpdate(User user)
        {
            _userDal.Update(user);
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
    }
}
