using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen3EV;

namespace TestSGL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            
        }

        [TestMethod]
        [ExceptedException(typeof(ArgumentOutOfRangeException))]
        public void validarVacio()
        {
            string cadena1 = "";
            string cadena2 = "";

            Diccionario objeto1 = new Diccionario(cadena1, cadena2);
        }
    }
}
