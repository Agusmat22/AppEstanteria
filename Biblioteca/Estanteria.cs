using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estanteria
    {
        private Producto[] productos;
        private int ubicacionEstante;

        //inicializo el constructor privado para que no puedan acceder
        private Estanteria(int capacidadProductos)
        {
            productos = new Producto[capacidadProductos];
        }

        //sobrecargo el constructor de forma publica para que ingrese los valores
        public Estanteria(int capacidadProductos, int ubicacionEstante) : this(capacidadProductos)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        //Creo el get para retornar el array
        public Producto[] GetProductos
        {
            get
            {
                return productos;
            }

        }

        public static string MostrarEstante(Estanteria estante)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ubicacion Estante: {estante.ubicacionEstante}");
            sb.AppendLine($"Cantidad Productos: {estante.GetProductos.Length}");

            return sb.ToString();

        }

        //SOBRECARGA DE OPERADORES ARITMETICOS
        public static bool operator ==(Estanteria estante, Producto producto)
        {
            foreach (var espacio in estante.GetProductos)
            {
                //pregunto si espacio no es NULL y dentro de espacio va conteneer un objeto entonces pregunto la marca
                if (espacio is not null && espacio.GetMarca == producto.GetMarca)
                {
                    return true;

                }

            }
            return false;

        }

        public static bool operator !=(Estanteria estante, Producto producto)
        {
            foreach (var espacio in estante.GetProductos)
            {
                if (espacio is not null && espacio.GetMarca == producto.GetMarca)
                {
                    return false;

                }

            }
            return true;

        }

        public static bool operator +(Estanteria estante, Producto producto)
        {
            for (int i = 0; i < estante.GetProductos.Length; i++)
            {
                if (estante != producto)
                {
                    estante.GetProductos[i] = producto;
                    return true;

                }

            }
            return false;
        }



    }
}