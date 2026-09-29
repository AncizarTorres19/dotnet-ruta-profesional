# 1. Genéricos, records y diseño de APIs

Los genéricos representan tipos con parámetros concretos, verificables en compilación.

```csharp
public sealed record Resultado<T>(T? Valor, string? Error)
{
    public bool EsExitoso => Error is null;
}

var respuesta = new Resultado<string>("Listo", null);
```

Define reglas de nulabilidad coherentes: un resultado no debe poder parecer exitoso sin valor si el dominio lo prohíbe. En sistemas importantes, un tipo discriminado modela éxito o fallo con mayor seguridad que dos valores opcionales independientes.

## Records y tipos de dominio

Los records ofrecen igualdad por valor apropiada para datos. Una entidad puede tener identidad estable aun si sus datos cambian. Usa `enum` para estados cerrados bien definidos y valida transiciones inválidas donde se cambia estado.

## Variancia

Las interfaces genéricas pueden usar `in` (contravarianza) y `out` (covarianza) bajo restricciones de tipos. Aprende productores/consumidores antes de diseñar abstracciones genéricas complejas. Evita hacer todo genérico sin un caso de reutilización concreto.

## API de tipos

Usa nombres con unidades explícitas o tipos de dominio: `TimeSpan`, `DateTimeOffset`, `decimal`, `Guid`. Convierte los tipos del exterior en los tipos internos adecuados en el borde de la aplicación.

## Ejercicios

1. Diseña un resultado discriminado que garantice éxito o error, nunca ambos.
2. Modela una transición de estado de pedido y prueba los estados inválidos.
3. Implementa un repositorio genérico y determina si mejora realmente la API del dominio.
