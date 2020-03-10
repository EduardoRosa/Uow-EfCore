using System;
using System.Collections.Generic;
using System.Text;

namespace Uow_EfCore_Domain.Entities
{
    public class DadosBancarios
    {

        public DadosBancarios(string agencia, string operacao, string nomeBanco, string numeroConta)
        {
            if (string.IsNullOrEmpty(agencia))
                throw new ArgumentException("Agencia Bancária é necessária para o cadastro.");
            if (string.IsNullOrEmpty(nomeBanco))
                throw new ArgumentException("Nome do Banco é necessário para o cadastro.");
            if (string.IsNullOrEmpty(numeroConta))
                throw new ArgumentException("Numero da Conta é necessário para o cadastro.");
            if (string.IsNullOrEmpty(operacao))
                throw new ArgumentException("Operação é necessária para o cadastro.");

            Agencia = agencia;
            Operacao = operacao;
            NomeBanco = nomeBanco;
            NumeroConta = numeroConta;
        }
        public string Agencia { get; set; }
        public string Operacao { get; set; }
        public string NomeBanco { get; set; }
        public string NumeroConta { get; set; }

    }
}
