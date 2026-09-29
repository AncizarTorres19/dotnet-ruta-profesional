# 4. Pruebas por capas

Una aplicación puede combinar pruebas unitarias rápidas, integración con infraestructura real controlada y end-to-end. Prueba contrato y comportamiento; no congeles detalles privados sin motivo.

## xUnit

`[Fact]` expresa un caso; `[Theory]` comparte comportamiento para diversos datos. Usa fixtures con cuidado para no filtrar estado. Revisa el test ya ejecutable en `tests/RutaProfesional.Tests`.

```csharp
[Fact]
public void CrearPedido_RechazaCantidadCero()
{
    Assert.Throws<ArgumentOutOfRangeException>(
        () => ValidarUnidades(0));
}
```

El método de ejemplo `ValidarUnidades` debe ser código público del comportamiento probado; evita hacer privadas públicas solo para permitir testing.

## Qué vale la pena probar

- Reglas de dominio, permisos y cálculos.
- Límites y estados inválidos.
- Serialización y compatibilidad de contratos.
- Queries de persistencia que tienen implicaciones de carga o integridad.
- Respuesta del sistema ante fallos transitorios y permanentes.

No mockees cada colaboración ni crees pruebas frágiles sobre el número de invocaciones internas. Testcontainers puede levantar dependencias reales, pero exige limpieza, aislamiento y tiempo de ejecución.

## Ejercicios

1. Crea tests de transición de pedido con `[Theory]`.
2. Integra una base de datos de test y verifica rollback/commit.
3. Decide qué componente conviene probar por contrato en vez de mockear.
