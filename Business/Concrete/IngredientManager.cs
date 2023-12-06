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
    public class IngredientManager : IIngredientService
    {
        private IIngredientDal _ingredientDal;

        public IngredientManager(IIngredientDal ingredientDal)
        {
            _ingredientDal = ingredientDal;
        }
        public IResult Add(Ingredient ingredient)
        {
            try
            {
                _ingredientDal.Add(ingredient);
                return new SuccessResult(Messages.added);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.failed);
            }

        }

        public IResult Delete(int id)
        {
            try
            {
                _ingredientDal.Delete(id);
                return new SuccessResult(Messages.deleted);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.failed);
            }

        }

        public IDataResult<List<Ingredient>> GetAll()
        {
            return new SuccessDataResult<List<Ingredient>>(_ingredientDal.GetAll(), Messages.success);
        }

        public IDataResult<Ingredient> GetById(int id)
        {
            return new SuccessDataResult<Ingredient>(_ingredientDal.Get(i => i.IngredientId == id));
        }

        public IDataResult<Ingredient> GetByIngredientName(string name)
        {
            return new SuccessDataResult<Ingredient>(_ingredientDal.Get(i => i.IngredientName == name));

        }
        public IResult Update(int id, Ingredient ingredient)
        {

            try
            {
                _ingredientDal.Update(id, ingredient);
                return new SuccessResult(Messages.updated);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.failed);
            }

        }
    }
}
