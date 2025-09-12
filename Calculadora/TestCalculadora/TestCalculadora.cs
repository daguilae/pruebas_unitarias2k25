using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculadoraEjemplo;

namespace TestCalculadora
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        public void Test_Suma()
        {
            //Arrange: incializar las variables
            int sumando1 = 3;
            int sumando2 = 5;
            //Act: ejecucion del metodo a probar
            int resultado = CalculadoraEjemplo.CalculadoraEjemplo.Suma(sumando1, sumando2);
            //Assert: comprobacion de los resultados
            Assert.AreEqual(8, resultado);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Division()
        {
            //Arrange: inicializar las variables
            int dividendo = 120;
            int divisor = 0;
            //Act: ejecucion del metodo a probar
            double resultado = CalculadoraEjemplo.CalculadoraEjemplo.Division(dividendo, divisor);
            //Assert: comprobacion de los resultados
            Assert.AreEqual(60, resultado);
        }
    }
}
