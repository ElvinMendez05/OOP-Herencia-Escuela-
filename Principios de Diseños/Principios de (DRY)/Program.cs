using System.Linq.Expressions;
using Principios_de__DRY_.Class;

namespace Principios_de__DRY_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Calcular Salario-- \n");
             
            Console.WriteLine("1. Empleado Tiempo Completo.");
            Console.WriteLine("2. Empleado Medio Tiempo. \n");

            Console.WriteLine("Ingresa el tipo de empleado: ");
            int empleado = int.Parse(Console.ReadLine()!);

            var calculo = new Payroll();
            if (empleado == 1)
            {
                Console.WriteLine("Calculando el salario base....");
                Console.WriteLine("Ingresa el salario base: ");
                decimal salarioBase = decimal.Parse(Console.ReadLine()!);  
                
                Console.WriteLine($"$Total: {calculo.CalulateSalaryForFullTime(salarioBase)}");
            }
            else 
            {   
                Console.WriteLine("Ingresa el sueldo por hora: ");
                decimal sueldoBase = decimal.Parse(Console.ReadLine()!);

                Console.WriteLine("Ingresa las horas trabajadasa: ");
                int horas = int.Parse(Console.ReadLine()!);

                Console.WriteLine($"$Total: {calculo.CalulateSalaryPartFullTime(sueldoBase, horas)}");
            }

        }
    }
}
