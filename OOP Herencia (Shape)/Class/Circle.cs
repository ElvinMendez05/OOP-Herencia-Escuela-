
using System.Security.Cryptography.X509Certificates;

namespace OOP_Herencia__Shape_.Class
{
    public class Circle : Shape { 
        public Circle(double radio) : base(radio, radio) { }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(Ancho, 2); 
        }
    }

}
