# Ruta Mid

**Meta:** construir una funcionalidad completa en .NET con contratos claros, pruebas útiles y manejo explícito de entrada, persistencia y fallos.

## Lecciones

1. [Genéricos, records y diseño de APIs](01-genericos-y-records.md)
2. [LINQ y expresiones](02-linq-y-expresiones.md)
3. [Async, await y cancelación](03-asincronia.md)
4. [Pruebas por capas](04-pruebas.md)
5. [API web con ASP.NET Core](05-aspnet-core.md)
6. [Datos y Entity Framework Core](06-ef-core.md)
7. [Configuración, logging y DI](07-configuracion-y-di.md)

## Criterio para avanzar

Entrega una API con contratos claros, persistencia, validación, pruebas de reglas y de integración, autenticación/autorización según necesidad y logging operacional. Explica quién controla transacciones y cómo la aplicación responde ante fallos.

## Proyecto sugerido: API de pedidos

Implementa crear, consultar y cancelar pedidos con reglas de transición de estado. Separa DTO, aplicación, dominio y acceso a datos de acuerdo con la complejidad. Agrega paginación, pruebas y una guía local de ejecución.
