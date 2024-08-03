using DataAccess.Abstarct;
using DataAccess.Context;
using Entities.Abstarct;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity, TContext>
        where TEntity : BaseEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity Entity)
        {
            using (TContext dbContext = new TContext())
            {
                var addedEntity = dbContext.Entry(Entity);
                addedEntity.State = EntityState.Added;
                dbContext.SaveChanges();
            }
        }

        public void Delete(TEntity Entity)
        {
            using (TContext dbContext = new TContext())
            {
                var deletedEntity = dbContext.Entry(Entity);
                deletedEntity.State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext dbContext = new TContext())
            {

                return filter == null ? dbContext.Set<TEntity>().ToList()
                   : dbContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity Entity)
        {
            using (TContext dbContext = new TContext())
            {
                var updatedEntity = dbContext.Entry(Entity);
                updatedEntity.State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
    }
}
