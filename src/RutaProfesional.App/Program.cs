using RutaProfesional.App;

var nivel = args.FirstOrDefault()?.ToLowerInvariant() ?? "junior";

switch (nivel)
{
    case "junior":
        EjemplosJunior.Ejecutar();
        break;
    case "mid":
        await EjemplosMid.EjecutarAsync();
        break;
    case "senior":
        EjemplosSenior.Ejecutar();
        break;
    default:
        Console.Error.WriteLine("Nivel desconocido. Usa: junior, mid o senior.");
        return 1;
}

return 0;
