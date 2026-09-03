using System;

class Atividade5
{
    static int acharNumero(int[] vetor, int numero)
    {
        int posAchada = -1;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numero)
            {
                posAchada = i;
            }
        }
        return posAchada;
    }

    static void Main()
    {
        Console.Write("Tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] vetor = new int[tamanho];
        Random random = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(0, 100);
        }

        Console.Write("Número para achar: ");
        int numero = int.Parse(Console.ReadLine());

        int posicao = acharNumero(vetor, numero);
        if (posicao != -1)
        {
            Console.WriteLine($"{numero} está na posição {posicao}");
        }
        else
        {
            Console.WriteLine($"{numero} ñ está no vetor");
        }
    }
}
