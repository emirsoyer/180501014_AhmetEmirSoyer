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

        public void Add(User t)
        {
            throw new NotImplementedException();
        }

        public void Update(User t)
        {
            throw new NotImplementedException();
        }

        public void Delete(User t)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
