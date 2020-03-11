using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uow_EfCore_Domain.Dto;
using Uow_EfCore_Domain.Entities;

namespace Uow_EfCore_App.Interface
{
    public interface IProfessorService : IService<Professor,ProfessorDto>
    {
    }
}
