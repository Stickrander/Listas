using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20matriz
{
    class Program
    {
        static void PreencherMatriz (double[,] matriz)
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength (0); i++)
            {
                for (int j = 0; j < matriz.GetLength (1); j++)
                {
                    matriz[i, j] = random.NextDouble() * 10;
                }
            }
        }

        static void ImprimiMatriz(double[,] matriz)
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]:f1}  ");
                }
                Console.WriteLine();
            }
        }

        static double SomaColImpares (double[,] matriz)
        {
            double soma = 0.0;

            for (int i = 0;i < matriz.GetLength (0);i++)
            {
                for (int j = 0;j < matriz.GetLength (1);j++)
                {
                    if (j % 2 != 0)
                    {
                        soma = soma + matriz[i, j];
                    }
                }
            }
            return soma;
        }

        static double MediaCol2e4(double[,] matriz)
        {
            double media = 0.0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 2 || j == 4)
                    {
                        media = media + matriz[i, j];
                    }
                }
            }
            media = media / 2;
            return media;
        }

        static double [,] MatrizModificada(double[,] matriz)
        {
            double[,] matrizM = new double[3, 6];
            matrizM = matriz;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 5)
                    {
                        matrizM[i, j] = matriz[i, 1] + matriz[i, 2];
                    }
                }
            }
            return matrizM;
        }

        static void Main(string[] args)
        {
            double[,] matriz = new double[3,6];
            double[,] matrizM;
            double soma, media;

            PreencherMatriz(matriz);
            ImprimiMatriz (matriz);
            soma = SomaColImpares (matriz);
            media = MediaCol2e4(matriz);
            Console.WriteLine();
            Console.WriteLine($"A soma das colunas ímpares é {soma:f1}");
            Console.WriteLine($"A média das colunas 2 e 4 é {media:f1}");
            Console.WriteLine();
            Console.WriteLine("\nMatriz modificada: ");
            matrizM = MatrizModificada (matriz);
            ImprimiMatriz(matrizM);
        }
    }
}
