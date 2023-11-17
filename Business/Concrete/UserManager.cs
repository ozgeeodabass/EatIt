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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(int id)
        {
            _userDal.Delete(id);
        }

        public List<User> GetAll()
        {
            //iş kodları
            return _userDal.GetAll();
        }

        public void Update(int id, User user)
        {
            _userDal.Update(id, user);
        }
    }
}
