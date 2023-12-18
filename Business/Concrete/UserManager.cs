using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            //validation
            ValidationTool.Validate(new UserValidator(), user);

            //busines rules 
            //....

            _userDal.Add(user);
            return new SuccessResult(Messages.added);

        }

        public IResult Delete(int id)
        {
            try
            {
                _userDal.Delete(id);
                return new SuccessResult(Messages.deleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.failed);
            }

        }

        public IDataResult<List<User>> GetAll()
        {
            //iş kodları
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.success);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(i => i.UserId == id), Messages.success);
        }

        public IDataResult<User> GetByUserName(string name)
        {
            return new SuccessDataResult<User>(_userDal.Get(i => i.UserName == name), Messages.success);
        }

        public IResult Update(int id, User user)
        {
            try
            {
                _userDal.Update(id, user);
                return new SuccessResult(Messages.updated);
            }
            catch
            {
                return new ErrorResult(Messages.failed);
            }

        }
    }
}
