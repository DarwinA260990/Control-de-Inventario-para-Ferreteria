namespace ControlInventarioFerreteria.Controllers
{
    public class MovimientoInventarioController
    {
        public string RegistrarEntrada(int productoId, int cantidad)
        {
            return $"Entrada registrada. Producto: {productoId}, Cantidad: {cantidad}";
        }

        public string RegistrarSalida(int productoId, int cantidad)
        {
            return $"Salida registrada. Producto: {productoId}, Cantidad: {cantidad}";
        }
    }
}
