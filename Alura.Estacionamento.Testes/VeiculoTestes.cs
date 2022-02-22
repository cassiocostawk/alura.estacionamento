using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            // arrange
            var veiculo = new Veiculo();

            // act
            veiculo.Acelerar(10);

            // assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrear()
        {
            // arrange
            var veiculo = new Veiculo();

            // act
            veiculo.Frear(10);

            // assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }
    }
}
