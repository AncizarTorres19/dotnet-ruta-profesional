namespace RutaProfesional.App;

/// <summary>
/// Ilustra validación, métodos, tipos decimales y salida por consola.
/// </summary>
public static class EjemplosJunior
{
    public static void Ejecutar()
    {
        var producto = new Producto("Cuaderno", 12_500m);
        const decimal tasaImpuesto = 0.19m;
        const int cantidad = 3;

        var subtotal = CalcularSubtotal(producto.Precio, cantidad);
        var impuesto = subtotal * tasaImpuesto;

        Console.WriteLine($"Producto: {producto.Nombre}");
        Console.WriteLine($"Subtotal: {subtotal:C}");
        Console.WriteLine($"Impuesto: {impuesto:C}");
        Console.WriteLine($"Total: {subtotal + impuesto:C}");
    }

    /// <summary>
    /// Multiplica el precio unitario por la cantidad después de validar las entradas.
    /// </summary>
    public static decimal CalcularSubtotal(decimal precioUnitario, int cantidad)
    {
        if (precioUnitario < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(precioUnitario), "El precio no puede ser negativo.");
        }

        if (cantidad < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(cantidad), "La cantidad no puede ser negativa.");
        }

        return precioUnitario * cantidad;
    }

    private sealed record Producto(string Nombre, decimal Precio);
}
