
using System.Security.Cryptography.X509Certificates;

namespace OOP_Herencia__Shape_.Class
{
    public class Triangle : Shape
    {
        public Triangle(double Alto, double Ancho) : base(Alto, Ancho) { }  

        public override double CalculateSurface()
        {
            return Alto * Ancho / 2;
        }
    }
}
