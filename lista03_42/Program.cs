using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace lista03_42
{
    internal class Program
    {

        static int[,] Prenchermar()
        {
            int [,] mat = new int[4, 4];
            Random rnd = new Random();
            
            for (int i = 0; i < mat.GetLength(0); i++) 
            {
                Console.WriteLine();
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    mat[i, j] = rnd.Next(1, 20);
                    Console.Write($"{mat[i,j]} ");

                }
            
            }
                return mat;
        }

        static  int[,] Produtomat(int[,] mat)
        {
            
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine();

                
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                   mat[i, j] =mat[i,j];
                    Console.Write($"{mat[i, j]} ");
                }
               
            }

            return mat ;
        }


        static void Main(string[] args)
        {
            /* 3. Preencha uma matriz 4x4 com o produto da linha pelo valor da coluna. Use um método para
            preencher e outro para exibir*/
            Console.WriteLine("Matriz Prenchida");
            int[,] mat = Prenchermar();
            Console.WriteLine();
            Console.WriteLine("Produto da matriz");
            Produtomat(mat);
            
            


        }
    }
}
