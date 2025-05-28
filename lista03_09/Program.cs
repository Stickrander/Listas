using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] par = new int[6];
            int num;

            for (int i = 0; i < par.Length; i++)
            {
                Console.Write($"Informe o valor da posição {i + 1}: ");
                num = int.Parse(Console.ReadLine());

                while (num % 2 != 0)
                {
                    Console.Write($"Informe o valor da posição {i + 1}: ");
                    num = int.Parse(Console.ReadLine());
                }

                if (num % 2 == 0)
                {
                    par[i] = num;
                }


            }

            Console.Write("\nVetor original: ");

            for (int i = 0; i < par.Length; ++i)
            {
                Console.Write($"{par[i]} ");
            }

            Console.Write("\nVetor inverso: ");

            for (int i = par.Length - 1; i >= 0; i--)
            {
                Console.Write($"{par[i]} ");
            }
        }
    }
}
