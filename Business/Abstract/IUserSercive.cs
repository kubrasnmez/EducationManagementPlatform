using Core.Entities.Concreate;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserSercive
    {
        IDataResult<User> GetByTCno(string tckn);
        List<OperationClaim> GetClaims(User user);
    }
}
