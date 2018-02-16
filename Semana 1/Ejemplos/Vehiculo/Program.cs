using System;

namespace Vehiculo
{
    class Program
    {

        static void Test<T>(T arg){
            Console.WriteLine(arg);
        }

        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo("Carro");

            Console.WriteLine(vehiculo);
        }
    }
}
