using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas: ");
            int n = int.Parse(Console.ReadLine());

            int[] linha = new int[n];

            linha[0] = 1;

            for (int i = 0; i < n; i++)
            {
                // Imprime a linha atual
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(linha[j] + " ");
                }
                Console.WriteLine();

                // Atualiza os valores da linha de trás pra frente
                for (int j = i; j > 0; j--)
                {
                    linha[j] = linha[j] + linha[j - 1];
                }

                linha[0] = 1; // Sempre começa com 1
            }
        }
    }
}
