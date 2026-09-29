# Ruta profesional de .NET y C#

Una ruta práctica y progresiva, en español, para aprender C# y construir aplicaciones modernas con .NET: desde los fundamentos hasta sistemas listos para operar.

El curso avanza por competencias **Junior → Mid → Senior**. Incluye lecciones conceptuales, ejemplos comentados, ejercicios, proyectos por etapa y una aplicación de demostración en C#.

## Requisitos

- SDK .NET 10 (LTS recomendado). Instálalo siguiendo la [guía oficial](https://dotnet.microsoft.com/download/dotnet/10.0).
- Editor como Visual Studio o Visual Studio Code con la extensión C#.
- Git.

Comprueba tu instalación en PowerShell:

```powershell
dotnet --info
dotnet --list-sdks
```

En el equipo donde se preparó este proyecto está instalado el SDK 9.0, no el 10.0. El proyecto apunta a .NET 10 por ser la versión LTS vigente; instala ese SDK antes de compilarlo con la configuración actual.

## Primeros pasos

1. Lee [Cómo usar el curso](docs/00-como-usar.md).
2. Estudia las lecciones Junior en orden y prueba los ejemplos.
3. Ejecuta y modifica la aplicación educativa:

```powershell
dotnet run --project src/RutaProfesional.App -- junior
dotnet run --project src/RutaProfesional.App -- mid
dotnet run --project src/RutaProfesional.App -- senior
dotnet test
```

4. Practica los ejercicios antes de seguir a la etapa siguiente.

## Mapa del curso

| Nivel | Temas | Ruta |
|---|---|---|
| **Junior** | C#, SDK, tipos, control de flujo, métodos, clases, objetos, colecciones, LINQ, errores, archivos y pruebas. | [Lecciones Junior](docs/junior/README.md) |
| **Mid** | Genéricos, records, async/await, ASP.NET Core, API REST, inyección de dependencias, EF Core y seguridad. | [Lecciones Mid](docs/mid/README.md) |
| **Senior** | CLR, GC y rendimiento, arquitectura, concurrencia, sistemas distribuidos, observabilidad, seguridad y liderazgo. | [Lecciones Senior](docs/senior/README.md) |

## Filosofía

- Aprende C# y sus bibliotecas estándar antes de delegar todo a un framework.
- Una aplicación real requiere pruebas, seguridad, observabilidad y un plan de operación además de compilar.
- No uses patrones por moda. Identifica qué problema resuelven y cuáles son sus costos.
- Las versiones de .NET y sus períodos de soporte cambian. Consulta la política oficial antes de desplegar.

## Estructura del repositorio

```text
docs/                         Curso por nivel
src/RutaProfesional.App/      Ejemplos ejecutables en C#
tests/RutaProfesional.Tests/  Pruebas automatizadas
RutaProfesional.slnx          Solución .NET
global.json                   SDK objetivo
```

## ¿Qué significa avanzar a Senior?

No es conocer todas las bibliotecas. Es tomar decisiones técnicas que atienden el contexto, comprender y comunicar riesgos, mantener sistemas operables y hacer crecer la capacidad del equipo.
