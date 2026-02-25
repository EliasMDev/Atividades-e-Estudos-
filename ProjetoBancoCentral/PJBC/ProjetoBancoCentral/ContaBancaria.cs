using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoCentral
{
    public abstract class ContaBancaria
    {
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public Cliente Titular { get; set; }
        public decimal Saldo { get;  set; }
        public abstract void CalcularTarifa();
    }
}
