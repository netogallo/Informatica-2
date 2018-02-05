using Xunit;

public class PerroTest{

    [Fact]
    public void TestConsumeEnergia(){
        // Preparacion
        Perro perro = new Perro();
        perro.Alimentar("carne");

        // Acto
        for(int i = 0; i < 100; i++)
        {
            perro.Mover(1,0);
        }

        // Verificacion
        Assert.Equal(100, perro.X);
        Assert.Equal(0, perro.Energia);
    }
}