using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_41
{
    internal class Program
    {
        static int[,] PrencherMat(int[,] mat)
        {
            
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    if(i == j)
                    {
                        mat[i,j ] = 1;
                    }
                    else
                    {
                        mat[i,j ] = 0;
                    }
                    Console.Write($"{mat[i, j]} ");
                }

            }

            return mat;
        }





        static void Main(string[] args)
        {
            /* 2. Declare uma matriz 5 x 5. Preencha com 1 a diagonal principal e com 0 os demais
             elementos. Escreva ao final a matriz obtida.*/

            int[,] mat = new int[5, 5];

            PrencherMat(mat);
           

        }
    }
}
