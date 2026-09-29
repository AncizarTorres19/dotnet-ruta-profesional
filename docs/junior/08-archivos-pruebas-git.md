# 8. Archivos, pruebas y Git

## Leer y escribir archivos

Las APIs de `System.IO` ofrecen operaciones síncronas y asíncronas. En aplicaciones con I/O, prefiere las APIs async para no bloquear hilos innecesariamente.

```csharp
var archivo = Path.Combine(AppContext.BaseDirectory, "datos.txt");
await File.WriteAllTextAsync(archivo, "Primer aprendizaje", cancellationToken);

var contenido = await File.ReadAllTextAsync(archivo, cancellationToken);
Console.WriteLine(contenido);
```

No confíes en rutas provistas directamente por usuarios: valida el acceso y el directorio permitido. Considera problemas de permisos, tamaño, encoding y fallos de disco.

## JSON

`System.Text.Json` permite serializar/deserializar DTOs. Verifica que la forma recibida sea válida y compatible; nunca uses deserialización como sustituto de validación de negocio.

## Pruebas

xUnit ofrece tests unitarios y teorías con múltiples datos. Una prueba debe aislar escenario, acción y resultado y no depender del orden.

```csharp
[Theory]
[InlineData(2, 4)]
[InlineData(3, 9)]
public void Cuadrado_DevuelveElResultadoEsperado(int valor, int esperado)
{
    Assert.Equal(esperado, valor * valor);
}
```

## Git

```powershell
git status
git diff
git add src tests
git commit -m "Agrega validación de gastos"
```

Incluye cambios intencionales, no salidas `bin/`, `obj/`, secretos ni información privada.

## Ejercicios

1. Persiste gastos JSON y maneja archivos inexistentes de forma explícita.
2. Prueba camino feliz, valores límite y fallos.
3. Cambia la localización actual del proceso y verifica que la fecha se maneje correctamente.
