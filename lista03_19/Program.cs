using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[50];

            Console.Write($"Vetor: ");
            Console.WriteLine();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = (i + 5 * i) % (i + 1);
                Console.Write($"{vetor[i]} ");
            }
        }
    }
}
