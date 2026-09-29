# 5. Observabilidad y operación

Usa logs, métricas y trazas para inferir salud e investigar fallos; agrega contexto distribuido y controla datos sensibles, volumen y costo.

- **Logs estructurados:** eventos con nivel, fecha, versión e ID de correlación.
- **Métricas:** contadores, histogramas, latencia, errores y saturación agregados.
- **Trazas:** recorrido de una operación entre servicios y dependencias.

Evita etiquetas de cardinalidad infinita, como un ID por usuario/solicitud. Instrumenta automáticamente y manualmente solo la información que apoye decisiones.

## SLI, SLO y alerta

Un SLI representa una propiedad de usuario; un SLO fija objetivo/ventana. Error budget ayuda a decidir qué riesgo de despliegue es aceptable. Alertas deben reflejar impacto y requerir acción, no solo ruido.

## Preparación operativa

Configura health/readiness checks que distingan proceso activo de servicio listo. Prueba rollback, backups y restauración. Define runbooks para fallos conocidos y revisa incidentes sin buscar culpables; prioriza factores del sistema.

## Ejercicios

1. Diseña un SLO de latencia y disponibilidad para consultas de pedidos.
2. Crea un dashboard que distinga saturación interna de caída de proveedor.
3. Restaura una copia en entorno de prueba y mide el tiempo real.
