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
        int [,] regioesTropas = gerarMatriz(new int[3,3]); // não especificou quantas linhas pode ser então deixei 3x3 como no exemplo
        
        Console.Write("Matriz das Tropas (Quantidade de Tropas por Cidade):");
        Console.WriteLine();
        for (int i = 0; i < regioesTropas.GetLength(0); i++)
        {
            Console.WriteLine($"Região {i+1}: ");
            for (int j = 0; j < regioesTropas.GetLength(1); j++)
            {
                Console.Write($"{regioesTropas[i,j]} ");
            }// fim for j
            Console.WriteLine();
        }// fim for i
    
        Console.WriteLine();
        Console.Write("Força total das regiões:");
        Console.WriteLine();
        for (int i = 0; i < regioesTropas.GetLength(0); i++)
        {
            Console.WriteLine($"Região {i+1}: ");
            int soma = 0;
            for (int j = 0; j < regioesTropas.GetLength(1); j++)
            {
                soma = soma + regioesTropas[i,j];
            }// fim for j
            Console.WriteLine($"{soma}");
        }// fim for i

    }
}
