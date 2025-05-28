using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];
            int z = 0;
            Random random = new Random();

            Console.WriteLine("Vetor 1:");
            for (int i = 0; i < 10; i++)
            {
                vetor1[i] = random.Next(0, 15);
                Console.Write($"{vetor1[i]} ");
            }

            Console.WriteLine("\n\nVetor 2:");
            for (int i = 0; i < 10; i++)
            {
                vetor2[i] = random.Next(0, 10);
                Console.Write($"{vetor2[i]} ");
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (vetor1[i] == vetor2[j])
                    {
                        bool jaExiste = false;
                        for (int k = 0; k < z; k++)
                        {
                            if (vetor3[k] == vetor1[i])
                            {
                                jaExiste = true;
                                break;
                            }
                        }

                        if (!jaExiste)
                        {
                            vetor3[z] = vetor1[i];
                            z++;
                        }
                        break;
                    }
                }
            }

            Console.WriteLine("\n\nVetor 3 (comuns sem repetição):");
            for (int i = 0; i < z; i++)
            {
                Console.Write($"{vetor3[i]} ");
            }
        }
    }
}
