
using System.Security.Cryptography.X509Certificates;

namespace OOP_herencia__Escuela_.Class
{
    public class Cursos
    {
        public string? NombreCurso { get; set; } 
        public Profesor? Profesor { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }

        public Cursos(string nombreCurso, int recuentoClases, int recuentoEjercicios)
        {
           NombreCurso = nombreCurso;
           RecuentoClases = recuentoClases;
           RecuentoEjercicios = recuentoEjercicios;
        }

        public void AnadirMateria(Profesor nuevaMateria)
        {
            Profesor = nuevaMateria;
            Console.WriteLine($"Se te a anadido una nueva materia {Profesor.Materia}");
        }
        public void MostrarInfoCurso()
        {
            Console.WriteLine($"Estas en el curso de: {NombreCurso}");
            Console.WriteLine($"Recuento de clases: {RecuentoClases}");
            Console.WriteLine($"Recuento de ejercicios: {RecuentoEjercicios}");
        }
    }
}
