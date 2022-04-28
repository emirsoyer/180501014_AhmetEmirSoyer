using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Interfaces;
using Entity.Concrete;

namespace DAL.Repository
{
    public class UserRepo:IUserDal
    {
        ApplicationContext context = new ApplicationContext();
        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetUsersById(int userId)
        {
            return context.Users.FirstOrDefault(x => x.UserId == userId); //return context.Users.Find(userId);
        }

        public void AddUser(User user)
        {
            context.Add(user);
            context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            context.Update(user);
            context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            context.Remove(user);
            context.SaveChanges();
        }
    }
}
