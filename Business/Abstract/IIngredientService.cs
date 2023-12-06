using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIngredientService
    {
        IDataResult<List<Ingredient>> GetAll();
        IDataResult<Ingredient> GetById(int id);
        IDataResult<Ingredient> GetByIngredientName(string name);
        IResult Update(int id, Ingredient ingredient);
        IResult Delete(int id);
        IResult Add(Ingredient ingredient);
    }
}
