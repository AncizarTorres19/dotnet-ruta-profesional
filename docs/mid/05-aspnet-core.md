# 5. APIs con ASP.NET Core

ASP.NET Core es el framework web multiplataforma de .NET. Elige minimal APIs o controladores según contrato, complejidad, convenciones del equipo y herramientas disponibles.

## HTTP y contratos

- `GET` consulta y debe ser seguro.
- `POST` suele crear un recurso o ejecutar una acción no idempotente.
- `PUT` reemplaza una representación y normalmente es idempotente.
- `PATCH` modifica parcialmente; define sus reglas de aplicación.
- `DELETE` elimina o deshabilita según contrato explícito.

Devuelve códigos correctos (200, 201, 204, 400, 401, 403, 404, 409, 500). No expongas excepciones internas ni detalles sensibles. Usa DTOs de entrada/salida; no serialices entidades de persistencia por comodidad.

## Capas útiles

1. Borde HTTP: parsing, validación de formato, códigos y DTOs.
2. Aplicación: orquesta casos de uso.
3. Dominio: reglas invariantes y estados válidos.
4. Infraestructura: base de datos, colas, llamadas externas.

No añadas capas si no separan un cambio real. La solución debe seguir siendo navegable.

## Seguridad y límites

Autenticación valida identidad; autorización decide acciones sobre recursos. Controla payload size, rate, paginación, CORS, timeouts y errores. Evita IDOR (autorización por identificador faltante) y mass assignment.

## Ejercicios

1. Define endpoints de pedidos con solicitud, respuesta y errores.
2. Implementa paginación, orden determinista y filtro autorizado.
3. Especifica cómo mantener compatibilidad entre versiones del cliente.
