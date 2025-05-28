using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
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
                vetor[i] = random.Next(-10, 11);
                Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nVetor trocado por 0: ");

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                {
                    vetor[i] = 0;
                }
                Console.Write($"{vetor[i]} ");
            }
        }
    }
}
