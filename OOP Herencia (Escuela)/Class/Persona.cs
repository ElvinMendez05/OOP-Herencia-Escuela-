

namespace OOP_herencia__Escuela_.Class
{
    public abstract class Persona 
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }
        public string? Sexo { get; set; }

        public Persona(string nombre, string apellido, int edad, string sexo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Sexo = sexo;
        }
    }
}
