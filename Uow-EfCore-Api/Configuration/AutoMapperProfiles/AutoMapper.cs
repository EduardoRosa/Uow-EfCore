using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uow_EfCore_Api.Configuration.AutoMapperProfiles
{
    public class AutoMapper
    {
        public AutoMapper(IServiceCollection service)
        {
            var mapping = new MapperConfiguration(config =>
            {
                //config.CreateMap<>();
            });
            IMapper mapper = mapping.CreateMapper();
            service.AddSingleton(mapper);
            service.AddAutoMapper(typeof(Startup));
        }
    }
}
