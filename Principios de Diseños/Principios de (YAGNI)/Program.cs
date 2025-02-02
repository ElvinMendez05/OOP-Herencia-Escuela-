using Principios_de__YAGNI_.Class;

namespace Principios_de__YAGNI_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la tienda de elementos");

            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Eliminar Producto");
            Console.WriteLine("3. Salir");

            var servicio = new ProductService();

            while (true)
            {
                Console.WriteLine("Ingresa el numero de servicios a realizar: ");
                
                int seleccion = int.Parse(Console.ReadLine()!);

                if (seleccion == 1)
                {
                    Console.WriteLine("Ingresa el nombre de un producto: ");
                    string nombreProducto = Console.ReadLine()!;

                    Console.WriteLine("Ingresa el precio del producto: ");
                    decimal precioProducto = decimal.Parse(Console.ReadLine()!);

                    servicio.AddProduct(nombreProducto, precioProducto);
                }
                else if (seleccion == 2) 
                {
                    Console.WriteLine("Ingresa un numero para eliminar un elemento");
                    int eliminarId = int.Parse(Console.ReadLine()!);

                    servicio.DeleteProduct(eliminarId);
                }

                else if (seleccion == 3)
                {
                    Console.WriteLine("Has decidido salir");
                    break;
                }

                else {
                    Console.WriteLine("Intentalo de nuevo");
                }
            }
        } 
    }
}
