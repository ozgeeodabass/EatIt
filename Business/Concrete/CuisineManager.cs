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
    public class CuisineManager : ICuisineService
    {
        private ICuisineDal _cuisineDal;

        public CuisineManager(ICuisineDal cuisineDal)
        {
            _cuisineDal = cuisineDal;
        }
        public void Add(Cuisine user)
        {
            _cuisineDal.Add(user);
        }

        public void Delete(int id)
        {
           _cuisineDal.Delete(id);
        }

        public List<Cuisine> GetAll()
        {
            return _cuisineDal.GetAll();
        }

        public Cuisine GetByCuisineName(string name)
        {
            return _cuisineDal.Get(c=>c.CuisineName==name);
        }

        public Cuisine GetById(int id)
        {
            return _cuisineDal.Get(c => c.CuisineId == id);
        }

        public void Update(int id, Cuisine cuisine)
        {
           _cuisineDal.Update(id, cuisine); 
        }
    }
}
