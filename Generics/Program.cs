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