// ./Exercicio 4
using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Produto(string nome, double preco, int quantidadeEmEstoque)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        QuantidadeEmEstoque += quantidade;
        Console.WriteLine($"{quantidade} unidades de {Nome} adicionadas ao estoque.");
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= QuantidadeEmEstoque)
        {
            QuantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades de {Nome} removidas do estoque.");
        }
        else
        {
            Console.WriteLine($"Não há {quantidade} unidades de {Nome} suficientes no estoque.");
        }
    }

    public double CalcularValorTotalEmEstoque()
    {
        return Preco * QuantidadeEmEstoque;
    }
}


