using Principios_de_Diseños.Class;

namespace Principios_de_Diseños
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el tipo de notificacion \n");

            Console.WriteLine("1. EMAIL ");
            Console.WriteLine("2. SMS \n");

            Console.WriteLine("Seleciona un servicio: ");
            int seleccion = int.Parse(Console.ReadLine()!);

            var servicio = new SendService();
            var notificacion  = new NotificationService();

            if (seleccion == 1)
            {
                Console.WriteLine("Ingresa tu email: ");
                string email = Console.ReadLine()!;

                Console.WriteLine("Ingresa un mensaje: ");
                string mensaje = Console.ReadLine()!;

                servicio.SendEmail(email, mensaje);

                notificacion.LogNotification(mensaje);
            }

            else {
                Console.WriteLine("Ingresa tu numero de telefono: ");
                string numeroTelefono = Console.ReadLine()!;

                Console.WriteLine("Ingresa un mensaje: ");
                string mensaje = Console.ReadLine()!;

                servicio.SendEmail(numeroTelefono, mensaje);

                notificacion.LogNotification(mensaje);
            }
        }
    }
}
