using System;
using Xunit;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double v1 = 0;

        for(int i = 0; i < 100; i++){
            v1+= Math.PI/5;
        }

        double v2 = Math.PI * 20;

        Assert.Equal(v1,v2);
    }
}
