using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace DAL.Interfaces
{
    public interface IUserDal
    {
        List<User> GetUsers();
        User GetUsersById(int userId);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user); //int userId parametre olacak

    }
}
