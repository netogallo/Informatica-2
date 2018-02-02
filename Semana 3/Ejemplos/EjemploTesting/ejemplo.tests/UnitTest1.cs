using System;
using Xunit;

namespace ejemplo.tests
{
    public class UnitTest1
    {
        [Fact]
        void ProbarPromedio(){

            // Setup
            Promedio prom = new Promedio();

            // Acto
            double resultado = prom.CalcularPromedio(2,2);

            // Verificacion
            Assert.Equal(2, resultado);
        }
    }
}
