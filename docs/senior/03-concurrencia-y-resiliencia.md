# 3. Concurrencia y resiliencia

La concurrencia sincroniza trabajos con progreso solapado; el paralelismo ejecuta trabajos a la vez. .NET usa `Task`, `async/await`, ThreadPool, primitivas sincronizadas y colecciones concurrentes para necesidades distintas.

## Riesgos

- Condiciones de carrera al compartir estado mutable.
- Deadlock por bloqueos o espera síncrona sobre tareas.
- Saturación de ThreadPool, sockets, DB connections o API quotas.
- Fan-out sin límites y efectos secundarios duplicados al reintentar.

Prefiere estado inmutable y operaciones asíncronas. Los locks protegen invariantes concretas; no los mantengas durante I/O remoto.

## Resiliencia

Establece timeout por dependencia, retry limitado con backoff/jitter y solo para fallos transitorios seguros. Usa idempotency keys para operaciones cuyo efecto debe ocurrir una vez. Circuit breaker y rate/concurrency limiter protegen recursos, pero también requieren monitoreo, tuning y pruebas de recuperación.

## Fallos distribuidos

Un timeout no demuestra que una operación no se procesó. Usa contratos de estado consultable, colas/outbox y consumidores idempotentes cuando aplique. Define la semántica de entrega y los límites de consistencia observable.

## Ejercicios

1. Evita doble cargo al repetir una petición tras timeout.
2. Limita 1,000 solicitudes a un servicio externo a una concurrencia acordada.
3. Simula dependencia lenta y comprueba que el límite libera recursos.
