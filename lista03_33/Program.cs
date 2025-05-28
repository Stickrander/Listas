using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[15];
            Random random = new Random();

            Console.WriteLine($"Vetor normal: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 3);
                Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();

            int posicao = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != 0)
                {
                    vetor[posicao] = vetor[i];
                    posicao++;
                }
            }

            Console.WriteLine("\nVetor compactado (sem zeros):");
            for (int i = 0; i < posicao; i++)
            {
                Console.Write(vetor[i] + " ");
            }

        }
    }
}
