using Xunit;

using Genericos;

public class Tests{

    [Fact]
    public void testZip(){

        // Arrange
        int[] arr1 = new int[]{1,2,3};
        string[] arr2 = new string[]{"hola", "mundo"};

        Tupla<int,string>[] resultado = Program.Zip<int, string>(arr1, arr2);
        // El arreglo resultado debe ser [new Tupla(1,"hola"), new Tupla(2, "mundo")]

        Tupla<int,string> primer = resultado[0];
        Assert.Equal(1, primer.Primero);
        Assert.Equal("hola", primer.Segundo);
    }

    [Fact]
    public void testHead(){
        int[] valores = new int[]{1,2,3};

        int resultado = Program.Head(valores);

        Assert.Equal(1, resultado);
    }
}