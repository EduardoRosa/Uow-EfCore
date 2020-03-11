using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Uow_EfCore_IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit();

        void Rollback();
    }
}
