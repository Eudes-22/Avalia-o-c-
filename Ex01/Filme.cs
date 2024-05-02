// ./Exercicio 5
public class Filme
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Filme(string titulo, string genero, int duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
        Disponivel = true;
    }

    public void RegistrarLocacao()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine("Filme " + Titulo + " alugado com sucesso.");
        }
        else
        {
            Console.WriteLine("Filme " + Titulo + " não está disponível para locação no momento.");
        }
    }

    public void RegistrarDevolucao()
    {
        if (!Disponivel)
        {
            Disponivel = true;
            Console.WriteLine("Filme " + Titulo + " devolvido com sucesso.");
        }
        else
        {
            Console.WriteLine("Filme " + Titulo + " já está disponível para locação.");
        }
    }

    public bool VerificarDisponibilidade()
    {
        return Disponivel;
    }
}