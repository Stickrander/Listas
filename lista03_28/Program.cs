using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            Random rand = new Random();

            Console.WriteLine("Elementos do vetor 1: ");
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rand.Next(0, 99);
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
            int iv1 = 0, iv2 = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                {
                    v1[iv1] = v[i];
                    iv1++;

                }
                else
                {
                    v2[iv2] = v[i];
                    iv2++;
                }
            }

            Console.WriteLine("\nElementos do vetor 2: ");
            for (int i = 0; i < iv1; i++)
            {
                Console.Write($"{v1[i]} ");

            }
            Console.WriteLine();
            Console.WriteLine("\nElementos do vetor 3: ");
            for (int i = 0; i < iv2; i++)
            {
                Console.Write($"{v2[i]} ");
            }
            Console.WriteLine();
        }
    }
}
