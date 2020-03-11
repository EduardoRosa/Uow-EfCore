using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uow_EfCore_App.Interface;
using Uow_EfCore_App.Services;
using Uow_EfCore_IRepository;
using Uow_EfCore_Repository;

namespace Uow_EfCore_API.Configuration.NativeInjectServices
{
    public class NativeInjectServices
    {
        public NativeInjectServices(IServiceCollection service)
        {
            //Services

            service.AddScoped<IProfessorService, ProfessorService>();


            //Repositories

            service.AddScoped<IProfessorRepository, ProfessorRepository>();

            service.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
