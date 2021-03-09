using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDAL
    {
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Uptade(Car car);
        
        List<Car> GetById(int carId);
    }
}
