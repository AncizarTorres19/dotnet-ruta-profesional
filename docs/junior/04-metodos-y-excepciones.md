# 4. Métodos, parámetros y errores

Un método encapsula una operación identificable. Los parámetros son entradas; el tipo de retorno describe el resultado.

```csharp
static decimal CalcularPromedio(decimal primera, decimal segunda)
{
    return (primera + segunda) / 2m;
}
```

Un método puede tener cuerpo en una sola expresión:

```csharp
static bool EsPar(int valor) => valor % 2 == 0;
```

C# pasa argumentos por valor por defecto: en referencias, copia el valor de la referencia. `ref`, `out` e `in` cambian reglas de parámetros y deben usarse cuando aporten claridad, no para simular retornos múltiples innecesariamente.

## Excepciones

Lanza excepciones para fallos excepcionales; usa resultados/validación explícita cuando un rechazo sea parte normal del flujo. Captura solo si puedes manejar, traducir o enriquecer el error. Preserva el detalle original al relanzar.

```csharp
if (string.IsNullOrWhiteSpace(nombre))
{
    throw new ArgumentException("El nombre es obligatorio.", nameof(nombre));
}
```

Evita `catch (Exception) { }`: oculta fallos y deja al sistema en un estado engañoso. En bordes de entrada, informa errores adecuados sin filtrar stack traces a usuarios.

## Ejercicios

1. Escribe una función que calcule subtotal y rechace cantidad/precio negativos.
2. Distingue `ArgumentException` de `InvalidOperationException`.
3. Divide un método largo en operaciones cuyos nombres comuniquen la regla.
