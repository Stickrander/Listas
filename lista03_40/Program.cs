using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_40
{
    internal class Program
    {
        static int[,] Prenchermstiz(int[,] mat)
        {
            
                Random rnd = new Random();

                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        mat[i, j] = rnd.Next(1, 50);
                        Console.Write($"{mat[i,j]} ");

                    }
                }
            
            return mat;
        }
        
        static void Valoresmaior(int[,] mat,ref int maior )
        {

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] >10) 
                    {
                        maior=mat[i, j];
                        Console.Write($"{maior} ");

                    }
                    

                }
            }

        }

        static void Main(string[] args)
        {
            int[,] mat = new int[4,4];
            int maior = 0;
            Console.WriteLine("Matiz Prenchida");
            int [,] matx=Prenchermstiz(mat);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Valores acima de 10");
            Valoresmaior(mat,ref maior);
           


        }
    }
}
