using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cuisine:IEntity
    {
        public int CuisineId { get; set; }
        public string CuisineName { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
