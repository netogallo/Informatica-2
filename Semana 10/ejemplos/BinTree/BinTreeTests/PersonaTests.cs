using Xunit;

public class PersonasTests
{
    [Fact]
    public void TestCumple()
    {
        Persona sut = new Persona(1, "Peyton-Jones", 22);

        sut.Cumple();

        Assert.Equal(23, sut.Edad);
    }

    [Fact]
    public void TestEdad()
    {
        for(int i = -30; i < 0; i++)
        {
            Persona sut = new Persona(1,"Zuckenberg", i);

            Assert.Equal(0, sut.Edad);
        }
    }
}