using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        IDataResult<User> GetById(int id);
        User GetByMail(string email);
        IDataResult<User> GetByMaill(string email);
    }
}
