using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoCentral
{
    public class TransacaoTed : Transacao
    {
        public override bool Validar()
        {
            // Regra de exemplo: TED deve ser maior que R$ 5.000 para fiscalização
            return base.Validar() && _valor > 5000;
        }
    }
}
