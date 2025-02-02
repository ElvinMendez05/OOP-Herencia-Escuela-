
using Principios__KISS_.Class;

namespace Principios__KISS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al restaurante \n");

            Console.WriteLine("Platos disponibles: \n");
            
            Console.WriteLine("Ensalada : $90.00");
            Console.WriteLine("Bistek   : $1500.00.");
            Console.WriteLine("Mofongo  : $3400.00");
            Console.WriteLine("Pasta    : $4400.00");
            Console.WriteLine("Chuletas : $5400.00 \n");

            Console.WriteLine("Ingresa los precios: ");
            string platos = Console.ReadLine()!;

            decimal[] price = platos.Split(',').Select(decimal.Parse).ToArray();

            Console.WriteLine("Deseas agregar una propina personalizada: (s/n)");
            string propina = Console.ReadLine()!;

            var cliente = new Restaurant();

            if (propina == "s")
            {
                Console.WriteLine("Agrega una propina: ");
                decimal monto = decimal.Parse(Console.ReadLine()!);

                Console.WriteLine($"El total a pagar es de {cliente.CalcularTotal(price, monto)} \n");
            } else
              {   
                Console.WriteLine($"El total a pagar es de {cliente.CalcularTotal(price, 10)} \n");   
            }

        }
    }
}
