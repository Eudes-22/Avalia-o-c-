// ./Excercio 7

public class ContaBancaria
{
    public string Titular { get; set; }
    public double Saldo { get; protected set; }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
    }
}

public class ContaCorrente : ContaBancaria
{
    public double TaxaManutencao { get; set; }

    public override void Sacar(double valor)
    {
        if (valor + TaxaManutencao <= Saldo)
        {
            Saldo -= valor + TaxaManutencao;
        }
    }
}

public class ContaPoupanca : ContaBancaria
{
    public double TaxaJuros { get; set; }

    public void CalcularJuros()
    {
        Saldo += Saldo * TaxaJuros;
    }
}

public class ContaEmpresarial : ContaBancaria
{
    public double SaldoMinimo { get; set; }

    public bool VerificarSaldoMinimo()
    {
        return Saldo >= SaldoMinimo;
    }
}