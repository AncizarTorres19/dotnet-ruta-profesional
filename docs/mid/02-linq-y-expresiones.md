# 2. LINQ y expresiones

LINQ consulta secuencias con operadores encadenables. Distingue LINQ to Objects de proveedores como EF Core: un proveedor puede traducir la expresión a SQL y tiene límites propios.

```csharp
var totalesPorCliente = pedidos
    .Where(pedido => pedido.Estado == EstadoPedido.Pagado)
    .GroupBy(pedido => pedido.ClienteId)
    .Select(grupo => new
    {
        ClienteId = grupo.Key,
        Total = grupo.Sum(pedido => pedido.Importe)
    })
    .OrderByDescending(grupo => grupo.Total)
    .ToArray();
```

La proyección reduce datos y declara exactamente qué se necesita. `GroupBy` puede consumir memoria si el conjunto es grande; en base de datos verifica SQL generado y usa paginación.

## Lambdas y closures

Una lambda puede capturar variables del ámbito exterior. Si la variable cambia, el delegado conserva acceso a esa variable; eso puede causar resultados inesperados en callbacks concurrentes. Prefiere expresiones sin efectos secundarios.

## Ejercicios

1. Agrupa ventas por día y calcula total por moneda.
2. Compara `Any` con `Count() > 0` en colecciones/proveedores consultables.
3. Inspecciona el SQL de una consulta EF Core y busca proyecciones innecesarias.
