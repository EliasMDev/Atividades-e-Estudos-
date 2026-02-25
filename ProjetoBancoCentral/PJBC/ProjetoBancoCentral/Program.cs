using ProjetoBancoCentral;

class Program
{
    static void Main(string[] args)
    {

        Banco meuBanco = new Banco();
        meuBanco.Nome = "banco do brasil";
        meuBanco.CodigoBACEN = "";
        meuBanco.CodigoBACEN = "001";

        try
        {
            minhaTransacao.Valor = 250.00m;
            minhaTransacao.Data = DateTime.Now;

        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro: {e.Message}");
        }

        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN);
        Console.WriteLine("-----------------------");
        Console.WriteLine("Valor: R$ " + minhaTransacao.Valor);
        Console.WriteLine("Data: " + minhaTransacao.Data);
        TransacaoPix meuPix = new TransacaoPix();
        meuPix.Valor = 15000;
        meuPix.ChavePix = "contato@gemini.com";

        TransacaoTed meuTed = new TransacaoTed();
        meuTed.Valor = 6000;

        Console.WriteLine($"PIX de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
        Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");
    }
}