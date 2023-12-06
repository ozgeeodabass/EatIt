using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.added);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.failed);
            }
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
