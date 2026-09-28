class Program
{
    public static void Main(){
        int[,] mar = new int[100, 100]; //limite grande para garantir o tamanho das coordenadas
        
        int n = int.Parse(Console.ReadLine());
        
        for (int k = 0; k < n; k++)
        {
            int xi = int.Parse(Console.ReadLine());
            int xf = int.Parse(Console.ReadLine());
            int yi = int.Parse(Console.ReadLine());
            int yf = int.Parse(Console.ReadLine());
            
            for (int i = xi; i <= xf; i++)
            {
                for (int j = yi; j <= yf; j++)
                {
                    mar[i, j] = 1;
                }
            }
        }
        
        int areaTotal = 0;
        for (int i = 0; i < mar.GetLength(0); i++)
        {
            for (int j = 0; j < mar.GetLength(1); j++)
            {
                if (mar[i, j] == 1)
                {
                    areaTotal = areaTotal + 1;
                }
            }// fim for j
        }// fim for i
        Console.WriteLine($"{areaTotal}");
    }
}
