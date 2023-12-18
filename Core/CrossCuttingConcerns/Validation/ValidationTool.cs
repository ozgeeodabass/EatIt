using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validater, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validater.Validate(context);
            if (!result.IsValid)
                throw new ValidationException(result.Errors);
        }
    }
}
