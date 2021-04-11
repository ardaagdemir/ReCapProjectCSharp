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
        IDataResult<List<Rentals>> GetCarDetailDto();
        IDataResult<List<CarRentalDetailDto>> GetCarRentalDto();

        IResult Add(Rentals rentals);
        IResult Delete(Rentals rentals);
        IResult Update(Rentals rentals);
        IResult UpdateReturnDate(Rentals rentals);
    }
}
