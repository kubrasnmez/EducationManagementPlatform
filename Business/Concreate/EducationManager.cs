using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        
        {
            _educationDal = educationDal;
        }

        public IResult Add(Education education)
        {
            _educationDal.Add(education);
            return new SuccessResult(Messages.EducationAdded);
        }

        public IResult Delete(Education education)
        {
            _educationDal.Delete(education);
            return new SuccessResult();
        }

        public IDataResult<List<Education>> GetAll()
        {
            return new SuccessDataResult<List<Education>>(_educationDal.GetAll());
        }

        public IDataResult<Education> GetById(int educationId)
        {
            return new SuccessDataResult<Education>(_educationDal.Get(b => b.Id == educationId));
        }

        public IResult Update(Education education)
        {
            _educationDal.Update(education);
            return new SuccessResult();
        }
    }
}
