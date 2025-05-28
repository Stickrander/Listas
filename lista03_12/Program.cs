using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_12
{
    internal class Program
    {
        static int PrencherVetor(int[] vet,ref int maior,ref int menor,ref double media) 
        {

            int soma = 0;
            
            Random rand = new Random();
            
            for(int i = 0; i < vet.Length; i++)
            {

                vet[i] = rand.Next(1,20);
                Console.Write($"{vet[i]} ");

               

                if( vet[i] >maior)
                {
                    maior = vet[i];
                    
                }

                if (vet[i] < menor)
                {
                    menor = vet[i];
                    
                }

                soma += vet[i];
            }
            media = soma / vet.Length;
            
            Console.WriteLine(media);
            return vet.Length;


        }


        static void Main(string[] args)
        {
            /*12. Leia 5 valores. Use métodos para mostrar os valores, indicar o maior e o menor e calcular a
            média*/

            int[] vet = new int[5];

            int maior=int.MinValue,menor=int.MaxValue;
            double media=0;

            PrencherVetor(vet, ref maior, ref menor, ref media);
            Console.WriteLine();
            Console.WriteLine("Menor");
            Console.WriteLine(menor);
           
            Console.WriteLine("Maior");
            Console.WriteLine(maior);
          
            Console.WriteLine("Media");
            Console.WriteLine(media);
        }
    }
}
