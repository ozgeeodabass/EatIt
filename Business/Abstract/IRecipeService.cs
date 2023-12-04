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
        List<Recipe> GetAll();
        Recipe GetById(int id);
        List<Recipe> GetAllRecipesByUserId(int id);
        Recipe GetRecipeByName(string name);
       // List<Recipe> GetAllRecipesByIngredientId(int id);
        List<Recipe> GetAllRecipesByCuisineId(int id);
        void Update(int id, Recipe recipe);
        void Delete(int id);
        void Add(Recipe recipe);
        List<RecipeDetailDto> GetRecipesDetail();
        RecipeDetailDto GetRecipeDetail(int id);
    }
}
