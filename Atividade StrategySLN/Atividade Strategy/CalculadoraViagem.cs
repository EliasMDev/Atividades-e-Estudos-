using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Strategy
{
    internal class CalculadoraViagem
    {
        private ITransporteStrategy _strategy;

       
        public void DefinirEstrategia(ITransporteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Calcular()
        {
            if (_strategy == null)
            {
                Console.WriteLine("Por favor, selecione um transporte primeiro.");
                return;
            }
            _strategy.CalcularTempo();
        }
    }
}
