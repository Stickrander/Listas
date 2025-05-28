using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_05
{
    internal class Program
    {

        static int Prenchervetor(int[] vet)
        {
           Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
               
                vet[i] = rnd.Next(1,50);
                Console.Write($"{vet[i]} ");
            }


            return vet.Length;
        }


        static int Par(int[] vet)
        {
            int par=vet.Length;
            
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] %2 == 0)
                {
                    par=vet[i];
                    Console.Write($"{par} ");
                   
                }
                
            }

            return par;
        }


        static void Main(string[] args)
        {

            /*5. Leia um vetor de 10 posições e use um método que conte e retorne a quantidade de valores
            pares existentes.*/
            int[] vet = new int[10];
            
            Console.WriteLine("Vetor prenchido");
            Prenchervetor(vet);
            
            Console.WriteLine();
            Console.WriteLine("Valores Par");
            Par(vet);

            
            


        }
    }
}
