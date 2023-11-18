using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityDalBase<TEntity, TContext>: IEntityRepository<TEntity>
        where TEntity : class,IEntity, new()
        where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (TContext context = new TContext())
            {
                var entity = context.Set<TEntity>().Find(id);
                if (entity != null)
                {
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(int id, TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var e = context.Set<TEntity>().Find(id);
                if (e != null )
                {
                    context.Entry(e).State = EntityState.Detached;
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                   
                    context.SaveChanges();
                }
            }
        }

    }
}
