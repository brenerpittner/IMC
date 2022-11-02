using projeto_teste;

namespace TesteXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Veifica��o
            Assert.Equal(rNum, resultado);
        }
        //Arrange
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - A��o
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Veifica��o
            Assert.Equal(rNum, resultado);
        }
    }
}