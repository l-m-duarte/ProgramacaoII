// See https://aka.ms/new-console-template for more information 
class Lista1Atividade1
{
    static int SomarVetor(int[] vetor)
    {
        int soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        return soma;
    }


    static void Main()
    {
        Console.WriteLine("Digite a quantidade de elementos do vetor: ");
        int quantElementos = int.Parse(Console.ReadLine()!);

        int[] vetor = new int[quantElementos];
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Digite o valor da posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }

        int soma = SomarVetor(vetor);
        Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
    }
}
