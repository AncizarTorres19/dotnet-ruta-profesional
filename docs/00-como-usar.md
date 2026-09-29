# Cómo usar el curso

## Preparar el entorno

Instala el SDK .NET 10 LTS, que incluye el compilador de C#, herramientas de línea de comandos, MSBuild y runtime. Visual Studio y Visual Studio Code son editores; no sustituyen al SDK.

```powershell
dotnet --info
dotnet --list-sdks
```

Desde la raíz del repositorio puedes compilar y ejecutar:

```powershell
dotnet build
dotnet run --project src/RutaProfesional.App -- junior
dotnet run --project src/RutaProfesional.App -- mid
dotnet run --project src/RutaProfesional.App -- senior
dotnet test
```

La primera restauración de paquetes de prueba necesita acceso a NuGet. El código de producción usa bibliotecas incluidas en .NET; las pruebas usan xUnit.

## Ciclo por lección

1. Lee los objetivos y trata de explicar el concepto.
2. Predice qué hará el ejemplo antes de ejecutarlo.
3. Escribe o modifica el código y observa los resultados.
4. Prueba valores límite y errores.
5. Resuelve los ejercicios y agrega pruebas automatizadas.
6. Guarda cambios pequeños y comprensibles con Git.

## Qué significa cada nivel

- **Junior:** puede resolver tareas acotadas, navegar una solución, usar depurador y preguntar con contexto.
- **Mid:** puede diseñar y mantener una funcionalidad completa, elegir herramientas razonables y validar sus fallos relevantes.
- **Senior:** puede conducir decisiones sistémicas, explicar costos/riesgos, cuidar producción y mejorar el desempeño del equipo.

Los niveles no se alcanzan por años ni por memorizar APIs; requieren práctica, revisión y criterio en proyectos reales.

## Recursos oficiales

- [Aprender C#](https://learn.microsoft.com/dotnet/csharp/)
- [.NET 10](https://learn.microsoft.com/dotnet/core/whats-new/dotnet-10/overview)
- [C# language reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [ASP.NET Core](https://learn.microsoft.com/aspnet/core/)
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)
- [xUnit](https://xunit.net/)
- [Política de soporte de .NET](https://dotnet.microsoft.com/platform/support/policy/dotnet-core)

Comprueba el estado de soporte antes de iniciar un producto o desplegar actualizaciones.
