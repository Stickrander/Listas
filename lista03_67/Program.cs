using System;

namespace CartelaBingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] cartela = new int[5, 5];
            GerarCartela(cartela);
            Console.WriteLine("Cartela de Bingo:");
            ExibirCartela(cartela);
        }

        // a) Gera números aleatórios sem repetição e preenche a matriz
        static void GerarCartela(int[,] mat)
        {
            Random rand = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    int numero;
                    bool repetido;

                    do
                    {
                        numero = rand.Next(0, 100);
                        repetido = VerificarRepeticao(mat, numero);
                    } while (repetido);

                    mat[i, j] = numero;
                }
            }
        }

        // b) Verifica se um número já está na matriz
        static bool VerificarRepeticao(int[,] mat, int valor)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == valor)
                        return true;
                }
            }
            return false;
        }

        // c) Exibe a matriz formatada
        static void ExibirCartela(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j],2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
