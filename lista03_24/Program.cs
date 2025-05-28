using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double[10], altura = new double[10];
            Random random = new Random();
            double alturaMaior = double.MinValue, numeroMaior = 0, alturaMenor = double.MaxValue, numeroMenor = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                altura[i] = random.NextDouble() * 2;
                numero[i] = random.Next(1000000000, 1988899999);
                Console.WriteLine($"Altura do aluno {i + 1}: {altura[i]:f2} ");
                Console.WriteLine($"Número do aluno {i + 1}: {numero[i]}");

                if (altura[i] > alturaMaior)
                {
                    alturaMaior = altura[i];
                    numeroMaior = numero[i];
                }
                if (altura[i] < alturaMenor)
                {
                    alturaMenor = altura[i];
                    numeroMenor = numero[i];
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Altura do maior aluno é {alturaMaior:f2} e seu número é {numeroMaior}");
            Console.WriteLine($"Altura do menor aluno é {alturaMenor:f2} e seu número é {numeroMenor}");
        }
    }
}
