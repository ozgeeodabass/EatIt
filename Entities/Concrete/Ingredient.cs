using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ingredient : IEntity
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }

        [JsonIgnore]
        public virtual List<Recipe> Recipes { get; set; }


    }
}
