using System;

class Atividade8
{
    static void inverterCaracteres(char[] vetor)
    {
        Console.WriteLine("Vetor inverso: ");
        for (int i = vetor.Length-1; i >= 0; i--)
        {
            Console.WriteLine(vetor[i]);
        }
    }

    static void Main()
    {
        Console.Write("Quantos caracteres no vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        char[] vetor = new char[tamanho];
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{i}: ");
            vetor[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Tamanho do vetor: {vetor.Length}");
        inverterCaracteres(vetor);
    }
}
