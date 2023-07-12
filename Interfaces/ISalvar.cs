namespace Interfaces
{
    internal interface ISalvar
    {
        abstract void Salvar();
        void Compactar()
        {
            Console.WriteLine("Compactando");
        }
    }
}
