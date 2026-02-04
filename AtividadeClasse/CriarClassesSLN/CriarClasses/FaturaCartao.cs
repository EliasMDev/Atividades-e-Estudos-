using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarClasses
{
    internal class FaturaCartao
    {
        public string MesReceita { get; set; }
        public decimal ValorProtal { get; set; }
        public DateTime DataInicio { get; set; }
        public decimal ValorPago { get; set; }
        public string Status { get; set; }
    }
}
