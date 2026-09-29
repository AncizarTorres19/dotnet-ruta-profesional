# 3. Async, await y cancelación

`async` y `await` componen operaciones de I/O asíncronas evitando ocupar un hilo bloqueado mientras la operación espera. Async no significa necesariamente ejecución paralela ni hace más rápido el trabajo limitado por CPU.

```csharp
public static async Task<string> ObtenerTextoAsync(
    HttpClient cliente,
    Uri direccion,
    CancellationToken cancellationToken)
{
    // Propaga cancelación hasta la operación de red.
    return await cliente.GetStringAsync(direccion, cancellationToken);
}
```

Devuelve `Task` o `Task<T>` de forma consistente. Evita `.Result`, `.Wait()` y `async void` excepto manejadores de eventos, porque bloquean o dificultan propagar errores.

## Cancelación y errores

La cancelación se comunica con `CancellationToken` y debe propagarse hasta los recursos que la aceptan. Decide si la cancelación significa abandono, timeout o desconexión del cliente. No captures `OperationCanceledException` como fallo inesperado sin comprobar el contexto.

## Concurrencia con límites

`Task.WhenAll` inicia y espera operaciones, pero iniciar millones simultáneas puede saturar memoria y servicios. Aplica límites de concurrencia, timeouts y backpressure. `Parallel.ForEachAsync` acepta un límite para procesamiento en paralelo.

## Ejercicios

1. Pide dos servicios a la vez con una fecha límite.
2. Propaga cancelación desde API hasta base de datos.
3. Compara async con síncrono bajo carga I/O usando métricas, no intuición.
