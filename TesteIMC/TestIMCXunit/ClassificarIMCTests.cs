//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TesteIMC;
using Xunit;

namespace TestIMCXunit
{
    //classe de testes
    public class ClassificarIMCTests
    {
        [Fact]
        public void ClassificarIMC_RetornaResultado()
        {
            //arrange
            double imc = 28;

            //act
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //assert
            Assert.Equal("Sobrepeso", classificacaoIMC);
        }

        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade Grau I")]

        public void ClassificarIMC_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, string resultadoEsperado)
        {
            var resultadoDoIMC = Operacoes.ClassificarIMC(primeiroNumero);
            Assert.Equal(resultadoEsperado, resultadoDoIMC);
        }

    }
}
