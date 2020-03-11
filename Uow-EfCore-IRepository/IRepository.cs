using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Uow_EfCore_IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> FindAll();
        //Task<IEnumerable<TEntity>> GetByConditional(Expression<Func<TEntity,bool>> predicate);
    }
}
