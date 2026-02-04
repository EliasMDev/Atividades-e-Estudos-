using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarClasses
{
    internal class Pagamento
    {
        public decimal Valor { get; set; }
        public string TipoInvestimento { get; set; }
        public decimal ValorInvestido { get; set; }
        public decimal Rendimento { get; set; }
        public DateOnly Prazo { get; set; }

    }
}
