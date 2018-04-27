using System;
using System.Linq;
public class Program
{
    public static int[] BubbleSort(int[] valores)
    {
        int[] resultado = new int[valores.Length];
        int[] indices = new int[valores.Length];
        for(int i = 0; i < indices.Length; i++)
        {
            indices[i] = -1;
        }

        for(int i = 0; i < valores.Length; i++)
        {
            int comodin = 0;

            for(int j = 0; j < indices.Length; j++)
            {
                if(!indices.Contains(j))
                {
                    comodin = j;
                    break;
                }
            }

            for(int j = 0; j < valores.Length; j++)
            {
                int otro = valores[j];

                if(
                    otro < valores[comodin]
                    && !indices.Contains(j))
                {
                    comodin = j;
                }
            }
            resultado[i] = valores[comodin];
            indices[i] = comodin;
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
