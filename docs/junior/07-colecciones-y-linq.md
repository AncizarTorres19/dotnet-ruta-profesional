# 7. Colecciones y LINQ

Elige colección según el acceso: `List<T>` conserva orden y duplicados; `HashSet<T>` representa valores únicos; `Dictionary<TKey,TValue>` asocia una clave.

```csharp
var tareas = new List<string> { "Leer", "Practicar" };
var intentosPorTema = new Dictionary<string, int>
{
    ["colecciones"] = 2
};
```

LINQ expresa consultas sobre colecciones con operadores de secuencia. Muchas consultas se evalúan de forma diferida: enumerarlas más de una vez puede repetir trabajo o lecturas.

```csharp
var nombres = new[] { "ana", "Luis", "Andrés" };

var coincidencias = nombres
    .Where(nombre => nombre.StartsWith("a", StringComparison.OrdinalIgnoreCase))
    .Select(nombre => nombre.ToUpperInvariant())
    .Order()
    .ToArray();
```

La consulta filtra, transforma, ordena y materializa el resultado. `ToArray` evita reevaluar accidentalmente esta secuencia diferida. En LINQ to Entities, la consulta se traduce a SQL; no todos los métodos de C# se pueden traducir.

## Igualdad y claves

Para tipos propios, entiende `Equals`/`GetHashCode` e igualdad estructural. Las claves de diccionario no deben mutar de forma que cambie su hash mientras se usan.

## Ejercicios

1. Cuenta palabras con `Dictionary<string,int>` y una comparación consistente.
2. Agrupa pedidos por estado y suma importes.
3. Compara `First`, `FirstOrDefault`, `Single` y `SingleOrDefault` y decide qué comunica mejor cada caso.
