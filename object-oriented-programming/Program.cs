using object_oriented_programming;

//Exercício 1

//Carro chevetao = new Carro(0);
//chevetao.Dirigir();
//chevetao.Abastecer(0);
//chevetao.Dirigir();

//Exercício 2
LivroFotos album1 = new LivroFotos();
LivroFotos album2 = new LivroFotos(24);
SuperLivroFotos album3 = new SuperLivroFotos();

Console.WriteLine(album1.GetNumeroPaginas());
Console.WriteLine(album2.GetNumeroPaginas());
Console.WriteLine(album3.GetNumeroPaginas());