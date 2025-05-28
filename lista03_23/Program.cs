using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor1 = new double[5];
            double[] vetor2 = new double[5];
            double produtoEscalar = 0;
            Random random = new Random();

            Console.WriteLine("Vetor 1: ");
            for (int i = 0; i < 5; i++)
            {
                vetor1[i] = random.NextDouble() * 10;
                Console.Write($"{vetor1[i]:f2}  ");
            }
            Console.WriteLine();
            Console.WriteLine("\nVetor 2: ");
            for (int i = 0; i < 5; i++)
            {
                vetor2[i] = random.NextDouble() * 10;
                Console.Write($"{vetor2[i]:f2}  ");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                produtoEscalar += vetor1[i] * vetor2[i];
            }
            Console.WriteLine($"\nProduto escalar: {produtoEscalar:f2} ");
        }
    }
}
