using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Posição {i + 1} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nValores do vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]} ");
            }
        }
    }
}
