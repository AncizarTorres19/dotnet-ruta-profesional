# 1. CLR, GC y rendimiento

## CLR y JIT

El CLR administra ejecución, carga de assemblies, excepciones y garbage collection. El JIT compila métodos al código nativo durante la ejecución y puede optimizar según patrones reales. AOT puede mejorar arranque/tamaño o despliegue, pero cambia restricciones de reflexión, trimming y generación de código.

## Recolección de memoria

Comprende generaciones, LOH, presión de asignación, pausas y referencias que mantienen objetos vivos. GC libera objetos inalcanzables; no corrige cachés ilimitadas ni suscripciones que retienen accidentalmente objetos. Gestiona recursos no administrados con `IDisposable` y `using`; finalizers no son un mecanismo general de liberación determinista.

## Método de optimización

1. Define la experiencia a mejorar y mide una línea base bajo carga representativa.
2. Perfila CPU, memoria, bloqueos, red y consultas.
3. Formula una hipótesis verificable.
4. Cambia una cosa, ejecuta pruebas equivalentes y compara percentiles/errores.
5. Conserva la mejora solo si mantiene corrección, claridad y costo aceptable.

Evita microoptimizaciones especulativas. Usa BenchmarkDotNet para microbenchmarks y herramientas como `dotnet-counters`, `dotnet-trace` y perfiles del entorno real.

## Ejercicios

1. Identifica asignaciones repetidas en un flujo medible.
2. Explica el costo de `ToList` dentro de un ciclo y perfila antes/después.
3. Analiza un dump de memoria de práctica con manejo seguro de datos.
