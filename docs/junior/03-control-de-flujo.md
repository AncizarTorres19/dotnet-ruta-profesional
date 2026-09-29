# 3. Expresiones, decisiones y ciclos

`if`/`else` modela decisiones; `switch` puede evaluar valores y patrones; `for`, `foreach` y `while` repiten trabajo.

```csharp
var nota = 82;
var resultado = nota switch
{
    >= 90 => "Excelente",
    >= 60 => "Aprobado",
    _ => "Requiere recuperación"
};

for (var intento = 1; intento <= 3; intento++)
{
    Console.WriteLine($"Intento {intento}");
}
```

El `switch` de expresión devuelve un valor y exige una alternativa de descarte cuando el conjunto de entradas no es cerrado.

```csharp
var numerosPares = new List<int>();
foreach (var numero in Enumerable.Range(1, 5))
{
    if (numero % 2 == 0)
    {
        numerosPares.Add(numero);
    }
}
```

`foreach` simplifica la iteración y no expone un índice por defecto. Si necesitas modificar una colección, entiende primero cuándo permite mutaciones y cuándo lanza una excepción.

## Errores comunes

- Usar límites equivocados en ciclos.
- Olvidar avanzar una condición en `while`.
- Anidar decisiones muy profundamente: busca una extracción por intención.

## Ejercicios

1. Muestra los múltiplos de tres hasta cien.
2. Clasifica edades y rechaza números negativos.
3. Crea un menú con `switch` que controle valores desconocidos.
