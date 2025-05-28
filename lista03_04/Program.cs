using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_04
{
    internal class Program
    {
        static int[] Prenchervetor (int[] vet)
        {
            Console.WriteLine("Digite 10 valores para o vetor");
            for (int i = 0; i < vet.Length; i++)
            {       
                Console.Write($"{i} posção do vetor");
                vet[i] = int.Parse(Console.ReadLine());

            }


            return vet;
        }
        static void Main(string[] args)
        {
            /*3. Crie um programa que leia 10 números reais, armazene-os e calcule o quadrado de cada
            elemento, armazenando em outro vetor. Use métodos para cada etapa*/
            int[] vet=new int[10];

            


        }
    }
}
