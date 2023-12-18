using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RecipeValidator : AbstractValidator<Recipe>
    {
        public RecipeValidator()
        {
            RuleFor(p => p.Ingredients).NotEmpty();
            RuleFor(p => p.RecipeName).NotEmpty();
            RuleFor(p => p.RecipeDescription).NotEmpty();
            RuleFor(p => p.CookingTime).NotEmpty();
            RuleFor(p => p.PreparationTime).NotEmpty();
            RuleFor(p => p.UserId).NotEmpty();
        }
    }
}
