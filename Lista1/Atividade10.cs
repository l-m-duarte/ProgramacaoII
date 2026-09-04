using System;

class Atividade10
{
    static int[] contarFaces(int[] lancamentos)
    {
        int[] quant = new int[6];
        for (int i = 0; i < lancamentos.Length; i++)
        {
            if (lancamentos[i] >= 1 && lancamentos[i] <= 6)
            {
                quant[(lancamentos[i]-1)]++;
            }
        }
        return quant;
    }

    static void Main()
    {
        Console.Write("Quantos lançamentos: ");
        int quant = int.Parse(Console.ReadLine());

        int[] lancamentos = new int[quant];
        Random rand = new Random();
        Console.WriteLine("Vetor lançamentos: ");
        for (int i = 0; i < lancamentos.Length; i++)
        {
            lancamentos[i] = rand.Next(1, 6); 
            Console.WriteLine($"{lancamentos[i]} ");
        }
      
        int[] quantFaces = contarFaces(lancamentos);
        Console.WriteLine("Quantidade de cada valor/face:");
        for (int i = 0; i < lancamentos.Length; i++)
        {
            Console.WriteLine($"Face {i+1}: {quantFaces[i]} vez(es)");
        }
    }
}
