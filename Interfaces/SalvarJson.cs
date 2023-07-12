namespace Interfaces;

internal class SalvarJson : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvando Json");
    }
    public override void Nome()
    {
        Console.WriteLine("Nome JSON");
    }
}
