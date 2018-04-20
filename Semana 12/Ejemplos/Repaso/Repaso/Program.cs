using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int valor = 10; //rand.Next();

        if(valor % 5 == 0 || valor / 0 > 70)
        {
            Console.WriteLine("Divisible entre 5");
        }
        
        if(valor % 2 == 0)
        {
            Console.WriteLine("Par");
        }
    }
}
