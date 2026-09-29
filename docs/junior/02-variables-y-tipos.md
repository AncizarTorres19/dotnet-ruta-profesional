# 2. Variables, tipos y valores

## Tipos comunes

`int`, `long`, `decimal`, `double`, `bool`, `char` y `string` cubren muchos casos iniciales. `decimal` está diseñado para cálculos decimales donde importa la precisión base 10, como importes; `double` suele ser adecuado para cálculos científicos.

```csharp
int cantidad = 3;
long habitantes = 8_000_000_000L;
decimal precio = 12_500.25m; // El sufijo m expresa un decimal.
bool disponible = true;
string ciudad = "Bogotá";

var saludo = $"Hola, {ciudad}"; // El compilador infiere que saludo es string.
```

`var` es tipado estático, no tipado dinámico. Úsalo cuando el tipo sea evidente a partir de la expresión.

## Nullabilidad

Con nullable reference types habilitado (`<Nullable>enable</Nullable>`), `string` representa un valor no nulo y `string?` permite `null`. Los avisos del compilador ayudan, pero no validan automáticamente datos externos.

```csharp
string nombre = "Ada";
string? segundoNombre = null;
Console.WriteLine(nombre.Length);
Console.WriteLine(segundoNombre?.Length ?? 0); // Acceso seguro con valor de reserva explícito.
```

Evita el operador `!` para silenciar advertencias sin verificar el origen real del dato.

## Igualdad y conversiones

Las cadenas se comparan por valor con `==`. Para texto sin distinción de mayúsculas, usa una comparación explícita con `StringComparison.OrdinalIgnoreCase`, no dependas accidentalmente de la cultura de la máquina.

## Ejercicios

1. Convierte temperaturas sin truncar decimales.
2. Prueba divisiones entre enteros y `decimal`.
3. Modela un campo opcional con `string?` y valida entrada de usuario.
