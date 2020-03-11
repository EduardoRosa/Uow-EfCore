using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uow_EfCore_App.Interface;
using Uow_EfCore_Domain.Dto;
using Uow_EfCore_Domain.Entities;
using Uow_EfCore_Domain.ValueObjects;
using Uow_EfCore_IRepository;

namespace Uow_EfCore_App.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository Professor;

        public ProfessorService(IProfessorRepository professor)
        {
            Professor = professor;
        }
        public async Task<ProfessorDto> Create(ProfessorDto dto)
        {

            var endereco = new Endereco("Itu Sabará",91370,"Ap.1209",146,"Rua teste");
            var dadosBancarios = new DadosBancarios("3221312","013","Caixa","000000");
            var pessoa = new Pessoa("Eduardo","Rosa", "03594126021");
            var contratatacao = new Contratacao(DateTime.Now, null);

            var professorDto = new Professor(pessoa,contratatacao,dadosBancarios,endereco);
  

            return dto;
        }
    }
}
