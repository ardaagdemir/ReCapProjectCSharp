using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDAL : ICarDAL
    {
        List<Car> _cars; //Global Variable

        public InMemoryCarDAL()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=0034, ModelYear=2005, DailyPrice=75, Description="BMW"},
                new Car{Id=2, BrandId=1, ColorId=0015, ModelYear=2021, DailyPrice=2000, Description="BMW"},
                new Car{Id=3, BrandId=2, ColorId=0027, ModelYear=2015, DailyPrice=200, Description="Volkwagen"},
                new Car{Id=4, BrandId=3, ColorId=0108, ModelYear=2010, DailyPrice=125, Description="Audi"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ
            //SingleOrDefault tek bir ürünü bulmak için kullanılmştır.
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        //Şartı sağlayan tüm durumlardan yeni bir liste oluşur.
        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();

        }

        public void Uptade(Car car)
        {
            Car carsToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);

            carsToUptade.BrandId = car.BrandId;
            carsToUptade.ColorId = car.ColorId;
            carsToUptade.ModelYear = car.ModelYear;
            carsToUptade.DailyPrice = car.DailyPrice;
            carsToUptade.Description = car.Description;
            
        }
    }
}
