using Core.Utilities.Results;
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
        IDataResult<List<Cuisine>> GetAll();
        IDataResult<Cuisine> GetById(int id);
        IDataResult<Cuisine> GetByCuisineName(string name);
        IResult Update(int id, Cuisine cuisine);
        IResult Delete(int id);
        IResult Add(Cuisine user);
    }
}
