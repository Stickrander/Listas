using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Posicao(int[] vetor, out int posMaior, out int posMenor)
        {
            posMaior = 0; posMenor = 0;
            int maiorValor = int.MinValue, menorValor = int.MaxValue;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maiorValor)
                {
                    maiorValor = vetor[i];
                    posMaior = i;
                }
                if (vetor[i] < menorValor)
                {
                    menorValor = vetor[i];
                    posMenor = i;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            int posMaior, posMenor;
            Random rand = new Random();

            Console.WriteLine("Vetor:");
            for (int i = 0; i < 5; i++)
            {
                vetor[i] = rand.Next(0, 101);
                Console.Write($"{vetor[i]} ");
            }

            Posicao(vetor, out posMaior, out posMenor);

            Console.WriteLine($"\nO maior número do vetor ocupa a posição {posMaior}º e o menor ocupa a posição {posMenor}º.");
        }
    }
}
