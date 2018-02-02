using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Promedio prom = new Promedio();
            double p1 = prom.CalcularPromedio(3,4,5,18);
            double p2 = prom.CalcularPromedio(3,18);
            double p3 = prom.CalcularPromedio();

            Console.WriteLine("Hello World!");
        }
    }
}
