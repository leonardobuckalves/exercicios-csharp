namespace object_oriented_programming;

public class Pessoa
{
    public Pessoa(string nome)
    {
        Nome = nome.ToString();
    }

    public string Nome { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}
