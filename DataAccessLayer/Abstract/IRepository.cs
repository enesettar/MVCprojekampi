using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //T nin amacı;dışarıdna gelecek entity e atama yapar.
    {
        List<T> List();
        void Insert(T p); //T classları (entityleri) temsil ediyor. Hangi classtan veri geliyorsa onu p parametresine aktarır
        void Delete(T p);
        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter); //şartlı listeleme yapar. mesela yazar adı ali olanları getir
    }
}
