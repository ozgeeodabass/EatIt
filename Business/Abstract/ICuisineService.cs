using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICuisineService
    {
        List<Cuisine> GetAll();
        Cuisine GetById(int id);
        Cuisine GetByCuisineName(string name);
        void Update(int id, Cuisine cuisine);
        void Delete(int id);
        void Add(Cuisine user);
    }
}
