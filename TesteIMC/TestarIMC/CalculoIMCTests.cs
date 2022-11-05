global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TesteIMC;

namespace TestarIMC
{
    //classe de testes
    [TestClass]
    public class CalculoIMCTests
    {
        [TestMethod]
        public void CalcularIMC()
        {
            //arrange
            double peso = 110;
            double altura = 1.80;

            //act
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);
            
            //assert
            Assert.AreEqual(33.95, resultadoIMC); //professor = 34.33 double do MAC?
        }
    
    }
}