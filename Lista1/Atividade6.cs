using System;

class Atividade6
{
    static int[] multiplicarVetor(int[] vetor1, int[] vetor2)
    {
        int[] resultado = new int[vetor1.Length];
        for (int i = 0; i < vetor1.Length; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }
        return resultado;
    }

    static void Main()
    {
        Console.Write("Quantos valores há os vetores: ");
        int tamanho = int.Parse(Console.ReadLine()!);

        int[] vetor1 = new int[tamanho];
        int[] vetor2 = new int[tamanho];

        Console.WriteLine("VETOR 1:");
        for (int i = 0; i < vetor1.Length; i++)
        {
            Console.Write($"{i}: ");
            vetor1[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("VETOR 2:");
        for (int i = 0; i < vetor2.Length; i++)
        {
            Console.Write($"{i}: ");
            vetor2[i] = int.Parse(Console.ReadLine()!);
        }

        int[] vetorResultante = multiplicarVetor(vetor1, vetor2);
        Console.WriteLine("VETOR MULT:");
        for (int i = 0; i < vetorResultante.Length; i++)
        {
            Console.WriteLine($"{vetorResultante[i]}");
        }
    }
}
