using System;

class Atividade7
{
    static int contarValor(int[] vetor, int valor)
    {
        int quant = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                quant++;
            }
        }
        return quant;
    }

    static void Main()
    {
        Console.Write("Tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] vetor = new int[tamanho];
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Valor para contar: ");
        int valor = int.Parse(Console.ReadLine());

        int quant = contarValor(vetor, valor);
        Console.WriteLine("Vetor completo: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"{vetor[i]} ");
        }

        Console.WriteLine($"{valorBuscado} aparece {quant} vez(es) no vetor");
    }
}
