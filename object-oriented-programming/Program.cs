using object_oriented_programming;

//Exercício 1

//Carro chevetao = new Carro(0);
//chevetao.Dirigir();
//chevetao.Abastecer(0);
//chevetao.Dirigir();

//Exercício 2
//LivroFotos album1 = new LivroFotos();
//LivroFotos album2 = new LivroFotos(24);
//SuperLivroFotos album3 = new SuperLivroFotos();

//Console.WriteLine(album1.GetNumeroPaginas());
//Console.WriteLine(album2.GetNumeroPaginas());
//Console.WriteLine(album3.GetNumeroPaginas());

//Exercício 3
List<Pessoa> pessoas = new List<Pessoa>();
Console.WriteLine("Digite o nome de tres pessoas");
string nome1 = Console.ReadLine();
string nome2 = Console.ReadLine();
string nome3 = Console.ReadLine();
Aluno aluno1 = new Aluno(nome1);
Aluno aluno2 = new Aluno(nome2);
Professor professor = new Professor(nome3);
pessoas.Add(aluno1);
pessoas.Add(aluno2);
pessoas.Add(professor);
foreach (var pessoa in pessoas)
{
    if (pessoa.GetType() == typeof(Aluno))
    {
        Console.WriteLine($"\nAluno {pessoa.Nome}");
        Aluno.Estudar();
    }
    else
    {
        Console.WriteLine($"\nProfessor {pessoa.Nome}");
        Professor.Explicar();
    }
}