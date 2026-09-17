class Program
{
    static float[,] gerarMatriz(float[,] matriz)
    {
        Random random = new Random();
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matriz[i, j] = (random.Next(100, 10000));
                matriz[i, j] = matriz[i,j]/100;
            }
        }
        return matriz;
    }
    
    static void lerMatriz(float[,] matriz)
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
    public static void mostrarMatriz(float[,] matriz)
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
        
        float[,] matriz = gerarMatriz(new float[linhas,colunas]);
        float[,] matriz2 = gerarMatriz(new float[linhas,colunas]);
        
        float[,] matrizResult = new float[linhas,colunas];
        
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matrizResult[i, j] = matriz[i,j] +  matriz2[i,j];
            }// fim j
        }
        Console.WriteLine();
         /*aqui ñ é preciso cheque pois ambas compartilham da mesma variável para o tamanho.
         mas se quisesse add. uma cond., fizesse com que conferisse se
         o GetLength(0) GetLength(1) da matriz conferem com os da matriz2, respectivamente
         e caso contrário forçasse o usuário a entrar os dados de novo, tudo num while do*/
        mostrarMatriz(matrizResult); 
    }
}
