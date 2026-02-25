using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ProjetoBancoCentral
{
    public class Banco
    {
        private string _nome;
        private string _codigoBACEN;
        public string Nome
        {
            get => _nome?.ToUpper();
            set => _nome = value;
        }

        public string CodigoBACEN
        {
            get => _codigoBACEN;
            set
            {
               
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Erro: O Código BACEN não pode ser vazio ou nulo!");
                 
                }
                else
                {
                    _codigoBACEN = value;
                }
            }
        }
    }
}