using System;
using System.Collections.Generic;
using System.Text;

namespace Uow_EfCore_Domain.Entities
{
    public class Endereco
    {
        public Endereco(string bairro, int cep, string complemento, int numero, string rua)
        {
            if (string.IsNullOrEmpty(bairro))
                throw new ArgumentException("Nome do Bairro é necessário para o cadastro.");
            if (string.IsNullOrEmpty(cep.ToString()))
                throw new ArgumentException("Cep é necessário para o cadastro.");
            if (string.IsNullOrEmpty(complemento))
                throw new ArgumentException("Complemento é necessário para o cadastro.");
            if (string.IsNullOrEmpty(numero.ToString()))
                throw new ArgumentException("Numero da Residencia é necessário para o cadastro.");
            if (string.IsNullOrEmpty(rua))
                throw new ArgumentException("Nome da Rua é necessário para o cadastro.");

            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
        }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
    }
}
