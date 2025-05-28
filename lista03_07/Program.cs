using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_07
{
    internal class Program
    {

        static int Prenchervetor(int[] vet, ref int maior, out int x)
        {
            x =int.MinValue;

            Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {

                vet[i] = rnd.Next(1, 50);
                Console.Write($"{vet[i]} ");

                if (vet[i] > maior)
                {
                    maior = vet[i];
                   x= i;
                }
                
            }
            

            return vet.Length;
        }


        static void Main(string[] args)
        {

            /*7. Escreva um programa que leia 10 números inteiros e armazene em um vetor. Use métodos para
encontrar e exibir o maior elemento e sua posição.*/

            int[] vet = new int[10];
            int maior = int.MinValue;
            int x;
           

            Console.WriteLine("Vetor prenchido");
            Prenchervetor(vet, ref maior,out x);
            Console.WriteLine();
            Console.WriteLine($"O maior valor: {maior} na posição: {x}");
         


        }
    }
}
