Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>()
{
    {1, new Aluno("Maria", 72) },
    {2, new Aluno("Matheus", 34) },
    {3, new Aluno("Mariana", 100) },
    {4, new Aluno("Leonardo", 88) },
    {5, new Aluno("Felipe", 75) }
};

foreach (var item in alunos)
{
    Console.WriteLine($"Item: {item.Key}, Nome: {item.Value.Nome}, Nota: {item.Value.Nota}.");
}

public class Aluno
{
    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public string? Nome { get; set; }
    public int Nota { get; set; }
}