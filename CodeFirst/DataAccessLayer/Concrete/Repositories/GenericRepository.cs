using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        // Generic repository operasyonları tek tek her class için yazmak yerine
        // Class parametresi alarak her class için o işlevi yerine getiriyor (ortak operasyonlar için)
        Context db = new Context();
        DbSet<T> _object;
        
        public GenericRepository()
        {
           _object=db.Set<T>();
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            db.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            db.SaveChanges();
        }

        public List<T> List()
        {
           return _object.ToList();
        }

        public List<T> List(Func<T, bool> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            db.SaveChanges(p);
        }
        
    }
}
