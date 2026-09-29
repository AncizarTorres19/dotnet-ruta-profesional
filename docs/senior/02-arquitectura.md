# 2. Arquitectura y límites

La arquitectura sirve a cambios reales, atributos de calidad y ownership del equipo. No la conviertas en una colección de carpetas o frameworks.

## Límites y dependencias

- Identifica módulos a partir de capacidades y reglas de negocio.
- Evita dependencias cíclicas y compartir directamente tablas entre módulos.
- Aísla detalles volátiles detrás de contratos relevantes.
- Mantén una ruta clara para probar cada regla y observarla en ejecución.

La arquitectura limpia/hexagonal permite que el dominio no dependa de transporte o persistencia, pero puede agregar archivos y capas. Úsala de forma proporcional al cambio y a las necesidades del producto.

## Monolito modular y servicios

Un monolito modular facilita despliegue único con límites internos claros. Los microservicios pueden ofrecer autonomía de despliegue y escalado independiente, pero añaden latencia, fallos parciales, consistencia distribuida, observabilidad y costos de plataforma. Extrae servicios cuando haya límites de dominio, escalado u ownership que lo justifiquen.

## ADR y calidad

Registra decisiones difíciles de revertir con contexto, opciones, decisión y consecuencias. Expresa metas como escenarios medibles: actor, estímulo, ambiente, respuesta y medida. Equilibra latencia, resiliencia, seguridad, costo y mantenibilidad.

## Ejercicios

1. Dibuja contexto y módulos de la plataforma de pedidos.
2. Escribe un ADR que compare monolito modular con servicios separados.
3. Define un atributo de calidad verificable para búsquedas de pedidos.
