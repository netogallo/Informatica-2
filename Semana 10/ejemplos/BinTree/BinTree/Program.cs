using System;

namespace BinTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            IBinTree<Persona> bTree = new BinaryTree<Persona>(
                new Persona(1, "Turing", 28),
                new BinaryTree<Persona>(new Persona(2, "Church", 38)),
                new BinaryTree<Persona>(
                    new Persona(3, "Von Neumann", 44),
                    new BinaryTree<Persona>(new Persona(4, "Elon Musk", 33)),
                    null
                )
            );

            Persona[] personas = bTree.ToArray();

            foreach(var p in personas)
            {
                p.Cumple();
            }

            Console.WriteLine(bTree.ToString());
        }
    }
}
