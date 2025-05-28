using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_62
{
    internal class Program
    {
        static double[,] Prenchermat(double[,] a) 
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++) 
            {
                Console.WriteLine();
                for(int j = 0; j < a.GetLength(1); j++) 
                {

                    a[i, j] = rnd.Next(1, 10);
                    Console.Write($"{a[i,j]} ");
                
                }
            
            }

            return a;
        
        }

        static void PrecherB(double[,] a) 
        { 
        
            for (int i = 0;i < a.GetLength(0); i++) 
            {
                Console.WriteLine();
                for(int j = 0;j < a.GetLength(1); j++)
                {
                    a[i,j]= Math.Pow(a[i,j], 2);

                    Console.Write($"{a[i,j]} ");
                }
            
            }
        
        }

        static void Main(string[] args)
        {

            /*23. Faca um programa que leia uma matriz A de tamanho 3x3 e calcule B= A2*/

            double[,] mat = new double[3, 3];

            Console.WriteLine("Matriz prenchida");
            Prenchermat(mat);
            Console.WriteLine();
            Console.WriteLine("Matriz elevada");
            PrecherB(mat);





        }
    }
}
