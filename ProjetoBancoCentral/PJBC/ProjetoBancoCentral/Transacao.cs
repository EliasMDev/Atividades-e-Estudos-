using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoCentral
{
    public abstract class Transacao
    {
        protected decimal _valor;

        public decimal Valor
        {
            get { return _valor; }
            set { if (value > 0) _valor = value; }
        }

        public DateTime Data { get; set; } = DateTime.Now;
        public ContaBancaria ContaOrigem { get; set; }
        public ContaBancaria ContaDestino { get; set; }

        public virtual bool Validar()
        {
            return _valor > 0 && ContaOrigem != null && ContaDestino != null ;
        }
    }
}
