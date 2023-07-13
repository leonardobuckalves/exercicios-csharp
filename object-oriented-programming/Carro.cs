namespace object_oriented_programming;

public class Carro : IVeiculo
{
    public Carro(int quantidadeInicialCombustivel)
    {
        QuantidadeInicialCombustivel = quantidadeInicialCombustivel;
        QuantidadeAtualCombustivel = QuantidadeInicialCombustivel;
    }

    public int QuantidadeInicialCombustivel { get; set; } = 1;
    public int QuantidadeAtualCombustivel { get; set; }

    public void Dirigir()
    {
        if(QuantidadeAtualCombustivel > 0)
        {
            Console.WriteLine($"Dirigindo por {QuantidadeAtualCombustivel} quilometros");
            QuantidadeAtualCombustivel = 0;

        }
        else
        {
            Console.WriteLine("Sem combustivel... abasteça o carro!");
        }
    }

    public bool Abastecer(int litros)
    {
        Console.WriteLine("Abastecer quantos litros?");
        litros = Convert.ToInt32(Console.ReadLine());
        if (QuantidadeAtualCombustivel == 0)
        {
            QuantidadeAtualCombustivel += litros;
            return true;
        }
        else
        {
            return false;
        }
    }


}
