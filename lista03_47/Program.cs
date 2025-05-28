namespace ConsoleApp8Matriz
{
    class Program
    {
        static void ImprimirMatriz(int[,] matriz)
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static void PreencherMatriz(int [,] matriz)
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(10, 100);
                }
            }
        }

        static double AcimaDiagonal(int[,] matriz)
        {
            double soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        soma = soma + matriz[i, j];
                    }
                }
            }
            return soma;
        }
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            double soma;

            PreencherMatriz(matriz);
            Console.WriteLine();
            ImprimirMatriz(matriz);
            soma = AcimaDiagonal(matriz);

            Console.WriteLine($"A soma dos elementos acima da diagonal principal é {soma}");
        }
    }
}
