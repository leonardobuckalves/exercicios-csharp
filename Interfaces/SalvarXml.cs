namespace Interfaces;

internal class SalvarXml : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvando XML");
    }
    public override void Nome()
    {
        Console.WriteLine("Nome XML");
    }
}
