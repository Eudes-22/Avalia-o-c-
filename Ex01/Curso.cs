// ./Exercicio 7
using System;

public class Curso
{
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public bool Concluido { get; set; }

    public virtual void GerarCertificado()
    {
        if (Concluido)
        {
            Console.WriteLine("Certificado de conclusão do curso de " + Nome);
        }
        else
        {
            Console.WriteLine("O curso de " + Nome + " ainda não foi concluído.");
        }
    }
}

public class CursoIngles : Curso
{
    public int Nivel { get; set; }

    public override void GerarCertificado()
    {
        base.GerarCertificado();
        Console.WriteLine("Nível de inglês: " + Nivel);
    }
}

public class CursoEspanhol : Curso
{
    public string Proficiencia { get; set; }

    public override void GerarCertificado()
    {
        base.GerarCertificado();
        Console.WriteLine("Proficiência em espanhol: " + Proficiencia);
    }
}

public class CursoFrances : Curso
{
    public double MediaNotas { get; set; }

    public override void GerarCertificado()
    {
        base.GerarCertificado();
        Console.WriteLine("Média de notas em francês: " + MediaNotas);
    }
}