class Program
{
    static int[,] gerarMatriz(int[,] matriz)
    {
        Random random = new Random();
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matriz[i, j] = random.Next(0, 100);
            }
        }
        return matriz;
    }
    
    static void lerMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        //lendo a matriz
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"[{i},{j}]:");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }// fim for j
        }// fim for i
    }// fim funcao ler

    // mostraMatriz
    public static void mostrarMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        // mostrar a matriz
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"|{matriz[i, j],3}");
            }// fim j
            Console.WriteLine();// quebra a linha
        }// fim i
    }


    public static void Main(){
        int [,] mapaTesouro = gerarMatriz(new int[3,3]); // também não especificou quantas linhas pode ser então deixei 3x3 como no exemplo
        
        Console.WriteLine("Mapa do Tesouro (Quantidade de Moedas em Cada Região):");
        mostrarMatriz(mapaTesouro);

        int somaPrincipal = 0;
        int somaSecundaria = 0;

        for (int i = 0; i < mapaTesouro.GetLength(0); i++)
        {
            for (int j = 0; j < mapaTesouro.GetLength(1); j++)
            {
                if (i == j)
                {
                    somaPrincipal = somaPrincipal + mapaTesouro[i,j];
                }
                if (i + j == mapaTesouro.GetLength(0) - 1)
                {
                    somaSecundaria = somaSecundaria + mapaTesouro[i,j];
                }
            }// fim for j
        }// fim for i

        Console.WriteLine($"Soma da Diagonal Principal: {somaPrincipal}");
        Console.WriteLine($"Soma da Diagonal Secundária: {somaSecundaria}");

        if (somaSecundaria > somaPrincipal)
        {
            Console.WriteLine("O maior tesouro está na diagonal secundária");
        }
        else if (somaPrincipal > somaSecundaria)
        {
            Console.WriteLine("O maior tesouro está na diagonal principal");
        }
        else
        {
            Console.WriteLine("Os dois caminhos têm a mesma quantidade");
        }
    }
}
