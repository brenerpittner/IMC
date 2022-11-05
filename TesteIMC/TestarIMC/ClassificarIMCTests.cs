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
    public class ClassificarIMCTests
    {
        [TestMethod]
        public void ClassificarIMC()
        {
            //arrange
            double imc = 28;

            //act
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //assert
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }

    }
}
