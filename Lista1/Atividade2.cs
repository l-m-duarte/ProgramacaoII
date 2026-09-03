using System;
using System.Runtime.InteropServices;
using BibliotecaFuncoes;

class Atividade2
{
    static int contarImpares(int[] vetor)
    {
        int cont = 0;
        for (int i=0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                cont++;
            }
        }
        return cont;
    }
    static void Main()
    {
        int n;
        Console.Write("Tamanho do vetor: ");
        n = int.Parse(Console.ReadLine()!);

        int[] meuArray = new int[n];

        BibliotecaVetor.gerarVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);
        Console.WriteLine($"\n Há {contarImpares(meuArray)} números ímpares");
    }
}