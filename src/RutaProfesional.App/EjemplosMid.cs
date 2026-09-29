namespace RutaProfesional.App;

/// <summary>
/// Demuestra records, LINQ y composición asíncrona con cancelación.
/// </summary>
public static class EjemplosMid
{
    public static async Task EjecutarAsync(CancellationToken cancellationToken = default)
    {
        var pedidos = new[]
        {
            new Pedido(1, "Ana", 120.00m, EstadoPedido.Pagado),
            new Pedido(2, "Luis", 80.50m, EstadoPedido.Nuevo),
            new Pedido(3, "Ana", 45.25m, EstadoPedido.Pagado)
        };

        var totalesPorEstado = pedidos
            .GroupBy(pedido => pedido.Estado)
            .Select(grupo => $"{grupo.Key}: {grupo.Count()}")
            .ToArray();

        var totalPagado = pedidos
            .Where(pedido => pedido.Estado == EstadoPedido.Pagado)
            .Sum(pedido => pedido.Total);

        // El token permite al llamador solicitar que el trabajo se detenga.
        await Task.Delay(TimeSpan.FromMilliseconds(100), cancellationToken);

        Console.WriteLine($"Pedidos: {string.Join(", ", totalesPorEstado)}");
        Console.WriteLine($"Total pagado: {totalPagado:C}");
    }

    private enum EstadoPedido
    {
        Nuevo,
        Pagado,
        Cancelado
    }

    private sealed record Pedido(long Id, string Cliente, decimal Total, EstadoPedido Estado);
}
