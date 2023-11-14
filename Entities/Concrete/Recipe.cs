using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Recipe : IEntity
    {
        public int RecipeId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } //Navigation property

        public string RecipeName { get; set; }
        public string RecipeDescription { get; set;}
        public TimeSpan PreparationTime { get; set; }
        public TimeSpan CookingTime { get; set; }

        List<RecipeIngredient> RecipeIngredients { get; set; } //Navigation property

        public int? CuisineId { get; set; }
        public Cuisine Cuisine { get; set; } //Navigation property

    }
}
