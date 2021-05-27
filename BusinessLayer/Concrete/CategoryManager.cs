using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
     public class CategoryManager:ICategoryService

    {
        ICategoryDal _categoryDal;

       

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

       

        public void CategoryAddBL(Category category)
        {
            throw new NotImplementedException();
        }


        //üzerinde çalışacağım sınıfı çağırmam gerek.Repository sııfına bağlı olarak çağırırım.
        //GenericRepository<Category> repo = new GenericRepository<Category>(); //zerinde çalışmak istediğim sınıfı çağırdım

        //sonra sırası ile curd işlemleri methodları yazılır
        //public List<Category> GetAll()
        //{
        //    return repo.List(); //generic reposityory e ait bir değeri gösterir,bunun içinede kategori sınıfını alır
        //    //
        //}

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
        //public void CategoryAddBL(Category p) //kategori sınıfında türetilen p parametresi eklenir
        //{
        //    if(p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length >= 51)
        //    {
        //       //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //    //hata mesajı vermezse p eklenir


        //}

    }
}
