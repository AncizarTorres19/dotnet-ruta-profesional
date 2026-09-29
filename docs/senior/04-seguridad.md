# 4. Seguridad de aplicaciones

Define activos y límites de confianza, modela amenazas y escoge mitigaciones según probabilidad e impacto. Security by design debe acompañar cada frontera de API y cada dato.

## Prácticas

- Valida entradas en las fronteras; parametriza consultas y evita construir SQL concatenado.
- Diferencia autenticación (identidad) y autorización (permiso sobre esta operación/recurso).
- Protege IDs de objetos ante IDOR/BOLA; los GUID difíciles de adivinar no autorizan acceso.
- Aplica mínimo privilegio a usuarios, servicios, archivos, red y secretos.
- Usa `Secrets`/gestor seguro en desarrollo y despliegue; rota credenciales.
- Actualiza dependencias con política de evaluación de avisos y parches.
- Evita loggear tokens, contraseñas, información personal y payloads secretos.
- Usa TLS y algoritmos de hash especializados para contraseñas; nunca texto plano.

## API y abuso de recursos

Establece límites de carga, tamaño, paginación y tasa; define CORS deliberadamente; maneja excepciones con errores públicos seguros y trazabilidad interna. Los mensajes de auth no deben facilitar enumeración.

## Ejercicio

Modela amenazas para el endpoint `/orders/{id}`: acceso horizontal, usuario anónimo, solicitud masiva, fuga en errores, credenciales y dependencias. Propón mitigaciones verificables con pruebas y monitoreo.
