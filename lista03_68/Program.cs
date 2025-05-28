using System;

namespace MaiorProdutoMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[20, 20];
            PreencherMatriz(matriz);
            Console.WriteLine("Matriz 20x20 preenchida.\n");

            int maiorProduto;
            string posicoes;
            BuscarMaiorProduto(matriz, out maiorProduto, out posicoes);

            Console.WriteLine($"Maior Produto: {maiorProduto}");
            Console.WriteLine($"Posições dos 4 números: {posicoes}");
        }

        // a) Preencher a matriz com números aleatórios de 1 a 99
        static void PreencherMatriz(int[,] mat)
        {
            Random rand = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rand.Next(1, 100);
                }
            }
        }

        // b) Buscar o maior produto em todas as direções
        static void BuscarMaiorProduto(int[,] mat, out int maior, out string posicoes)
        {
            maior = 0;
            posicoes = "";

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    VerificarDirecao(mat, i, j, 0, 1, ref maior, ref posicoes); // Direita
                    VerificarDirecao(mat, i, j, 1, 0, ref maior, ref posicoes); // Baixo
                    VerificarDirecao(mat, i, j, 1, 1, ref maior, ref posicoes); // Diagonal principal
                    VerificarDirecao(mat, i, j, 1, -1, ref maior, ref posicoes); // Diagonal secundária
                }
            }
        }

        // c) Verifica uma direção a partir da posição (i, j)
        static void VerificarDirecao(int[,] mat, int i, int j, int dx, int dy, ref int maior, ref string posicoes)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            if (i + 3 * dx < 0 || i + 3 * dx >= linhas || j + 3 * dy < 0 || j + 3 * dy >= colunas)
                return;

            int produto = 1;
            string posTemp = "";

            for (int k = 0; k < 4; k++)
            {
                int x = i + k * dx;
                int y = j + k * dy;
                produto *= mat[x, y];
                posTemp += $"[{x},{y}] ";
            }

            if (produto > maior)
            {
                maior = produto;
                posicoes = posTemp;
            }
        }
    }
}
