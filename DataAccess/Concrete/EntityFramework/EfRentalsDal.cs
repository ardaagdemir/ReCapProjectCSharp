using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalsDal : EfEntityRepositoryBase<Rental, CarProjectContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from rt in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on rt.CarId equals c.CarId
                             join col in context.Colors
                             on c.ColorId equals col.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cus in context.Customers
                             on rt.CustomerId equals cus.Id
                             join us in context.Users
                             on cus.UserId equals us.UserId
                             select new CarRentalDetailDto
                             {
                                 RentalId = rt.Id,
                                 CustomerName = us.FirstName,
                                 CustomerLastName = us.LastName,
                                 CustomerCompanyName = cus.CompanyName,
                                 CarName = c.CarName,
                                 ColorName = col.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 RentDate = rt.RentDate,
                                 ReturnDate = rt.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
