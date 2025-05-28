using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_01
{
    internal class Program
    {

        static int[] Prenchervetor(int[] vet)
        {

            int [] vetor = { 1, 0, 5, -2, -5, 7 };

            return vetor;
        }

        static int Somar(int[] vetor) 
        { 
         
            int soma=0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 0 || vetor[i] == 1 || vetor[i] == 5)
                {
                    soma += vetor[i];
                }

            }
            return soma;
        }

        static void Alterar(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                
                   vetor[4]=100;
                
                Console.Write($"{vetor[i]} ");
            }
            
        }

        static void Main(string[] args)
        {
            /*1. Faça um programa que possua um vetor denominado A que armazene 6 números inteiros. Use
            métodos para atribuir valores, calcular a soma de A[0], A[1] e A[5], modificar o valor na posição 4 e
            exibir o vetor*/

            int[] A= new int [6];
            


            A=Prenchervetor(A);
            Console.WriteLine("Vetor Prenchido");
            Console.WriteLine();
            foreach (int i in A) 
            {
                Console.Write($"{i} ");
            }
            
            Console.WriteLine();
            int soma=Somar(A);
            Console.WriteLine($"A soma dos posicoes e {soma}");

            Console.WriteLine("Vetor alterado");
           Alterar(A);
           


        }
    }
}
