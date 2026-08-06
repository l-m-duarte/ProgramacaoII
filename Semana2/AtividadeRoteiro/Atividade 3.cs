// See https://aka.ms/new-console-template for more information
class Atividade3
{
     static int acharMedia(int[] vetor, int valorAachar)
    {
       int posicaoAchada = -1;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valorAachar)
            {
                posicaoAchada = i;
                break;
            }
        }
        return posicaoAchada;
    }


    static void Main()
    {
        int[] valores = new int[5];
        valores = [1, 2, 3, 4, 5];

        Console.WriteLine("Digite o valor do numero a achar: ");
        int valorAachar = int.Parse(Console.ReadLine()!);

        int posicaoAchada = acharMedia(valores, valorAachar);

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
