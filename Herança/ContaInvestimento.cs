namespace Herança;
class ContaInvestimento : Conta
{
    public override double Juros { get; set; } = 0.09;
    public double Imposto { get; set; } = 0.01;

    public ContaInvestimento(int NumeroConta, string NomeCliente) : base(NumeroConta, NomeCliente)
    {
        this.NumeroConta = NumeroConta;
        this.NomeCliente = NomeCliente;
    }

    public decimal CalculaImposto(double imposto)
    {
        return Saldo * (decimal)Imposto;
    }

    public override decimal Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor - CalculaImposto(Imposto);
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente");
            return Saldo;
        }
    }
}