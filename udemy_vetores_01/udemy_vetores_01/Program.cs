using System;
using System.Globalization;

namespace udemy_vetores01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            for (int i = 0; i < n; i++){
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }


            Console.ReadLine();
        }
    }
}