using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Repository;
using Entity.Concrete;

namespace DAL.EF
{
    public class EfUserRepo:GenericRepo<User>, IUserDal
    {

    }
}
