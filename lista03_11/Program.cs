using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_11
{
    internal class Program
    {

        static int[] Prenchervetor(int[] vet)
        {
            Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {

                //Console.Write($"Digite a nota do {i+1}º Aluno: ");
                //vet[i] = int.Parse(Console.ReadLine());

                vet[i] = rnd.Next(-20,20);


            }

            return vet;
        }

        static int VerificarPosi(int[] vet)
        {
            int positivo=vet.Length;

            
            for (int i = 0; i < vet.Length; i++) 
            {
            
                if (vet[i] > 0)
                {
                    positivo=vet[i];
                    Console.Write($"{positivo} ");
                }
            
            }

            return positivo;
        }

        static int Verificarneg(int[] vet)
        {
            int negativo = vet.Length;


            for (int i = 0; i < vet.Length; i++)
            {

                if (vet[i] < 0)
                {
                    negativo = vet[i];
                    Console.Write($"{negativo} ");
                }

            }

            return negativo;
        }

        static void Main(string[] args)
        {
            /*11. Preencha um vetor com 10 números reais. Use métodos para contar e exibir a quantidade de
            negativos e a soma dos positivos.*/
            
            int [] vet = new int[10];

            Prenchervetor (vet);
            for (int i = 0; i < vet.Length; i++) 
            {

                Console.Write($"{vet[i]} ");

            }

            Console.WriteLine();
            Console.WriteLine("Positivos");
            VerificarPosi(vet);
            Console.WriteLine();
            Console.WriteLine("Negativos");
            Verificarneg (vet);

        }
    }
}
