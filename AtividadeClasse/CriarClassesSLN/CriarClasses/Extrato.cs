using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CriarClasses
{
    internal class Extrato
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string ListaTransacoes { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal SaldoAtual { get; set; }

    }
}
