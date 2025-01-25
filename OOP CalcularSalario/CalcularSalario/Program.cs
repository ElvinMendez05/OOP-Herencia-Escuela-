using CalcularSalario.Clases;

namespace CalcularSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Bienvenido a la Empresa de Trabajo---- \n");

            var docentesPorHoras = new DocentesPorHoras("Elvin", "Mendez", "Masculino", 4600, 40.2M, 800M);
            Console.WriteLine(docentesPorHoras);
            Console.WriteLine($"Tu salario es de: {docentesPorHoras.CalcularSalarioMensual()}");
            Console.WriteLine("\n");

            var docenteFijos = new DocentesFijos("Reymon", "Ruiz", "Masculino", 10000.00M, 500.00M);
            Console.WriteLine(docenteFijos);
            Console.WriteLine($"Tu salario es de: {docenteFijos.CalcularSalarioMensual()}");
            Console.WriteLine("\n");

            var empleadoAdministrativo = new EmpleadoAdministrativo("Ricardo", "Castro", "Masculino", 3000.00M, 1000.00M);
            Console.WriteLine(empleadoAdministrativo);
            Console.WriteLine($"Tu salario es de: {empleadoAdministrativo.CalcularSalarioMensual()}");
            Console.WriteLine("\n");
        }
    }
}
