using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_65
{
    internal class Program
    {
        /*Gera uma matriz e verifica os numeros primos */


        static void PreencherMatriz(int[,] mat, Random rand)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rand.Next(1, 101);
                }
            }
        }

        static void ImprimirMatriz(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

        static bool EhPrimo(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;  // Achou um divisor → não é primo
            }
            return true;  // Não achou divisores → é primo
        }
    




        static void Main(string[] args)
        {


            int[,] matriz = new int[5, 5];
            Random rand = new Random();

            // Preenchendo a matriz com valores aleatórios de 1 a 100
            PreencherMatriz(matriz, rand);

            Console.WriteLine("Matriz Gerada:");
            ImprimirMatriz(matriz);

            Console.WriteLine("\nNúmeros primos encontrados:");

            // Verificando e mostrando os números primos
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (EhPrimo(matriz[i, j]))
                    {
                        Console.WriteLine($"Primo: {matriz[i, j]} na posição [{i},{j}]");
                    }
                }
            }


        }
    }
}
