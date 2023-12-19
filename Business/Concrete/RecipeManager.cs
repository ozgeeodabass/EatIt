using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RecipeManager : IRecipeService
    {

        private IRecipeDal _recipeDal;

        public RecipeManager(IRecipeDal recipeDal)
        {
            _recipeDal = recipeDal;
        }
        public IResult Add(Recipe recipe)
        {

            //validation
            ValidationTool.Validate(new RecipeValidator(), recipe);

            //busines rules 
            //....

            _recipeDal.Add(recipe);
            return new SuccessResult(Messages.added);


        }

        public IDataResult<List<RecipeDetailDto>> GetRecipesDetail()
        {
            return new SuccessDataResult<List<RecipeDetailDto>>(_recipeDal.GetRecipesDetail(), Messages.success);
        }

        public IResult Delete(int id)
        {
            try
            {
                _recipeDal.Delete(id);
                return new SuccessResult(Messages.deleted);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.failed);
            }

        }

        public IDataResult<List<Recipe>> GetAll()
        {
            return new SuccessDataResult<List<Recipe>>(_recipeDal.GetAll(), Messages.success);
        }

        public IDataResult<List<Recipe>> GetAllRecipesByCuisineId(int id)
        {
            return new SuccessDataResult<List<Recipe>>(_recipeDal.GetAll(r => r.CuisineId == id), Messages.success);
        }


        public IDataResult<List<Recipe>> GetAllRecipesByUserId(int id)
        {
            return new SuccessDataResult<List<Recipe>>(_recipeDal.GetAll(r => r.UserId == id), Messages.success);
        }

        public IDataResult<Recipe> GetById(int id)
        {
            return new SuccessDataResult<Recipe>(_recipeDal.Get(r => r.RecipeId == id), Messages.success);
        }

        public IDataResult<Recipe> GetRecipeByName(string name)
        {
            return new SuccessDataResult<Recipe>(_recipeDal.Get(r => r.RecipeName == name), Messages.success);
        }

        public IResult Update(int id, Recipe recipe)
        {
            try
            {
                _recipeDal.Update(id, recipe);
                return new SuccessResult(Messages.updated);
            }
            catch (Exception)
            {
                return new ErrorResult(Messages.failed);
            }

        }

        public IDataResult<RecipeDetailDto> GetRecipeDetail(int id)
        {
            return new SuccessDataResult<RecipeDetailDto>(_recipeDal.GetRecipeDetail(id),Messages.success);
        }
    }
}
