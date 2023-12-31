﻿using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRecipeDal: IEntityRepository<Recipe>
    {
        List<RecipeDetailDto> GetRecipesDetail();
        RecipeDetailDto GetRecipeDetail(int id);
    }
}
