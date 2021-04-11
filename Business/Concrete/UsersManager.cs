using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {
        IUserDal _usersDal;

        public UsersManager(IUserDal usersDal)
        {
            _usersDal = usersDal;
        }
        public IResult Add(User users)
        {
            _usersDal.Add(users);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User users)
        {
            _usersDal.Delete(users);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(), Messages.UserListed);
        }

        public IResult Update(User users)
        {
            _usersDal.Update(users);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
