# 5. Clases, objetos y encapsulación

Una clase define una abstracción; una instancia es un objeto concreto. La encapsulación protege las invariantes y expone operaciones útiles.

```csharp
public sealed class Cuenta
{
    public Cuenta(string titular)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(titular);
        Titular = titular;
    }

    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public void Depositar(decimal importe)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(importe);
        Saldo += importe;
    }
}
```

`private set` evita que cualquier consumidor cambie el saldo arbitrariamente. La operación de depósito mantiene una regla del dominio y usa `decimal` para representar importe.

## Clases y referencias

Las clases se almacenan en el heap y las variables contienen referencias. Asignar una variable de tipo clase copia la referencia, no duplica el objeto. Los tipos valor como structs y primitivos tienen semántica de valor; no asumas el lugar físico exacto de almacenamiento, porque el JIT puede optimizarlo.

## Records

`record` (`record class` o `record struct`) ofrece igualdad por valor apropiada para modelos de datos. No conviertas automáticamente toda entidad mutable en record: piensa en identidad, mutabilidad y reglas.

## Ejercicios

1. Construye un producto con nombre requerido y precio no negativo.
2. Añade retiro que impida saldo insuficiente.
3. Explica qué invariantes preserva cada operación.
