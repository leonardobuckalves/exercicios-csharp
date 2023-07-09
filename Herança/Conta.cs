namespace Herança;

class Conta
{
    public int NumeroConta { get; set; }
    public string? NomeCliente { get; set; }
    public decimal Saldo { get; set; } = 0.00m;
    public virtual double Juros { get; set; } = 0.00;

    public Conta(int NumeroConta, string NomeCliente)
    {
        this.NumeroConta = NumeroConta;
        this.NomeCliente = NomeCliente;
    }

    private decimal CalculaRemuneracao(double juros)
    {
        return Saldo * (decimal)Juros;
    }

    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Saldo = Saldo + CalculaRemuneracao(Juros);
        return Saldo;
    }
    public virtual decimal Sacar(decimal valor)
    {
        Saldo -= valor;
        return Saldo;
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Seu saldo é: {Saldo.ToString("c")}");
    }
}