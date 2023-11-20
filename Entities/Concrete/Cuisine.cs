using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cuisine:IEntity
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CuisineId { get; set; }
        public string CuisineName { get; set; }

        [JsonIgnore]
        public virtual List<Recipe>? Recipes { get; set; }
    }
}
