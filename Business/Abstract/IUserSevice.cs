using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserSevice
    {
        List<User> GetAll();
        void Update(int id, User user);
        void Delete(int id);

    }
}
