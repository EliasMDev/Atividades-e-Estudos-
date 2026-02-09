using ProjetoBancoCentral;

internal class Program
{
    static void Main(string[] args)
    {
        Banco meuBanco = new Banco();
        meuBanco.Nome = "Banco do Brasil";
        meuBanco.CodigoBACEN = "001";

        Transacao minhaTransacao = new Transacao();
        minhaTransacao.Valor = 250.00m;
        minhaTransacao.Data = DateTime.Now;
        minhaTransacao.Tipo = "PIX";

        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN);
        Console.WriteLine("-----------------------");
        Console.WriteLine("Tipo: " + minhaTransacao.Tipo);
        Console.WriteLine("Valor: R$ " + minhaTransacao.Valor);
        Console.WriteLine("Data: " + minhaTransacao.Data);
    }
}