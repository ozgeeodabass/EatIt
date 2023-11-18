using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ingredient : IEntity
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
       
        public virtual List<RecipeIngredient> RecipeIngredients { get; } = new List<RecipeIngredient>();


    }
}
