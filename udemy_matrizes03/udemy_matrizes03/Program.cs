using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;
// ler numeros inteiros, matriz de m linhas e n colunas, gerar vetor que mostre a saida somando as 
// linhas

namespace udemy_matrizes03_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] mat;

            string[] s = Console.ReadLine().Split(' ');
            m = int.Parse(s[0]);
            n = int.Parse(s[1]);
            mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[m];

            for (int i = 0; i < m; i++)
            {
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }

    }
}