public static class Primos{
    // Javier, jjalvarez
    public int[] Primos(int num)
    {
        int i, n = 2, cont = 0;
        int[] numeros = new int[num];
        while (cont < num)
        {
            i = 2;
            while (i <= n)
            {
                if (i == n)
                {
                    numeros[cont] = n;
                    cont = cont + 1;
                    break;
                }
                else
                {
                    if (n % i == 0)
                    {
                        i = n;
                        break;
                    }
                }
                i = i + 1;
            }
            n = n + 1;
        }
        return numeros;
    }
}