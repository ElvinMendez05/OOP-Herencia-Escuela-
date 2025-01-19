

namespace OOP_Herencia__Shape_.Class
{
    public abstract class Shape
    {
        public double Alto { get; set; }
        public double Ancho { get; set; }

        public Shape(double alto, double ancho)
        {
            Alto = alto;
            Ancho = alto;
        }
        public abstract double CalculateSurface();

    }
}
