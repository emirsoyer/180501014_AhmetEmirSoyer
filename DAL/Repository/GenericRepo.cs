using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class GenericRepo<T>: IGenericDal<T> where T : class
    {
        ApplicationContext genContext = new ApplicationContext();
        public void Add(T t)
        {
            genContext.Add(t);
            genContext.SaveChanges();
        }

        public void Update(T t)
        {
            genContext.Update(t);
            genContext.SaveChanges();
        }

        public void Delete(T t)
        {
            genContext.Remove(t);
            genContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return genContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return genContext.Set<T>().Find(id);
        }
    }
}
