using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uow_EfCore_Domain.Dto;
using Uow_EfCore_Domain.Entities;
using Uow_EfCore_IRepository;

namespace Uow_EfCore_Repository
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(DataContext context) : base(context)
        {
        }

    }
}
