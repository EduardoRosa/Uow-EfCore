using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uow_EfCore_IRepository;

namespace Uow_EfCore_Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Rollback()
        {
            // nao implementa nada
        }
    }
}
