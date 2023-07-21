using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        //GETTER
        public string GetMarca
        {
            get
            {
                return marca;
            }

        }

        public float GetPrecio
        {
            get
            {
                return precio;
            }

        }

        public string MostrarProducto(string marca, string codigo, float precio)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {marca} ");
            sb.AppendLine($"Precio: {precio} ");
            sb.AppendLine($"Codigo de barra: {marca} ");

            return sb.ToString();
        }

        //CREO UN OPERADOR EXPLICITO PARA MOSTRAR "CODIGO DE BARRA"
        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }

        //CREO UNA SOBRECARGA DE OPERADORES

        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.GetMarca == producto2.GetMarca;

        }

        public static bool operator ==(Producto producto1, string marcaIngresada)
        {
            return producto1.marca == marcaIngresada;

        }

        public static bool operator ==(string marcaIngresada, Producto producto1)
        {
            return producto1.marca == marcaIngresada;

        }

        public static bool operator !=(string marcaIngresada, Producto producto1)
        {
            return producto1.marca == marcaIngresada;

        }


        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return producto1.GetMarca != producto2.GetMarca;

        }

        public static bool operator !=(Producto producto1, string marcaIngresada)
        {
            return producto1.GetMarca != marcaIngresada;

        }

    }
}