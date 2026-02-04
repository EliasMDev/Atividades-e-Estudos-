using CriarClasses;

internal class Program
{
    private static void Main(string[] args)
    {
       
        Agencia agencia = new Agencia();
        agencia.Endereco = "Rua Pneu, 123";
        agencia.NumeroAgencia = "555-5";
        agencia.Nome = "Banco do Brasil";
        agencia.Telefone = "4002-8922";
        agencia.NomeInvestidor = "Elias";
        Console.WriteLine("=== DADOS DA AGÊNCIA ===");
        Console.WriteLine($"Nome: {agencia.Nome}\nAgência: {agencia.NumeroAgencia}\nEndereço: {agencia.Endereco}\nTelefone: {agencia.Telefone}\nInvestidor: {agencia.NomeInvestidor}");
        Console.WriteLine("------------------------------------------\n");

        Beneficiario beneficiario = new Beneficiario();
        beneficiario.Nome = "Ana Souza";
        beneficiario.Banco = "Bradesco";
        beneficiario.Agencia = "1234-X";
        Console.WriteLine("=== BENEFICIÁRIO ===");
        Console.WriteLine($"Nome: {beneficiario.Nome}\nBanco: {beneficiario.Banco}\nAgência: {beneficiario.Agencia}");
        Console.WriteLine("------------------------------------------\n");

        Cartao cartao = new Cartao();
        cartao.Numero = 1.0; 
        cartao.NumeroCartao = 4524987654321000;
        cartao.TotalHora = DateTime.Now;
        cartao.DataValidade = new DateTime(2030, 08, 25);
        cartao.CVV = 999;
        Console.WriteLine("=== CARTÃO ===");
        Console.WriteLine($"ID: {cartao.Numero}\nNúmero Cartão: {cartao.NumeroCartao}\nData/Hora Registro: {cartao.TotalHora}\nValidade: {cartao.DataValidade:MM/yy}\nCVV: {cartao.CVV}");
        Console.WriteLine("------------------------------------------\n");

        Cliente cliente = new Cliente();
        cliente.Nome = "Carlos Alberto";
        cliente.CPF = 123456789;
        cliente.DataNascimento = new DateTime(1995, 10, 20);
        cliente.Email = "carlos.alberto@email.com";
        Console.WriteLine("=== CLIENTE ===");
        Console.WriteLine($"Nome: {cliente.Nome}\nCPF: {cliente.CPF}\nNascimento: {cliente.DataNascimento:dd/MM/yyyy}\nEmail: {cliente.Email}");
        Console.WriteLine("------------------------------------------\n");

        Conta conta = new Conta();
        conta.Numero = 98765;
        conta.Agencia = "0001";
        conta.Saldo = 2500.75m;
        conta.TipoConta = "Poupança Ouro";
        Console.WriteLine("=== CONTA (GERAL) ===");
        Console.WriteLine($"Número: {conta.Numero}\nAgência: {conta.Agencia}\nSaldo: {conta.Saldo:C}\nTipo: {conta.TipoConta}");
        Console.WriteLine("------------------------------------------\n");

        ContaCorrente cc = new ContaCorrente();
        cc.NumeroConta = 112233;
        cc.Agencia = "789-0";
        cc.TaxaRendimento = 0.02;
        cc.TaxaFim = 15.90;
        Console.WriteLine("=== CONTA CORRENTE ===");
        Console.WriteLine($"Conta: {cc.NumeroConta}\nAgência: {cc.Agencia}\nRendimento: {cc.TaxaRendimento}%\nTaxa Final: {cc.TaxaFim:C}");
        Console.WriteLine("------------------------------------------\n");

        ContaPoupanca cp = new ContaPoupanca();
        cp.NumeroConta = 445566;
        cp.Agencia = "321-X";
        cp.TaxaRendimento = 0.5;
        cp.TaxaFim = 0.0;
        Console.WriteLine("=== CONTA POUPANÇA ===");
        Console.WriteLine($"Conta: {cp.NumeroConta}\nAgência: {cp.Agencia}\nRendimento: {cp.TaxaRendimento}%\nTaxa Final: {cp.TaxaFim:C}");
        Console.WriteLine("------------------------------------------\n");

        Despesas despesa = new Despesas();
        despesa.Valor = 1200.50m;
        despesa.TipoInvestimento = "CDB Pós-Fixado";
        despesa.Rendimento = 125.30m;
        despesa.Prazo = new DateOnly(2027, 12, 31);
        Console.WriteLine("=== DESPESAS / INVESTIMENTO ===");
        Console.WriteLine($"Valor: {despesa.Valor:C}\nTipo: {despesa.TipoInvestimento}\nRendimento Esperado: {despesa.Rendimento:C}\nPrazo: {despesa.Prazo}");
        Console.WriteLine("------------------------------------------\n");

        Emprestimo emp = new Emprestimo();
        emp.Valor = 15000m;
        emp.DataJuros = DateTime.Now.AddMonths(1);
        emp.TaxaJuros = 3.99m;
        emp.Parcelas = 48;
        emp.DataContratacao = DateTime.Now;
        Console.WriteLine("=== EMPRÉSTIMO ===");
        Console.WriteLine($"Valor: {emp.Valor:C}\nContratado em: {emp.DataContratacao:dd/MM/yyyy}\nPrimeiro Juros: {emp.DataJuros:dd/MM/yyyy}\nTaxa: {emp.TaxaJuros}%\nParcelas: {emp.Parcelas}");
        Console.WriteLine("------------------------------------------\n");

        Endereco end = new Endereco();
        end.Rua = "Avenida das Américas";
        end.Numero = "4200";
        end.Cidade = "Rio de Janeiro";
        end.Cep = "22640-102";
        Console.WriteLine("=== ENDEREÇO COMPLETO ===");
        Console.WriteLine($"Logradouro: {end.Rua}, {end.Numero}\nCidade: {end.Cidade}\nCEP: {end.Cep}");
        Console.WriteLine("------------------------------------------\n");

        Extrato extrato = new Extrato();
        extrato.DataInicio = DateTime.Now.AddDays(-7);
        extrato.DataFim = DateTime.Now;
        extrato.ListaTransacoes = "1. Mercado R$ 50,00 | 2. Posto R$ 100,00";
        extrato.SaldoAnterior = 500.00m;
        extrato.SaldoAtual = 350.00m;
        Console.WriteLine("=== EXTRATO DETALHADO ===");
        Console.WriteLine($"Período: {extrato.DataInicio:dd/MM} a {extrato.DataFim:dd/MM}\nSaldo Anterior: {extrato.SaldoAnterior:C}\nTransações: {extrato.ListaTransacoes}\nSaldo Atual: {extrato.SaldoAtual:C}");
        Console.WriteLine("------------------------------------------\n");

        FaturaCartao fatura = new FaturaCartao();
        fatura.MesReceita = "Janeiro";
        fatura.ValorProtal = 1250.00m; 
        fatura.DataInicio = new DateTime(2024, 01, 01);
        fatura.ValorPago = 1250.00m;
        fatura.Status = "Liquidado";
        Console.WriteLine("=== FATURA CARTÃO ===");
        Console.WriteLine($"Mês: {fatura.MesReceita}\nInício Ciclo: {fatura.DataInicio:dd/MM}\nTotal: {fatura.ValorProtal:C}\nValor Pago: {fatura.ValorPago:C}\nStatus: {fatura.Status}");
        Console.WriteLine("------------------------------------------\n");

        Funcionario func = new Funcionario();
        func.Nome = "Julia Silva";
        func.Matricula = "MAT-2024-001";
        func.Cargo = "Gerente de Contas";
        func.Salario = 8500.00m;
        Console.WriteLine("=== QUADRO FUNCIONAL ===");
        Console.WriteLine($"Nome: {func.Nome}\nMatrícula: {func.Matricula}\nCargo: {func.Cargo}\nSalário: {func.Salario:C}");
        Console.WriteLine("------------------------------------------\n");

        Gerente gerente = new Gerente();
        gerente.NumeroConta = 778899;
        gerente.Agencia = "0005";
        gerente.Saldo = 100000m;
        gerente.ChequeEspecial = "R$ 5.000,00 Pré-Aprovado";
        Console.WriteLine("=== PAINEL DO GERENTE ===");
        Console.WriteLine($"Conta Ref: {gerente.NumeroConta}\nAgência: {gerente.Agencia}\nSaldo Gerenciado: {gerente.Saldo:C}\nCheque Especial: {gerente.ChequeEspecial}");
        Console.WriteLine("------------------------------------------\n");

        Investidores inv = new Investidores();
        inv.Nome = "Ricardo S.A.";
        inv.ValorInvestido = 250000m;
        inv.NomeEmpresa = "Global Tech Investments";
        Console.WriteLine("=== INVESTIDORES ===");
        Console.WriteLine($"Investidor: {inv.Nome}\nEmpresa: {inv.NomeEmpresa}\nTotal Alocado: {inv.ValorInvestido:C}");
        Console.WriteLine("------------------------------------------\n");

        Notificacao note = new Notificacao();
        note.Mensagem = "Sua senha expira em 3 dias!";
        note.DataHora = DateTime.Now;
        note.DataFim = DateTime.Now.AddDays(3);
        Console.WriteLine("=== NOTIFICAÇÃO ===");
        Console.WriteLine($"Mensagem: {note.Mensagem}\nData Envio: {note.DataHora}\nData Expiração: {note.DataFim}");
        Console.WriteLine("------------------------------------------\n");

        Pagamento pag = new Pagamento();
        pag.Valor = 300.00m;
        pag.TipoInvestimento = "LCI";
        pag.ValorInvestido = 2000m;
        pag.Rendimento = 180.50m;
        pag.Prazo = new DateOnly(2025, 06, 30);
        Console.WriteLine("=== DETALHES DO PAGAMENTO ===");
        Console.WriteLine($"Valor: {pag.Valor:C}\nTipo: {pag.TipoInvestimento}\nTotal Investido: {pag.ValorInvestido:C}\nRendimento: {pag.Rendimento:C}\nPrazo: {pag.Prazo}");
        Console.WriteLine("------------------------------------------\n");

        Seguro seg = new Seguro();
        seg.Segurou = "Imóvel Residencial";
        seg.TipoSeguro = "Contra Incêndio";
        seg.ValorPremio = 85.90;
        seg.TipoInicial = "Básico";
        seg.Cobertura = 150000.00;
        Console.WriteLine("=== APÓLICE DE SEGURO ===");
        Console.WriteLine($"Objeto: {seg.Segurou}\nTipo: {seg.TipoSeguro}\nCategoria: {seg.TipoInicial}\nPrêmio: {seg.ValorPremio:C}\nCobertura: {seg.Cobertura:C}");
        Console.WriteLine("------------------------------------------\n");

        Suporte suporte = new Suporte();
        suporte.Protocolo = "TICKET-9988";
        suporte.TipoAtendimento = "Suporte Técnico Nível 2";
        suporte.DescricaoStatus = "Aguardando retorno do desenvolvedor";
        suporte.DataAbertura = DateTime.Now.AddHours(-2);
        Console.WriteLine("=== TICKET DE SUPORTE ===");
        Console.WriteLine($"Protocolo: {suporte.Protocolo}\nTipo: {suporte.TipoAtendimento}\nAbertura: {suporte.DataAbertura}\nStatus: {suporte.DescricaoStatus}");
        Console.WriteLine("------------------------------------------\n");

        Transacao trans = new Transacao();
        trans.Valor = 550.00m;
        trans.Agencia = "0001";
        trans.TipoInstituicao = "Banco Digital";
        trans.DataHora = DateTime.Now;
        trans.Status = "Em Processamento";
        Console.WriteLine("=== TRANSAÇÃO FINAL ===");
        Console.WriteLine($"Valor: {trans.Valor:C}\nAgência: {trans.Agencia}\nInstituição: {trans.TipoInstituicao}\nData: {trans.DataHora}\nStatus: {trans.Status}");
        Console.WriteLine("==========================================");

        Console.WriteLine("\nTodos os dados foram carregados. Pressione qualquer tecla para encerrar.");
        Console.ReadKey();
    }
}