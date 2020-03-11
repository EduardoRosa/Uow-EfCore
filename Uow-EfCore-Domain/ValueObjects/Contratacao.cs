using System;
using System.Collections.Generic;
using System.Text;

namespace Uow_EfCore_Domain.ValueObjects
{
    public class Contratacao : ValueObjects
    {
        public Contratacao(DateTime dataEntrada, DateTime? dataSaida)
        {
            if (string.IsNullOrEmpty(dataEntrada.ToString("dd/MM/yyyy")))
                throw new ArgumentException("Data de Entrada é um dado necessário no sistema.");

            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        

        public DateTime DataEntrada { get; private set; }
        public DateTime? DataSaida { get; private set; }
    }
}
