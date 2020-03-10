using System;
using System.Collections.Generic;
using System.Text;
using Uow_EfCore_Domain;
using Uow_EfCore_Domain.Entities;

namespace Uow_EfCore_DOMAIN.Entities
{
    public class Aluno : BaseEntity
    {
        public Aluno(string nome, string sobrenome, string responsavel, DateTime DataEntrada, DateTime? DataSaida,  string cpfResponsavel,Endereco endereco)
        {

        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Responsavel { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string CpfResponsavel { get; set; }
        public Endereco Endereco { get; set; }
    }
}
