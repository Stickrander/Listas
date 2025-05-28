using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            Random random = new Random();


            Console.WriteLine("Vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);
                Console.Write($"{vetor[i]} ");
            }

            Console.WriteLine("\nNúmeros primos do vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                bool primo = true;

                if (vetor[i] <= 1)
                {
                    primo = false;
                }
                for (int j = 2; j < Math.Sqrt(vetor[i]); j++)
                {

                    if (vetor[i] % j == 0)
                    {
                        primo = false;
                    }
                }
                if (primo == true)
                {
                    Console.WriteLine($"\nNúmero {vetor[i]} é primo e está na posição {i}º.");
                }
            }

        }
    }
}
