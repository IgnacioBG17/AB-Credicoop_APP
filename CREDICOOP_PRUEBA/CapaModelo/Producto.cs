using System.Reflection.Metadata.Ecma335;

namespace CapaModelo
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public float precio { get; set; }
        public int Stock { get; set; }
    }
}