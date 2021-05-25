using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class  //
    {
        Context c = new Context();
        DbSet<T> _object; // T değerine karşılık gelen sınıfı tutar

        //T değerine karşılık gelen sınıfı nasıl bulurum?
        //normal writer ya da diğer sınıflarında repolarında T değeri belli idi yani writer ise writer ama burada belli değil. Onun ataması için ctor kullanılır

        public GenericRepository()
        {
            _object = c.Set<T>(); //object e contexte bağı olarak gönderilen T değeri yani class olacak
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
