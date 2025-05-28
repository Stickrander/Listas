using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Program
    {

     static void ImprimeMatriz (int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int linha = 0, coluna = 0, cont = 0;


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 0;
                }
            }

            ImprimeMatriz(matriz);

            bool ganhou = false;
            while (ganhou == false)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Jogador 1: ");
                    Console.Write("Linha: ");
                    linha = int.Parse(Console.ReadLine());
                    Console.Write("Coluna: ");
                    coluna = int.Parse(Console.ReadLine());

                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            matriz[linha, coluna] = -1;
                        }
                    }
                    ImprimeMatriz(matriz);
                    cont++;
                }
                else
                {
                    Console.WriteLine();

                    while (true)
                    {
                        Console.Write("Jogador 2: ");
                        Console.Write("Linha: ");
                        linha = int.Parse(Console.ReadLine());
                        Console.Write("Coluna: ");
                        coluna = int.Parse(Console.ReadLine());
                        if (matriz[linha, coluna] == 0)
                        {
                            matriz[linha, coluna] = 1;
                        }
                        else
                        {
                            Console.WriteLine("Jogador 2, informe uma linha e coluna que não esteja ocupada: ");

                        }
                    }

                }
            }
            ImprimeMatriz(matriz);
            cont++;
        }
            }
        }

