using System;

namespace Metodos_Abstractos
{
    class Program
    {

        static void AlimentarTodoElDia(Animal animal, string alimento){
            // En la manana
            animal.Comer(alimento);

            // En la tarde
            animal.Comer(alimento);

            // En la noche
            animal.Comer(alimento);
        }

        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();

            Program.AlimentarTodoElDia(perro, "carne");
            Program.AlimentarTodoElDia(gato, "leche");

            Console.WriteLine($"El perro tiene {perro.Energia} calorias");
        }
    }
}
