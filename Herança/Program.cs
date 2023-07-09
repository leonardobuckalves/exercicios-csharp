using Herança;

Conta contaCorrente = new Conta(1, "Leonardo");
contaCorrente.ExibirSaldo();
Console.WriteLine("Depositando 1000,00");
contaCorrente.Depositar(1000);
contaCorrente.ExibirSaldo();
Console.WriteLine("Sacando 100,00");
contaCorrente.Sacar(100);
contaCorrente.ExibirSaldo();
Console.WriteLine("Sacando 2.000,00");
contaCorrente.Sacar(2000);
contaCorrente.ExibirSaldo();

Console.WriteLine();
ContaPoupanca contaPoupanca = new ContaPoupanca(1, "Rodolfo");
contaPoupanca.ExibirSaldo();
Console.WriteLine("Depositando 1000,00");
contaPoupanca.Depositar(1000);
contaPoupanca.ExibirSaldo();
Console.WriteLine("Sacando 100,00");
contaPoupanca.Sacar(100);
contaPoupanca.ExibirSaldo();
Console.WriteLine("Sacando 2.000,00");
contaPoupanca.Sacar(2000);
contaPoupanca.ExibirSaldo();

Console.WriteLine();
ContaInvestimento contaInvestimento = new ContaInvestimento(1, "Zezim");
contaInvestimento.ExibirSaldo();
Console.WriteLine("Depositando 1000,00");
contaInvestimento.Depositar(1000);
contaInvestimento.ExibirSaldo();
Console.WriteLine("Sacando 100,00");
contaInvestimento.Sacar(100);
contaInvestimento.ExibirSaldo();
Console.WriteLine("Sacando 2.000,00");
contaInvestimento.Sacar(2000);
contaInvestimento.ExibirSaldo();