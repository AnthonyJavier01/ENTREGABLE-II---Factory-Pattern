using FactoryPattern.Factories;
using FactoryPattern.Interfaces;

INotificadorFactory factory = new NotificadorFactory();

Console.WriteLine("==================================");
Console.WriteLine(" FACTORY PATTERN - NOTIFICADOR");
Console.WriteLine("==================================");

Console.WriteLine("1. Email");
Console.WriteLine("2. SMS");
Console.WriteLine("3. Teams");

Console.Write("Seleccione una opción: ");

if (!int.TryParse(Console.ReadLine(), out int opcion))
{
    Console.WriteLine("Opción inválida.");
    return;
}

try
{
    TipoNotificacion tipo = (TipoNotificacion)opcion;

    INotificador notificador =
    factory.CrearNotificador(tipo);

    Console.Write("Ingrese el mensaje: ");
    string mensaje = Console.ReadLine() ?? string.Empty;

    notificador.Enviar(mensaje);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}