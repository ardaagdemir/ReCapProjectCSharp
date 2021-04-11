using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomersService
    {
        ICustomerDal _customersDal;

        public CustomerManager(ICustomerDal customersDal)
        {
            _customersDal = customersDal;
        }

        public IResult Add(Customer customers)
        {
            _customersDal.Add(customers);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customers)
        {
            _customersDal.Delete(customers);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customersDal.GetAll(), Messages.CustomerListed);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetail()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customersDal.GetCustomerDetails());
        }

        public IResult Update(Customer customers)
        {
            _customersDal.Update(customers);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
