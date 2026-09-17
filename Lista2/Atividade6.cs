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
        
        
        float [,] matrizResult = new float[linhas,colunas];
        
        String opcao = "e";

        do{
            Console.WriteLine("escolha a opção [(a) somar as 2 matrizes (b) subtrair a 1a matriz da 2a (c) add. uma const. as 2 matrizes (d) imprimir as matrizes]:");
            opcao = Console.ReadLine().ToUpper();
        }while ((opcao != "A") && (opcao != "B") && (opcao != "C") && (opcao != "D"));
        
        if (opcao == "A"){
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizResult[i, j] = matriz[i,j] +  matriz2[i,j];
                }// fim j
            }
            mostrarMatriz(matrizResult);
        }
        else if (opcao == "B"){
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizResult[i, j] = matriz2[i,j] - matriz[i,j];
                }// fim j
            }
            mostrarMatriz(matrizResult);
        }
        else if (opcao == "C"){
            Console.WriteLine("constante a adicionar:");
            int constante = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = matriz2[i,j] + matriz[i,j] + constante;
                }// fim j
                mostrarMatriz(matriz);
            }
            
            mostrarMatriz(matriz);
        }
        else{
            mostrarMatriz(matriz);
            Console.WriteLine();
            mostrarMatriz(matriz2);
        }
        
    }
}
