using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        // using = IDisposable pattern implementation of C#
        //using bloğu -- C#' a özel bir yapıdır. Using içerisinde yazılan nesneler using bitince bellekten atılır, bu da kodun daha performanslı çalışmasını sağlar.
        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Brand GetT(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Uptade(Brand entity)
        {
            throw new NotImplementedException();       
        }
    }
}
