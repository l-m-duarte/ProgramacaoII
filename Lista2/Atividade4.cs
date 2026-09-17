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
        int ordem = 0;
        Console.WriteLine("ordem da matriz (menor que 100):");
        do
            ordem = int.Parse(Console.ReadLine());
        while (ordem > 100);
        
        int[,] matriz = new int[ordem,ordem];
        matriz = gerarMatriz(matriz);
        
        mostrarMatriz(matriz);
        
        int[,] diagSecundaria = new int[ordem,ordem];
        
        for (int i = 0; i < diagSecundaria.GetLength(0); i++)
        {
            int j = diagSecundaria.GetLength(1)-i-1;
            diagSecundaria[i,j] = matriz[i,j];
        }// fim i
        
        Console.WriteLine("Diagonal Secundaria:");
        mostrarMatriz(diagSecundaria);
    }
}
