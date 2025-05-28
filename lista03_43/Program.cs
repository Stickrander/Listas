    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            Random random = new Random();
            int maiorValor = int.MinValue;
            int indiceI = 0, indiceJ = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(10, 51);
                    Console.Write($"{matriz[i,j]}  ");

                    if (matriz[i, j] >  maiorValor)
                    {
                        maiorValor = matriz[i, j];
                        indiceI = i;
                        indiceJ = j;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Maior valor é {maiorValor} e se encontra no indice [{indiceI},{indiceJ}]");
        }
    }
}
