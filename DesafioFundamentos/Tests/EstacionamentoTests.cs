using Xunit;
using DesafioFundamentos.Models;

public class EstacionamentoTests
{
    [Fact]
    public void AdicionarVeiculo_DeveRetornarTrue_QuandoVeiculoEhAdicionadoComSucesso()
    {
        // Arrange
        var estacionamento = new Estacionamento(10, 5);
        var placa = "ABC-1234";

        // Act
        var resultado = estacionamento.AdicionarVeiculo(placa);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void AdicionarVeiculo_DeveRetornarFalse_QuandoVeiculoJaExiste()
    {
        // Arrange
        var estacionamento = new Estacionamento(10, 5);
        var placa = "ABC-1234";
        estacionamento.AdicionarVeiculo(placa);

        // Act
        var resultado = estacionamento.AdicionarVeiculo(placa);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void ListarVeiculos_DeveRetornarListaCorreta_QuandoVeiculosSaoAdicionados()
    {
        // Arrange
        var estacionamento = new Estacionamento(10, 5);
        var placa1 = "ABC-1234";
        var placa2 = "DEF-5678";
        estacionamento.AdicionarVeiculo(placa1);
        estacionamento.AdicionarVeiculo(placa2);

        // Act
        var resultado = estacionamento.ListarVeiculos();

        // Assert
        Assert.Equal(new List<string> { placa1, placa2 }, resultado);
    }
}