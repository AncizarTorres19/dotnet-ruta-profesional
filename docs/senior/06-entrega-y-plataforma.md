# 6. Entrega, plataforma y costos

El ciclo de entrega debe hacer cambios repetibles, verificables, trazables y reversibles. Automatiza restore/build/test/security scan y publicación de artifacts con versiones inmutables.

## Pipeline

1. Restaurar y compilar en modo reproducible.
2. Ejecutar pruebas y análisis estático con políticas de calidad.
3. Analizar vulnerabilidades y procedencia de dependencias.
4. Empaquetar una vez y promover el mismo artefacto.
5. Desplegar de forma progresiva y observar salud; revertir si los indicadores se degradan.

No despliegues secretos dentro de imágenes ni valores de entorno versionados. Firma/valida artefactos según criticidad y estrategia del equipo.

## Contenedores y .NET

Entiende imágenes base oficiales, build multi-stage, usuario no root, señales de apagado y límites de CPU/memoria. Los contenedores no sustituyen configurar salud ni comprender networking y persistencia.

## Costos y capacidad

Estima tráfico y dependencias, mide saturación y fija límites. Compara costo por operación o usuario con el valor del SLO. Un servicio sobredimensionado puede reducir costo de incidentes en un sistema crítico; mide la decisión.

## Ejercicios

1. Define un pipeline build/test para una app .NET sin exponer secretos.
2. Construye una imagen multi-stage y valida el shutdown graceful.
3. Evalúa despliegue progresivo con rollback automático basado en métricas.
