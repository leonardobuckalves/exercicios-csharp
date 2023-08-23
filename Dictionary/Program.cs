Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>()
{
    {1, new Aluno("Maria", 72) },
    {2, new Aluno("Matheus", 34) },
    {3, new Aluno("Mariana", 100) },
    {4, new Aluno("Leonardo", 88) },
    {5, new Aluno("Felipe", 75) }
};

ExibirColecao(alunos);

//Localiza e atualiza nota do aluno
do
{
    Console.WriteLine("\nInforme o código do Aluno (99 sai)");
    int codigo = Convert.ToInt32(Console.ReadLine());

    if (codigo == 99)
        break;

    var resultado = alunos.ContainsKey(codigo);
    if (resultado)
    {
        Console.WriteLine("\nInforme a nota de 0 a 100");
        var nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
        Console.WriteLine("\nNota modificada com sucesso!");
    }
    else
    {
        Console.WriteLine("\nAluno não localizado!");
    }
}
while (true);

ExibirColecao(alunos);

//Remove um aluno da coleção
Console.WriteLine("\nInforme o código do Aluno a ser removido");
int cod = Convert.ToInt32(Console.ReadLine());
if (alunos.ContainsKey(cod))
{
    alunos.Remove(cod);
    Console.WriteLine("Aluno removido com sucesso");
}

ExibirColecao(alunos);

//Adiciona um novo aluno na coleção
alunos.Add(7, new Aluno("Vilma", 7));
Console.WriteLine("\nAdicionando aluna Vilma com nota 7 à coleção");

ExibirColecao(alunos);

//Ordenar todos os Alunos por Nome na coleção
var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);
Console.WriteLine("\nOrdenando a coleção por nome");

foreach (var item in alunosOrdenados)
{
    Console.WriteLine($"Item: {item.Key}, Nome: {item.Value.Nome}, Nota: {item.Value.Nota}.");
}

//Remover todos os dados da coleção
Console.WriteLine("\nLimpando coleção");
alunos.Clear();
ExibirColecao(alunos);

static void ExibirColecao(Dictionary<int, Aluno> alunos)
{
    foreach (var item in alunos)
    {
        Console.WriteLine($"Item: {item.Key}, Nome: {item.Value.Nome}, Nota: {item.Value.Nota}.");
    }
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