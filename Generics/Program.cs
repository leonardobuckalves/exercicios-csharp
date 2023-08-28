// Exercício 1
/*
ClasseGenerica<int> objInt = new ClasseGenerica<int>();

objInt.Adicionar(10);
objInt.Adicionar(20);
objInt.Adicionar(30);
objInt.Adicionar(40);
objInt.Adicionar(50);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(objInt[i]);
}


public class ClasseGenerica<T>
{
    //array com 5 elementos
    T[] obj = new T[5];
    int indice = 0;

    //método adicionar
    public void Adicionar(T item)
    {
        if(indice < 5)
        {
            obj[indice] = item;
        }
        indice++;
    }

    //indexador
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}
*/

//Exercício 2

AdicionaInteiros<int> adicionaInteiros = new AdicionaInteiros<int>();

var resultado = adicionaInteiros.Adiciona(10, 20);
Console.WriteLine(resultado);

class AdicionaInteiros<T> where T : struct, IComparable, IConvertible,
    IFormattable
{
    public T Adiciona(T num1, T num2)
    {
        dynamic dynamicNum1 = num1;
        dynamic dynamicNum2 = num2;
        return dynamicNum1 + dynamicNum2;
    }
}