using System.Data;

namespace CapaNegocio
{
    public class Producto
    {
        private readonly CapaDatos.Producto productoDatos = new CapaDatos.Producto();

        public DataTable Mostrar()
        {
            return productoDatos.Mostrar();
        }

        public void Insertar(CapaModelo.Producto producto)
        {
            productoDatos.Insertar(producto);
        }
        public void Editar(CapaModelo.Producto producto)
        {
            productoDatos.Editar(producto);
        }
        public void Eliminar(CapaModelo.Producto producto)
        {
            productoDatos.Eliminar(producto);
        }
    }
}
