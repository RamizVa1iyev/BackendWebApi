using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.Concrete.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from OperationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on OperationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim(){Id = OperationClaim.Id,Name = OperationClaim.Name};
                return result.ToList();
            }
        }
    }
}
