
namespace CalcularSalario.Clases
{
    public class DocentesFijos : Empleado
    {
        public decimal Bonificaciones { get; set; }
        public DocentesFijos(string nombre, string apellido, string sexo, decimal salario,
            decimal bonificaciones) : base(nombre, apellido, sexo, salario)
        {
            Bonificaciones = bonificaciones;
        }

        public override decimal CalcularSalarioMensual()
        {
            if (Salario >= 5000)
            {
                return Salario + Bonificaciones;
            } else {
                return (Salario + Bonificaciones) / 2;
            }
        }
        public override string ToString() => $" Nombre: {Nombre} \n Apellido: {Apellido} \n Sexo: {Sexo}";
    }
}
