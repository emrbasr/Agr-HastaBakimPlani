using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstarct
{
    public interface IRepositoryBase<TEntity, TContext> where TEntity : class, new() where TContext : class
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        void Add(TEntity Entity);
        void Update(TEntity Entity);
        void Delete(TEntity Entity);



    }
}
