namespace RutaProfesional.App;

/// <summary>
/// Enseña inversión de dependencias mediante un caso de uso pequeño.
/// </summary>
public static class EjemplosSenior
{
    public static void Ejecutar()
    {
        IRepositorioPedidos repositorio = new RepositorioEnMemoria();
        var registrarPedido = new RegistrarPedido(repositorio);

        var pedido = registrarPedido.Ejecutar("Ana", 3);
        Console.WriteLine($"Pedido registrado: {pedido.Id} para {pedido.Cliente}");
    }

    private sealed record Pedido(long Id, string Cliente, int Unidades)
    {
        public static Pedido Crear(string cliente, int unidades, long id)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(cliente);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(unidades);
            return new Pedido(id, cliente, unidades);
        }
    }

    private interface IRepositorioPedidos
    {
        Pedido Guardar(string cliente, int unidades);
    }

    private sealed class RegistrarPedido(IRepositorioPedidos repositorio)
    {
        public Pedido Ejecutar(string cliente, int unidades) =>
            repositorio.Guardar(cliente, unidades);
    }

    private sealed class RepositorioEnMemoria : IRepositorioPedidos
    {
        private readonly Dictionary<long, Pedido> _pedidos = [];
        private long _siguienteId = 1;

        public Pedido Guardar(string cliente, int unidades)
        {
            var pedido = Pedido.Crear(cliente, unidades, _siguienteId++);
            _pedidos.Add(pedido.Id, pedido);
            return pedido;
        }
    }
}
