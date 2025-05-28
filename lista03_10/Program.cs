using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_10
{
    internal class Program
    {

        static int [] Prenchervetor(int[] vet)
        {
            Random rnd = new Random();
            for (int i = 0; i < vet.Length; i++)
            {

                //Console.Write($"Digite a nota do {i+1}º Aluno: ");
                //vet[i] = int.Parse(Console.ReadLine());

                vet[i] = rnd.Next(1,50);

                
            }

            return vet;
        }

        static int Media(int[] vet)
        {
            int soma = 0;
            
            for (int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
            }

            soma = soma / vet.Length;

            return soma;
        }

        static void Main(string[] args)
        {

            /*10. Faça um programa para ler a nota da prova de 15 alunos e armazene num vetor. Use um
método para calcular e exibir a média geral.*/


            int[] vet = new int[15];
            int soma;
            

            Console.WriteLine("Vetor Prenchido");
            Prenchervetor (vet);
            for (int i = 0; i < vet.Length; i++) 
            {
                Console.Write($"{vet[i]} ");
            }

            Console.WriteLine();
            Media(vet);
            soma = Media(vet);
            Console.WriteLine($"A media geral dos alunos e: {soma}");

            Console.WriteLine();
        }
    }
}
