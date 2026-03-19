using System;
using System.Globalization;

namespace udemy_para_for
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, x, soma,i;

            n = int.Parse(Console.ReadLine());

            soma = 0;

            for (i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}