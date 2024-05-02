// ./Exercicio 9
using System;

public interface MetodoPagamento
{
    void RealizarPagamento(double valor);
    string VerificarStatusPagamento();
}

public class CartaoCredito : MetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine("Pagamento de R$" + valor + " realizado com cartão de crédito.");
    }

    public string VerificarStatusPagamento() 
    {
        return "Pagamento com cartão de crédito aprovado";
    }
}

public class BoletoBancario : MetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine("Gerar boleto de R$" + valor + " para pagamento.");
    }

    public string VerificarStatusPagamento()
    {
        return "Boleto bancário aguardando pagamento";
    }
}

public class TransferenciaBancaria : MetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine("Transferência bancária de R$" + valor + " realizada com sucesso.");
    }

    public string VerificarStatusPagamento()
    {
        return "Pagamento via transferência bancária concluído";
    }
}

class Program
{
    static void Main()
    {
        MetodoPagamento metodo1 = new CartaoCredito();
        metodo1.RealizarPagamento(100.0);
        Console.WriteLine(metodo1.VerificarStatusPagamento());

        MetodoPagamento metodo2 = new BoletoBancario();
        metodo2.RealizarPagamento(150.0);
        Console.WriteLine(metodo2.VerificarStatusPagamento());

        MetodoPagamento metodo3 = new TransferenciaBancaria();
        metodo3.RealizarPagamento(200.0);
        Console.WriteLine(metodo3.VerificarStatusPagamento());
    }
}