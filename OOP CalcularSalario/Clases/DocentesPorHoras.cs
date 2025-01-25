
namespace CalcularSalario.Clases
{
    public class DocentesPorHoras : Empleado
    {
        public decimal Horas { get; set; }
        public decimal Tarifa { get; set; }
        public DocentesPorHoras(string nombre, string apellido, string sexo, 
            decimal salario, decimal horas, decimal tarifa):base(nombre, apellido, sexo, salario) 
        { 
           Horas = horas;
           Tarifa = tarifa;
        }
        public override decimal CalcularSalarioMensual()
        {
            Salario = Horas * Tarifa;
            return Salario;

        }
        public override string ToString() => $" Nombre: {Nombre} \n Apellido: {Apellido} \n Sexo: {Sexo}";

    }
}
