using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEducationService
    {
        IDataResult<List<Education>> GetAll();
        IDataResult<Education> GetById(int educationId);
        IResult Add(Education education);
        IResult Delete(Education education);
        IResult Update(Education education);

        
    }
}
