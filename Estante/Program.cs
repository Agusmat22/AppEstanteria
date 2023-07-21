using Biblioteca;
namespace Estante
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            Producto product = new Producto("123456f","pepsi",153.54f);
            Producto product2 = new Producto("87234","pepsii",153.54f);
            Estanteria estante1 = new Estanteria(3,1);
            Estanteria estante2 = new Estanteria(3,2);

            
            string numero = (string)product;
            Console.WriteLine(numero);
            Console.WriteLine($"La marca del producto 1 y del producto 2 son: {product == product2}");
            Console.WriteLine(Estanteria.MostrarEstante(estante1)) ;
            Console.WriteLine(estante1 == product);

            if (estante1 + product)
            {
                Console.WriteLine("Se guardo correctamente: {0},{1},{2}", product.GetMarca, (string)product, product.GetPrecio);
            }

            
            if (estante1 + product) 
            {
                Console.WriteLine("SEGUNDA VERSION: {0},{1},{2}", product.GetMarca, (string)product, product.GetPrecio);

            }
            else
            {
                Console.WriteLine("YA EXISTE EN EL ARRAY, NO SE PUDO GUARDAR");
            }
            */

            // Creo un estante
            Estanteria estante = new Estanteria(3, 1);

            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);

            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca, (string)p1, p1.GetPrecio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca, (string)p1, p1.GetPrecio);
            }

            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca, (string)p1, p1.GetPrecio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca, (string)p1, p1.GetPrecio);
            }

            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca, (string)p2, p2.GetPrecio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca, (string)p2, p2.GetPrecio);
            }

            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca, (string)p3, p3.GetPrecio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca, (string)p3, p3.GetPrecio);
            }

            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca, (string)p4, p4.GetPrecio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca, (string)p4, p4.GetPrecio);
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estanteria.MostrarEstante(estante));

        }
    }
}