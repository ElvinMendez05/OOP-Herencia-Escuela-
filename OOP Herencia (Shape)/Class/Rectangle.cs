

using System.Security.Cryptography.X509Certificates;

namespace OOP_Herencia__Shape_.Class
{
    public class Rectangle : Shape
    {
        public Rectangle(double Alto, double Ancho) : base(Alto, Ancho) { }

        public override double CalculateSurface()
        {
            return Alto * Ancho;
        }
    }
}

