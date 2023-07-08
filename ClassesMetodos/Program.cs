Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine($"Modelo: {chevrolet.Modelo}, Montadora: {chevrolet.Montadora}, " +
    $"Marca: {chevrolet.Marca}, Ano: {chevrolet.Ano}, Potência: {chevrolet.Potencia}");
chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine($"Modelo: {ford.Modelo}, Montadora: {ford.Montadora}, " +
    $"Marca: {ford.Marca}, Ano: {ford.Ano}, Potência: {ford.Potencia}");
ford.Acelerar(ford.Marca);

class Carro
{
    public string? Modelo { get; set; }
    public string? Montadora { get; set; }
    public string? Marca { get; set; }
    public int Ano { get; set; }
    public int Potencia { get; set; }

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    public Carro(string Modelo, string Montadora)
    {

    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    public double VelocidadeMaxima(int potencia)
    {
        double velocidadeMaxima = potencia * 1.75;
        return velocidadeMaxima;
    }
}