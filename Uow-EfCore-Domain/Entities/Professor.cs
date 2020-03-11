using System;
using System.Collections.Generic;
using System.Text;
using Uow_EfCore_Domain.ValueObjects;

namespace Uow_EfCore_Domain.Entities
{
    public class Professor : BaseEntity
    {
        public Professor(Pessoa pessoa, Contratacao contratacao, DadosBancarios dadosBancarios, Endereco endereco)
        {

            Pessoa = pessoa;
            Contratacao = contratacao;
            DadosBancarios = dadosBancarios;
            Endereco = endereco;

        }
        public Pessoa Pessoa { get; private set; }
        public Contratacao Contratacao { get; private set; }
        public Endereco Endereco { get; set; }
        public DadosBancarios DadosBancarios { get; set; }


    }
}
