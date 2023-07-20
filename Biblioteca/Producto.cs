
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

        public string MostrarProducto(string marca,string codigo,float precio)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {marca} ");
            sb.AppendLine($"Precio: {precio} ");
            sb.AppendLine($"Codigo de barra: {marca} ");

            return sb.ToString();
        }
    }
}