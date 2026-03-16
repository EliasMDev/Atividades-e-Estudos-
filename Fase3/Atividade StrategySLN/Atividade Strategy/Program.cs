using Atividade_Strategy;
class Program
{
    static void Main()
    {
        var calculadora = new CalculadoraViagem();


        calculadora.DefinirEstrategia(new BicicletaStrategy());
        calculadora.Calcular();

        calculadora.DefinirEstrategia(new CarroStrategy());
        calculadora.Calcular();

       
        calculadora.DefinirEstrategia(new AviaoStrategy());
        calculadora.Calcular();
    }
}