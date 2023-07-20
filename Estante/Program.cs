using Biblioteca;
namespace Estante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto product = new Producto("123456f","pepsi",153.54f);
            Producto product2 = new Producto("87234","pepsii",153.54f);
            Estanteria estante1 = new Estanteria(3,1);
            Estanteria estante2 = new Estanteria(3,2);

            /*
            string numero = (string)product;
            Console.WriteLine(numero);
            Console.WriteLine($"La marca del producto 1 y del producto 2 son: {product == product2}");*/
            Console.WriteLine(Estanteria.MostrarEstante(estante1));
            Console.WriteLine(estante1 == product);


        }
    }
}