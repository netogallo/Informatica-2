using System;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            Carro carro = new Carro();
            carro.Avanzar();
            vehiculo.Avanzar();
            Console.WriteLine($"La coordenada del carro en X es: {carro.Posicion.X}");
            Console.WriteLine($"La coordenada del vehiculo en X es: {vehiculo.Posicion.X}");
        }
    }
}
