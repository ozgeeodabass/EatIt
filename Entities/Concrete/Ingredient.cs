using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ingredient : IEntity
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        List<RecipeIngredient> RecipeIngredients { get; set; }


    }
}
