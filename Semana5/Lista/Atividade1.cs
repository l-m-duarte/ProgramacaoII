// eu decidi embutir todas as funções da biblioteca matriz para fazer o código, por alguma ventura, mais fácil de executar
    public class Atividade1
    {
        public static void lerMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void mostrarMatriz (int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{matriz[i, j],3}| ");
                }
                Console.WriteLine();
            }
        }

        public static void gerarMatriz(int[,] matriz)
        {
            Random random = new Random();
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    matriz[i, j] = random.Next(0, 100);
        }
        public static void Main()
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());
                
            int[,] matriz = new int[linhas, colunas];
            Console.WriteLine("Digite os elementos da matriz:");
            lerMatriz(matriz);
            Console.WriteLine("Matriz digitada:");
            mostrarMatriz(matriz);
            
            int maior = matriz[0,0];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i,j] > maior)
                    {
                        maior = matriz[i,j];
                    }
                }
            }
            Console.WriteLine($"Maior valor da matriz: {maior}");
        }
    }
