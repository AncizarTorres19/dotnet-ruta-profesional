# 1. C# y la plataforma .NET

## Objetivos

- Distinguir C#, SDK, compilador, runtime y aplicación.
- Crear y ejecutar un programa de consola.
- Entender el flujo básico de compilación y ejecución.

C# es un lenguaje. El SDK compila proyectos; el runtime de .NET ejecuta aplicaciones administradas por el CLR. NuGet administra paquetes externos. Una solución agrupa proyectos, y un proyecto define cómo compilar un conjunto de código.

```csharp
Console.WriteLine("Hola, C#");
```

Desde C# 9, una aplicación de consola puede usar instrucciones de nivel superior como las de arriba. C# moderno utiliza `Program.cs` como punto de entrada generado por el compilador. En proyectos grandes puedes declarar explícitamente `class Program` y `static void Main`.

En el ejemplo:

```csharp
// Crea una referencia a partir de un literal de texto y muestra una línea.
string mensaje = "Hola, .NET";
Console.WriteLine(mensaje);
```

`Console` forma parte de la biblioteca estándar del runtime. El punto y coma termina la instrucción. Los nombres distinguen mayúsculas y minúsculas.

## Errores frecuentes

- Tener el runtime sin el SDK cuando necesitas compilar.
- Ejecutar el comando desde otra carpeta sin especificar el proyecto.
- Confundir el código de la aplicación con las plantillas que crea `dotnet new`.

## Ejercicios

1. Crea una consola y cambia el mensaje.
2. Ejecuta `dotnet --info` y localiza SDK y runtime.
3. Añade otra instrucción `WriteLine` y predice la salida.
