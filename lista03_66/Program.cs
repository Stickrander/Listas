using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista03_66
{
    internal class Program
    {

        /*
         Questão 1 - Produto de Vetores (Complexidade e abstração com métodos)
Enunciado:
Leia dois conjuntos de números reais, armazenando-os em dois vetores com 5 elementos cada.
Em seguida, utilizando métodos, faça:
a) Imprima os dois vetores;
b) Calcule e imprima o produto escalar entre os dois vetores, sendo o produto escalar definido por:
Produto Escalar = x1 * y1 + x2 * y2 + ... + xn * yn
c) Exiba a média aritmética de cada vetor.
Dificuldade extra:
Valide a entrada para garantir que todos os números são reais. Caso o usuário digite algo inválido,
peça novamente*/

        static void LerVetor(double[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"Posição {i}: ");
                vet[i] = double.Parse(Console.ReadLine());
            }
        }

        static void ImprimirVetor(double[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{vet[i]} ");
            }
            Console.WriteLine();
        }

        static double ProdutoEscalar(double[] x, double[] y)
        {
            double soma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                soma += x[i] * y[i];
            }
            return soma;
        }

        static double CalcularMedia(double[] vet)
        {
            double soma = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
            }
            return soma / vet.Length;
        }
    




        static void Main(string[] args)
        {

            double[] vetorX = new double[5];
            double[] vetorY = new double[5];

            Console.WriteLine("Digite os valores para o vetor X:");
            LerVetor(vetorX);

            Console.WriteLine("Digite os valores para o vetor Y:");
            LerVetor(vetorY);

            Console.WriteLine("\nVetor X:");
            ImprimirVetor(vetorX);

            Console.WriteLine("Vetor Y:");
            ImprimirVetor(vetorY);

            double produto = ProdutoEscalar(vetorX, vetorY);
            Console.WriteLine($"\nProduto Escalar: {produto}");

            double mediaX = CalcularMedia(vetorX);
            double mediaY = CalcularMedia(vetorY);

            Console.WriteLine($"Média de X: {mediaX:F2}");
            Console.WriteLine($"Média de Y: {mediaY:F2}");

        }
    }
}
