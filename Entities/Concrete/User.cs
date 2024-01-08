using Core.Entities;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User : UserBase, IEntity
    {
        [JsonIgnore]
        public virtual List<Recipe>? Recipes { get; set; }

        public OperationClaim OperationClaim { get; set; }
    }
}
