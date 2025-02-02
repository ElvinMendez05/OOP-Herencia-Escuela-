
using System.Runtime.InteropServices;

namespace Principios_de__YAGNI_.Class
{
    public class ProductService
    {
        List<string> nombreItems = new List<string>();
        List<decimal> priceItems = new List<decimal>();
        public void AddProduct(String name, decimal price)
        {
            nombreItems.Add(name);
            priceItems.Add(price);

            Console.WriteLine($"Product: {name} ha sido agregado con price: {price}");
        }
        
        public void DeleteProduct(int productId)
        {
            string nombreProducto = nombreItems[productId];

            nombreItems.RemoveAt(productId);
            priceItems.RemoveAt(productId);

            Console.WriteLine($"Product {productId} - {nombreProducto} a sido eliminado correctamente.");
        }

    }
}
