using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                vetorA[i] = random.Next(0, 11);
                Console.Write($"{vetorA[i]} ");
            }
        }
    }
}
