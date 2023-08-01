using System.Collections.Specialized;

namespace ContactoAdo.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public string correo { get; set; }
        public string clave { get;set; }
    }
}
