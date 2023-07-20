using Biblioteca;
namespace Estante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto product = new Producto("12345f","pepsi",153.54f);

            string numero = (string)product;
            Console.WriteLine(numero);
        }
    }
}