using System;
using System.Collections.Generic;
using System.Text;
using Uow_EfCore_Domain;
using Uow_EfCore_Domain.Entities;
using Uow_EfCore_Domain.ValueObjects;

namespace Uow_EfCore_DOMAIN.Entities
{
    public class Aluno : BaseEntity
    {
        public Aluno(Pessoa pessoa, string responsavel, Contratacao contratacao, Endereco endereco)
        {
            if (string.IsNullOrEmpty(responsavel))
                throw new ArgumentException("Nome de Responsável é necessário para efetuar mátricula.");

            Pessoa = pessoa;
            Responsavel = responsavel;
            Contratacao = contratacao;
            Endereco = endereco;

        }

        public Pessoa Pessoa { get; private set; }
        public Contratacao Contratacao { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Responsavel { get; private set; }

    }
}
