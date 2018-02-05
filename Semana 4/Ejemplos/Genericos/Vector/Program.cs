using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2d<int> vector = new Vector2d<int>();
            Vector2d<double> vector2 = new Vector2d<double>();
            Vector2d<Racional> vector3 = new Vector2d<Racional>();
            vector3.X = new Racional(3,4);
            vector3.Y = new Racional(7,5);

            Console.WriteLine($"El vector es {vector.X}, {vector.Y}");
            Console.WriteLine($"El vector es {vector2.X}, {vector2.Y}");
            Console.WriteLine($"El vector es {vector3.X}, {vector3.Y}");
        }
    }
}
