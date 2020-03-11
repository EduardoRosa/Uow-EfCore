using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uow_EfCore_App.Interface;
using Uow_EfCore_Domain.Dto;
using Uow_EfCore_Domain.Entities;
using Uow_EfCore_Domain.ValueObjects;
using Uow_EfCore_IRepository;
using Uow_EfCore_Repository;

namespace Uow_EfCore_App.Services
{
    public class ProfessorService : Service<Professor, ProfessorDto>, IProfessorService
    {
        public ProfessorService(DataContext context, IMapper mapper, IProfessorRepository repository) : base(context, mapper, repository)
        {
        }
    }
}
