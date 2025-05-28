using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            Random random = new Random();

            Console.WriteLine("Vetor original: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 51);
                Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nVetor com ímpares: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.Write($"{vetor[i]} ");
                }
            }

        }
    }
}
