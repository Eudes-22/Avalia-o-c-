// ./Exercicio 10
using System;

public interface Reserva
{
    void ReservarVoo();
    void CancelarReserva();
    string VerificarStatusReserva();
}

public class ReservaVooRegular : Reserva
{
    public void ReservarVoo()
    {
        Console.WriteLine("Reserva de voo regular realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo regular cancelada.");
    }

    public string VerificarStatusReserva()
    {
        return "Status da reserva de voo regular: Confirmada";
    }
}

public class ReservaVooComUpgrade : Reserva
{
    public void ReservarVoo()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo com upgrade de classe cancelada.");
    }

    public string VerificarStatusReserva()
    {
        return "Status da reserva de voo com upgrade de classe: Confirmada";
    }
}

public class ReservaVooGrupoGrande : Reserva
{
    public void ReservarVoo()
    {
        Console.WriteLine("Reserva de voo para grupo grande realizada com sucesso.");
    }

    public void CancelarReserva()
    {
        Console.WriteLine("Reserva de voo para grupo grande cancelada.");
    }

    public string VerificarStatusReserva()
    {
        return "Status da reserva de voo para grupo grande: Confirmada";
    }
}
