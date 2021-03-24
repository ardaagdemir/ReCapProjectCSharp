using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            Console.WriteLine("\n" + "Araçları açıklama ve günlük fiyata göre listele");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car : " + car.CarName);
            }

        }
    }
}
