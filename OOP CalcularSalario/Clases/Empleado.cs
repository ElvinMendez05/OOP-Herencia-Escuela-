
namespace CalcularSalario.Clases
{
    public abstract class Empleado
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set;}
        public string? Sexo { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, string apellido, string sexo, decimal salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Salario = salario;
        }    
        public abstract decimal CalcularSalarioMensual();
    }
}
