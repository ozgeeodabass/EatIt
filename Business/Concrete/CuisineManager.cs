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
    public class CuisineManager : ICuisineService
    {
        private ICuisineDal _cuisineDal;

        public CuisineManager(ICuisineDal cuisineDal)
        {
            _cuisineDal = cuisineDal;
        }
        public IResult Add(Cuisine user)
        {
            try
            {
                _cuisineDal.Add(user);
                return new SuccessResult(Messages.added);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.failed + " : " + ex.ToString());
            }

        }

        public IResult Delete(int id)
        {
            try
            {
                _cuisineDal.Delete(id);
                return new SuccessResult(Messages.deleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.failed + " : " + ex.ToString());
            }

        }

        public IDataResult<List<Cuisine>> GetAll()
        {
            return new SuccessDataResult<List<Cuisine>>(_cuisineDal.GetAll(), Messages.success);
        }

        public IDataResult<Cuisine> GetByCuisineName(string name)
        {
            return new SuccessDataResult<Cuisine>(_cuisineDal.Get(c => c.CuisineName == name), Messages.success);
        }

        public IDataResult<Cuisine> GetById(int id)
        {
            return new SuccessDataResult<Cuisine>(_cuisineDal.Get(c => c.CuisineId == id), Messages.success);
        }

        public IResult Update(int id, Cuisine cuisine)
        {
            try
            {
                _cuisineDal.Update(id, cuisine);
                return new SuccessResult(Messages.updated);
            }
            catch (Exception ex)
            {
                return new ErrorResult(Messages.failed + " : " + ex.ToString());
            }

        }
    }
}
