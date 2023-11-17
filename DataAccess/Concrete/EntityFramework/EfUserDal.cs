using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        public void Add(User entity)
        {
            using (EatItContext context = new EatItContext())
            {
                context.Users.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (EatItContext context = new EatItContext())
            {
                var entity = context.Users.FirstOrDefault(x => x.UserId == id);
                if (entity != null)
                {
                    context.Users.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (EatItContext context = new EatItContext())
            {
                return context.Users.SingleOrDefault(filter);
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using(EatItContext context = new EatItContext()){
                 return filter==null ? context.Users.ToList() : context.Users.Where(filter).ToList() ;
            }
        }

        public void Update(int id, User entity)
        {
            using (EatItContext context = new EatItContext())
            {
                var e = context.Users.FirstOrDefault(x => x.UserId == id);
                if (entity != null && id==entity.UserId)
                {
                    e.UserName = entity.UserName;
                    context.Users.Update(e);
                    context.SaveChanges() ;
                }
            }
        }
    }
}
