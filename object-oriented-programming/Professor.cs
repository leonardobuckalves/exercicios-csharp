namespace object_oriented_programming;

public class Professor : Pessoa
{
    public Professor(string Nome) : base(Nome)
    { }

    public static void Explicar()
    {
        Console.WriteLine("Explicando...");
    }
}
