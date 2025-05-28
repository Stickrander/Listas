using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_14
{

  
    internal class Program
    {

        static int[] Prenchervetor(int[] vet)
        {
            Random rnd = new Random();
            int [] vetB= new int[10]; 
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 50);
                Console.Write($"{vet[i]} ");

            }

            return vet;
        }

        static void VerificaIguais(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[i] == vet[j])
                    {
                        Console.WriteLine($"Valor repetido: {vet[i]}");
                    }
                }
            }
        }


        static void Main(string[] args)
        {

            /*14. Leia um vetor de 10 posições e, com um método, verifique se existem valores iguais e exiba-os.*/
            int [] vet = new int[10];
            int iguais;

            Console.WriteLine("Vetor");
            Prenchervetor (vet);
            Console.WriteLine();
            Console.WriteLine("Valores iguais");
            VerificaIguais (vet);
            

        }
    }
}
