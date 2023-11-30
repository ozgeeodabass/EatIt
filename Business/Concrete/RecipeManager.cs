using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public void Add(Recipe recipe)
        {
            _recipeDal.Add(recipe);
        }

        public void Delete(int id)
        {
            _recipeDal.Delete(id); 
        }

        public List<Recipe> GetAll()
        {
            return _recipeDal.GetAll();
        }

        public List<Recipe> GetAllRecipesByCuisineId(int id)
        {
            return _recipeDal.GetAll(r=>r.CuisineId == id);
        }

        //public List<Recipe> GetAllRecipesByIngredientId(int id)
        //{
        //    return _recipeDal.GetAll(r => r.RecipeIngredients.Contains(r.RecipeIngredients.SingleOrDefault(x=>x.IngredientId==id)));
        //}

        public List<Recipe> GetAllRecipesByUserId(int id)
        {
            return _recipeDal.GetAll(r => r.UserId == id);
        }

        public Recipe GetById(int id)
        {
            return _recipeDal.Get(r=>r.RecipeId == id);
        }

        public Recipe GetRecipeByName(string name)
        {
            return _recipeDal.Get(r => r.RecipeName == name);
        }

        public void Update(int id, Recipe recipe)
        {
            _recipeDal.Update(id, recipe);
        }
    }
}
