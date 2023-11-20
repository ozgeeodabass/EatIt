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
        List<Ingredient> GetAll();
        Ingredient GetById(int id);
        Ingredient GetByIngredientName(string name);
        void Update(int id, Ingredient ingredient);
        void Delete(int id);
        void Add(Ingredient ingredient);
    }
}
