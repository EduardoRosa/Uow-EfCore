using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uow_EfCore_App.Interface;
using Uow_EfCore_Domain.Dto;
using Uow_EfCore_Domain.Entities;

namespace Uow_EfCore_App.Services
{
    public class ProfessorService : IProfessorService
    {
        public async Task<Professor> Create()
        {

            var endereco = new Endereco("Itu Sabará",91370,"Ap.1209",146,"Rua teste");
            var dadosBancarios = new DadosBancarios("3221312","013","Caixa","000000");
            var professorDto = new Professor("Eduardo","Rosa",DateTime.Now,null,"00000000000","mat",dadosBancarios,endereco);

            return professorDto;
        }
    }
}
