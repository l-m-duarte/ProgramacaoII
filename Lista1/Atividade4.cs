using System;

class Atividade3
{
    static double encontrarMenor(double[] vetor)
    {
        double menor = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }
        return menor;
    }

    static void Main()
    {
        Console.WriteLine("Tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        double[] vetor = new double[tamanho];
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{i}: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        double menor = encontrarMenor(vetor);
        
        Console.WriteLine("Vetor completo:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"{vetor[i]}");
        }
         Console.WriteLine($"O menor valor: {menor}");
    }
}
