global using Xunit;
using Teste_Opera��es;

namespace ElementoX
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
            {
                // Arrange - Prepara��o
                double pNum = 1;
                double sNum = 1;
                double rNum = 2;

                // Act - A��o
                var resultado = Operacoes.Somar(pNum, sNum);

                // Assert - Verifica��o
                Assert.Equal(rNum, resultado);
            }

            [Theory]
            [InlineData(1, 2, 3)]
            [InlineData(1, 1, 2)]
            [InlineData(5, 6, 12)]
            [InlineData(13, 4, 15)]

            public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
            {
                // Act - A��o
                var resultado = Operacoes.Somar(pNum, sNum);

                // Assert - Verifica��o
                Assert.Equal(rNum, resultado);

            }
     
    }
}