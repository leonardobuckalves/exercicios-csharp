namespace Herança;

class ContaPoupanca : Conta
{
    public override double Juros { get; set; } = 0.05;

    public ContaPoupanca(int NumeroConta, string NomeCliente) : base(NumeroConta, NomeCliente)
    {
        this.NumeroConta = NumeroConta;
        this.NomeCliente = NomeCliente;
    }

    public override decimal Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente");
            return Saldo;
        }
    }
}
