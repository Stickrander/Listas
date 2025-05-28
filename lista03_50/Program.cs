using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10Matriz
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
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void PreencherMatriz(int[,] matriz)
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

        static int [,] Transposta(int[,] matriz)
        {
            int[,] matrizT = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizT[i, j] = matriz[j, i];
                }
            }
            return matrizT;
        }
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int[,] matrizT;

            Console.WriteLine("Matriz: ");
            PreencherMatriz(matriz);
            Console.WriteLine();
            ImprimirMatriz(matriz);
            Console.WriteLine("\nMatriz transposta: ");
            matrizT = Transposta(matriz);
            ImprimirMatriz(matrizT);

        }
    }
}
