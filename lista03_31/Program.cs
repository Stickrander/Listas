using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_31
{
    internal class Program
    {
        static void PreencherVetor(int[] vetor, Random random)
        {

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 10);
                Console.Write($"{vetor[i]} ");
            }
        }

        static int[] Uniao(int[] vetor1, int[] vetor2, out int z)
        {
            int[] vetor3 = new int[20];
            z = 0;
            for (int i = 0; i < vetor1.Length; i++)
            {
                bool ContemNum = false;

                for (int j = 0; j < z; j++)
                {
                    if (vetor1[i] == vetor3[j])
                    {
                        ContemNum = true;
                        break;

                    }
                }
                if (ContemNum == false)
                {
                    vetor3[z] = vetor1[i];
                    z++;
                }
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                bool ContemNum = false;

                for (int j = 0; j < z; j++)
                {
                    if (vetor2[i] == vetor3[j])
                    {
                        ContemNum = true;
                        break;
                    }
                }
                if (ContemNum == false)
                {
                    vetor3[z] = vetor2[i];
                    z++;
                }

            }
            return vetor3;
        }
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3;
            int z;
            Random random = new Random();

            Console.WriteLine("Vetor 1: ");
            PreencherVetor(vetor1, random);

            Console.WriteLine("\nVetor 2: ");
            PreencherVetor(vetor2, random);

            vetor3 = Uniao(vetor1, vetor2, out z);
            Console.WriteLine("\nVetor 3: ");

            for (int i = 0; i < z; i++)
            {
                Console.Write($"{vetor3[i]} ");
            }





        }
    }
}
