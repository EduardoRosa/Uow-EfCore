using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uow_EfCore_Domain.Dto;
using Uow_EfCore_Domain.Entities;

namespace Uow_EfCore_Api.Configuration.AutoMapperProfiles
{
    public class AutoMapper : Profile
    {
        public AutoMapper(IServiceCollection service)
        {
            var mapping = new MapperConfiguration(config =>
            {
                config.CreateMap<Professor,ProfessorDto>();
                config.CreateMap<ProfessorDto,Professor>();
            });
            IMapper mapper = mapping.CreateMapper();
            service.AddSingleton(mapper);
            service.AddAutoMapper(typeof(Startup));
        }
    }
}
