﻿using DataAccessLayer.Abstract;
using DataAccessLayer.concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal //EF,genericteki categroty sınıfındaki methodu kullanacak
    {
    }
}
