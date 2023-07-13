namespace object_oriented_programming;

public class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome)
    { }

    public static void Estudar()
    {
        Console.WriteLine("Estudando...");
    }
}
