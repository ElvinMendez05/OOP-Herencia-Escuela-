

namespace OOP_herencia__Escuela_.Class
{
    public class Escuela 
    {
  
        public string? Nombre { get; set; }

        public Clases? Clases { get; set; }
        public Escuela(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarClase(Clases? clases) 
        {
           Clases = clases;
           Console.WriteLine($"Clase agregada correctamente {Clases?.NombreClase}");
        }
    }
}