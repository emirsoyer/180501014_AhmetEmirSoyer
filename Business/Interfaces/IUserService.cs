using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace Business.Interfaces
{
    public interface IUserService
    {
        void UserAdd(User user);
        void UserDelete(User user);
        void UserUpdate(User user);
        User GetById(int id);
        List<User> GetAll();

    }
}
