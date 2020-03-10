using System;
using System.Collections.Generic;
using System.Text;

namespace Uow_EfCore_Domain.Entities
{
    public class Professor : BaseEntity
    {
        public Professor(string nome, string sobrenome, DateTime dataContratacao, DateTime? dataDemissao, string cpf, string matricula, DadosBancarios dadosBancarios, Endereco endereco)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome inválido.");
            if (string.IsNullOrEmpty(sobrenome))
                throw new ArgumentException("Sobrenome inválido.");
            if (string.IsNullOrEmpty(cpf))
                throw new ArgumentException("Cpf deve ser cadastrado.");

            Nome = nome;
            Sobrenome = sobrenome;
            DataContratacao = dataContratacao;
            DataDemissao = dataDemissao;
            Cpf = cpf;
            Matricula = matricula;
            DadosBancarios = dadosBancarios;
            Endereco = endereco;

        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public Endereco Endereco { get; set; }
        public DadosBancarios DadosBancarios { get; set; }


    }
}
