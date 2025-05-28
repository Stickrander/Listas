using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_06
{
    internal class Program
    {
        static int Prenchervetor(int[] vet,ref int maior,ref int menor)
        {
            Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {

                vet[i] = rnd.Next(1, 50);
                Console.Write($"{vet[i]} ");

                if (vet[i] > maior)
                {
                  maior = vet[i];
                }

                if (vet[i] < menor)
                {
                    menor=vet[i];
                }

            }


            return vet.Length;
        }

        static void Main(string[] args)
        {

            /*6. Faça um programa que receba um vetor com 10 posições. Use métodos para encontrar e exibir o
            maior e o menor elemento.*/

            int[] vet = new int[10];
            int maior = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("Vetor prenchido");
            Prenchervetor (vet, ref maior, ref menor);
            Console.WriteLine();
            Console.WriteLine($"O maior valor: {maior}");
            Console.WriteLine($"O menor valor: {menor}");
        }
    }
}
