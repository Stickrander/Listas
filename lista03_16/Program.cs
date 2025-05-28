using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[5];
            int codigo;
            Random random = new Random();



            for (int i = 0; i < 5; i++)
            {
                vetor[i] = random.Next(0, 10);
                Console.Write($"{vetor[i]} ");
            }

            Console.Write("\nQual código? ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 0: break;
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"{vetor[i]} ");
                    }
                    break;
                case 2:
                    for (int i = 5 - 1; i >= 0; i--)
                    {
                        Console.Write($"{vetor[i]} ");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
