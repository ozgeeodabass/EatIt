using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RecipeDetailDto:IDto
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public string PreparationTime { get; set; }
        public string CookingTime { get; set; }
        public string UserName  { get; set; }
        public string CuisineName { get; set; }

        public List<string> IngredientNames { get; set; }
       
    
    }
}
