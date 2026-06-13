namespace ControlInventarioFerreteria.Services
{
    public class SeguridadService
    {
        public bool ValidarUsuario(string usuario, string clave)
        {
            return usuario == "admin" && clave == "1234";
        }

        public bool ValidarCampoObligatorio(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        public bool ValidarCantidad(int cantidad)
        {
            return cantidad > 0;
        }

        public bool ValidarPrecio(decimal precio)
        {
            return precio >= 0;
        }
    }
}
