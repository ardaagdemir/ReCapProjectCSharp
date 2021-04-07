using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResulvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<EfCarDal>().As<ICarDal>();

            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<EfColorDal>().As<IColorDal>();

            builder.RegisterType<CustomerManager>().As<ICustomersService>();
            builder.RegisterType<EfColorDal>().As<IColorDal>();

            builder.RegisterType<RentalsManager>().As<IRentalsService>();
            builder.RegisterType<EfRentalsDal>().As<IRentalsDal>();

            builder.RegisterType<UsersManager>().As<IUsersService>();
            builder.RegisterType<EfUsersDal>().As<IUsersDal>();

        }
    }
}
