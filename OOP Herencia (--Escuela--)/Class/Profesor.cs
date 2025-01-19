
using System.Security.Principal;

namespace OOP_herencia__Escuela_.Class
{
    public class Profesor : Persona, IProfesor
    {
        public int IdProfesor { get; set; }
        public string Materia { get; set; }
        public Profesor(int idProfesor, string nombre, string apellido,
            int edad, string sexo, string materia) : base(nombre, apellido, edad, sexo)
        {
            IdProfesor = idProfesor;
            Materia = materia;
        }

        public void EnsenarAlumno()
        {
            Console.WriteLine("Estoy ensenando.......");
        }

        public void PasarAsistencia()
        {
            Console.WriteLine("Estoy pasando lista.......");
        }
    }
}
