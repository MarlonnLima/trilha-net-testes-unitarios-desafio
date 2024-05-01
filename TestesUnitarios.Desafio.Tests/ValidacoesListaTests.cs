using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        bool contem = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(contem);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        // Act
        var listaCalculada = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, listaCalculada);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Assert / Act
        Assert.Equal(9, _validacoes.RetornarMaiorNumeroLista(lista));
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Assert / Act
        Assert.Equal(-8, _validacoes.RetornarMenorNumeroLista(lista));
    }
}
