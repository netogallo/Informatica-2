using System;
using Xunit;

public class SortingTests
{
    [Fact]
    public void TestBubbleSort()
    {
        int[] test = new int[]{2,-5,3,8};
        int[] esperado = new int[]{-5,2,3,8};

        int[] resultado = Program.BubbleSort(test);

        Assert.Equal(esperado, resultado);
    }
}

