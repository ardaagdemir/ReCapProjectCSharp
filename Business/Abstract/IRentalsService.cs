using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalsService
    {
        IDataResult<List<Rental>> GetCarDetailDto();
        IDataResult<List<CarRentalDetailDto>> GetCarRentalDto();

        IResult Add(Rental rentals);
        IResult Delete(Rental rentals);
        IResult Update(Rental rentals);
        IResult UpdateReturnDate(Rental rentals);
    }
}
