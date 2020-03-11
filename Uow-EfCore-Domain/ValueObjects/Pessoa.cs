using System;
using System.Collections.Generic;
using System.Text;

namespace Uow_EfCore_Domain.ValueObjects
{
    public class Pessoa : ValueObjects
    {
        public Pessoa(string nome, string sobrenome, string cpf)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome inválido");
            if (string.IsNullOrEmpty(sobrenome))
                throw new ArgumentException("Sobrenome Inválido");
            if (string.IsNullOrEmpty(cpf))
                throw new ArgumentException("Cpf necessário para efetuar matrícula.");
            if (!CpfValido(cpf))
                throw new ArgumentException("Cpf informado inválido.");

            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Cpf { get; private set; }


        private bool CpfValido(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }

}
