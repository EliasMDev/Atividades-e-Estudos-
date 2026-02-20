using ProjetoBancoCentral;
internal class Program
{
    static void Main(string[] args)
    {
        Banco meuBanco = new Banco();
        meuBanco.Nome = "banco do brasil";
        meuBanco.CodigoBACEN = ""; 
        meuBanco.CodigoBACEN = "001";

        Transacao minhaTransacao = new Transacao();

        try
        {
            minhaTransacao.Valor = 250.00m;
            minhaTransacao.Data = DateTime.Now;
            minhaTransacao.Tipo = "PIX";
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }

        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN);
        Console.WriteLine("-----------------------");
        Console.WriteLine("Tipo: " + minhaTransacao.Tipo);
        Console.WriteLine("Valor: R$ " + minhaTransacao.Valor);
        Console.WriteLine("Data: " + minhaTransacao.Data);
    }
}