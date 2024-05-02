// ./Exercicio 6
public class Veiculo
{
    // Atributos comuns a todos os veículos
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public double Preco { get; set; }
}

public class Carro : Veiculo
{
    // Atributos específicos para carros
    public int NumeroPortas { get; set; }
}

public class Moto : Veiculo
{
    // Atributos específicos para motos
    public int Cilindrada { get; set; }
}

public class Bicicleta : Veiculo
{
    // Atributos específicos para bicicletas
    public int NumeroMarchas { get; set; }
}