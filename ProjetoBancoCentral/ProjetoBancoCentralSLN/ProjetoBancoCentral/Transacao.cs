using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoCentral
{
    internal class Transacao
    {

        private decimal _valor;
        public decimal Valor
        {
            get { return _valor; }
            set
            {
                if (value > 0)
                    _valor = value;
                else
                    throw new ArgumentException("O valor deve ser maior que 0");
            }
        }

        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public ContaBancaria ContaOrigem { get; set; }
        public ContaBancaria ContaDestino { get; set; }

    }
}
