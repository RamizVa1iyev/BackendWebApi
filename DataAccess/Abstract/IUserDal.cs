﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
