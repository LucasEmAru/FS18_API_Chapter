global using Xunit;
using Teste_Operações;

namespace ElementoX
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
            {
                // Arrange - Preparação
                double pNum = 1;
                double sNum = 1;
                double rNum = 2;

                // Act - Ação
                var resultado = Operacoes.Somar(pNum, sNum);

                // Assert - Verificação
                Assert.Equal(rNum, resultado);
            }

            [Theory]
            [InlineData(1, 2, 3)]
            [InlineData(1, 1, 2)]
            [InlineData(5, 6, 12)]
            [InlineData(13, 4, 15)]

            public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
            {
                // Act - Ação
                var resultado = Operacoes.Somar(pNum, sNum);

                // Assert - Verificação
                Assert.Equal(rNum, resultado);

            }
     
    }
}