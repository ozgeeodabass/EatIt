using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class IngredientManager : IIngredientService
    {
        private IIngredientDal _ingredientDal;

        public IngredientManager(IIngredientDal ingredientDal)
        {
            _ingredientDal = ingredientDal;
        }
        public void Add(Ingredient ingredient)
        {
            _ingredientDal.Add(ingredient);
        }

        public void Delete(int id)
        {
           _ingredientDal.Delete(id);
        }

        public List<Ingredient> GetAll()
        {
           return _ingredientDal.GetAll();
        }

        public Ingredient GetById(int id)
        {
            return _ingredientDal.Get(i=>i.IngredientId == id);
        }

        public Ingredient GetByIngredientName(string name)
        {
            return _ingredientDal.Get(i => i.IngredientName == name);

        }
        public void Update(int id, Ingredient ingredient)
        {
           _ingredientDal.Update(id, ingredient);
        }
    }
}
