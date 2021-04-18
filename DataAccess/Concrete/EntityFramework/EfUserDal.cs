using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarProjectContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from userOperationClaim in context.UserOperationClaims
                             join operationClaim in context.OperationClaims
                               on userOperationClaim.OperationClaimId equals operationClaim.Id

                             where userOperationClaim.UserId == user.Id

                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }   
}
