using System;

class Atividade3
{
    static double encontrarMaior(double[] vetor)
    {
        double maior = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
    }

    static void Main()
    {
        Console.Write("Tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        double[] vetor = new double[tamanho];
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Valor {i}: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        double maior = encontrarMaior(vetor);
        
        Console.WriteLine("Vetor completo:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"{vetor[i]}");
        }
         Console.WriteLine($"O maior valor: {maior}");
    }
}
