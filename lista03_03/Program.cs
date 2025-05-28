using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_03
{
    internal class Program
    {
        static double Prenchervetor(double[] vet)
        {
            double[] vetA = vet;
            Console.WriteLine("Digite 10 valores para o vetor");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{i+1} posição do vetor: ");
                vetA[i] = int.Parse(Console.ReadLine());
            }
            

            return vetA.Length;
        }

        static int Quadrado(double[] vet)
        {
            double[] vetA = vet;
            Console.WriteLine("Valores ao quadrado");
            for (int i = 0; i < vet.Length; i++)
            {
                
                vetA[i] =Math.Pow(2, i);
            }


            return vetA.Length;
        }

        static void Main(string[] args)
        {
            /*3. Crie um programa que leia 10 números reais, armazene-os e calcule o quadrado de cada
            elemento, armazenando em outro vetor. Use métodos para cada etapa*/
            double[] vet = new double[10];
            Random r = new Random();

            Console.WriteLine("Vetor prenchido");
            Prenchervetor(vet);
            for (int i = 0; i < vet.Length; i++) 
            {
                Console.Write($"{vet[i]} ");
            }
            
            Console.WriteLine();
            Quadrado(vet);
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{vet[i]} ");
            }
        }
    }
}
