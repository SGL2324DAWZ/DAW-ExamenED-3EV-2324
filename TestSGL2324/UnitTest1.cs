using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen3EV;

namespace TestSGL2324
{
    [TestClass]
    public class UnitTest1
    {
        /*este metodo seria para validar un caso valido
        
        [TestMethod]
        public void Validar()
        {
            string cadena1 = "frase primera";
            string cadena2 = "frase segunda";

            int resultadoEsperado = 0; //al terminar la funcion analizar si ha ido bien devuelve un 0

            Diccionario objeto1 = new Diccionario();

            int resultado = objeto1.analizar(cadena1, cadena2);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        */

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarVacio()
        {
            string cadena1 = "";
            string cadena2 = "";

            Diccionario objeto1 = new Diccionario();

            int resultado = objeto1.analizar(cadena1, cadena2);
        }
    }
}
