using System;
using System.Globalization;

namespace URI1078_FOR_tabuada
{
    class Program
    {
        static void Main(string[] args) {

            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                int resultado = i * n;
                Console.WriteLine(i + " X " + n + " = " + resultado);
            }
        }
    }
}

