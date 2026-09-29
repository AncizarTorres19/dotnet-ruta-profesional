# 6. Persistencia con EF Core

Entity Framework Core es un ORM para trabajar con bases relacionales mediante modelos y LINQ. No sustituye aprender SQL, modelado, restricciones ni planes de ejecución.

## Conceptos esenciales

- `DbContext` representa una unidad de trabajo y no debe compartirse entre operaciones concurrentes.
- Las consultas suelen ser diferidas hasta materializarse.
- El change tracker detecta cambios y puede retener entidades.
- `AsNoTracking` evita seguimiento cuando solo se consulta y no se editará.
- `SaveChanges` agrupa cambios y administra transacción para esa operación según proveedor.

```csharp
var pedidos = await dbContext.Pedidos
    .AsNoTracking()
    .Where(pedido => pedido.Estado == EstadoPedido.Pagado)
    .Select(pedido => new PedidoResumen(pedido.Id, pedido.Importe))
    .ToListAsync(cancellationToken);
```

La proyección selecciona lo necesario; el token cancela la operación. Comprueba consultas generadas, índices, N+1, eager/lazy loading y tamaño del tracking. La forma de transacciones depende del caso de uso y del proveedor.

## Migraciones

Versiona el esquema con migraciones revisadas. Para desplegar sin downtime, haz cambios compatibles por etapas; una migración de aplicación no puede asumir que todas las instancias cambian al mismo tiempo.

## Ejercicios

1. Analiza una consulta con `Include` y evita sobrecargar resultados.
2. Diseña una restricción única además de la validación en aplicación.
3. Planea migración aditiva, backfill y eliminación posterior de un campo.
