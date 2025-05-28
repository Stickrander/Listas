using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int x;
            Random rnd = new Random();

            Console.Write("Qual o valor de X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("\nVetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rnd.Next(0, 101);
                Console.Write($"{vetor[i]} ");
            }

            Console.Write($"\nElementos do vetor múltiplos de {x}: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % x == 0)
                {
                    Console.Write($"{vetor[i]} ");
                }
            }


        }
    }
}
