using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uow_EfCore_App.Interface;
using Uow_EfCore_Domain;
using Uow_EfCore_IRepository;
using Uow_EfCore_Repository;

namespace Uow_EfCore_App.Services
{
    public class Service<TEntity, TEntityDto> : IService<TEntity, TEntityDto> where TEntity : BaseEntity where TEntityDto : BaseEntity
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IRepository<TEntity> Repository;

        public Service(DataContext context, IMapper mapper, IRepository<TEntity> repository)
        {
            _context = context;
            _mapper = mapper;
            Repository = repository;
        }

        public async Task<TEntityDto> Create(TEntityDto dto)
        {
            var uow = new UnitOfWork(_context);

            Repository.Create(_mapper.Map<TEntity>(dto));
            await uow.Commit();
            return dto;
        }

        public Task<IEnumerable<TEntityDto>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntityDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
