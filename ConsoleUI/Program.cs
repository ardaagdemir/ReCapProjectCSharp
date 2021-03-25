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


            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka-Model" + "-->" + " " + car.Description + " " + car.CarName + " " + "Fiyat:" + car.DailyPrice );
            }

        }
    }
}
