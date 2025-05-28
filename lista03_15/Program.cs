using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void semRepetir(int[] vetor)
        {
            int[] vetorSemRepetir = new int[vetor.Length];
            int tam = 0;


            for (int i = 0; i < vetor.Length; i++)
            {
                bool jaExiste = false;
                for (int j = 0; j < tam; j++)
                {
                    if (vetor[i] == vetorSemRepetir[j])
                    {
                        jaExiste = true;
                        break;
                    }
                }
                if (!jaExiste)
                {
                    vetorSemRepetir[tam] = vetor[i];
                    tam++;
                }
            }


            for (int i = 0; i < tam; i++)
            {
                Console.Write($"{vetorSemRepetir[i]} ");
            }

        }
        static void Main(string[] args)
        {
            int[] vetor = new int[20];
            Random random = new Random();

            Console.WriteLine("Elementos do vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 10);
                Console.Write($"{vetor[i]} ");
            }

            Console.WriteLine("\nElementos do vetor sem repetição: ");
            semRepetir(vetor);
        }
    }
}
