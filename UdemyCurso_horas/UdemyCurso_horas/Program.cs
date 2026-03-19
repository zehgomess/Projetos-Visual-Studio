using System;

namespace teste_horas {
    class Program
    {
        static void Main(string[] args)
        {

            int horas;

            Console.Write("Horas sao?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine(" Bom dia caraio ");
            }
            else
            {
                if (horas < 18)
                {
                    Console.WriteLine(" Boa tarde jovem");
                }
                else
                {
                    Console.WriteLine(" boa noite rapaz ");
                }
            }
            Console.ReadLine();

        }
    }
}