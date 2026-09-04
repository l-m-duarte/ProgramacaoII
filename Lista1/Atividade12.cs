using System;

class Atividade8
{
    static double obterMaiorNota(double[] notas)
    {
        double maiorNota = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > maiorNota)
            {
                maiorNota = notas[i];
            }
        }
        return maiorNota;
    }

    static double obterMenorNota(double[] notas)
    {
        double menorNota = 10;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < menorNota)
            {
                menorNota = notas[i];
            }
        }
        return menorNota;
    }

    static double calcularSomaNotas(double[] notas)
    {
        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }
        return soma;
    }
    
    static double calcularNotaFinal(double[] notas)
    {
        double notaFinal = calcularSomaNotas(notas) - obterMaiorNota(notas) - obterMenorNota(notas);


        return Math.Round(notaFinal, 1);
    }


    static void Main()
    {
        double[] notas = new double[5];
        Console.WriteLine("Digite as 5 notas ");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Nota Final: {calcularNotaFinal(notas)}");       
    }
    
}
