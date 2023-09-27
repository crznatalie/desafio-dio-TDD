using Desafio;

namespace TesteDesafio
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "27/09/2023";
            Calculadora calc = new Calculadora(data);

            return calc;

        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        [InlineData (5, 9, 14)]
        public void TesteSoma(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.soma(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(10, 5, 5)]
        [InlineData(9, 4, 5)]
        public void TestarSubtracao(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.subtracao(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(4, 5, 20)]
        [InlineData(2, 9, 18)]
        public void TestarMultiplicacao(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.multiplicacao(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(4, 2, 2)]
        [InlineData(60, 6, 10)]
        public void TestarDivisao(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalculadora = calc.divisao(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.divisao(7, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.soma(3, 7);
            calc.subtracao(5, 2);
            calc.multiplicacao(4, 6);
            calc.divisao(50, 5);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}