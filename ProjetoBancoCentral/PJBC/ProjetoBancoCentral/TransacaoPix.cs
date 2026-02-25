using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoCentral
{
    public class TransacaoPix : Transacao
    {
        public string ChavePix { get; set; }

        public override bool Validar()
        {
            return base.Validar() && _valor <= 10000;
        }
    }
}
