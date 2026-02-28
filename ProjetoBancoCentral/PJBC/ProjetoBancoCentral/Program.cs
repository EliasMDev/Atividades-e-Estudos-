using ProjetoBancoCentral;

class Program
{
    static void Main(string[] args)
    {

        Banco meuBanco = new Banco();
        meuBanco.Nome = "banco do brasil";
        meuBanco.CodigoBACEN = "";
        meuBanco.CodigoBACEN = "001";



        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN);
        Console.WriteLine("-----------------------");
        TransacaoPix meuPix = new TransacaoPix();
        meuPix.Valor = 15000;
        meuPix.ChavePix = "contato@gemini.com";

        TransacaoTed meuTed = new TransacaoTed();
        meuTed.Valor = 6000;

        Console.WriteLine($"PIX de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
        Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");

        decimal valor1 = 5000000000m;
        decimal valor2 = 2000000000000m;

        // Para Bilhões
        IConversorGrandeza conversorBi = new ConversorBilhoes();
        ExibirRelatorio(valor1, conversorBi);

        // Para Trilhões
        IConversorGrandeza conversorTri = new ConversorTrilhoes();
        ExibirRelatorio(valor2, conversorTri);
    }
    public static void ExibirRelatorio(decimal valorBruto, IConversorGrandeza conversor)
    {
        decimal valorConvertido = conversor.Converter(valorBruto);
        Console.WriteLine($"Valor convertido: {valorConvertido:N2} {conversor.ObterSimbolo()}");
    }

}