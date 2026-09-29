# 7. Configuración, logging e inyección de dependencias

ASP.NET Core configura proveedores, logging y dependency injection. Prefiere dependencias explícitas por constructor en vez de un service locator oculto.

## Ciclos de vida DI

- `Singleton`: una instancia por contenedor; debe ser segura ante concurrencia.
- `Scoped`: una instancia por ámbito (en web, a menudo una por solicitud); apropiada para `DbContext`.
- `Transient`: una instancia por resolución; útil para servicios livianos sin estado.

No inyectes una dependencia scoped en un singleton de forma directa. Comprende el ámbito de background services y su creación explícita.

## Configuración y opciones

Centraliza configuración con tipos Options, valida al iniciar si es posible y separa valores por entorno. Secretos vienen de una fuente segura; no se guardan en código, logs ni configuración versionada.

## Logging

Usa logs estructurados con placeholders, contexto y nivel adecuado. Registra eventos importantes, no cada dato ni secretos. Distingue una métrica agregada de una línea de log por solicitud.

## Ejercicios

1. Registra una opción tipada de configuración y valida el URI del servicio.
2. Decide lifetime apropiado para repositorio, cliente HTTP y DbContext.
3. Registra un fallo externo con correlation ID sin incluir credenciales ni payload sensible.
