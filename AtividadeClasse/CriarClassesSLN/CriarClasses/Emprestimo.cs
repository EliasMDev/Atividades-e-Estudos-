using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarClasses
{
    internal class Emprestimo
    {
        public decimal Valor { get; set; }
        public DateTime DataJuros { get; set; }
        public decimal TaxaJuros { get; set; }
        public int Parcelas { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}
