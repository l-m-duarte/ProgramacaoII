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
        Console.WriteLine("linhas da matriz:");
        int linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("colunas da matriz:");
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas,colunas];
        matriz = gerarMatriz(matriz);
        
        mostrarMatriz(matriz);
        
        int maior = matriz[0,0];
        
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i,j] > maior){ maior = matriz[i,j];}
            }// fim j
        }// fim i
        
        Console.WriteLine($"Maior valor da matriz: {maior}");
    }
}
