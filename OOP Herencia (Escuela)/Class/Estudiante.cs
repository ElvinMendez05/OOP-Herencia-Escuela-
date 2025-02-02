using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_herencia__Escuela_.Class
{
    public class Estudiante : Persona, IEstudiante
    {
        public int IdEstudiante { get; set; }
        public Estudiante(int idEstudiante, string nombre, string apellido, int edad, string sexo) 
            : base(nombre, apellido, edad, sexo)
        {
            IdEstudiante = idEstudiante;
            
        }

        public void Escribir()
        {
            Console.WriteLine($"El estudiante {IdEstudiante} - {Nombre} - {Apellido} esta escribiendo....");
        }

        public void Explicar()
        {
            Console.WriteLine($"El estudiante {IdEstudiante} - {Nombre} - {Apellido} esta explicando....");
        }

        public void Leer()
        {
            Console.WriteLine($"El estudiante {IdEstudiante} - {Nombre} - {Apellido} esta leyendo....");
        }
    }
}
