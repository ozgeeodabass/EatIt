using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Recipe : IEntity
    {
        public int RecipeId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }  //Navigation property

        public string RecipeName { get; set; }
        public string RecipeDescription { get; set;}
        public string PreparationTime { get; set; }
        public string CookingTime { get; set; }

        public List<Ingredient> Ingredients { get; set; } 

        public int CuisineId { get; set; }
        public Cuisine Cuisine { get; set; } = null!; //Navigation property

    }
}
