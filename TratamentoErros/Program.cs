//// Exercício 1
//string resposta = null;

//try
//{
//    Console.WriteLine("Escreva um valor: ");
//    resposta = Console.ReadLine();

//    if (resposta == null)
//    {
//        throw new ArgumentNullException("resposta", "A entrada não pode ser nula.");
//    }
//    else if (string.IsNullOrWhiteSpace(resposta))
//    {
//        throw new ArgumentException("A entrada não pode estar vazia.", "entrada");
//    }
//    else
//    {
//        Console.WriteLine("Entrada: " + resposta); // Exibe a entrada
//    }
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine("Erro: " + ex.Message);
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Erro: " + ex.Message);
//}
//finally
//{
//    // O bloco finally será executado independentemente de ter ocorrido uma exceção ou não
//    Console.WriteLine("Fim do programa.");

//}

// Exercício 2
//int idade = 0;
//string nome = null;
//try
//{
//    Console.WriteLine("Informe a sua idade");
//    idade = Convert.ToInt32(Console.ReadLine());
//    if (idade < 0)
//    {
//        throw new ArgumentNullException("A idade não pode ser negativa.");
//    }
//    if (idade == 0)
//    {
//        throw new NotImplementedException("A idade ainda não foi definida.");
//    }
//    Console.WriteLine("Informe o seu nome");
//    nome = Console.ReadLine();
//    if (string.IsNullOrEmpty(nome))
//    {
//        throw new NullReferenceException("O nome não pode ser nulo nem vazio");
//    }
//    Console.WriteLine($"Nome: {nome}, Idade: {idade}");
//}
//catch (ArgumentException e)
//{
//    Console.WriteLine("Erro de argumento: " + e.Message);
//}
//catch (NotImplementedException e)
//{
//    Console.WriteLine("Erro de implementação: " + e.Message);
//}
//catch (NullReferenceException e)
//{
//    Console.WriteLine("Erro de referência nula: " + e.Message);
//}
//catch (Exception e)
//{
//    Console.WriteLine("Erro inesperado: " + e.Message);
//}
// Exercício 3
int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
Console.WriteLine("Números no array:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"[{i}] - {numeros[i]}");
}
try
{
    Console.Write("Informe um índice para obter o valor correspondente: ");
    int indice = int.Parse(Console.ReadLine());
    int valor = numeros[indice];
    Console.WriteLine($"O valor no índice {indice} é: {valor}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Erro: O índice está fora do intervalo válido.");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Erro: A entrada não pode ser nula.");
}
finally
{
    Console.WriteLine("Fim do programa.");
}