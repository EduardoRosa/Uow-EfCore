using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uow_EfCore_App.Interface;
using Uow_EfCore_App.Services;

namespace Uow_EfCore_API.Configuration.NativeInjectServices
{
    public class NativeInjectServices
    {
        public NativeInjectServices(IServiceCollection service)
        {
            service.AddScoped<IProfessorService, ProfessorService>();
        }
    }
}
