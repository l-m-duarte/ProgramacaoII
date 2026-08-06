// See https://aka.ms/new-console-template for more information
class Atividade2
{
    static void Main()
    {
        int[] vetor = new int[5];
        vetor = [1, 2, 3, 4, 5];

        Console.WriteLine("Digite o valor do numero a achar: ");
        int valorAachar = int.Parse(Console.ReadLine()!);

        int posicaoAchada = -1;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valorAachar)
            {
                posicaoAchada = i;
                break;
            }
        }

        if (posicaoAchada != -1)
        {
            Console.WriteLine($"O valor {valorAachar} foi encontrado na posição {posicaoAchada}");
        }
        else
        {
            Console.WriteLine($"O valor {valorAachar} não existe no vetor");
        }
    }
}
