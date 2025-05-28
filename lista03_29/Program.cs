using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int soma = 0, impares = 0;
            Random random = new Random();

            Console.WriteLine("Vetor:");
            for (int i = 0; i < 6; i++)
            {
                vetor[i] = random.Next(0, 10);

                if (vetor[i] % 2 == 0)
                {
                    soma = soma + vetor[i];
                }
                else
                {
                    impares++;
                }
                Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nElementos impares do vetor:");
            for (int i = 0; i < 6; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.Write($"{vetor[i]} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"\nO vetor possui {impares} números ímpares e a soma dos pares é de {soma}.");
        }
    }
}
