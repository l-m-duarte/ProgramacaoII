/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program {
    public static int[,] gerarMatriz(int[,] matriz)
    {
        Random random = new Random();
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matriz[i, j] = random.Next(0, 2);
            }
        }
        return matriz;
    }
    public static void lerMatriz(int[,] matriz)
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



  static void Main() {
    Console.WriteLine("Tamanho da área analisada: ");
    int tamanho = int.Parse(Console.ReadLine());
    //muito mais fácil eu gerar as matrizes automaticamente do que user lerMatriz
    
    Console.WriteLine("MATRIZ ANTIGA");
    int [,] matrizArea1 = gerarMatriz(new int[tamanho,tamanho]);
    mostrarMatriz(matrizArea1);
    
    Console.WriteLine("MATRIZ ATUAL");
    int [,] matrizArea2 = gerarMatriz(new int[tamanho,tamanho]);
    mostrarMatriz(matrizArea2);
    
    int cobertaAnterior = 0;
    int cobertaAtual = 0;
    
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++) // já que linhas = colunas
        {
            if (matrizArea1[i,j] == 1) cobertaAnterior++;
            if (matrizArea2[i,j] == 1) cobertaAtual++; // ambos têm mesmo tamanho, já faz de uma vez num mesmo for
        }// fim j
        Console.WriteLine();// quebra a linha
    }// fim i
    
    //isso é algo que não foi passado em aula mas eu acho simplesmente útil demais, converter de uma base para outra
    double porcentAnterior = ((double)cobertaAnterior*100)/((double)tamanho*(double)tamanho);
    double porcentAtual = ((double)cobertaAtual*100)/((double)tamanho*(double)tamanho);
    
    Console.WriteLine($"Área coberta anterior: {cobertaAnterior} com percentual {porcentAnterior}%");
    Console.WriteLine($"Área coberta atual: {cobertaAtual} com percentual {porcentAtual}%");
    
    if (cobertaAtual > cobertaAnterior) Console.WriteLine($"Aumento de área coberta de {porcentAtual-porcentAnterior}%");
    else if (cobertaAtual < cobertaAnterior) Console.WriteLine($"Redução de área coberta de {porcentAnterior-porcentAtual}%");
    else Console.WriteLine($"A área coberta estagnou");
  }
}
