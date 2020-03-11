using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Uow_EfCore_App.Interface
{
    public interface IService<TEntity, TEntityDto> where TEntity : class where TEntityDto : class
    {
        Task<TEntityDto> Create(TEntityDto dto);
        void Update(TEntityDto dto);
        Task<TEntityDto> GetById(int id);
        Task<IEnumerable<TEntityDto>> FindAll();
        //Task<IEnumerable<TEntity>> GetByConditional(Expression<Func<TEntity,bool>> predicate);
    }
}
