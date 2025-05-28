using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[10];
            Random random = new Random();

            Console.WriteLine("Vetor 1: ");
            for (int i = 0; i < 10; i++)
            {
                vet1[i] = random.Next(10, 100);
                Console.Write($"{vet1[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("\nVetor 2: ");
            for (int i = 0; i < 10; i++)
            {
                vet2[i] = random.Next(10, 100);
                Console.Write($"{vet2[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nVetor 3: ");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    vet3[i] = vet1[i];
                }
                else
                {
                    vet3[i] = vet2[i];
                }
                Console.Write($"{vet3[i]} ");
            }

        }
    }
}
