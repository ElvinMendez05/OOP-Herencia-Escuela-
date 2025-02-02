using OOP_herencia__Escuela_.Class;

namespace OOP_Herencia____Escuela___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia de escuela
            var escuela = new Escuela("Escuela Secundaria El Fabio");

            //Instancia de la clases
            var clase1 = new Clases("Sexto A");
            var clase2 = new Clases("Sexto B");

            //Instancia de los Estudiantes 
            var estudiante = new Estudiante(1, "Elvin", "Mendez", 19, "Masculino");

            //Instancia de los maestro
            var profesor = new Profesor(1, "Jose", "Martinez", 35, "Masculino", "Matematica");

            //Acciones del estudiante 
            var curso = new Cursos("Matematica", 20, 10);

            Console.WriteLine(escuela.Nombre);

            //Agregando estudiantes
            clase1.AgregarEstudiante(estudiante);
            estudiante.Escribir();
            estudiante.Leer();

            //Agregando maestro 
            clase2.AgregarMaestro(profesor);
            profesor.PasarAsistencia();
            profesor.EnsenarAlumno();

            //Agregando las clases 
            escuela.AgregarClase(clase1);
            escuela.AgregarClase(clase2);

            //Informacion del curso 
            curso.AnadirMateria(profesor);
            curso.MostrarInfoCurso();
        }
    }
}
