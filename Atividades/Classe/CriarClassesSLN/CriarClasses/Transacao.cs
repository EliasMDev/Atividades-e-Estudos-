using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarClasses
{
    internal class Transacao
    {
        public decimal Valor { get; set; }
        public string Agencia { get; set; }
        public string TipoInstituicao { get; set; }
        public DateTime DataHora { get; set; }
        public string Status { get; set; }

    }
}
