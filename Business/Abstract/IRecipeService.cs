using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRecipeService
    {
        IDataResult<List<Recipe>> GetAll();
        IDataResult<Recipe> GetById(int id);
        IDataResult<List<Recipe>> GetAllRecipesByUserId(int id);
        IDataResult<Recipe> GetRecipeByName(string name);
        IDataResult<List<Recipe>> GetAllRecipesByCuisineId(int id);
        IResult Update(int id, Recipe recipe);
        IResult Delete(int id);
        IResult Add(Recipe recipe);
        IDataResult<List<RecipeDetailDto>> GetRecipesDetail();
        IDataResult<RecipeDetailDto> GetRecipeDetail(int id);
    }
}
