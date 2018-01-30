using System;

namespace Ejemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro miPerrito = new Perro();
            Vehiculo carro = new Vehiculo();

            /*
            Polimorfismo: Cuando un objeto puede ser
            de varios tipos diferentes segun el
            contexto.
            */
            Program.Acercar(miPerrito, 0, 0);
            Program.Alimentar(miPerrito);
            Program.Acercar(carro, 0, 0);
        }

        /**
        Mueve el objeto hasta que el pase las coordenadas
        que se dieron como parametro.
        */
        static void Acercar(IMover obj, double x, double y){
            Console.WriteLine($"El objeto esta en ({obj.X},{obj.Y})");
            obj.Mover(4,6);
            Console.WriteLine($"El objeto esta en ({obj.X},{obj.Y})");
        }

        static void Alimentar(Organismo org){
            org.Alimentar("carne");
        }
    }
}
