using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_61
{
    internal class Program
    {

        static int[,] Prenchermat(int[,] mat) 
        { 
         Random rnd = new Random();
            for (int i = 0; i < mat.GetLength(0); i++) 
            {
                Console.WriteLine();
            
                for (int j = 0; j < mat.GetLength(1); j++) 
                { 
                
                    mat[i, j] = rnd.Next(1,10);
                    Console.Write($"{mat[i,j]} ");
                
                }

            }

            return mat;

        }

        static int [,] Multimat(int[,] mat)
        {
            
            for (int i = 0;i < mat.GetLength(0); i++) 
            {
                Console.WriteLine();
                for(int j = 0;j < mat.GetLength(1); j++)
                {

                    mat[i,j]=mat[i,j]* mat[i, j];
                    Console.Write($"{mat[i,j]} ");
                }
            
            }

            return mat ;

        }


        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
 
            /* 22. Faca um programa que leia duas matrizes A e B de tamanho 3x3 e calcule C = A ∗ B.*/
            
            Console.WriteLine("Matriz A");
            Prenchermat(mat);
            Console.WriteLine();
            Console.WriteLine("Matiz B");
            Prenchermat(mat);
            
            Console.WriteLine("Produto da Matria A e B");
            Multimat(mat);

        }
    }
}
