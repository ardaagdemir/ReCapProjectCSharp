using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rentals rentals)
        {
            _rentalsDal.Add(rentals);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rentals rentals)
        {
            _rentalsDal.Delete(rentals);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rentals>> GetCarDetailDto()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<CarRentalDetailDto>> GetCarRentalDto()
        {
            return new SuccessDataResult<List<CarRentalDetailDto>>(_rentalsDal.GetCarRentalDetails());
        }

        public IResult Update(Rentals rentals)
        {
            _rentalsDal.Uptade(rentals);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult UptadeReturnDate(Rentals rentals)
        {
            var result = _rentalsDal.GetAll(r => r.Id == rentals.Id);
            var uptadeRental = result.LastOrDefault();

            if (uptadeRental.ReturnDate != null)
            {
                return new ErrorResult(Messages.RentalUpdateReturnDateError);
            }

            uptadeRental.ReturnDate = rentals.ReturnDate;
            _rentalsDal.Uptade(rentals);
            return new SuccessResult(Messages.RentalUpdateReturnDate);
        }
    }
}
