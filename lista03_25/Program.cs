using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[100];

            for (int numero = 0, i = 0; i < 100; numero++)
            {
                if (numero % 7 != 0 && numero % 10 != 7)
                {
                    vetor[i] = numero;
                    i++;
                }
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{vetor[i]}");
            }
        }
    }
}
