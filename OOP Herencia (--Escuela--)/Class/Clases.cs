

namespace OOP_herencia__Escuela_.Class
{
    public class Clases : Escuela
    {
        public string? NombreClase { get; set; } 
        public Profesor? Profesor { get; set; }  
        public Estudiante? Estudiante { get; set; }
        public Clases(string nombreClase):base(nombreClase) 
        {
            NombreClase = nombreClase;        
        }

        public void AgregarEstudiante(Estudiante nuevoEstudiante)
        {
            Estudiante = nuevoEstudiante;
            Console.WriteLine($"Se ha agregado un nuevo estudiante... {Estudiante.Nombre} - {Estudiante.Apellido}");
        }

        public void AgregarMaestro(Profesor nuevoProfesor)
        {
            Profesor = nuevoProfesor;
            Console.WriteLine($"Agregado correctamente... {Profesor.Nombre} -- {Profesor.Materia}");
        }  

        
    }
}
