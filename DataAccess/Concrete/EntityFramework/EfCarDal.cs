using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                //referansı yakala, sil, kaydet
                var addedEntity = context.Entry(entity);
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Car entity)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                //referansı yakala, sil, kaydet
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                //filter null ise ilk context, değil ise ikinci context çalışır
                return filter == null
                    ?context.Set<Car>().ToList() 
                    :context.Set<Car>().Where(filter).ToList();           
            }
        }

        public Car GetT(Expression<Func<Car, bool>> filter = null)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Uptade(Car entity)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                //referansı yakala, sil, kaydet
                var uptadedEntity = context.Entry(entity);
                uptadedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
                

        }
    }
}
