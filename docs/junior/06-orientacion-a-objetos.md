# 6. Orientación a objetos

La abstracción describe lo relevante; el polimorfismo permite intercambiar implementaciones bajo un contrato; la herencia permite especializar una clase base, con cuidado.

```csharp
public interface INotificador
{
    void Enviar(string destinatario, string mensaje);
}

public sealed class ServicioDeAlertas(INotificador notificador)
{
    public void Avisar(string usuario)
    {
        notificador.Enviar(usuario, "El pedido está listo.");
    }
}
```

La clase usa una interfaz para enviar el mensaje sin quedar acoplada a una implementación de correo concreta. La inyección por constructor deja visible su colaboración.

## Composición frente a herencia

Prefiere composición para combinar capacidades independientes. Usa herencia cuando la relación “es un” sea estable y la subclase respete el contrato de base. No heredes solo para compartir unas pocas líneas.

## SOLID como herramienta

- ¿Tiene la clase una razón clara para cambiar?
- ¿Las sustituciones respetan contrato y comportamiento?
- ¿La interfaz es pequeña y útil para sus clientes?
- ¿Las políticas de alto nivel conocen innecesariamente detalles volátiles?

Aplica patrones solo cuando resuelvan un problema real y el vocabulario mejore la comprensión.

## Ejercicios

1. Implementa `INotificador` por consola y una segunda implementación falsa para pruebas.
2. Modela métodos de pago sin poner un `switch` gigante en el servicio.
3. Identifica un caso donde agregar una interfaz añade complejidad sin beneficio.
