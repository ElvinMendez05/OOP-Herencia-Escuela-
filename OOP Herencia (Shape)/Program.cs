using OOP_Herencia__Shape_.Class;

namespace OOP_Herencia__Shape_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia de shapes 
            Shape[] shapes = new Shape[]
            {
                new Rectangle(24, 5), 
                new Triangle(12, 3),
                new Circle(78)
            };

            //Calculando el area de mis figuras 
            double[] areas = new double[shapes.Length];

            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
            }

            Console.WriteLine("Áreas de las figuras geometricas: ");
            for (int i = 0; i < areas.Length; i++)
            {
                Console.WriteLine($"Forma {i + 1}: {areas[i]}");
            }
        }
    }
}