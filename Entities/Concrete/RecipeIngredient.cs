using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RecipeIngredient : IEntity
    {
        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }
        public int IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }

        public string Amount { get; set; }


    }
}
