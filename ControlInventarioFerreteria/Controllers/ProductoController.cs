using ControlInventarioFerreteria.Models;

namespace ControlInventarioFerreteria.Controllers
{
    public class ProductoController
    {
        private readonly List<Producto> productos = new();

        public Producto AgregarProducto(string nombre, int cantidad, decimal precio)
        {
            Producto producto = new Producto
            {
                Id = productos.Count + 1,
                Nombre = nombre,
                Cantidad = cantidad,
                Precio = precio
            };

            productos.Add(producto);
            return producto;
        }

        public List<Producto> ListarProductos()
        {
            return productos;
        }

        public Producto? BuscarProductoPorId(int id)
        {
            return productos.FirstOrDefault(producto => producto.Id == id);
        }

        public bool ActualizarStock(int id, int nuevaCantidad)
        {
            Producto? producto = BuscarProductoPorId(id);

            if (producto == null)
            {
                return false;
            }

            producto.Cantidad = nuevaCantidad;
            return true;
        }
    }
}
