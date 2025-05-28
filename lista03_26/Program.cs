using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            double media = 0, desvioPadrao = 0;
            Random random = new Random();

            Console.WriteLine("Vetor: ");
            for (int i = 0; i < 10; i++)
            {
                v[i] = random.Next(0, 10);
                Console.Write($"{v[i]} ");
                media = media + v[i];
            }
            media = media / v.Length;
            for (int i = 0; i < 10; i++)
            {
                desvioPadrao += Math.Pow(v[i] - media, 2);
            }
            desvioPadrao = Math.Sqrt(desvioPadrao / (v.Length - 1));
            Console.WriteLine($"\nO desvio padrão desse vetor é {desvioPadrao}");
        }
    }
}
