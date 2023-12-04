using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRecipeDal : EfEntityDalBase<Recipe, EatItContext>, IRecipeDal
    {
        public RecipeDetailDto GetRecipeDetail(int id)
        {
            using (EatItContext context = new EatItContext())
            {
                var result = (from r in context.Recipes
                             join c in context.Cuisines
                             on r.CuisineId equals c.CuisineId
                             join u in context.Users
                             on r.UserId equals u.UserId
                             where r.RecipeId == id
                             select new RecipeDetailDto
                             {
                                 CookingTime = r.CookingTime,
                                 PreparationTime = r.PreparationTime,
                                 RecipeName = r.RecipeName,
                                 RecipeId = r.RecipeId,
                                 CuisineName = c.CuisineName,
                                 RecipeDescription = r.RecipeDescription,
                                 UserName = u.UserName,
                                 IngredientNames = r.Ingredients.Select(x => x.IngredientName).ToList()
                             }).SingleOrDefault();

                return result;

            }
        }

        public List<RecipeDetailDto> GetRecipesDetail()
        {
            using(EatItContext context = new EatItContext())
            {
                var result = from r in context.Recipes
                             join c in context.Cuisines
                             on r.CuisineId equals c.CuisineId
                             join u in context.Users
                             on r.UserId equals u.UserId
                             select new RecipeDetailDto 
                             {
                                 CookingTime = r.CookingTime, PreparationTime = r.PreparationTime,
                                 RecipeName = r.RecipeName, RecipeId = r.RecipeId, 
                                 CuisineName = c.CuisineName, RecipeDescription = r.RecipeDescription,
                                 UserName = u.UserName,
                                 IngredientNames = r.Ingredients.Select(x=>x.IngredientName).ToList()
                             };

                return result.ToList();
                       
            }
        }
    }
}
