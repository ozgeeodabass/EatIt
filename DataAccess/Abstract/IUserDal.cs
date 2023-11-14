using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal
    {
        List<User> GetAll();
        void Add(User user);
        void Update(int id,User user);
        void Delete(int id);

    }
}
