using RutaProfesional.App;
using Xunit;

namespace RutaProfesional.Tests;

public sealed class EjemplosJuniorTests
{
    [Theory]
    [InlineData(12.50, 4, 50.00)]
    [InlineData(0, 0, 0)]
    [InlineData(0.1, 3, 0.3)]
    public void CalcularSubtotal_MultiplicaPrecioPorCantidad(
        decimal precio,
        int cantidad,
        decimal totalEsperado)
    {
        var resultado = EjemplosJunior.CalcularSubtotal(precio, cantidad);

        Assert.Equal(totalEsperado, resultado);
    }

    [Theory]
    [InlineData(-1, 1, "precioUnitario")]
    [InlineData(1, -1, "cantidad")]
    public void CalcularSubtotal_RechazaValoresNegativos(
        decimal precio,
        int cantidad,
        string parametroInvalido)
    {
        var error = Assert.Throws<ArgumentOutOfRangeException>(
            () => EjemplosJunior.CalcularSubtotal(precio, cantidad));

        Assert.Equal(parametroInvalido, error.ParamName);
    }
}
